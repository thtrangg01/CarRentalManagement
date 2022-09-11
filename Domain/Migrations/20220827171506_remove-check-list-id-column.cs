using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class removechecklistidcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_check_list",
                table: "check_list");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "check_list");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "check_list",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_check_list_CarId",
                table: "check_list",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_car_Number",
                table: "car",
                column: "Number",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_check_list_car_CarId",
                table: "check_list",
                column: "CarId",
                principalTable: "car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_check_list_car_CarId",
                table: "check_list");

            migrationBuilder.DropIndex(
                name: "IX_check_list_CarId",
                table: "check_list");

            migrationBuilder.DropIndex(
                name: "IX_car_Number",
                table: "car");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "check_list");

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
        }
    }
}
