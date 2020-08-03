using Microsoft.EntityFrameworkCore.Migrations;

namespace ShipMobile.Data.Migrations
{
    public partial class updateTableName2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>s_ShipMobile.Data.Models.ApplicationRoles_RoleId",
                table: "Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>s");

            migrationBuilder.DropForeignKey(
                name: "FK_Microsoft.AspNetCore.Identity.IdentityUserClaim<long>s_ShipMobile.Data.Models.ApplicationUsers_UserId",
                table: "Microsoft.AspNetCore.Identity.IdentityUserClaim<long>s");

            migrationBuilder.DropForeignKey(
                name: "FK_Microsoft.AspNetCore.Identity.IdentityUserLogin<long>s_ShipMobile.Data.Models.ApplicationUsers_UserId",
                table: "Microsoft.AspNetCore.Identity.IdentityUserLogin<long>s");

            migrationBuilder.DropForeignKey(
                name: "FK_Microsoft.AspNetCore.Identity.IdentityUserRole<long>s_ShipMobile.Data.Models.ApplicationRoles_RoleId",
                table: "Microsoft.AspNetCore.Identity.IdentityUserRole<long>s");

            migrationBuilder.DropForeignKey(
                name: "FK_Microsoft.AspNetCore.Identity.IdentityUserRole<long>s_ShipMobile.Data.Models.ApplicationUsers_UserId",
                table: "Microsoft.AspNetCore.Identity.IdentityUserRole<long>s");

            migrationBuilder.DropForeignKey(
                name: "FK_Microsoft.AspNetCore.Identity.IdentityUserToken<long>s_ShipMobile.Data.Models.ApplicationUsers_UserId",
                table: "Microsoft.AspNetCore.Identity.IdentityUserToken<long>s");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.Addresses_ShipMobile.Data.Models.ApplicationUsers_CreatedById",
                table: "ShipMobile.Data.Models.Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.Addresses_ShipMobile.Data.Models.Contacts_MobileId",
                table: "ShipMobile.Data.Models.Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.Addresses_ShipMobile.Data.Models.ApplicationUsers_UpdatedById",
                table: "ShipMobile.Data.Models.Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.CustomerAddresses_ShipMobile.Data.Models.Addresses_AddressId",
                table: "ShipMobile.Data.Models.CustomerAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.CustomerAddresses_ShipMobile.Data.Models.Customers_CustomerId",
                table: "ShipMobile.Data.Models.CustomerAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.Customers_ShipMobile.Data.Models.ApplicationUsers_CreatedById",
                table: "ShipMobile.Data.Models.Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.Customers_ShipMobile.Data.Models.Contacts_EmailId",
                table: "ShipMobile.Data.Models.Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.Customers_ShipMobile.Data.Models.Contacts_MobileId",
                table: "ShipMobile.Data.Models.Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.Customers_ShipMobile.Data.Models.ApplicationUsers_UpdatedById",
                table: "ShipMobile.Data.Models.Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.Packages_ShipMobile.Data.Models.ShippingAddresses_AddressId",
                table: "ShipMobile.Data.Models.Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.Packages_ShipMobile.Data.Models.Customers_CustomerId",
                table: "ShipMobile.Data.Models.Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.ShipmentPackages_ShipMobile.Data.Models.Packages_PackageId",
                table: "ShipMobile.Data.Models.ShipmentPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.ShipmentPackages_ShipMobile.Data.Models.Shipments_ShipmentId",
                table: "ShipMobile.Data.Models.ShipmentPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.Shipments_ShipMobile.Data.Models.ApplicationUsers_AgentId",
                table: "ShipMobile.Data.Models.Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.Shipments_ShipMobile.Data.Models.ApplicationUsers_CreatedById",
                table: "ShipMobile.Data.Models.Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipMobile.Data.Models.Shipments_ShipMobile.Data.Models.ApplicationUsers_UpdatedById",
                table: "ShipMobile.Data.Models.Shipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipMobile.Data.Models.ShippingAddresses",
                table: "ShipMobile.Data.Models.ShippingAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipMobile.Data.Models.Shipments",
                table: "ShipMobile.Data.Models.Shipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipMobile.Data.Models.ShipmentPackages",
                table: "ShipMobile.Data.Models.ShipmentPackages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipMobile.Data.Models.Packages",
                table: "ShipMobile.Data.Models.Packages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipMobile.Data.Models.Customers",
                table: "ShipMobile.Data.Models.Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipMobile.Data.Models.CustomerAddresses",
                table: "ShipMobile.Data.Models.CustomerAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipMobile.Data.Models.Contacts",
                table: "ShipMobile.Data.Models.Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipMobile.Data.Models.ApplicationUsers",
                table: "ShipMobile.Data.Models.ApplicationUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipMobile.Data.Models.ApplicationRoles",
                table: "ShipMobile.Data.Models.ApplicationRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipMobile.Data.Models.Addresses",
                table: "ShipMobile.Data.Models.Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Microsoft.AspNetCore.Identity.IdentityUserToken<long>s",
                table: "Microsoft.AspNetCore.Identity.IdentityUserToken<long>s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Microsoft.AspNetCore.Identity.IdentityUserRole<long>s",
                table: "Microsoft.AspNetCore.Identity.IdentityUserRole<long>s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Microsoft.AspNetCore.Identity.IdentityUserLogin<long>s",
                table: "Microsoft.AspNetCore.Identity.IdentityUserLogin<long>s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Microsoft.AspNetCore.Identity.IdentityUserClaim<long>s",
                table: "Microsoft.AspNetCore.Identity.IdentityUserClaim<long>s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>s",
                table: "Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>s");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.ShippingAddresses",
                newName: "ShippingAddresses");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.Shipments",
                newName: "Shipments");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.ShipmentPackages",
                newName: "ShipmentPackages");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.Packages",
                newName: "Packages");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.Customers",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.CustomerAddresses",
                newName: "CustomerAddresses");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.Contacts",
                newName: "Contacts");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.ApplicationUsers",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.ApplicationRoles",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.Addresses",
                newName: "Addresses");

            migrationBuilder.RenameTable(
                name: "Microsoft.AspNetCore.Identity.IdentityUserToken<long>s",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "Microsoft.AspNetCore.Identity.IdentityUserRole<long>s",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "Microsoft.AspNetCore.Identity.IdentityUserLogin<long>s",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "Microsoft.AspNetCore.Identity.IdentityUserClaim<long>s",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>s",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Shipments_UpdatedById",
                table: "Shipments",
                newName: "IX_Shipments_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Shipments_CreatedById",
                table: "Shipments",
                newName: "IX_Shipments_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Shipments_AgentId",
                table: "Shipments",
                newName: "IX_Shipments_AgentId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.ShipmentPackages_PackageId",
                table: "ShipmentPackages",
                newName: "IX_ShipmentPackages_PackageId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Packages_Token",
                table: "Packages",
                newName: "IX_Packages_Token");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Packages_CustomerId",
                table: "Packages",
                newName: "IX_Packages_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Packages_AddressId",
                table: "Packages",
                newName: "IX_Packages_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Customers_UpdatedById",
                table: "Customers",
                newName: "IX_Customers_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Customers_MobileId",
                table: "Customers",
                newName: "IX_Customers_MobileId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Customers_EmailId",
                table: "Customers",
                newName: "IX_Customers_EmailId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Customers_CreatedById",
                table: "Customers",
                newName: "IX_Customers_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.CustomerAddresses_AddressId",
                table: "CustomerAddresses",
                newName: "IX_CustomerAddresses_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Addresses_UpdatedById",
                table: "Addresses",
                newName: "IX_Addresses_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Addresses_MobileId",
                table: "Addresses",
                newName: "IX_Addresses_MobileId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Addresses_CreatedById",
                table: "Addresses",
                newName: "IX_Addresses_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Microsoft.AspNetCore.Identity.IdentityUserRole<long>s_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Microsoft.AspNetCore.Identity.IdentityUserLogin<long>s_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Microsoft.AspNetCore.Identity.IdentityUserClaim<long>s_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>s_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShippingAddresses",
                table: "ShippingAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shipments",
                table: "Shipments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipmentPackages",
                table: "ShipmentPackages",
                columns: new[] { "ShipmentId", "PackageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Packages",
                table: "Packages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerAddresses",
                table: "CustomerAddresses",
                columns: new[] { "CustomerId", "AddressId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "4f2ed848-d0ae-41d3-9e91-2e9c59427e57");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "7700a05e-541e-46db-8c1b-6c8ab9072d1f");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_CreatedById",
                table: "Addresses",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Contacts_MobileId",
                table: "Addresses",
                column: "MobileId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_AspNetUsers_UpdatedById",
                table: "Addresses",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddresses_Addresses_AddressId",
                table: "CustomerAddresses",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddresses_Customers_CustomerId",
                table: "CustomerAddresses",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_CreatedById",
                table: "Customers",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Contacts_EmailId",
                table: "Customers",
                column: "EmailId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Contacts_MobileId",
                table: "Customers",
                column: "MobileId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_UpdatedById",
                table: "Customers",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_ShippingAddresses_AddressId",
                table: "Packages",
                column: "AddressId",
                principalTable: "ShippingAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Customers_CustomerId",
                table: "Packages",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipmentPackages_Packages_PackageId",
                table: "ShipmentPackages",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipmentPackages_Shipments_ShipmentId",
                table: "ShipmentPackages",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_AspNetUsers_AgentId",
                table: "Shipments",
                column: "AgentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_AspNetUsers_CreatedById",
                table: "Shipments",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_AspNetUsers_UpdatedById",
                table: "Shipments",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_CreatedById",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Contacts_MobileId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_AspNetUsers_UpdatedById",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddresses_Addresses_AddressId",
                table: "CustomerAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddresses_Customers_CustomerId",
                table: "CustomerAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_CreatedById",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Contacts_EmailId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Contacts_MobileId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_UpdatedById",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_ShippingAddresses_AddressId",
                table: "Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Customers_CustomerId",
                table: "Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipmentPackages_Packages_PackageId",
                table: "ShipmentPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipmentPackages_Shipments_ShipmentId",
                table: "ShipmentPackages");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_AspNetUsers_AgentId",
                table: "Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_AspNetUsers_CreatedById",
                table: "Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_AspNetUsers_UpdatedById",
                table: "Shipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingAddresses",
                table: "ShippingAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shipments",
                table: "Shipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipmentPackages",
                table: "ShipmentPackages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Packages",
                table: "Packages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerAddresses",
                table: "CustomerAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "ShippingAddresses",
                newName: "ShipMobile.Data.Models.ShippingAddresses");

            migrationBuilder.RenameTable(
                name: "Shipments",
                newName: "ShipMobile.Data.Models.Shipments");

            migrationBuilder.RenameTable(
                name: "ShipmentPackages",
                newName: "ShipMobile.Data.Models.ShipmentPackages");

            migrationBuilder.RenameTable(
                name: "Packages",
                newName: "ShipMobile.Data.Models.Packages");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "ShipMobile.Data.Models.Customers");

            migrationBuilder.RenameTable(
                name: "CustomerAddresses",
                newName: "ShipMobile.Data.Models.CustomerAddresses");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "ShipMobile.Data.Models.Contacts");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "Microsoft.AspNetCore.Identity.IdentityUserToken<long>s");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "ShipMobile.Data.Models.ApplicationUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "Microsoft.AspNetCore.Identity.IdentityUserRole<long>s");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "Microsoft.AspNetCore.Identity.IdentityUserLogin<long>s");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "Microsoft.AspNetCore.Identity.IdentityUserClaim<long>s");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "ShipMobile.Data.Models.ApplicationRoles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>s");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "ShipMobile.Data.Models.Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_Shipments_UpdatedById",
                table: "ShipMobile.Data.Models.Shipments",
                newName: "IX_ShipMobile.Data.Models.Shipments_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Shipments_CreatedById",
                table: "ShipMobile.Data.Models.Shipments",
                newName: "IX_ShipMobile.Data.Models.Shipments_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Shipments_AgentId",
                table: "ShipMobile.Data.Models.Shipments",
                newName: "IX_ShipMobile.Data.Models.Shipments_AgentId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipmentPackages_PackageId",
                table: "ShipMobile.Data.Models.ShipmentPackages",
                newName: "IX_ShipMobile.Data.Models.ShipmentPackages_PackageId");

            migrationBuilder.RenameIndex(
                name: "IX_Packages_Token",
                table: "ShipMobile.Data.Models.Packages",
                newName: "IX_ShipMobile.Data.Models.Packages_Token");

            migrationBuilder.RenameIndex(
                name: "IX_Packages_CustomerId",
                table: "ShipMobile.Data.Models.Packages",
                newName: "IX_ShipMobile.Data.Models.Packages_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Packages_AddressId",
                table: "ShipMobile.Data.Models.Packages",
                newName: "IX_ShipMobile.Data.Models.Packages_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_UpdatedById",
                table: "ShipMobile.Data.Models.Customers",
                newName: "IX_ShipMobile.Data.Models.Customers_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_MobileId",
                table: "ShipMobile.Data.Models.Customers",
                newName: "IX_ShipMobile.Data.Models.Customers_MobileId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_EmailId",
                table: "ShipMobile.Data.Models.Customers",
                newName: "IX_ShipMobile.Data.Models.Customers_EmailId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_CreatedById",
                table: "ShipMobile.Data.Models.Customers",
                newName: "IX_ShipMobile.Data.Models.Customers_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAddresses_AddressId",
                table: "ShipMobile.Data.Models.CustomerAddresses",
                newName: "IX_ShipMobile.Data.Models.CustomerAddresses_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "Microsoft.AspNetCore.Identity.IdentityUserRole<long>s",
                newName: "IX_Microsoft.AspNetCore.Identity.IdentityUserRole<long>s_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "Microsoft.AspNetCore.Identity.IdentityUserLogin<long>s",
                newName: "IX_Microsoft.AspNetCore.Identity.IdentityUserLogin<long>s_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "Microsoft.AspNetCore.Identity.IdentityUserClaim<long>s",
                newName: "IX_Microsoft.AspNetCore.Identity.IdentityUserClaim<long>s_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>s",
                newName: "IX_Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>s_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_UpdatedById",
                table: "ShipMobile.Data.Models.Addresses",
                newName: "IX_ShipMobile.Data.Models.Addresses_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_MobileId",
                table: "ShipMobile.Data.Models.Addresses",
                newName: "IX_ShipMobile.Data.Models.Addresses_MobileId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CreatedById",
                table: "ShipMobile.Data.Models.Addresses",
                newName: "IX_ShipMobile.Data.Models.Addresses_CreatedById");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.ShippingAddresses",
                table: "ShipMobile.Data.Models.ShippingAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.Shipments",
                table: "ShipMobile.Data.Models.Shipments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.ShipmentPackages",
                table: "ShipMobile.Data.Models.ShipmentPackages",
                columns: new[] { "ShipmentId", "PackageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.Packages",
                table: "ShipMobile.Data.Models.Packages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.Customers",
                table: "ShipMobile.Data.Models.Customers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.CustomerAddresses",
                table: "ShipMobile.Data.Models.CustomerAddresses",
                columns: new[] { "CustomerId", "AddressId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.Contacts",
                table: "ShipMobile.Data.Models.Contacts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Microsoft.AspNetCore.Identity.IdentityUserToken<long>s",
                table: "Microsoft.AspNetCore.Identity.IdentityUserToken<long>s",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.ApplicationUsers",
                table: "ShipMobile.Data.Models.ApplicationUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Microsoft.AspNetCore.Identity.IdentityUserRole<long>s",
                table: "Microsoft.AspNetCore.Identity.IdentityUserRole<long>s",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Microsoft.AspNetCore.Identity.IdentityUserLogin<long>s",
                table: "Microsoft.AspNetCore.Identity.IdentityUserLogin<long>s",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Microsoft.AspNetCore.Identity.IdentityUserClaim<long>s",
                table: "Microsoft.AspNetCore.Identity.IdentityUserClaim<long>s",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.ApplicationRoles",
                table: "ShipMobile.Data.Models.ApplicationRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>s",
                table: "Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>s",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.Addresses",
                table: "ShipMobile.Data.Models.Addresses",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ShipMobile.Data.Models.ApplicationRoles",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ConcurrencyStamp",
                value: "9bdc2bcc-d3d1-4da5-8ff7-8f45e8a86144");

            migrationBuilder.UpdateData(
                table: "ShipMobile.Data.Models.ApplicationRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "6efa042f-e8ef-4a44-bbec-fb746baad1ce");

            migrationBuilder.AddForeignKey(
                name: "FK_Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>s_ShipMobile.Data.Models.ApplicationRoles_RoleId",
                table: "Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>s",
                column: "RoleId",
                principalTable: "ShipMobile.Data.Models.ApplicationRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Microsoft.AspNetCore.Identity.IdentityUserClaim<long>s_ShipMobile.Data.Models.ApplicationUsers_UserId",
                table: "Microsoft.AspNetCore.Identity.IdentityUserClaim<long>s",
                column: "UserId",
                principalTable: "ShipMobile.Data.Models.ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Microsoft.AspNetCore.Identity.IdentityUserLogin<long>s_ShipMobile.Data.Models.ApplicationUsers_UserId",
                table: "Microsoft.AspNetCore.Identity.IdentityUserLogin<long>s",
                column: "UserId",
                principalTable: "ShipMobile.Data.Models.ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Microsoft.AspNetCore.Identity.IdentityUserRole<long>s_ShipMobile.Data.Models.ApplicationRoles_RoleId",
                table: "Microsoft.AspNetCore.Identity.IdentityUserRole<long>s",
                column: "RoleId",
                principalTable: "ShipMobile.Data.Models.ApplicationRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Microsoft.AspNetCore.Identity.IdentityUserRole<long>s_ShipMobile.Data.Models.ApplicationUsers_UserId",
                table: "Microsoft.AspNetCore.Identity.IdentityUserRole<long>s",
                column: "UserId",
                principalTable: "ShipMobile.Data.Models.ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Microsoft.AspNetCore.Identity.IdentityUserToken<long>s_ShipMobile.Data.Models.ApplicationUsers_UserId",
                table: "Microsoft.AspNetCore.Identity.IdentityUserToken<long>s",
                column: "UserId",
                principalTable: "ShipMobile.Data.Models.ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.Addresses_ShipMobile.Data.Models.ApplicationUsers_CreatedById",
                table: "ShipMobile.Data.Models.Addresses",
                column: "CreatedById",
                principalTable: "ShipMobile.Data.Models.ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.Addresses_ShipMobile.Data.Models.Contacts_MobileId",
                table: "ShipMobile.Data.Models.Addresses",
                column: "MobileId",
                principalTable: "ShipMobile.Data.Models.Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.Addresses_ShipMobile.Data.Models.ApplicationUsers_UpdatedById",
                table: "ShipMobile.Data.Models.Addresses",
                column: "UpdatedById",
                principalTable: "ShipMobile.Data.Models.ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.CustomerAddresses_ShipMobile.Data.Models.Addresses_AddressId",
                table: "ShipMobile.Data.Models.CustomerAddresses",
                column: "AddressId",
                principalTable: "ShipMobile.Data.Models.Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.CustomerAddresses_ShipMobile.Data.Models.Customers_CustomerId",
                table: "ShipMobile.Data.Models.CustomerAddresses",
                column: "CustomerId",
                principalTable: "ShipMobile.Data.Models.Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.Customers_ShipMobile.Data.Models.ApplicationUsers_CreatedById",
                table: "ShipMobile.Data.Models.Customers",
                column: "CreatedById",
                principalTable: "ShipMobile.Data.Models.ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.Customers_ShipMobile.Data.Models.Contacts_EmailId",
                table: "ShipMobile.Data.Models.Customers",
                column: "EmailId",
                principalTable: "ShipMobile.Data.Models.Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.Customers_ShipMobile.Data.Models.Contacts_MobileId",
                table: "ShipMobile.Data.Models.Customers",
                column: "MobileId",
                principalTable: "ShipMobile.Data.Models.Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.Customers_ShipMobile.Data.Models.ApplicationUsers_UpdatedById",
                table: "ShipMobile.Data.Models.Customers",
                column: "UpdatedById",
                principalTable: "ShipMobile.Data.Models.ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.Packages_ShipMobile.Data.Models.ShippingAddresses_AddressId",
                table: "ShipMobile.Data.Models.Packages",
                column: "AddressId",
                principalTable: "ShipMobile.Data.Models.ShippingAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.Packages_ShipMobile.Data.Models.Customers_CustomerId",
                table: "ShipMobile.Data.Models.Packages",
                column: "CustomerId",
                principalTable: "ShipMobile.Data.Models.Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.ShipmentPackages_ShipMobile.Data.Models.Packages_PackageId",
                table: "ShipMobile.Data.Models.ShipmentPackages",
                column: "PackageId",
                principalTable: "ShipMobile.Data.Models.Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.ShipmentPackages_ShipMobile.Data.Models.Shipments_ShipmentId",
                table: "ShipMobile.Data.Models.ShipmentPackages",
                column: "ShipmentId",
                principalTable: "ShipMobile.Data.Models.Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.Shipments_ShipMobile.Data.Models.ApplicationUsers_AgentId",
                table: "ShipMobile.Data.Models.Shipments",
                column: "AgentId",
                principalTable: "ShipMobile.Data.Models.ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.Shipments_ShipMobile.Data.Models.ApplicationUsers_CreatedById",
                table: "ShipMobile.Data.Models.Shipments",
                column: "CreatedById",
                principalTable: "ShipMobile.Data.Models.ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipMobile.Data.Models.Shipments_ShipMobile.Data.Models.ApplicationUsers_UpdatedById",
                table: "ShipMobile.Data.Models.Shipments",
                column: "UpdatedById",
                principalTable: "ShipMobile.Data.Models.ApplicationUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
