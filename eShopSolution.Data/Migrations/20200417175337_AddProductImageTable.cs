using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 4, 17, 14, 55, 24, 17, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 4, 17, 14, 55, 24, 17, DateTimeKind.Local).AddTicks(483),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("cba465bb-5ba7-450b-84c2-07a977daeee7"),
                column: "ConcurrencyStamp",
                value: "8f304792-d1e3-4b9a-9517-f5e346345e2a");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a521908b-f9f7-481d-ac41-7ebd8e5cadc9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "057423c0-a277-44b2-8222-2d87873d3caa", "AQAAAAEAACcQAAAAEFZF/JKAeA6mmOfqhuWUZLT7J56w478oyExWdW6tgT/Uun1oB5Ax/uTCFjy8ANGxzA==" });

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
    }
}
