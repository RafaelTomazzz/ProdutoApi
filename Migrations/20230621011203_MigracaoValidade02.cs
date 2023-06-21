using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProdutoApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoValidade02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Validade",
                value: new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Validade",
                value: new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Validade",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Validade",
                value: new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Validade",
                value: new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Validade",
                value: new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
