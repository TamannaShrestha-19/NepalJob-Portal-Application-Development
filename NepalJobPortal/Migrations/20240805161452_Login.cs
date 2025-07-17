using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NepalJobPortal.Migrations
{
    /// <inheritdoc />
    public partial class Login : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4147760-6e31-4208-99ce-8edfced6397d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4769cac5-adc0-4e71-8e60-0e83e6da4727", "576d68c5-997b-423d-a08c-2406c5743ed2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4769cac5-adc0-4e71-8e60-0e83e6da4727");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "576d68c5-997b-423d-a08c-2406c5743ed2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42f6a0e0-0de2-456d-a1f0-6bdd5c02a36e", "2", "Vendor", "VENDOR" },
                    { "f1f57832-e94d-4ef5-94b1-5630d412517c", "1", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d81e3da6-b137-42e9-a97c-1a65f41400a1", 0, "6f7aa647-7d4f-4adf-bb75-6cb0a85bd5c9", "tmnnshrsth@gmail.com", true, false, null, null, "TMNNSHRSTH@GMAIL.COM", null, "AQAAAAIAAYagAAAAEKje8UsFVKKzn9xa0YcHKk1o85SM7Fz23L2xi1qSwe6YANeXTnjoiEBamcKORx6BUw==", null, false, "90f78a53-35a0-4e4c-9ae3-d9a942b2707b", false, "Tamanna" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f1f57832-e94d-4ef5-94b1-5630d412517c", "d81e3da6-b137-42e9-a97c-1a65f41400a1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42f6a0e0-0de2-456d-a1f0-6bdd5c02a36e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f1f57832-e94d-4ef5-94b1-5630d412517c", "d81e3da6-b137-42e9-a97c-1a65f41400a1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1f57832-e94d-4ef5-94b1-5630d412517c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d81e3da6-b137-42e9-a97c-1a65f41400a1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4769cac5-adc0-4e71-8e60-0e83e6da4727", "1", "SuperAdmin", "SUPERADMIN" },
                    { "f4147760-6e31-4208-99ce-8edfced6397d", "2", "Vendor", "VENDOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "OrgId", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "576d68c5-997b-423d-a08c-2406c5743ed2", 0, "8e7400ec-553c-4813-b9e8-a584abe54d4f", "bipindhakal05@gmail.com", true, false, null, null, "BIPINDHAKAL05@GMAIL.COM", null, "AQAAAAIAAYagAAAAEKIlC3/0NdrAiXNfs9RokaBU/jdP/GjqRKam/u3WyLNTvXZ20f77kBdxZuyhnzz4rw==", null, false, "09c4be4c-7c72-45d2-8c36-76c2bb7d4ee0", false, "bipindhakal05@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4769cac5-adc0-4e71-8e60-0e83e6da4727", "576d68c5-997b-423d-a08c-2406c5743ed2" });
        }
    }
}
