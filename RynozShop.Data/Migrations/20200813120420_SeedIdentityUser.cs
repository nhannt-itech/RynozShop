using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RynozShop.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("999edbaf-d1b4-4731-bc78-e1dfe968aadd"), "93e2942a-8606-4f0c-8b12-038dccb9fc7a", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRole",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("61171d84-c0f4-4998-94e4-2315d1ef146f"), new Guid("999edbaf-d1b4-4731-bc78-e1dfe968aadd") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("61171d84-c0f4-4998-94e4-2315d1ef146f"), 0, "4b2eb973-a09d-4872-9659-8b0bb5b3a16e", new DateTime(2000, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "rynoz2k@gmail.com", true, "Nhan", "Nguyen", false, null, "rynoz2k@gmail.com", "admin", "AQAAAAEAACcQAAAAEHCd1jalPTDBJHV/nPrrMlNcbXOEGMKfXf9FIu+0QyilrEkqk953h/HwNL735sr0WQ==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 8, 13, 19, 4, 20, 35, DateTimeKind.Local).AddTicks(9973));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("999edbaf-d1b4-4731-bc78-e1dfe968aadd"));

            migrationBuilder.DeleteData(
                table: "AppUserRole",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("61171d84-c0f4-4998-94e4-2315d1ef146f"), new Guid("999edbaf-d1b4-4731-bc78-e1dfe968aadd") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("61171d84-c0f4-4998-94e4-2315d1ef146f"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 8, 13, 18, 45, 0, 155, DateTimeKind.Local).AddTicks(526));
        }
    }
}
