using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MBS.DAL.Migrations
{
    public partial class newwAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "UserDivisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DivisionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDivisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_UserDivisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "UserDivisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubDistricts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubDistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubDistricts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubDistricts_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SubDistricts_UserDivisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "UserDivisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubDistrictId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Locations_SubDistricts_SubDistrictId",
                        column: x => x.SubDistrictId,
                        principalTable: "SubDistricts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Locations_UserDivisions_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "UserDivisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

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

            migrationBuilder.InsertData(
                table: "UserDivisions",
                columns: new[] { "Id", "CreatedDate", "DivisionName", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9189), "Chattagram", new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9190) },
                    { 2, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9191), "Rajshahi", new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9192) },
                    { 3, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9193), "Khulna", new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9193) },
                    { 4, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9194), "Barishal", new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9194) },
                    { 5, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9195), "Sylhet", new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9195) },
                    { 6, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9196), "Dhaka", new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9196) },
                    { 7, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9197), "Rangpur", new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9197) },
                    { 8, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9198), "Mymensingh", new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9198) }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CreatedDate", "DistrictName", "DivisionId", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9214), "Chattagram", 1, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9215) },
                    { 2, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9217), "Rajshahi", 2, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9217) },
                    { 3, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9218), "Khulna", 3, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9218) },
                    { 4, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9219), "Barishal", 4, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9219) },
                    { 5, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9220), "Sylhet", 5, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9221) },
                    { 6, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9222), "Dhaka", 6, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9223) },
                    { 7, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9223), "Rangpur", 7, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9224) },
                    { 8, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9224), "Mymensingh", 8, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9225) },
                    { 9, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9225), "Noakhali", 1, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9226) },
                    { 10, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9227), "Coxbazar", 1, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9227) },
                    { 11, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9228), "Pabna", 2, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9228) },
                    { 12, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9229), "Nator", 2, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9229) },
                    { 13, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9230), "Jashore", 3, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9230) },
                    { 14, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9231), "Magura", 3, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9231) },
                    { 15, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9232), "MusnshiGanj", 5, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9232) },
                    { 16, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9233), "ManikGanj", 5, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9234) }
                });

            migrationBuilder.InsertData(
                table: "SubDistricts",
                columns: new[] { "Id", "CreatedDate", "DistrictId", "DivisionId", "ModifiedDate", "SubDistrictName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9248), 1, 1, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9249), "Chattagram_sadar" },
                    { 2, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9250), 2, 2, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9251), "Rajshahi_sadar" },
                    { 3, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9251), 3, 3, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9252), "Khulna_sadar" },
                    { 4, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9253), 4, 4, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9253), "Barishal_sadar" },
                    { 6, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9254), 6, 6, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9254), "Dhaka_sadar" },
                    { 7, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9255), 13, 3, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9255), "Monirampur" },
                    { 8, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9256), 13, 3, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9257), "Avainagar" },
                    { 9, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9257), 14, 3, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9258), "Shalikha" },
                    { 10, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9258), 14, 3, new DateTime(2025, 1, 9, 23, 34, 25, 768, DateTimeKind.Local).AddTicks(9259), "Mohammadpur" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Districts_DivisionId",
                table: "Districts",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_DistrictId",
                table: "Locations",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_DivisionId",
                table: "Locations",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_SubDistrictId",
                table: "Locations",
                column: "SubDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_SubDistricts_DistrictId",
                table: "SubDistricts",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_SubDistricts_DivisionId",
                table: "SubDistricts",
                column: "DivisionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "SubDistricts");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "UserDivisions");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 12, 37, 50, 568, DateTimeKind.Local).AddTicks(7468), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 12, 37, 50, 568, DateTimeKind.Local).AddTicks(7482), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 12, 37, 50, 568, DateTimeKind.Local).AddTicks(7483), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 12, 37, 50, 568, DateTimeKind.Local).AddTicks(7484), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 12, 37, 50, 568, DateTimeKind.Local).AddTicks(7484), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 12, 37, 50, 568, DateTimeKind.Local).AddTicks(7485), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 12, 37, 50, 568, DateTimeKind.Local).AddTicks(7486), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Divisions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 10, 24, 12, 37, 50, 568, DateTimeKind.Local).AddTicks(7486), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
