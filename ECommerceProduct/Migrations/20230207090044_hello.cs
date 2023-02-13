using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerceProduct.Migrations
{
    public partial class hello : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0215de4b-e4ae-46fd-b530-92678aaa3487"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fcfc4c9-d283-4d4a-8b88-fe8a5d53b529"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24d066c6-92f8-4457-9475-435090170ff1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b6aa7d6-1974-430f-a760-3ced549d0471"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 781, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37eee076-d740-430c-a3e6-4b56a5d0f5c4"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("552d5bb7-3af3-4f82-b44b-f32468d46c9d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99532ba0-b7e3-4a8a-ad91-7524b95c6d98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0df594f-1a9b-4fa8-9ac0-6b24db187318"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 30, 43, 783, DateTimeKind.Local).AddTicks(3380));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0215de4b-e4ae-46fd-b530-92678aaa3487"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0fcfc4c9-d283-4d4a-8b88-fe8a5d53b529"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24d066c6-92f8-4457-9475-435090170ff1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b6aa7d6-1974-430f-a760-3ced549d0471"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 785, DateTimeKind.Local).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37eee076-d740-430c-a3e6-4b56a5d0f5c4"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("552d5bb7-3af3-4f82-b44b-f32468d46c9d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99532ba0-b7e3-4a8a-ad91-7524b95c6d98"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0df594f-1a9b-4fa8-9ac0-6b24db187318"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 786, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "RefSets",
                keyColumn: "Id",
                keyValue: new Guid("24085e18-602d-4d27-8e97-2263202c6064"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("1fa74cce-2a56-44f4-b4b7-853babb4bfb0"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("61ba2ce4-3d28-46d4-b190-ff01c1d00ce2"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("78366a93-ff88-47c6-982e-e5fd1491f5eb"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "RefTerms",
                keyColumn: "Id",
                keyValue: new Guid("f5b90d42-9c02-465e-b29e-3ac8339c2fc2"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("117e4539-493c-43ff-88f7-524777fe9fe4"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("399d3958-35a7-43ac-ad4d-32f49ab96fb1"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("44ec4508-1d9e-4f9f-b110-d863cfdd7a1c"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "SetRefTerms",
                keyColumn: "Id",
                keyValue: new Guid("456657b0-7444-47e1-ad58-2e670a78231d"),
                column: "DateCreated",
                value: new DateTime(2023, 2, 7, 14, 29, 34, 787, DateTimeKind.Local).AddTicks(6048));
        }
    }
}
