using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZW.MyAirport.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FLIGHTID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIE = table.Column<int>(nullable: false),
                    LIG = table.Column<string>(nullable: true),
                    JEX = table.Column<int>(nullable: false),
                    DHC = table.Column<DateTime>(nullable: false),
                    PKG = table.Column<string>(nullable: true),
                    IMM = table.Column<string>(nullable: true),
                    PAX = table.Column<int>(nullable: false),
                    DES = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FLIGHTID);
                });

            migrationBuilder.CreateTable(
                name: "Luggages",
                columns: table => new
                {
                    LUGGAGEID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FLIGHTID = table.Column<int>(nullable: false),
                    CODE_IATA = table.Column<string>(nullable: true),
                    DATE_CREATION = table.Column<DateTime>(nullable: false),
                    CLASSE = table.Column<string>(nullable: true),
                    PRIORITAIRE = table.Column<bool>(nullable: false),
                    STA = table.Column<string>(nullable: true),
                    SSUR = table.Column<string>(nullable: true),
                    DESTINATION = table.Column<string>(nullable: true),
                    ESCALE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luggages", x => x.LUGGAGEID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Luggages");
        }
    }
}
