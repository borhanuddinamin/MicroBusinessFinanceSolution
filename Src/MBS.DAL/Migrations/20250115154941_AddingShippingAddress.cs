using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MBS.DAL.Migrations
{
    public partial class AddingShippingAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShippingAddress",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAddress", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7788), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7791), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7792), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7793), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7794), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7794), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7795), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7796), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7797), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7798), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7799), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7799) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7799), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7800), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7801), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7802), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7803), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7625), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7635), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7636), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7637), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7638), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7639), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7640), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7641), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7817), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7819), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7820), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7821), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7822), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7823), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7824), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7824), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7825), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7770), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7771), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7772), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7773), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7774), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7775), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7775), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7776), new DateTime(2025, 1, 15, 21, 49, 40, 868, DateTimeKind.Local).AddTicks(7777) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShippingAddress");

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9214), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9217), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9218), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9219), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9220), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9222), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9223), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9224), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9225), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9227), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9228), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9229), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9230), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9231), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9232), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9233), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(8980), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(8994), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(8996), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(8997), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9046), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9048), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9049), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9050), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9248), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9250), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9251), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9253), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9254), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9255), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9256), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9257), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "SubDistricts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9258), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9189), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9191), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9192) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9193), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9193) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9194), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9195), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9196), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9197), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9197) });

            migrationBuilder.UpdateData(
                table: "UserDivisions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9198), new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9198) });
        }
    }
}
