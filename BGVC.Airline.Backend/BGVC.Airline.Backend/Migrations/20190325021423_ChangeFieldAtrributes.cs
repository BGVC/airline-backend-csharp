using Microsoft.EntityFrameworkCore.Migrations;

namespace BGVC.Airline.Backend.Migrations
{
    public partial class ChangeFieldAtrributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airports_AirportTypes_AirportTypeId",
                table: "Airports");

            migrationBuilder.DropIndex(
                name: "IX_Airports_AirportTypeId",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "AirportTypeId",
                table: "Airports");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Iso",
                table: "Countries",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Airports",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LongitudeDegrees",
                table: "Airports",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LatitudeDegrees",
                table: "Airports",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ElevationFeet",
                table: "Airports",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Airports",
                maxLength: 7,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Airports_TypeId",
                table: "Airports",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Airports_AirportTypes_TypeId",
                table: "Airports",
                column: "TypeId",
                principalTable: "AirportTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airports_AirportTypes_TypeId",
                table: "Airports");

            migrationBuilder.DropIndex(
                name: "IX_Airports_TypeId",
                table: "Airports");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Iso",
                table: "Countries",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Airports",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "LongitudeDegrees",
                table: "Airports",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LatitudeDegrees",
                table: "Airports",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ElevationFeet",
                table: "Airports",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Airports",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 7);

            migrationBuilder.AddColumn<int>(
                name: "AirportTypeId",
                table: "Airports",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Airports_AirportTypeId",
                table: "Airports",
                column: "AirportTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Airports_AirportTypes_AirportTypeId",
                table: "Airports",
                column: "AirportTypeId",
                principalTable: "AirportTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
