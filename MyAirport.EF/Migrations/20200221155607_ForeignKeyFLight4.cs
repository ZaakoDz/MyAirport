﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ZW.MyAirport.EF.Migrations
{
    public partial class ForeignKeyFLight4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Luggages_Flights_FLIGHTID",
                table: "Luggages");

            migrationBuilder.DropIndex(
                name: "IX_Luggages_FLIGHTID",
                table: "Luggages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Luggages_FLIGHTID",
                table: "Luggages",
                column: "FLIGHTID");

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
