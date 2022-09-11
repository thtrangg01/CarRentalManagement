using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class updatedatabaseschemav41 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SelectedPriceId",
                table: "contract_detail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contract_detail",
                table: "contract_detail",
                columns: new[] { "CarId", "ContractId" });

            migrationBuilder.CreateIndex(
                name: "IX_contract_detail_ContractId",
                table: "contract_detail",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_contract_detail_car_CarId",
                table: "contract_detail",
                column: "CarId",
                principalTable: "car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contract_detail_contract_ContractId",
                table: "contract_detail",
                column: "ContractId",
                principalTable: "contract",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contract_detail_car_CarId",
                table: "contract_detail");

            migrationBuilder.DropForeignKey(
                name: "FK_contract_detail_contract_ContractId",
                table: "contract_detail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contract_detail",
                table: "contract_detail");

            migrationBuilder.DropIndex(
                name: "IX_contract_detail_ContractId",
                table: "contract_detail");

            migrationBuilder.AddColumn<int>(
                name: "SelectedPriceId",
                table: "contract_detail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
