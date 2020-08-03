using Microsoft.EntityFrameworkCore.Migrations;

namespace ShipMobile.Data.Migrations
{
    public partial class updateTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_AspNetUsers_CreatedById",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_Contact_MobileId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_AspNetUsers_UpdatedById",
                table: "Address");

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
                name: "FK_Customer_AspNetUsers_CreatedById",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Contact_EmailId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Contact_MobileId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_AspNetUsers_UpdatedById",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_Address_AddressId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_Customer_CustomerId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_ShippingAddress_AddressId",
                table: "Package");

            migrationBuilder.DropForeignKey(
                name: "FK_Package_Customer_CustomerId",
                table: "Package");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_AspNetUsers_AgentId",
                table: "Shipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_AspNetUsers_CreatedById",
                table: "Shipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipment_AspNetUsers_UpdatedById",
                table: "Shipment");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipmentPackage_Package_PackageId",
                table: "ShipmentPackage");

            migrationBuilder.DropForeignKey(
                name: "FK_ShipmentPackage_Shipment_ShipmentId",
                table: "ShipmentPackage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingAddress",
                table: "ShippingAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShipmentPackage",
                table: "ShipmentPackage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shipment",
                table: "Shipment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Package",
                table: "Package");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerAddress",
                table: "CustomerAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

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
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "ShippingAddress",
                newName: "ShipMobile.Data.Models.ShippingAddresses");

            migrationBuilder.RenameTable(
                name: "ShipmentPackage",
                newName: "ShipMobile.Data.Models.ShipmentPackages");

            migrationBuilder.RenameTable(
                name: "Shipment",
                newName: "ShipMobile.Data.Models.Shipments");

            migrationBuilder.RenameTable(
                name: "Package",
                newName: "ShipMobile.Data.Models.Packages");

            migrationBuilder.RenameTable(
                name: "CustomerAddress",
                newName: "ShipMobile.Data.Models.CustomerAddresses");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "ShipMobile.Data.Models.Customers");

            migrationBuilder.RenameTable(
                name: "Contact",
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
                name: "Address",
                newName: "ShipMobile.Data.Models.Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_ShipmentPackage_PackageId",
                table: "ShipMobile.Data.Models.ShipmentPackages",
                newName: "IX_ShipMobile.Data.Models.ShipmentPackages_PackageId");

            migrationBuilder.RenameIndex(
                name: "IX_Shipment_UpdatedById",
                table: "ShipMobile.Data.Models.Shipments",
                newName: "IX_ShipMobile.Data.Models.Shipments_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Shipment_CreatedById",
                table: "ShipMobile.Data.Models.Shipments",
                newName: "IX_ShipMobile.Data.Models.Shipments_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Shipment_AgentId",
                table: "ShipMobile.Data.Models.Shipments",
                newName: "IX_ShipMobile.Data.Models.Shipments_AgentId");

            migrationBuilder.RenameIndex(
                name: "IX_Package_Token",
                table: "ShipMobile.Data.Models.Packages",
                newName: "IX_ShipMobile.Data.Models.Packages_Token");

            migrationBuilder.RenameIndex(
                name: "IX_Package_CustomerId",
                table: "ShipMobile.Data.Models.Packages",
                newName: "IX_ShipMobile.Data.Models.Packages_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Package_AddressId",
                table: "ShipMobile.Data.Models.Packages",
                newName: "IX_ShipMobile.Data.Models.Packages_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerAddress_AddressId",
                table: "ShipMobile.Data.Models.CustomerAddresses",
                newName: "IX_ShipMobile.Data.Models.CustomerAddresses_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_UpdatedById",
                table: "ShipMobile.Data.Models.Customers",
                newName: "IX_ShipMobile.Data.Models.Customers_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_MobileId",
                table: "ShipMobile.Data.Models.Customers",
                newName: "IX_ShipMobile.Data.Models.Customers_MobileId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_EmailId",
                table: "ShipMobile.Data.Models.Customers",
                newName: "IX_ShipMobile.Data.Models.Customers_EmailId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_CreatedById",
                table: "ShipMobile.Data.Models.Customers",
                newName: "IX_ShipMobile.Data.Models.Customers_CreatedById");

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
                name: "IX_Address_UpdatedById",
                table: "ShipMobile.Data.Models.Addresses",
                newName: "IX_ShipMobile.Data.Models.Addresses_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Address_MobileId",
                table: "ShipMobile.Data.Models.Addresses",
                newName: "IX_ShipMobile.Data.Models.Addresses_MobileId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CreatedById",
                table: "ShipMobile.Data.Models.Addresses",
                newName: "IX_ShipMobile.Data.Models.Addresses_CreatedById");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.ShippingAddresses",
                table: "ShipMobile.Data.Models.ShippingAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.ShipmentPackages",
                table: "ShipMobile.Data.Models.ShipmentPackages",
                columns: new[] { "ShipmentId", "PackageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.Shipments",
                table: "ShipMobile.Data.Models.Shipments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.Packages",
                table: "ShipMobile.Data.Models.Packages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.CustomerAddresses",
                table: "ShipMobile.Data.Models.CustomerAddresses",
                columns: new[] { "CustomerId", "AddressId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipMobile.Data.Models.Customers",
                table: "ShipMobile.Data.Models.Customers",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "ShippingAddress");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.Shipments",
                newName: "Shipment");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.ShipmentPackages",
                newName: "ShipmentPackage");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.Packages",
                newName: "Package");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.Customers",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.CustomerAddresses",
                newName: "CustomerAddress");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.Contacts",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.ApplicationUsers",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.ApplicationRoles",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "ShipMobile.Data.Models.Addresses",
                newName: "Address");

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
                table: "Shipment",
                newName: "IX_Shipment_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Shipments_CreatedById",
                table: "Shipment",
                newName: "IX_Shipment_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Shipments_AgentId",
                table: "Shipment",
                newName: "IX_Shipment_AgentId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.ShipmentPackages_PackageId",
                table: "ShipmentPackage",
                newName: "IX_ShipmentPackage_PackageId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Packages_Token",
                table: "Package",
                newName: "IX_Package_Token");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Packages_CustomerId",
                table: "Package",
                newName: "IX_Package_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Packages_AddressId",
                table: "Package",
                newName: "IX_Package_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Customers_UpdatedById",
                table: "Customer",
                newName: "IX_Customer_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Customers_MobileId",
                table: "Customer",
                newName: "IX_Customer_MobileId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Customers_EmailId",
                table: "Customer",
                newName: "IX_Customer_EmailId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Customers_CreatedById",
                table: "Customer",
                newName: "IX_Customer_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.CustomerAddresses_AddressId",
                table: "CustomerAddress",
                newName: "IX_CustomerAddress_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Addresses_UpdatedById",
                table: "Address",
                newName: "IX_Address_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Addresses_MobileId",
                table: "Address",
                newName: "IX_Address_MobileId");

            migrationBuilder.RenameIndex(
                name: "IX_ShipMobile.Data.Models.Addresses_CreatedById",
                table: "Address",
                newName: "IX_Address_CreatedById");

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
                name: "PK_ShippingAddress",
                table: "ShippingAddress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shipment",
                table: "Shipment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShipmentPackage",
                table: "ShipmentPackage",
                columns: new[] { "ShipmentId", "PackageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Package",
                table: "Package",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerAddress",
                table: "CustomerAddress",
                columns: new[] { "CustomerId", "AddressId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
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
                name: "PK_Address",
                table: "Address",
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
                value: "057e773b-f5ad-4881-93be-372e0d4885c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ConcurrencyStamp",
                value: "57140f89-1ac3-4eb1-b283-decb8da80ebb");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_AspNetUsers_CreatedById",
                table: "Address",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Contact_MobileId",
                table: "Address",
                column: "MobileId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_AspNetUsers_UpdatedById",
                table: "Address",
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
                name: "FK_Customer_AspNetUsers_CreatedById",
                table: "Customer",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Contact_EmailId",
                table: "Customer",
                column: "EmailId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Contact_MobileId",
                table: "Customer",
                column: "MobileId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_AspNetUsers_UpdatedById",
                table: "Customer",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_Address_AddressId",
                table: "CustomerAddress",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_Customer_CustomerId",
                table: "CustomerAddress",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_ShippingAddress_AddressId",
                table: "Package",
                column: "AddressId",
                principalTable: "ShippingAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Package_Customer_CustomerId",
                table: "Package",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_AspNetUsers_AgentId",
                table: "Shipment",
                column: "AgentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_AspNetUsers_CreatedById",
                table: "Shipment",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipment_AspNetUsers_UpdatedById",
                table: "Shipment",
                column: "UpdatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipmentPackage_Package_PackageId",
                table: "ShipmentPackage",
                column: "PackageId",
                principalTable: "Package",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShipmentPackage_Shipment_ShipmentId",
                table: "ShipmentPackage",
                column: "ShipmentId",
                principalTable: "Shipment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
