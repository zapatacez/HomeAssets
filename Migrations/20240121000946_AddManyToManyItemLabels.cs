using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeAssets.Migrations
{
    /// <inheritdoc />
    public partial class AddManyToManyItemLabels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Labels_Items_ItemId",
                table: "Labels");

            migrationBuilder.DropIndex(
                name: "IX_Labels_ItemId",
                table: "Labels");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Labels");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ItemId",
                table: "Labels",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Labels_ItemId",
                table: "Labels",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Labels_Items_ItemId",
                table: "Labels",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
