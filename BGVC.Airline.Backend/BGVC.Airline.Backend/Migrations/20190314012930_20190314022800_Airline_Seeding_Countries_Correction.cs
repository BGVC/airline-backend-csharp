using Microsoft.EntityFrameworkCore.Migrations;

namespace BGVC.Airline.Backend.Migrations
{
    public partial class _20190314022800_Airline_Seeding_Countries_Correction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Iso",
                table: "Countries",
                maxLength: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Iso3",
                table: "Countries",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumCode",
                table: "Countries",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneCode",
                table: "Countries",
                maxLength: 4,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrintableName",
                table: "Countries",
                maxLength: 64,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Iso",
                value: "AF");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Iso",
                value: "AX");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Iso",
                value: "AL");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Iso",
                value: "DZ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Iso",
                value: "AS");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Iso",
                value: "AD");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Iso",
                value: "AO");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Iso",
                value: "AI");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Iso",
                value: "AQ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10,
                column: "Iso",
                value: "AG");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11,
                column: "Iso",
                value: "AR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12,
                column: "Iso",
                value: "AM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13,
                column: "Iso",
                value: "AW");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14,
                column: "Iso",
                value: "AU");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15,
                column: "Iso",
                value: "AT");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16,
                column: "Iso",
                value: "AZ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17,
                column: "Iso",
                value: "BH");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18,
                column: "Iso",
                value: "BS");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19,
                column: "Iso",
                value: "BD");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20,
                column: "Iso",
                value: "BB");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21,
                column: "Iso",
                value: "BY");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22,
                column: "Iso",
                value: "BE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23,
                column: "Iso",
                value: "BZ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24,
                column: "Iso",
                value: "BJ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25,
                column: "Iso",
                value: "BM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26,
                column: "Iso",
                value: "BT");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27,
                column: "Iso",
                value: "BO");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28,
                column: "Iso",
                value: "BQ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29,
                column: "Iso",
                value: "BA");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30,
                column: "Iso",
                value: "BW");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31,
                column: "Iso",
                value: "BV");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32,
                column: "Iso",
                value: "BR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33,
                column: "Iso",
                value: "IO");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34,
                column: "Iso",
                value: "BN");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35,
                column: "Iso",
                value: "BG");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36,
                column: "Iso",
                value: "BF");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37,
                column: "Iso",
                value: "BI");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38,
                column: "Iso",
                value: "KH");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39,
                column: "Iso",
                value: "CM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40,
                column: "Iso",
                value: "CA");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41,
                column: "Iso",
                value: "CV");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42,
                column: "Iso",
                value: "KY");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43,
                column: "Iso",
                value: "CF");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44,
                column: "Iso",
                value: "TD");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45,
                column: "Iso",
                value: "CL");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46,
                column: "Iso",
                value: "CN");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47,
                column: "Iso",
                value: "CX");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48,
                column: "Iso",
                value: "CC");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49,
                column: "Iso",
                value: "CO");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50,
                column: "Iso",
                value: "KM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51,
                column: "Iso",
                value: "CG");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52,
                column: "Iso",
                value: "CD");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53,
                column: "Iso",
                value: "CK");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54,
                column: "Iso",
                value: "CR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55,
                column: "Iso",
                value: "CI");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56,
                column: "Iso",
                value: "HR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57,
                column: "Iso",
                value: "CU");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58,
                column: "Iso",
                value: "CW");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59,
                column: "Iso",
                value: "CY");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60,
                column: "Iso",
                value: "CZ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61,
                column: "Iso",
                value: "DK");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62,
                column: "Iso",
                value: "DJ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63,
                column: "Iso",
                value: "DM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64,
                column: "Iso",
                value: "DO");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65,
                column: "Iso",
                value: "EC");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66,
                column: "Iso",
                value: "EG");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67,
                column: "Iso",
                value: "SV");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68,
                column: "Iso",
                value: "GQ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69,
                column: "Iso",
                value: "ER");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70,
                column: "Iso",
                value: "EE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71,
                column: "Iso",
                value: "ET");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72,
                column: "Iso",
                value: "FK");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73,
                column: "Iso",
                value: "FO");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74,
                column: "Iso",
                value: "FJ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75,
                column: "Iso",
                value: "FI");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76,
                column: "Iso",
                value: "FR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77,
                column: "Iso",
                value: "GF");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78,
                column: "Iso",
                value: "PF");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79,
                column: "Iso",
                value: "TF");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80,
                column: "Iso",
                value: "GA");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81,
                column: "Iso",
                value: "GM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82,
                column: "Iso",
                value: "GE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83,
                column: "Iso",
                value: "DE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84,
                column: "Iso",
                value: "GH");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85,
                column: "Iso",
                value: "GI");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86,
                column: "Iso",
                value: "GR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87,
                column: "Iso",
                value: "GL");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88,
                column: "Iso",
                value: "GD");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89,
                column: "Iso",
                value: "GP");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90,
                column: "Iso",
                value: "GU");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91,
                column: "Iso",
                value: "GT");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92,
                column: "Iso",
                value: "GG");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93,
                column: "Iso",
                value: "GN");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94,
                column: "Iso",
                value: "GW");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95,
                column: "Iso",
                value: "GY");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96,
                column: "Iso",
                value: "HT");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97,
                column: "Iso",
                value: "HM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98,
                column: "Iso",
                value: "VA");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99,
                column: "Iso",
                value: "HN");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100,
                column: "Iso",
                value: "HK");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101,
                column: "Iso",
                value: "HU");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102,
                column: "Iso",
                value: "IS");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103,
                column: "Iso",
                value: "IN");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104,
                column: "Iso",
                value: "ID");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105,
                column: "Iso",
                value: "IR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106,
                column: "Iso",
                value: "IQ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107,
                column: "Iso",
                value: "IE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108,
                column: "Iso",
                value: "IM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109,
                column: "Iso",
                value: "IL");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110,
                column: "Iso",
                value: "IT");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111,
                column: "Iso",
                value: "JM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112,
                column: "Iso",
                value: "JP");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113,
                column: "Iso",
                value: "JE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114,
                column: "Iso",
                value: "JO");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115,
                column: "Iso",
                value: "KZ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116,
                column: "Iso",
                value: "KE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117,
                column: "Iso",
                value: "KI");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118,
                column: "Iso",
                value: "KP");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119,
                column: "Iso",
                value: "KR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120,
                column: "Iso",
                value: "KW");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121,
                column: "Iso",
                value: "KG");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122,
                column: "Iso",
                value: "LA");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123,
                column: "Iso",
                value: "LV");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124,
                column: "Iso",
                value: "LB");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125,
                column: "Iso",
                value: "LS");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126,
                column: "Iso",
                value: "LR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127,
                column: "Iso",
                value: "LY");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128,
                column: "Iso",
                value: "LI");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129,
                column: "Iso",
                value: "LT");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130,
                column: "Iso",
                value: "LU");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131,
                column: "Iso",
                value: "MO");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132,
                column: "Iso",
                value: "MK");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133,
                column: "Iso",
                value: "MG");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134,
                column: "Iso",
                value: "MW");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135,
                column: "Iso",
                value: "MY");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136,
                column: "Iso",
                value: "MV");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137,
                column: "Iso",
                value: "ML");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138,
                column: "Iso",
                value: "MT");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139,
                column: "Iso",
                value: "MH");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140,
                column: "Iso",
                value: "MQ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141,
                column: "Iso",
                value: "MR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142,
                column: "Iso",
                value: "MU");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143,
                column: "Iso",
                value: "YT");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144,
                column: "Iso",
                value: "MX");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145,
                column: "Iso",
                value: "FM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146,
                column: "Iso",
                value: "MD");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147,
                column: "Iso",
                value: "MC");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148,
                column: "Iso",
                value: "MN");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149,
                column: "Iso",
                value: "ME");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150,
                column: "Iso",
                value: "MS");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151,
                column: "Iso",
                value: "MA");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152,
                column: "Iso",
                value: "MZ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153,
                column: "Iso",
                value: "MM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154,
                column: "Iso",
                value: "NA");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155,
                column: "Iso",
                value: "NR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156,
                column: "Iso",
                value: "NP");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157,
                column: "Iso",
                value: "NL");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158,
                column: "Iso",
                value: "NC");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159,
                column: "Iso",
                value: "NZ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160,
                column: "Iso",
                value: "NI");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161,
                column: "Iso",
                value: "NE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162,
                column: "Iso",
                value: "NG");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163,
                column: "Iso",
                value: "NU");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164,
                column: "Iso",
                value: "NF");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165,
                column: "Iso",
                value: "MP");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166,
                column: "Iso",
                value: "NO");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167,
                column: "Iso",
                value: "OM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168,
                column: "Iso",
                value: "PK");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169,
                column: "Iso",
                value: "PW");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170,
                column: "Iso",
                value: "PS");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171,
                column: "Iso",
                value: "PA");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172,
                column: "Iso",
                value: "PG");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173,
                column: "Iso",
                value: "PY");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174,
                column: "Iso",
                value: "PE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175,
                column: "Iso",
                value: "PH");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176,
                column: "Iso",
                value: "PN");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177,
                column: "Iso",
                value: "PL");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178,
                column: "Iso",
                value: "PT");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179,
                column: "Iso",
                value: "PR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180,
                column: "Iso",
                value: "QA");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181,
                column: "Iso",
                value: "RE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182,
                column: "Iso",
                value: "RO");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183,
                column: "Iso",
                value: "RU");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184,
                column: "Iso",
                value: "RW");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185,
                column: "Iso",
                value: "BL");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186,
                column: "Iso",
                value: "SH");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187,
                column: "Iso",
                value: "KN");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188,
                column: "Iso",
                value: "LC");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189,
                column: "Iso",
                value: "MF");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190,
                column: "Iso",
                value: "PM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191,
                column: "Iso",
                value: "VC");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192,
                column: "Iso",
                value: "WS");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193,
                column: "Iso",
                value: "SM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194,
                column: "Iso",
                value: "ST");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195,
                column: "Iso",
                value: "SA");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196,
                column: "Iso",
                value: "SN");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197,
                column: "Iso",
                value: "RS");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198,
                column: "Iso",
                value: "SC");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199,
                column: "Iso",
                value: "SL");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200,
                column: "Iso",
                value: "SG");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201,
                column: "Iso",
                value: "SX");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 202,
                column: "Iso",
                value: "SK");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 203,
                column: "Iso",
                value: "SI");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 204,
                column: "Iso",
                value: "SB");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 205,
                column: "Iso",
                value: "SO");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 206,
                column: "Iso",
                value: "ZA");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 207,
                column: "Iso",
                value: "GS");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 208,
                column: "Iso",
                value: "SS");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 209,
                column: "Iso",
                value: "ES");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 210,
                column: "Iso",
                value: "LK");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 211,
                column: "Iso",
                value: "SD");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 212,
                column: "Iso",
                value: "SR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 213,
                column: "Iso",
                value: "SJ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 214,
                column: "Iso",
                value: "SZ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 215,
                column: "Iso",
                value: "SE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 216,
                column: "Iso",
                value: "CH");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 217,
                column: "Iso",
                value: "SY");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 218,
                column: "Iso",
                value: "TW");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 219,
                column: "Iso",
                value: "TJ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 220,
                column: "Iso",
                value: "TZ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 221,
                column: "Iso",
                value: "TH");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 222,
                column: "Iso",
                value: "TL");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 223,
                column: "Iso",
                value: "TG");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 224,
                column: "Iso",
                value: "TK");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 225,
                column: "Iso",
                value: "TO");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 226,
                column: "Iso",
                value: "TT");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 227,
                column: "Iso",
                value: "TN");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 228,
                column: "Iso",
                value: "TR");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 229,
                column: "Iso",
                value: "TM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 230,
                column: "Iso",
                value: "TC");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 231,
                column: "Iso",
                value: "TV");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 232,
                column: "Iso",
                value: "UG");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 233,
                column: "Iso",
                value: "UA");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 234,
                column: "Iso",
                value: "AE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 235,
                column: "Iso",
                value: "GB");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 236,
                column: "Iso",
                value: "US");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 237,
                column: "Iso",
                value: "UM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 238,
                column: "Iso",
                value: "UY");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 239,
                column: "Iso",
                value: "UZ");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 240,
                column: "Iso",
                value: "VU");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 241,
                column: "Iso",
                value: "VE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 242,
                column: "Iso",
                value: "VN");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 243,
                column: "Iso",
                value: "VG");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 244,
                column: "Iso",
                value: "VI");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 245,
                column: "Iso",
                value: "WF");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 246,
                column: "Iso",
                value: "EH");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 247,
                column: "Iso",
                value: "YE");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 248,
                column: "Iso",
                value: "ZM");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 249,
                column: "Iso",
                value: "ZW");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Iso",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Iso3",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "NumCode",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "PhoneCode",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "PrintableName",
                table: "Countries");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);
        }
    }
}
