using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Demo.Migrations
{
    /// <inheritdoc />
    public partial class AddDataAnnotaion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreateDate",
                table: "Students",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<decimal>(
                name: "Fees",
                table: "Courses",
                type: "Decimal(18,0)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreateDate",
                table: "Students",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "Date");

            migrationBuilder.AlterColumn<int>(
                name: "Fees",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "Decimal(18,0)",
                oldNullable: true);
        }
    }
}
