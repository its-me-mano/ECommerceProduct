using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceProduct.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b6aa7d6-1974-430f-a760-3ced549d0471"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0215de4b-e4ae-46fd-b530-92678aaa3487"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 243, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fcfc4c9-d283-4d4a-8b88-fe8a5d53b529"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 243, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24d066c6-92f8-4457-9475-435090170ff1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 243, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37eee076-d740-430c-a3e6-4b56a5d0f5c4"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 243, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("552d5bb7-3af3-4f82-b44b-f32468d46c9d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 243, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99532ba0-b7e3-4a8a-ad91-7524b95c6d98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 243, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0df594f-1a9b-4fa8-9ac0-6b24db187318"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 243, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreateBy", "DateCreated", "DateUpdated", "ImageAsset", "Name", "Price", "ProductCount", "UpdateBy", "Visibility" },
                values: new object[] { new Guid("8de4b55d-80d2-4313-9367-de5c561ef335"), new Guid("78366a93-ff88-47c6-982e-e5fd1491f5eb"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 12, 12, 58, 38, 241, DateTimeKind.Local).AddTicks(6015), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Apple IPhone Xs Max", 100000f, 50, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae") });

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("1a78c6af-aa76-4e14-b9bc-ad41eb31b2b2"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("24085e18-602d-4d27-8e97-2263202c6064"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("1fa74cce-2a56-44f4-b4b7-853babb4bfb0"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("61ba2ce4-3d28-46d4-b190-ff01c1d00ce2"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("78366a93-ff88-47c6-982e-e5fd1491f5eb"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("e55b3bf9-9e45-4e3a-8484-0a25e18c4734"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("f5b90d42-9c02-465e-b29e-3ac8339c2fc2"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("117e4539-493c-43ff-88f7-524777fe9fe4"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("399d3958-35a7-43ac-ad4d-32f49ab96fb1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("426de7a2-bbc3-436c-b97e-598572bf6a40"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("44ec4508-1d9e-4f9f-b110-d863cfdd7a1c"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("456657b0-7444-47e1-ad58-2e670a78231d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("eb9c0adf-6faf-47eb-b997-82e052875e90"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 12, 12, 58, 38, 244, DateTimeKind.Local).AddTicks(9784));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8de4b55d-80d2-4313-9367-de5c561ef335"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0215de4b-e4ae-46fd-b530-92678aaa3487"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fcfc4c9-d283-4d4a-8b88-fe8a5d53b529"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24d066c6-92f8-4457-9475-435090170ff1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37eee076-d740-430c-a3e6-4b56a5d0f5c4"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("552d5bb7-3af3-4f82-b44b-f32468d46c9d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99532ba0-b7e3-4a8a-ad91-7524b95c6d98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0df594f-1a9b-4fa8-9ac0-6b24db187318"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 88, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreateBy", "DateCreated", "DateUpdated", "ImageAsset", "Name", "Price", "ProductCount", "UpdateBy", "Visibility" },
                values: new object[] { new Guid("2b6aa7d6-1974-430f-a760-3ced549d0471"), new Guid("78366a93-ff88-47c6-982e-e5fd1491f5eb"), new Guid("f46f9dba-8a1c-4dd9-a8ea-c572a83be0be"), new DateTime(2023, 2, 7, 23, 42, 11, 86, DateTimeKind.Local).AddTicks(3874), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), "Apple IPhone Xs Max", 100000f, 50, new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae") });

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("1a78c6af-aa76-4e14-b9bc-ad41eb31b2b2"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("24085e18-602d-4d27-8e97-2263202c6064"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(383));

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
                keyValue: new Guid("d2c13aea-044d-4f1d-a0ea-3937c85ef0ae"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("e55b3bf9-9e45-4e3a-8484-0a25e18c4734"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("f5b90d42-9c02-465e-b29e-3ac8339c2fc2"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(4001));

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
                keyValue: new Guid("426de7a2-bbc3-436c-b97e-598572bf6a40"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(7343));

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

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("eb9c0adf-6faf-47eb-b997-82e052875e90"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 23, 42, 11, 89, DateTimeKind.Local).AddTicks(7369));
        }
    }
}
