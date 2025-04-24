using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Event.Migrations
{
    /// <inheritdoc />
    public partial class AddAdvertOption : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b54d3a7-c197-48b9-b447-ba47fa98cf81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e3d97cf-e45a-4e1b-ac02-fa9d5e037497");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0001d86f-4202-4116-8ac6-1d216408c622");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<bool>(
                name: "IsOpenForAdvert",
                table: "Events",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsOpenForAdvert",
                table: "Events");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4b54d3a7-c197-48b9-b447-ba47fa98cf81", null, "Admin", "ADMIN" },
                    { "9e3d97cf-e45a-4e1b-ac02-fa9d5e037497", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Town", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0001d86f-4202-4116-8ac6-1d216408c622", 0, "8c43584e-2783-4f86-8a08-2f90b66b463e", "zack@gmail.com", false, null, false, null, "ZACK@GMAIL.COM", "PAN", "AQAAAAIAAYagAAAAEHz18fQWx0vMQ9zOiEHAPvK6nIGAiixErzcvn5/VB8EWHLKH2Ud7ogi8vgH5SalCtw==", null, false, "9cba8e7f-b424-4e56-b25e-b87a9604feca", null, false, "Zack" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Category", "Date", "Description", "ImageUrl", "IsTicketed", "LikesCount", "Location", "OrganizerId", "SecondaryImageUrls" },
                values: new object[,]
                {
                    { 1, "Online", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AI, the major break through", "assets/ai.jpg", false, 0, "Google Meet", null, "[\"assets/ai.jpg\",\"assets/ai2.jpg\"]" },
                    { 2, "Online", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Graphic design webinar", "assets/girl.jpeg", false, 0, "Whatsapp", null, "[\"assets/ai.jpg\",\"assets/ai2.jpg\"]" }
                });
        }
    }
}
