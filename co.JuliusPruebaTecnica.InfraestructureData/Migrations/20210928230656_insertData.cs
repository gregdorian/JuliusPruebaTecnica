using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace co.JuliusPruebaTecnica.InfraestructureData.Migrations
{
    public partial class insertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PostNoticias",
                table: "PostNoticias");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PostNoticias");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ImagenPost",
                table: "PostNoticias",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ImagenPost",
                table: "PostNoticias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PostNoticias",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostNoticias",
                table: "PostNoticias",
                column: "Id");
        }
    }
}
