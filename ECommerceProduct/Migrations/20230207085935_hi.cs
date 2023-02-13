using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceProduct.Migrations
{
    public partial class hi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProductCount = table.Column<int>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    Visibility = table.Column<Guid>(nullable: false),
                    ImageAsset = table.Column<Guid>(nullable: false),
                    Category = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    Key = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefTerms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    Key = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefTerms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SetRefTerms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateUpdated = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<Guid>(nullable: false),
                    UpdateBy = table.Column<Guid>(nullable: false),
                    RefSetid = table.Column<Guid>(nullable: false),
                    ReftermId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetRefTerms", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreateBy", "DateCreated", "DateUpdated", "ImageAsset", "Name", "Price", "ProductCount", "UpdateBy", "Visibility" },
                values: new object[,]
                {
                    { new Guid("2b6aa7d6-1974-430f-a760-3ced549d0471"), new Guid("78366a93-ff88-47c6-982e-e5fd1491f5eb"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 7, 14, 29, 34, 785, DateTimeKind.Local).AddTicks(1428), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Apple IPhone Xs Max", 100000f, 50, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("24d066c6-92f8-4457-9475-435090170ff1"), new Guid("78366a93-ff88-47c6-982e-e5fd1491f5eb"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7207), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Apple IPhone 14", 150000f, 500, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("37eee076-d740-430c-a3e6-4b56a5d0f5c4"), new Guid("1fa74cce-2a56-44f4-b4b7-853babb4bfb0"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7337), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Fan", 5000f, 500, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("552d5bb7-3af3-4f82-b44b-f32468d46c9d"), new Guid("1fa74cce-2a56-44f4-b4b7-853babb4bfb0"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7362), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Light", 800f, 500, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0215de4b-e4ae-46fd-b530-92678aaa3487"), new Guid("61ba2ce4-3d28-46d4-b190-ff01c1d00ce2"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7383), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Ghee Bottle", 250f, 250, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0fcfc4c9-d283-4d4a-8b88-fe8a5d53b529"), new Guid("61ba2ce4-3d28-46d4-b190-ff01c1d00ce2"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7405), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Honey Bottle", 300f, 250, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e0df594f-1a9b-4fa8-9ac0-6b24db187318"), new Guid("f5b90d42-9c02-465e-b29e-3ac8339c2fc2"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7424), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Sony Alpha", 250000f, 50, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("99532ba0-b7e3-4a8a-ad91-7524b95c6d98"), new Guid("f5b90d42-9c02-465e-b29e-3ac8339c2fc2"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7443), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Canon 5000D", 75000f, 50, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "RefSets",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "Description", "Key", "UpdateBy" },
                values: new object[] { new Guid("24085e18-602d-4d27-8e97-2263202c6064"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(745), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Types of Products", "PRODUCT_TYPE", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "RefTerms",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "Description", "Key", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("78366a93-ff88-47c6-982e-e5fd1491f5eb"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(3365), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Contains tech gadgets
                ", "TECH", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1fa74cce-2a56-44f4-b4b7-853babb4bfb0"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(3648), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Contains home acessories
                ", "HOME", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("61ba2ce4-3d28-46d4-b190-ff01c1d00ce2"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(3695), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Contains types of foods
                ", "FOOD", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f5b90d42-9c02-465e-b29e-3ac8339c2fc2"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(3728), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Contains all types of Camera
                ", "CAMERA", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "SetRefTerms",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "RefSetid", "ReftermId", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("399d3958-35a7-43ac-ad4d-32f49ab96fb1"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(5726), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("24085e18-602d-4d27-8e97-2263202c6064"), new Guid("78366a93-ff88-47c6-982e-e5fd1491f5eb"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("117e4539-493c-43ff-88f7-524777fe9fe4"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(5985), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("24085e18-602d-4d27-8e97-2263202c6064"), new Guid("1fa74cce-2a56-44f4-b4b7-853babb4bfb0"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("44ec4508-1d9e-4f9f-b110-d863cfdd7a1c"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(6023), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("24085e18-602d-4d27-8e97-2263202c6064"), new Guid("61ba2ce4-3d28-46d4-b190-ff01c1d00ce2"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("456657b0-7444-47e1-ad58-2e670a78231d"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(6048), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("24085e18-602d-4d27-8e97-2263202c6064"), new Guid("f5b90d42-9c02-465e-b29e-3ac8339c2fc2"), new Guid("00000000-0000-0000-0000-000000000000") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "RefSets");

            migrationBuilder.DropTable(
                name: "RefTerms");

            migrationBuilder.DropTable(
                name: "SetRefTerms");
        }
    }
}
