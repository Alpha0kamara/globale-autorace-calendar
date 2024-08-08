using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GlobaleAutoRaceKalender.Migrations
{
    public partial class AddedDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RaceEntries_Pilots_PilotId",
                table: "RaceEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceEntries_Races_RaceId",
                table: "RaceEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceEntries_Teams_TeamId",
                table: "RaceEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Circuits_CircuitId",
                table: "Races");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Seasons_SeasonId",
                table: "Races");

            migrationBuilder.DropForeignKey(
                name: "FK_Seasons_Series_SeriesId",
                table: "Seasons");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seasons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Races",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Circuits",
                columns: new[] { "Id", "Address", "City", "Country", "Length", "Name", "PostalCode" },
                values: new object[,]
                {
                    { 1, "Circuit de Monaco", "Monte Carlo", "Monaco", 3340, "Grand Prix of Monaco", "98000" },
                    { 2, "Silverstone Circuit", "Silverstone", "UK", 5891, "Silverstone Grand Prix", "NN12 8TN" },
                    { 3, "Albert Park Circuit", "Melbourne", "Australia", 5303, "Australian Grand Prix", "3004" }
                });

            migrationBuilder.InsertData(
                table: "Pilots",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "Gender", "Height", "LastName", "LicenseNumber", "NickName", "PhotoPath", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alpha", 0, 174, "Kamara", "LIC123456", "Hammertime", "/images/pilots/alpha.jpg", 73 },
                    { 2, new DateTime(1997, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Max", 0, 180, "Verstappen", "LIC654321", "Mad Max", "/images/pilots/max_verstappen.jpg", 72 },
                    { 3, new DateTime(1999, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lando", 0, 170, "Norris", "LIC987654", "Lando", "/images/pilots/lando_norris.jpg", 68 }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndDate", "IsActive", "Name", "SeriesId", "StartDate" },
                values: new object[] { 6, new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2024 NASCAR Season", 6, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Series",
                columns: new[] { "Id", "EndDate", "Name", "SortOrder", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIA Formula One World Championship", 1, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIA Formula E World Championship", 2, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIA World Endurance Championship", 3, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "IndyCar Series", 4, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "MotoGP World Championship", 5, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "AlphaTeam" },
                    { 2, "BetaTeam" },
                    { 3, "IsmailTeam" }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "EndDate", "IsActive", "Name", "SeriesId", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2024 Formula One Season", 1, new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2024 Formula E Season", 2, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2024 WEC Season", 3, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2024 IndyCar Season", 4, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2024 MotoGP Season", 5, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "CircuitId", "EndTime", "Name", "SeasonId", "StartTIme" },
                values: new object[] { 1, 1, new DateTime(2024, 5, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), "Monaco Grand Prix 2024", 1, new DateTime(2024, 5, 26, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "CircuitId", "EndTime", "Name", "SeasonId", "StartTIme" },
                values: new object[] { 2, 2, new DateTime(2024, 7, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), "Silverstone Grand Prix 2024", 1, new DateTime(2024, 7, 7, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "CircuitId", "EndTime", "Name", "SeasonId", "StartTIme" },
                values: new object[] { 3, 3, new DateTime(2024, 3, 17, 7, 0, 0, 0, DateTimeKind.Unspecified), "Australian Grand Prix 2024", 1, new DateTime(2024, 3, 17, 5, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "RaceEntries",
                columns: new[] { "Id", "PilotId", "RaceId", "TeamId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 6, 3, 1, 3 },
                    { 2, 2, 2, 2 },
                    { 4, 1, 2, 1 },
                    { 3, 3, 3, 3 },
                    { 5, 2, 3, 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_RaceEntries_Pilots_PilotId",
                table: "RaceEntries",
                column: "PilotId",
                principalTable: "Pilots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceEntries_Races_RaceId",
                table: "RaceEntries",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceEntries_Teams_TeamId",
                table: "RaceEntries",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Circuits_CircuitId",
                table: "Races",
                column: "CircuitId",
                principalTable: "Circuits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Seasons_SeasonId",
                table: "Races",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Series_SeriesId",
                table: "Seasons",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RaceEntries_Pilots_PilotId",
                table: "RaceEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceEntries_Races_RaceId",
                table: "RaceEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_RaceEntries_Teams_TeamId",
                table: "RaceEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Circuits_CircuitId",
                table: "Races");

            migrationBuilder.DropForeignKey(
                name: "FK_Races_Seasons_SeasonId",
                table: "Races");

            migrationBuilder.DropForeignKey(
                name: "FK_Seasons_Series_SeriesId",
                table: "Seasons");

            migrationBuilder.DeleteData(
                table: "RaceEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RaceEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RaceEntries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RaceEntries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RaceEntries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RaceEntries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pilots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Circuits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seasons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Series",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seasons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Races",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_RaceEntries_Pilots_PilotId",
                table: "RaceEntries",
                column: "PilotId",
                principalTable: "Pilots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceEntries_Races_RaceId",
                table: "RaceEntries",
                column: "RaceId",
                principalTable: "Races",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RaceEntries_Teams_TeamId",
                table: "RaceEntries",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Circuits_CircuitId",
                table: "Races",
                column: "CircuitId",
                principalTable: "Circuits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Races_Seasons_SeasonId",
                table: "Races",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Series_SeriesId",
                table: "Seasons",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
