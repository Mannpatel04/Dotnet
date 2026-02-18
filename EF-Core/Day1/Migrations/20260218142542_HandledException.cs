using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Demo.Migrations
{
    /// <inheritdoc />
    public partial class HandledException : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batchs_Courses_CourseId",
                table: "Batchs");

            migrationBuilder.DropForeignKey(
                name: "FK_Batchs_Trainers_Trainer_ID1",
                table: "Batchs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Batchs",
                table: "Batchs");

            migrationBuilder.DropColumn(
                name: "Trainer_ID",
                table: "Batchs");

            migrationBuilder.RenameTable(
                name: "Batchs",
                newName: "Batches");

            migrationBuilder.RenameColumn(
                name: "startDate",
                table: "Batches",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Trainer_ID1",
                table: "Batches",
                newName: "TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_Batchs_Trainer_ID1",
                table: "Batches",
                newName: "IX_Batches_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_Batchs_CourseId",
                table: "Batches",
                newName: "IX_Batches_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Batches",
                table: "Batches",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Batches_Courses_CourseId",
                table: "Batches",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Course_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Batches_Trainers_TrainerId",
                table: "Batches",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Trainer_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batches_Courses_CourseId",
                table: "Batches");

            migrationBuilder.DropForeignKey(
                name: "FK_Batches_Trainers_TrainerId",
                table: "Batches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Batches",
                table: "Batches");

            migrationBuilder.RenameTable(
                name: "Batches",
                newName: "Batchs");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Batchs",
                newName: "startDate");

            migrationBuilder.RenameColumn(
                name: "TrainerId",
                table: "Batchs",
                newName: "Trainer_ID1");

            migrationBuilder.RenameIndex(
                name: "IX_Batches_TrainerId",
                table: "Batchs",
                newName: "IX_Batchs_Trainer_ID1");

            migrationBuilder.RenameIndex(
                name: "IX_Batches_CourseId",
                table: "Batchs",
                newName: "IX_Batchs_CourseId");

            migrationBuilder.AddColumn<int>(
                name: "Trainer_ID",
                table: "Batchs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Batchs",
                table: "Batchs",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Batchs_Courses_CourseId",
                table: "Batchs",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Course_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Batchs_Trainers_Trainer_ID1",
                table: "Batchs",
                column: "Trainer_ID1",
                principalTable: "Trainers",
                principalColumn: "Trainer_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
