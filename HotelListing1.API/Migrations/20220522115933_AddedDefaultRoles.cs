using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing1.API.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "67c4e9a6-289e-4a74-97a9-1acb39f7861a", "e074ed06-8701-4fe0-84af-501dc692aca3", "User", "USER" },
                    { "c71d7eb6-6118-4619-8ccc-8a4b0c4fd684", "3b9d2e53-3ad6-40b8-b6f3-cb31ebf1198e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "ShortName" },
                values: new object[] { "Cayman Island", "CI" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "Negril");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67c4e9a6-289e-4a74-97a9-1acb39f7861a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c71d7eb6-6118-4619-8ccc-8a4b0c4fd684");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "ShortName" },
                values: new object[] { "Cayman", "CY" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "Nagril");
        }
    }
}
