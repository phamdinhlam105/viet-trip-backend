using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace viet_trip_backend.Migrations
{
    /// <inheritdoc />
    public partial class updateTour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_TourDetails_TourDetailId1",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_NoticeInformationId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_TourDetailId1",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "TourDetailId1",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "TourId",
                table: "TourDetails");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_NoticeInformationId",
                table: "Tours",
                column: "NoticeInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TourDetailId",
                table: "Tours",
                column: "TourDetailId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_TourDetails_TourDetailId",
                table: "Tours",
                column: "TourDetailId",
                principalTable: "TourDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_TourDetails_TourDetailId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_NoticeInformationId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_TourDetailId",
                table: "Tours");

            migrationBuilder.AddColumn<Guid>(
                name: "TourDetailId1",
                table: "Tours",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TourId",
                table: "TourDetails",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Tours_NoticeInformationId",
                table: "Tours",
                column: "NoticeInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TourDetailId1",
                table: "Tours",
                column: "TourDetailId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_TourDetails_TourDetailId1",
                table: "Tours",
                column: "TourDetailId1",
                principalTable: "TourDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
