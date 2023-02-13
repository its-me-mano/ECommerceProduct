using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceProduct.Migrations
{
    public partial class updateproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0215de4b-e4ae-46fd-b530-92678aaa3487"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6183), new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fcfc4c9-d283-4d4a-8b88-fe8a5d53b529"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6228), new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24d066c6-92f8-4457-9475-435090170ff1"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6000), new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b6aa7d6-1974-430f-a760-3ced549d0471"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 42, 11, 86, DateTimeKind.Local).AddTicks(3874), new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37eee076-d740-430c-a3e6-4b56a5d0f5c4"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6103), new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("552d5bb7-3af3-4f82-b44b-f32468d46c9d"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6145), new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99532ba0-b7e3-4a8a-ad91-7524b95c6d98"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6299), new Guid("e55b3bf9-9e45-4e3a-8484-0a25e18c4734") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0df594f-1a9b-4fa8-9ac0-6b24db187318"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6264), new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae") });

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("24085e18-602d-4d27-8e97-2263202c6064"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.InsertData(
                table: "RefSets",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "Description", "Key", "UpdateBy" },
                values: new object[] { new Guid("1a78c6af-aa76-4e14-b9bc-ad41eb31b2b2"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(735), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Visibility to users", "PRODUCT_VISIBILITY", new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("1fa74cce-2a56-44f4-b4b7-853babb4bfb0"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("61ba2ce4-3d28-46d4-b190-ff01c1d00ce2"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("78366a93-ff88-47c6-982e-e5fd1491f5eb"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("f5b90d42-9c02-465e-b29e-3ac8339c2fc2"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.InsertData(
                table: "RefTerms",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "Description", "Key", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("e55b3bf9-9e45-4e3a-8484-0a25e18c4734"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(4072), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Not visible to the users
                ", "INVINCIBLE", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(4035), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), @"Visible to the users
                ", "VISIBLIE", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("117e4539-493c-43ff-88f7-524777fe9fe4"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("399d3958-35a7-43ac-ad4d-32f49ab96fb1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("44ec4508-1d9e-4f9f-b110-d863cfdd7a1c"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("456657b0-7444-47e1-ad58-2e670a78231d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.InsertData(
                table: "SetRefTerms",
                columns: new[] { "Id", "CreateBy", "DateCreated", "DateUpdated", "RefSetid", "ReftermId", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("eb9c0adf-6faf-47eb-b997-82e052875e90"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(7369), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1a78c6af-aa76-4e14-b9bc-ad41eb31b2b2"), new Guid("e55b3bf9-9e45-4e3a-8484-0a25e18c4734"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("426de7a2-bbc3-436c-b97e-598572bf6a40"), new Guid("68417748-6864-4866-8d9b-b82ae29da396"), new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(7343), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1a78c6af-aa76-4e14-b9bc-ad41eb31b2b2"), new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae"), new Guid("00000000-0000-0000-0000-000000000000") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("1a78c6af-aa76-4e14-b9bc-ad41eb31b2b2"));

            migrationBuilder.DeleteData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae"));

            migrationBuilder.DeleteData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("e55b3bf9-9e45-4e3a-8484-0a25e18c4734"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("426de7a2-bbc3-436c-b97e-598572bf6a40"));

            migrationBuilder.DeleteData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("eb9c0adf-6faf-47eb-b997-82e052875e90"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0215de4b-e4ae-46fd-b530-92678aaa3487"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3333), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fcfc4c9-d283-4d4a-8b88-fe8a5d53b529"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3359), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24d066c6-92f8-4457-9475-435090170ff1"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3152), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b6aa7d6-1974-430f-a760-3ced549d0471"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 14, 30, 43, 781, DateTimeKind.Local).AddTicks(7249), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37eee076-d740-430c-a3e6-4b56a5d0f5c4"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3285), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("552d5bb7-3af3-4f82-b44b-f32468d46c9d"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3311), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99532ba0-b7e3-4a8a-ad91-7524b95c6d98"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3450), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0df594f-1a9b-4fa8-9ac0-6b24db187318"),
                columns: new[] { "DateCreated", "Visibility" },
                values: new object[] { new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3380), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("24085e18-602d-4d27-8e97-2263202c6064"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("1fa74cce-2a56-44f4-b4b7-853babb4bfb0"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 784, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("61ba2ce4-3d28-46d4-b190-ff01c1d00ce2"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 784, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("78366a93-ff88-47c6-982e-e5fd1491f5eb"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("f5b90d42-9c02-465e-b29e-3ac8339c2fc2"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 784, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("117e4539-493c-43ff-88f7-524777fe9fe4"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 784, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("399d3958-35a7-43ac-ad4d-32f49ab96fb1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 784, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("44ec4508-1d9e-4f9f-b110-d863cfdd7a1c"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 784, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("456657b0-7444-47e1-ad58-2e670a78231d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 784, DateTimeKind.Local).AddTicks(3589));
        }
    }
}
