using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class updatedatabaseschemav2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_contract_detail",
                table: "contract_detail");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "contract_detail");

            migrationBuilder.CreateIndex(
                name: "IX_check_list_item_CheckListId",
                table: "check_list_item",
                column: "CheckListId");

            migrationBuilder.AddForeignKey(
                name: "FK_check_list_item_check_list_CheckListId",
                table: "check_list_item",
                column: "CheckListId",
                principalTable: "check_list",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_check_list_item_check_list_CheckListId",
                table: "check_list_item");

            migrationBuilder.DropIndex(
                name: "IX_check_list_item_CheckListId",
                table: "check_list_item");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "contract_detail",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contract_detail",
                table: "contract_detail",
                column: "Id");
        }
    }
}
