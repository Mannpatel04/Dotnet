using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddedConsoleMenuOfStudentAndCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Fees",
                table: "Courses",
                type: "Decimal(18,0)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "Decimal(18,0)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Fees",
                table: "Courses",
                type: "Decimal(18,0)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "Decimal(18,0)");
        }
    }
}
