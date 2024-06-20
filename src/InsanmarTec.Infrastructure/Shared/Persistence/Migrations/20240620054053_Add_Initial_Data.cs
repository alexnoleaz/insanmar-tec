using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsanmarTec.Infrastructure.Shared.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_Initial_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreationTime", "Description", "LastModificationTime", "Name" },
                values: new object[] { 1, new DateTime(2024, 6, 20, 0, 40, 52, 226, DateTimeKind.Local).AddTicks(2724), "Role con acceso al programa completo", null, "Administrador" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreationTime", "Email", "FirstName", "IsActive", "LastModificationTime", "LastName", "Password", "Username" },
                values: new object[] { 1, new DateTime(2024, 6, 20, 0, 40, 52, 226, DateTimeKind.Local).AddTicks(2911), "administrador@gmail.com", "Administrador", true, null, "Administrador", "$2a$11$QdDAzZ4F5/i2qUXOq4Vk4ej/0uwk4GABWFyisu7pIYBFKZ4GtUzua", "admin" });

            migrationBuilder.InsertData(
                table: "RoleUser",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoleUser",
                keyColumns: new[] { "RolesId", "UsersId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
