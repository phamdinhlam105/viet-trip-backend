using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace viet_trip_backend.Migrations
{
    /// <inheritdoc />
    public partial class updateImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<List<Guid>>(
                name: "Images",
                table: "Tours",
                type: "uuid[]",
                nullable: false,
                oldClrType: typeof(List<string>),
                oldType: "text[]");

            migrationBuilder.AlterColumn<List<Guid>>(
                name: "Images",
                table: "Hotels",
                type: "uuid[]",
                nullable: false,
                oldClrType: typeof(List<string>),
                oldType: "text[]");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_Slug",
                table: "Tours",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Slug",
                table: "Posts",
                column: "Slug",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_Slug",
                table: "Hotels",
                column: "Slug",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tours_Slug",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Slug",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_Slug",
                table: "Hotels");

            migrationBuilder.AlterColumn<List<string>>(
                name: "Images",
                table: "Tours",
                type: "text[]",
                nullable: false,
                oldClrType: typeof(List<Guid>),
                oldType: "uuid[]");

            migrationBuilder.AlterColumn<List<string>>(
                name: "Images",
                table: "Hotels",
                type: "text[]",
                nullable: false,
                oldClrType: typeof(List<Guid>),
                oldType: "uuid[]");
        }
    }
}
