using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class InitRemainModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_product_ProductId",
                table: "cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rentalPrices",
                table: "rentalPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cars",
                table: "cars");

            migrationBuilder.RenameTable(
                name: "rentalPrices",
                newName: "rental_pricce");

            migrationBuilder.RenameTable(
                name: "cars",
                newName: "car");

            migrationBuilder.RenameIndex(
                name: "IX_cars_ProductId",
                table: "car",
                newName: "IX_car_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rental_pricce",
                table: "rental_pricce",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_car",
                table: "car",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "check_list",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarContractDetailId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Meter = table.Column<double>(type: "float", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_check_list", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "check_list_item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckListId = table.Column<int>(type: "int", nullable: false),
                    IsChecked = table.Column<bool>(type: "bit", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_check_list_item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "contract_detail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: false),
                    PickUpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PickUpCheckListId = table.Column<int>(type: "int", nullable: false),
                    ReturnCheckListId = table.Column<int>(type: "int", nullable: false),
                    SelectedPriceId = table.Column<int>(type: "int", nullable: false),
                    CheckInDone = table.Column<bool>(type: "bit", nullable: false),
                    CheckOutDone = table.Column<bool>(type: "bit", nullable: false),
                    RealMeter = table.Column<double>(type: "float", nullable: false),
                    MeterLimit = table.Column<double>(type: "float", nullable: false),
                    Overtime = table.Column<double>(type: "float", nullable: false),
                    OvertimeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contract_detail", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_car_product_ProductId",
                table: "car",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_product_ProductId",
                table: "car");

            migrationBuilder.DropTable(
                name: "check_list");

            migrationBuilder.DropTable(
                name: "check_list_item");

            migrationBuilder.DropTable(
                name: "contract_detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rental_pricce",
                table: "rental_pricce");

            migrationBuilder.DropPrimaryKey(
                name: "PK_car",
                table: "car");

            migrationBuilder.RenameTable(
                name: "rental_pricce",
                newName: "rentalPrices");

            migrationBuilder.RenameTable(
                name: "car",
                newName: "cars");

            migrationBuilder.RenameIndex(
                name: "IX_car_ProductId",
                table: "cars",
                newName: "IX_cars_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rentalPrices",
                table: "rentalPrices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cars",
                table: "cars",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_product_ProductId",
                table: "cars",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
