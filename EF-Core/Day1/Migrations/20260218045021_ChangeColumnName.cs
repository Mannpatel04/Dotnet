using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Demo.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "Student_Id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Courses",
                newName: "Course_Id");

            migrationBuilder.CreateTable(
                name: "Trainer",
                columns: table => new
                {
                    Trainer_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience_Years = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.Trainer_ID);
                });

            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    startDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false),
                    TraineID = table.Column<int>(type: "int", nullable: false),
                    Trainer_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Batch_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "Course_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Batch_Trainer_Trainer_ID",
                        column: x => x.Trainer_ID,
                        principalTable: "Trainer",
                        principalColumn: "Trainer_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batch_CourseID",
                table: "Batch",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Batch_Trainer_ID",
                table: "Batch",
                column: "Trainer_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropTable(
                name: "Trainer");

            migrationBuilder.RenameColumn(
                name: "Student_Id",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "Courses",
                newName: "Id");
        }
    }
}
