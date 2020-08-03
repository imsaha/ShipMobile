using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShipMobile.Data.Migrations
{
    public partial class removeShipmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShipmentPackages");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.AddColumn<long>(
                name: "AgentId",
                table: "Packages",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Delivered",
                table: "Packages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FailedNote",
                table: "Packages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuccessNote",
                table: "Packages",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "e474656f-1fe6-4ed0-ab3f-f44f5cbc8210");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "bd2c28ff-d71c-41bb-8c94-c95761848e84");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_AgentId",
                table: "Packages",
                column: "AgentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_AspNetUsers_AgentId",
                table: "Packages",
                column: "AgentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_AspNetUsers_AgentId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_AgentId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "AgentId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Delivered",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "FailedNote",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "SuccessNote",
                table: "Packages");

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedById = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UpdatedById = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shipments_AspNetUsers_AgentId",
                        column: x => x.AgentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shipments_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Shipments_AspNetUsers_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShipmentPackages",
                columns: table => new
                {
                    ShipmentId = table.Column<long>(type: "bigint", nullable: false),
                    PackageId = table.Column<long>(type: "bigint", nullable: false),
                    Delivered = table.Column<bool>(type: "bit", nullable: false),
                    FailedNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuccessNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipmentPackages", x => new { x.ShipmentId, x.PackageId });
                    table.ForeignKey(
                        name: "FK_ShipmentPackages_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ShipmentPackages_Shipments_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ShipmentPackages_PackageId",
                table: "ShipmentPackages",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_AgentId",
                table: "Shipments",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_CreatedById",
                table: "Shipments",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_UpdatedById",
                table: "Shipments",
                column: "UpdatedById");
        }
    }
}
