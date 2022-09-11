using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class updatechecklistconstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "check_list",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_check_list",
                table: "check_list",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_car_PickUpCheckListId",
                table: "car",
                column: "PickUpCheckListId",
                unique: true,
                filter: "[PickUpCheckListId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_car_ReturnCheckListId",
                table: "car",
                column: "ReturnCheckListId",
                unique: true,
                filter: "[ReturnCheckListId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_car_check_list_PickUpCheckListId",
                table: "car",
                column: "PickUpCheckListId",
                principalTable: "check_list",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_car_check_list_ReturnCheckListId",
                table: "car",
                column: "ReturnCheckListId",
                principalTable: "check_list",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_car_check_list_PickUpCheckListId",
                table: "car");

            migrationBuilder.DropForeignKey(
                name: "FK_car_check_list_ReturnCheckListId",
                table: "car");

            migrationBuilder.DropPrimaryKey(
                name: "PK_check_list",
                table: "check_list");

            migrationBuilder.DropIndex(
                name: "IX_car_PickUpCheckListId",
                table: "car");

            migrationBuilder.DropIndex(
                name: "IX_car_ReturnCheckListId",
                table: "car");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "check_list");
        }
    }
}
