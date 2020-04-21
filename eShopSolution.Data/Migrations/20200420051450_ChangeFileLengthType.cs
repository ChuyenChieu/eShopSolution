using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cba465bb-5ba7-450b-84c2-07a977daeee7"),
                column: "ConcurrencyStamp",
                value: "4f4c17e6-f9fc-42e7-b637-f52b1d72d108");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a521908b-f9f7-481d-ac41-7ebd8e5cadc9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "302f25f2-df46-44bb-9a9a-f795f4061674", "AQAAAAEAACcQAAAAEMGTzh49LupDqjkEdo8lLmxXUgpu1MayA6Z6xZgfZxwVsrnbPr8OdfJndvVqzxYF9w==" });

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
                value: new DateTime(2020, 4, 20, 12, 14, 49, 570, DateTimeKind.Local).AddTicks(4129));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cba465bb-5ba7-450b-84c2-07a977daeee7"),
                column: "ConcurrencyStamp",
                value: "d33fbe74-e841-4975-b5c3-372e5f0b6b70");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a521908b-f9f7-481d-ac41-7ebd8e5cadc9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ccf6f2e-1fb5-4ed6-a0af-474c5104e949", "AQAAAAEAACcQAAAAEJUeNLsKM78vS9aGT2Rtox56+N4q+3kh8QXj8WpjeplzJbrFBY9vZ9kx5WImtSg7uw==" });

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
                value: new DateTime(2020, 4, 18, 0, 53, 35, 706, DateTimeKind.Local).AddTicks(4407));
        }
    }
}
