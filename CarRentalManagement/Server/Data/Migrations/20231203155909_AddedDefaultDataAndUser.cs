using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d8393368-6001-42e1-80ee-19c9aa594ced", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEH+/5J5aet/szQ0mUuQJ8+ntkzIiYbDx8IfXokVExJqv0/IkvU6oZtSssjYKFjNdQA==", null, false, "8ec992d2-1cb4-4a26-b015-a58df022ca4e", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8182), new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8197), "Black", "System" },
                    { 2, "System", new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8200), new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8200), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8494), new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8495), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8497), new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8497), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8653), new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8653), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8655), new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8655), "X5", "System" },
                    { 3, "System", new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8656), new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8657), "3 Series", "System" },
                    { 4, "System", new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8658), new DateTime(2023, 12, 3, 23, 59, 8, 843, DateTimeKind.Local).AddTicks(8658), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
