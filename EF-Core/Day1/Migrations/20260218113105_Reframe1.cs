using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Demo.Migrations
{
    /// <inheritdoc />
    public partial class Reframe1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batchs_Trainers_Trainer_ID",
                table: "Batchs");

            migrationBuilder.DropIndex(
                name: "IX_Batchs_Trainer_ID",
                table: "Batchs");

            migrationBuilder.RenameColumn(
                name: "TraineId",
                table: "Batchs",
                newName: "Trainer_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Batchs_Trainer_ID1",
                table: "Batchs",
                column: "Trainer_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Batchs_Trainers_Trainer_ID1",
                table: "Batchs",
                column: "Trainer_ID1",
                principalTable: "Trainers",
                principalColumn: "Trainer_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batchs_Trainers_Trainer_ID1",
                table: "Batchs");

            migrationBuilder.DropIndex(
                name: "IX_Batchs_Trainer_ID1",
                table: "Batchs");

            migrationBuilder.RenameColumn(
                name: "Trainer_ID1",
                table: "Batchs",
                newName: "TraineId");

            migrationBuilder.CreateIndex(
                name: "IX_Batchs_Trainer_ID",
                table: "Batchs",
                column: "Trainer_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Batchs_Trainers_Trainer_ID",
                table: "Batchs",
                column: "Trainer_ID",
                principalTable: "Trainers",
                principalColumn: "Trainer_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
