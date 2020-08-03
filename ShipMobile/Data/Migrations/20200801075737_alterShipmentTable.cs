using Microsoft.EntityFrameworkCore.Migrations;

namespace ShipMobile.Data.Migrations
{
    public partial class alterShipmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Delivered",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "FailedNote",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "SuccessNote",
                table: "Shipments");

            migrationBuilder.AddColumn<bool>(
                name: "Delivered",
                table: "ShipmentPackages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FailedNote",
                table: "ShipmentPackages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuccessNote",
                table: "ShipmentPackages",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "c3eda1c3-a445-4eb1-bb10-261fb4d06770");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "33ea8de9-48de-4b2d-ae98-f46b5d6956be");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Delivered",
                table: "ShipmentPackages");

            migrationBuilder.DropColumn(
                name: "FailedNote",
                table: "ShipmentPackages");

            migrationBuilder.DropColumn(
                name: "SuccessNote",
                table: "ShipmentPackages");

            migrationBuilder.AddColumn<bool>(
                name: "Delivered",
                table: "Shipments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FailedNote",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuccessNote",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "8321455e-c72f-4580-8793-cfc32c667bd3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "1be7c9d3-8523-4ab8-aec7-21a925199b9f");
        }
    }
}
