using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Event.Migrations
{
    /// <inheritdoc />
    public partial class NumberOfAttendees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "564e500c-cf19-4e44-a0a1-9d899114f43c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb811ef9-552c-428a-acd0-ec3434f82f96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bd693e5-1da0-41e2-ba3b-03c16b2d5d8d");

            migrationBuilder.AddColumn<int>(
                name: "EstimatedNunberOfAttendees",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "58bced0e-aa15-48c2-bbe9-0998debb7fda", null, "Admin", "ADMIN" },
                    { "d57900d1-e8c9-4cff-9c64-ac13258d7499", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Town", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e948ffd8-d2da-4064-811f-79325a837d48", 0, "afcaedbb-74db-4f0b-b519-9c18fec5b6b8", "pack@gmail.com", false, null, false, null, "PACK@GMAIL.COM", "PACK", "AQAAAAIAAYagAAAAEINZBH7B2bhOq2pj+idt4dcsm8KRa+EHESqdvmHKTnoJOMQ29wIWowTXuVI1A/uZsA==", null, false, "bff9b064-fae1-479a-932b-9ed67a906785", null, false, "Pack" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58bced0e-aa15-48c2-bbe9-0998debb7fda");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d57900d1-e8c9-4cff-9c64-ac13258d7499");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e948ffd8-d2da-4064-811f-79325a837d48");

            migrationBuilder.DropColumn(
                name: "EstimatedNunberOfAttendees",
                table: "Events");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "564e500c-cf19-4e44-a0a1-9d899114f43c", null, "User", "USER" },
                    { "bb811ef9-552c-428a-acd0-ec3434f82f96", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Town", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5bd693e5-1da0-41e2-ba3b-03c16b2d5d8d", 0, "e265937f-a34f-49c0-94ae-5332dd7d9ada", "pack@gmail.com", false, null, false, null, "PACK@GMAIL.COM", "PACK", "AQAAAAIAAYagAAAAEG/x7Pa1XURV/jbOPVdcmmiQfgh9MRFAYRKMNMiMQZnvlWDtAcN8x1vFTngdyfWsVw==", null, false, "b33775ef-bcab-4899-a542-81269beac301", null, false, "Pack" });
        }
    }
}
