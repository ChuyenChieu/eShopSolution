using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 17, 14, 55, 24, 17, DateTimeKind.Local).AddTicks(483),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 4, 17, 12, 58, 40, 71, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("cba465bb-5ba7-450b-84c2-07a977daeee7"), "8f304792-d1e3-4b9a-9517-f5e346345e2a", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("a521908b-f9f7-481d-ac41-7ebd8e5cadc9"), new Guid("cba465bb-5ba7-450b-84c2-07a977daeee7") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a521908b-f9f7-481d-ac41-7ebd8e5cadc9"), 0, "057423c0-a277-44b2-8222-2d87873d3caa", new DateTime(2020, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenchuyen091292@gmail.com", true, "Chieu", "Chuyen", false, null, "nguyenchuyen091292@gmail.com", "admin", "AQAAAAEAACcQAAAAEFZF/JKAeA6mmOfqhuWUZLT7J56w478oyExWdW6tgT/Uun1oB5Ax/uTCFjy8ANGxzA==", null, false, "", false, "admin" });

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
                value: new DateTime(2020, 4, 17, 14, 55, 24, 59, DateTimeKind.Local).AddTicks(770));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cba465bb-5ba7-450b-84c2-07a977daeee7"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a521908b-f9f7-481d-ac41-7ebd8e5cadc9"), new Guid("cba465bb-5ba7-450b-84c2-07a977daeee7") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a521908b-f9f7-481d-ac41-7ebd8e5cadc9"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 17, 12, 58, 40, 71, DateTimeKind.Local).AddTicks(3941),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 4, 17, 14, 55, 24, 17, DateTimeKind.Local).AddTicks(483));

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
                value: new DateTime(2020, 4, 17, 12, 58, 40, 98, DateTimeKind.Local).AddTicks(5449));
        }
    }
}
