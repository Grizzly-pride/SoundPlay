﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoundPlay.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProdeuctModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Guitars",
                type: "decimal(8,3)",
                precision: 8,
                scale: 3,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Guitars",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,3)",
                oldPrecision: 8,
                oldScale: 3);
        }
    }
}