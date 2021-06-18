using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class Inixx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Order",
                table: "Route2Stops",
                newName: "StopId");

            migrationBuilder.CreateIndex(
                name: "IX_Route2Stops_StopId",
                table: "Route2Stops",
                column: "StopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Route2Stops_Stops_StopId",
                table: "Route2Stops",
                column: "StopId",
                principalTable: "Stops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Route2Stops_Stops_StopId",
                table: "Route2Stops");

            migrationBuilder.DropIndex(
                name: "IX_Route2Stops_StopId",
                table: "Route2Stops");

            migrationBuilder.RenameColumn(
                name: "StopId",
                table: "Route2Stops",
                newName: "Order");
        }
    }
}
