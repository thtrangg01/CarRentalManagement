using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class updatedatabaseschemav42 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "contract_detail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<double>(
                name: "PercenDiscount",
                table: "contract_detail",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PercentTax",
                table: "contract_detail",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<decimal>(
                name: "Subtotal",
                table: "contract_detail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Tax",
                table: "contract_detail",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "contract_detail");

            migrationBuilder.DropColumn(
                name: "PercenDiscount",
                table: "contract_detail");

            migrationBuilder.DropColumn(
                name: "PercentTax",
                table: "contract_detail");

            migrationBuilder.DropColumn(
                name: "Subtotal",
                table: "contract_detail");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "contract_detail");
        }
    }
}
