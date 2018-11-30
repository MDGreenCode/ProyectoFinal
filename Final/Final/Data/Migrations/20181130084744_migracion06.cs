using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Final.Data.Migrations
{
    public partial class migracion06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_factura_productos_productosid",
                table: "factura");

            migrationBuilder.DropIndex(
                name: "IX_factura_productosid",
                table: "factura");

            migrationBuilder.DropColumn(
                name: "productosid",
                table: "factura");

            migrationBuilder.AddColumn<int>(
                name: "facturaid",
                table: "productos",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "total",
                table: "factura",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_productos_facturaid",
                table: "productos",
                column: "facturaid");

            migrationBuilder.AddForeignKey(
                name: "FK_productos_factura_facturaid",
                table: "productos",
                column: "facturaid",
                principalTable: "factura",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productos_factura_facturaid",
                table: "productos");

            migrationBuilder.DropIndex(
                name: "IX_productos_facturaid",
                table: "productos");

            migrationBuilder.DropColumn(
                name: "facturaid",
                table: "productos");

            migrationBuilder.AlterColumn<int>(
                name: "total",
                table: "factura",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<int>(
                name: "productosid",
                table: "factura",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_factura_productosid",
                table: "factura",
                column: "productosid");

            migrationBuilder.AddForeignKey(
                name: "FK_factura_productos_productosid",
                table: "factura",
                column: "productosid",
                principalTable: "productos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
