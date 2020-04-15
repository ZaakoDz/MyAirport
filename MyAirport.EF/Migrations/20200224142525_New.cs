using Microsoft.EntityFrameworkCore.Migrations;

namespace ZW.MyAirport.EF.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Luggages_Flights_FLIGHTID",
                table: "Luggages");

            migrationBuilder.AlterColumn<int>(
                name: "FLIGHTID",
                table: "Luggages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Luggages_Flights_FLIGHTID",
                table: "Luggages",
                column: "FLIGHTID",
                principalTable: "Flights",
                principalColumn: "FLIGHTID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Luggages_Flights_FLIGHTID",
                table: "Luggages");

            migrationBuilder.AlterColumn<int>(
                name: "FLIGHTID",
                table: "Luggages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Luggages_Flights_FLIGHTID",
                table: "Luggages",
                column: "FLIGHTID",
                principalTable: "Flights",
                principalColumn: "FLIGHTID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
