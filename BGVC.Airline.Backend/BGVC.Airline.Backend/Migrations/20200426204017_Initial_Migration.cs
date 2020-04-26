using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BGVC.Airline.Backend.Migrations
{
    public partial class Initial_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirplaneTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(maxLength: 512, nullable: false),
                    Model = table.Column<string>(maxLength: 512, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirplaneTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirportTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirportTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Iso = table.Column<string>(maxLength: 2, nullable: false),
                    Name = table.Column<string>(maxLength: 64, nullable: false),
                    PrintableName = table.Column<string>(maxLength: 64, nullable: true),
                    Iso3 = table.Column<string>(maxLength: 3, nullable: true),
                    NumCode = table.Column<string>(maxLength: 3, nullable: true),
                    PhoneCode = table.Column<string>(maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirlineCompany",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 512, nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirlineCompany", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AirlineCompany_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IsoRegions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 16, nullable: false),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsoRegions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IsoRegions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsoRegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipalities_IsoRegions_IsoRegionId",
                        column: x => x.IsoRegionId,
                        principalTable: "IsoRegions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(maxLength: 20, nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 1000, nullable: false),
                    LatitudeDegrees = table.Column<int>(nullable: true),
                    LongitudeDegrees = table.Column<int>(nullable: true),
                    ElevationFeet = table.Column<int>(nullable: true),
                    MunicipalityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Airports_Municipalities_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Airports_AirportTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AirportTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureAirportId = table.Column<int>(nullable: false),
                    DestinationAirportId = table.Column<int>(nullable: false),
                    DepartureTime = table.Column<DateTime>(nullable: false),
                    ArrivalTime = table.Column<DateTime>(nullable: false),
                    AirplaneNumber = table.Column<string>(nullable: true),
                    AirplaneTypeId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flights_AirplaneTypes_AirplaneTypeId",
                        column: x => x.AirplaneTypeId,
                        principalTable: "AirplaneTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Flights_AirlineCompany_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "AirlineCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Flights_Airports_DepartureAirportId",
                        column: x => x.DepartureAirportId,
                        principalTable: "Airports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Flights_Airports_DestinationAirportId",
                        column: x => x.DestinationAirportId,
                        principalTable: "Airports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AirplaneTypes",
                columns: new[] { "Id", "Manufacturer", "Model" },
                values: new object[,]
                {
                    { 1, "Boeing", "737" },
                    { 2, "Airbus", "A330" }
                });

            migrationBuilder.InsertData(
                table: "AirportTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "heliport" },
                    { 2, "small_airport" },
                    { 3, "closed" },
                    { 4, "seaplane_base" },
                    { 5, "balloonport" },
                    { 6, "medium_airport" },
                    { 7, "large_airport" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Iso", "Iso3", "Name", "NumCode", "PhoneCode", "PrintableName" },
                values: new object[,]
                {
                    { 1, "RS", null, "Serbia", null, null, null },
                    { 2, "US", null, "United States", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "AirlineCompany",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Jat Airways" },
                    { 2, 2, "US AirTrans" }
                });

            migrationBuilder.InsertData(
                table: "IsoRegions",
                columns: new[] { "Id", "Code", "CountryId" },
                values: new object[,]
                {
                    { 2, "RS-05", 1 },
                    { 3, "RS-16", 1 },
                    { 1, "US-NJ", 2 }
                });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "Id", "IsoRegionId", "Name" },
                values: new object[] { 2, 3, "Belgrade" });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "Id", "IsoRegionId", "Name" },
                values: new object[] { 1, 1, "Los Angeles" });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Code", "ElevationFeet", "LatitudeDegrees", "LongitudeDegrees", "MunicipalityId", "Name", "TypeId" },
                values: new object[] { 2, "BEG", null, null, null, 2, "Belgrade Nikola Tesla Airport", 7 });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "Code", "ElevationFeet", "LatitudeDegrees", "LongitudeDegrees", "MunicipalityId", "Name", "TypeId" },
                values: new object[] { 1, "LAX", null, null, null, 1, "Los Angeles International Airport", 7 });

            migrationBuilder.CreateIndex(
                name: "IX_AirlineCompany_CountryId",
                table: "AirlineCompany",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_MunicipalityId",
                table: "Airports",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_TypeId",
                table: "Airports",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AirplaneTypeId",
                table: "Flights",
                column: "AirplaneTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_CompanyId",
                table: "Flights",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_DepartureAirportId",
                table: "Flights",
                column: "DepartureAirportId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_DestinationAirportId",
                table: "Flights",
                column: "DestinationAirportId");

            migrationBuilder.CreateIndex(
                name: "IX_IsoRegions_CountryId",
                table: "IsoRegions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipalities_IsoRegionId",
                table: "Municipalities",
                column: "IsoRegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "AirplaneTypes");

            migrationBuilder.DropTable(
                name: "AirlineCompany");

            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "AirportTypes");

            migrationBuilder.DropTable(
                name: "IsoRegions");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
