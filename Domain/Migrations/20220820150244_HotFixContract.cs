using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class HotFixContract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_product_productId",
                table: "cars");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "cars",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "returnCheckListId",
                table: "cars",
                newName: "ReturnCheckListId");

            migrationBuilder.RenameColumn(
                name: "resreved",
                table: "cars",
                newName: "Resreved");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "cars",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "pickUpCheckListId",
                table: "cars",
                newName: "PickUpCheckListId");

            migrationBuilder.RenameColumn(
                name: "overtimeRate",
                table: "cars",
                newName: "OvertimeRate");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "cars",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "meterUnit",
                table: "cars",
                newName: "MeterUnit");

            migrationBuilder.RenameColumn(
                name: "meter",
                table: "cars",
                newName: "Meter");

            migrationBuilder.RenameColumn(
                name: "insuranceOn",
                table: "cars",
                newName: "InsuranceOn");

            migrationBuilder.RenameColumn(
                name: "cost",
                table: "cars",
                newName: "Cost");

            migrationBuilder.RenameIndex(
                name: "IX_cars_productId",
                table: "cars",
                newName: "IX_cars_ProductId");

            migrationBuilder.CreateTable(
                name: "contract",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PercentDiscount = table.Column<double>(type: "float", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RentalAgreement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RentalCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: true),
                    CompleteById = table.Column<int>(type: "int", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contract_customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contract_staff_CompleteById",
                        column: x => x.CompleteById,
                        principalTable: "staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_contract_staff_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rentalPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MeterLimit = table.Column<double>(type: "float", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rentalPrices", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contract_CompleteById",
                table: "contract",
                column: "CompleteById");

            migrationBuilder.CreateIndex(
                name: "IX_contract_CreatorId",
                table: "contract",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_contract_CustomerId",
                table: "contract",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_product_ProductId",
                table: "cars",
                column: "ProductId",
                principalTable: "product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_product_ProductId",
                table: "cars");

            migrationBuilder.DropTable(
                name: "contract");

            migrationBuilder.DropTable(
                name: "rentalPrices");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "cars",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "ReturnCheckListId",
                table: "cars",
                newName: "returnCheckListId");

            migrationBuilder.RenameColumn(
                name: "Resreved",
                table: "cars",
                newName: "resreved");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "cars",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "PickUpCheckListId",
                table: "cars",
                newName: "pickUpCheckListId");

            migrationBuilder.RenameColumn(
                name: "OvertimeRate",
                table: "cars",
                newName: "overtimeRate");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "cars",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "MeterUnit",
                table: "cars",
                newName: "meterUnit");

            migrationBuilder.RenameColumn(
                name: "Meter",
                table: "cars",
                newName: "meter");

            migrationBuilder.RenameColumn(
                name: "InsuranceOn",
                table: "cars",
                newName: "insuranceOn");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "cars",
                newName: "cost");

            migrationBuilder.RenameIndex(
                name: "IX_cars_ProductId",
                table: "cars",
                newName: "IX_cars_productId");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_product_productId",
                table: "cars",
                column: "productId",
                principalTable: "product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
