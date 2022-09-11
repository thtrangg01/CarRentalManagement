using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class updateschema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_check_list_car_CarId",
                table: "check_list");

            migrationBuilder.DropIndex(
                name: "IX_check_list_CarId",
                table: "check_list");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "check_list");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "check_list",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_check_list_CarId",
                table: "check_list",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_check_list_car_CarId",
                table: "check_list",
                column: "CarId",
                principalTable: "car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
