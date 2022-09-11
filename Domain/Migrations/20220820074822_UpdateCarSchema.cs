using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class UpdateCarSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "insuranceOn",
                table: "cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "meter",
                table: "cars",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "meterUnit",
                table: "cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "overtimeRate",
                table: "cars",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "pickUpCheckListId",
                table: "cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "productId",
                table: "cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "resreved",
                table: "cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "returnCheckListId",
                table: "cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "insuranceOn",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "meter",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "meterUnit",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "overtimeRate",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "pickUpCheckListId",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "resreved",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "returnCheckListId",
                table: "cars");
        }
    }
}
