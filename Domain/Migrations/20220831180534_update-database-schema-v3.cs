using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class updatedatabaseschemav3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "staff",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "staff",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "staff",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "car",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "dbo.F_GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_rental_pricce_CarId",
                table: "rental_pricce",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_rental_pricce_car_CarId",
                table: "rental_pricce",
                column: "CarId",
                principalTable: "car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rental_pricce_car_CarId",
                table: "rental_pricce");

            migrationBuilder.DropIndex(
                name: "IX_rental_pricce_CarId",
                table: "rental_pricce");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "staff");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "staff");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "staff");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "car",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "dbo.F_GETDATE()");
        }
    }
}
