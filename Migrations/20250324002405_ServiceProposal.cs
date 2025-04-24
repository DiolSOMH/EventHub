using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Event.Migrations
{
    /// <inheritdoc />
    public partial class ServiceProposal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceProposals_AspNetUsers_AuthorId",
                table: "ServiceProposals");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceProposals_Events_EventId",
                table: "ServiceProposals");

            migrationBuilder.DropIndex(
                name: "IX_ServiceProposals_EventId",
                table: "ServiceProposals");

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
                name: "EventId",
                table: "ServiceProposals");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ServiceProposals",
                newName: "MoreDetails");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "ServiceProposals",
                newName: "WorkingDays");

            migrationBuilder.AlterColumn<string>(
                name: "EventTypes",
                table: "ServiceProposals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "ServiceProposals",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "ServiceProposals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "ServiceProposals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "ServiceProposals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Service",
                table: "ServiceProposals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c1e914a-d2bd-4e92-bb74-f43e318f0a97", null, "User", "USER" },
                    { "c707b873-c63a-4a01-870c-1c48e961ffa5", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Town", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dc7c40c4-21a0-41be-a270-582c58ecebf7", 0, "777cd27c-b1fc-436c-9f65-94f167e57d8e", "pack@gmail.com", false, null, false, null, "PACK@GMAIL.COM", "PACK", "AQAAAAIAAYagAAAAEHI/zau5VUv46N/wSirkN3iBRU/SVMAe8ARgs0edh4jHr3COLpaAonLhKYesQiDpNw==", null, false, "0e8b45cb-a557-4d91-a699-3fcd0a6d27d9", null, false, "Pack" });

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceProposals_AspNetUsers_AuthorId",
                table: "ServiceProposals",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceProposals_AspNetUsers_AuthorId",
                table: "ServiceProposals");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c1e914a-d2bd-4e92-bb74-f43e318f0a97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c707b873-c63a-4a01-870c-1c48e961ffa5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc7c40c4-21a0-41be-a270-582c58ecebf7");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "ServiceProposals");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "ServiceProposals");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "ServiceProposals");

            migrationBuilder.DropColumn(
                name: "Service",
                table: "ServiceProposals");

            migrationBuilder.RenameColumn(
                name: "WorkingDays",
                table: "ServiceProposals",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "MoreDetails",
                table: "ServiceProposals",
                newName: "Status");

            migrationBuilder.AlterColumn<string>(
                name: "EventTypes",
                table: "ServiceProposals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "ServiceProposals",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "ServiceProposals",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ServiceProposals_EventId",
                table: "ServiceProposals",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceProposals_AspNetUsers_AuthorId",
                table: "ServiceProposals",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceProposals_Events_EventId",
                table: "ServiceProposals",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");
        }
    }
}
