using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddedRemainingCRUD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batch_Courses_CourseID",
                table: "Batch");

            migrationBuilder.DropForeignKey(
                name: "FK_Batch_Trainer_Trainer_ID",
                table: "Batch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainer",
                table: "Trainer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Batch",
                table: "Batch");

            migrationBuilder.RenameTable(
                name: "Trainer",
                newName: "Trainers");

            migrationBuilder.RenameTable(
                name: "Batch",
                newName: "Batchs");

            migrationBuilder.RenameColumn(
                name: "TraineID",
                table: "Batchs",
                newName: "TraineId");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Batchs",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Batch_Trainer_ID",
                table: "Batchs",
                newName: "IX_Batchs_Trainer_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Batch_CourseID",
                table: "Batchs",
                newName: "IX_Batchs_CourseId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Fees",
                table: "Courses",
                type: "Decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(18,0)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainers",
                table: "Trainers",
                column: "Trainer_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Batchs",
                table: "Batchs",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesCourse_Id = table.Column<int>(type: "int", nullable: false),
                    StudentsStudent_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesCourse_Id, x.StudentsStudent_Id });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_CoursesCourse_Id",
                        column: x => x.CoursesCourse_Id,
                        principalTable: "Courses",
                        principalColumn: "Course_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsStudent_Id",
                        column: x => x.StudentsStudent_Id,
                        principalTable: "Students",
                        principalColumn: "Student_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsStudent_Id",
                table: "CourseStudent",
                column: "StudentsStudent_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Batchs_Courses_CourseId",
                table: "Batchs",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Course_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Batchs_Trainers_Trainer_ID",
                table: "Batchs",
                column: "Trainer_ID",
                principalTable: "Trainers",
                principalColumn: "Trainer_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batchs_Courses_CourseId",
                table: "Batchs");

            migrationBuilder.DropForeignKey(
                name: "FK_Batchs_Trainers_Trainer_ID",
                table: "Batchs");

            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainers",
                table: "Trainers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Batchs",
                table: "Batchs");

            migrationBuilder.RenameTable(
                name: "Trainers",
                newName: "Trainer");

            migrationBuilder.RenameTable(
                name: "Batchs",
                newName: "Batch");

            migrationBuilder.RenameColumn(
                name: "TraineId",
                table: "Batch",
                newName: "TraineID");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Batch",
                newName: "CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_Batchs_Trainer_ID",
                table: "Batch",
                newName: "IX_Batch_Trainer_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Batchs_CourseId",
                table: "Batch",
                newName: "IX_Batch_CourseID");

            migrationBuilder.AlterColumn<decimal>(
                name: "Fees",
                table: "Courses",
                type: "Decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainer",
                table: "Trainer",
                column: "Trainer_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Batch",
                table: "Batch",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Batch_Courses_CourseID",
                table: "Batch",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "Course_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Batch_Trainer_Trainer_ID",
                table: "Batch",
                column: "Trainer_ID",
                principalTable: "Trainer",
                principalColumn: "Trainer_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
