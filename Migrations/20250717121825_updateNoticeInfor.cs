using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace viet_trip_backend.Migrations
{
    /// <inheritdoc />
    public partial class updateNoticeInfor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tours_NoticeInformations_NoticeInformationId",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_Tours_NoticeInformationId",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "NoticeInformationId",
                table: "Tours");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "NoticeInformationId",
                table: "Tours",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Tours_NoticeInformationId",
                table: "Tours",
                column: "NoticeInformationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_NoticeInformations_NoticeInformationId",
                table: "Tours",
                column: "NoticeInformationId",
                principalTable: "NoticeInformations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
