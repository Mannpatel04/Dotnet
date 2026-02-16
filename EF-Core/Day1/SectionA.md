Q1.What problem was EF solving compared to ADO.NET?

Ans=>This is the fundamental problem. Relational databases store data in tables (rows and columns), while modern applications use objects (classes and inheritance).

ADO.NET: You had to manually map database columns to object properties. If a database schema changed, you often had to rewrite your mapping logic in multiple places.

EF: It acts as an Object-Relational Mapper (ORM). It allows you to work with your database data as if it were a collection of objects, handling the translation between the two worlds automatically.

Boilerplate Code Reduction: In ADO.NET, even a simple SELECT query requires a significant amount of repetitive code. And in Entity Framework a single line of LINQ code (e.g., context.Users.ToList()) replaces that entire block.

Automated Relationship Management: Handling foreign keys and relationships in ADO.NET can be a headache, especially when dealing with deeply nested data.

Type Safety and Compile-Time Checking: ADO>NET relies on "string-based" SQL queries, the compiler cannot check if you misspelled a table name or column. You only find out when the code crashes at runtime. And in EF your queries are checked at compile-time. If you rename a property on your object and forget to update a query, the project won't build, saving you from easy-to-miss bugs.

---
Q2. Explain EDM architecture (Conceptual, Mapping, Storage).

Ans=> The EDM is typically defined in an .edmx file  or via code-first configurations. It consists of the following three parts:

1. Conceptual Layer (CSDL):The Conceptual Schema Definition Language is the "Application View." It describes your data as objects and properties rather than tables and columns.
     
     Focus: How the programmer interacts with the data.

     Key components: Entity types (Classes), Associations (Relationships), and Navigation Properties.

     Example: You see a Student class with a List< Course > property.

2. Storage Layer (SSDL): The Store Schema Definition Language is the "Database View." It is a literal representation of the database schema.

    Focus: How the data is physically organized in the database (SQL Server, MySQL, etc.).

    Key components: Tables, Columns, Data Types (e.g., nvarchar, int), Primary Keys, and Foreign Keys.

    Example: It sees a tbl_Student_Info table with a Student_ID primary key.
       
3. Mapping Layer (MSL):The Mapping Specification Language is the "Glue." It sits between the Conceptual and Storage layers to tell Entity Framework exactly how to connect them.

    Focus: Translation logic.

    Function: It maps a property in the Conceptual layer (e.g., Student.FirstName) to a specific column in the Storage layer (e.g., tbl_Student_Info.f_name).

    Power: This layer allows for Entity Splitting (mapping one object to two different tables) or Table Splitting (mapping two objects to one table).

=> How it Works: When you write a LINQ query, Entity Framework performs a "waterfall" translation.

Conceptual: You write context.Students.Where(s => s.Name == "John").

Mapping: EF looks at the MSL to find which table and column "Student" and "Name" correspond to.

Storage: EF generates the specific SQL (SSDL) for that database: SELECT * FROM tbl_Student_Info WHERE f_name = 'John'.

---
Q3.Difference between EF Core and EF6.
Ans=> Ef core was the final evolution of original Entity framework. while EF Core is a complete ground-up rewrite.

1. Platform and Compatibility:The most significant difference is where they can run.
 - EF6: Primarily built for the .NET Framework (Windows only). While it can technically run on .NET Core, it isn't optimized for it and retains many legacy Windows-specific dependencies.
 - EF Core: Built for modern .NET. It is truly cross-platform, meaning it runs perfectly on Windows, Linux, and macOS.

2. Performance: Because EF Core was rewritten from scratch, it removed a lot of bloat.
 - EF Core is significantly faster and uses less memory and allows you to "compile" your data model, drastically reducing application startup time.

3.Modularity and Lightness: 

 - EF6: A monolithic library. When you include it, you get everything, including code for every feature, even if you don't use it.
 - EF Core: Highly modular. It uses NuGet packages for specific database providers. If you only need SQL Server, you only download the SQL Server provider (Microsoft.EntityFrameworkCore.SqlServer). This makes your final application deployment much smaller.
 
=>Use EF6 in Legacy Projects that already uses it and doesn't need to move to the cloud or Linux.
=>Use EF Core if You are starting a new project. It is the future of the framework, is actively maintained, and offers the best performance for modern MERN-like or Java-inspired architectures.

---
Q4.What happens internally when SaveChanges() is called?

Ans=> When you call SaveChanges(), Entity Framework transitions from being a simple "list of objects" to a database engine. It performs a multi-step Authentication to ensure that the changes in your memory match the state of the database.

1. Detect Changes: Before EF can send any SQL to the database, it needs to know what actually changed. It uses a process called Change Tracking. In change Tracking there are states like added, Modified, Deleted, Unchanged.
                   When SaveChanges() is called, EF loops through every entity currently tracked by the DbContext and compares its current state against that original snapshot.

2.Entity Validation: Once the states are determined, EF runs Validation Rules like [Required] is null or if a string exceeds its [MaxLength].

3.Database Command Generation: This is where the Mapping Layer (MSL) from the EDM architecture comes into play.
                               EF looks at the entities marked as Added, Modified, or Deleted.
                               It generates the appropriate SQL commands (INSERT, UPDATE, DELETE).

4.Transaction Initialization: To ensure data integrity, SaveChanges() wraps all generated commands in a Transaction.
                              If you are updating five different tables and the fourth one fails, EF will Rollback the first three.
                              This ensures your database never ends up in a "partial" or corrupted state.

5.State Reset: Once the database confirms success, All entities are moved back to the Unchanged state, and a new "snapshot" is taken, preparing for the next round of changes.

--- 
Q5. What is Change Tracking?

Ans=> In Entity Framework, Change Tracking is the intelligence layer that sits between your C# objects and the database. It is the mechanism that keeps track of which objects have been modified, added, or deleted so that EF knows exactly what SQL to generate when you call SaveChanges().

- When you query data from the database, EF doesn't just give you the data; it also creates a snapshot (a backup copy) of that data in its internal memory.

1. The States of an Entity:Every object tracked by EF has an EntityState. This state determines what happens during the next save:

Added: The object is new and doesn't exist in the database yet. EF will generate an INSERT.

Unchanged: The object matches the database. No SQL will be generated.

Modified: At least one property has been changed. EF will generate an UPDATE.

Deleted: The object is marked for removal. EF will generate a DELETE.

Detached: The object is not being tracked. 

2. Detection Strategies:
 - Snapshot-based Tracking:When you call SaveChanges(), EF compares the current values of your objects against the original snapshots it took when the data was first loaded. If User.Name was "John" and is now "Johnny", EF marks it as Modified.
 - Notification-based Tracking:The entity itself "notifies" the tracker whenever a property changes usually by implementing the INotifyPropertyChanged interface. This is more efficient for very large sets of data but requires more complex entity classes.

---

Q6.Difference between DbContext and DbSet?

Ans=> In Entity Framework, DbContext and DbSet work together like a Database and its Tables. If you think of your data access layer as a library, the DbContext is the entire building (the management system), and the DbSet represents a specific shelf of books (a specific table).

1. DbContext:The DbContext is the primary class responsible for interacting with the database. It manages the connection, the transactions, and the overall configuration.

- Role: It acts as a gateway. It handles the "session" with the database.

- Key Responsibilities:

    Configuration: Defining which database provider to use (SQL Server, SQLite, etc.).

    Change Tracking: It houses the "Change Tracker" we discussed earlier.

    Transaction Management: Ensuring all changes succeed or fail together.

    Model Creation: Using the OnModelCreating method to define how classes map to tables.

    Analogy: The Project Manager who knows where everything is and how to talk to the client (the Database).

2. DbSet: A DbSet< TEntity > represents a collection of a specific type of entity. It maps directly to a table or view in your database.

- Role: It allows you to perform CRUD (Create, Read, Update, Delete) operations on a specific table.

- Key Responsibilities:

    Querying: Providing the entry point for LINQ queries (e.g., context.Users.Where(...)).

    Adding/Removing: Methods like .Add(), .AddRange(), or .Remove() to mark entities for change.

    Data Representation: It holds the in-memory references to the rows fetched from that specific table.

    Analogy: A Table in Excel or a specific Folder of files.



     
      



