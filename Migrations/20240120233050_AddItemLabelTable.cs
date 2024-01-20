using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeAssets.Migrations
{
    /// <inheritdoc />
    public partial class AddItemLabelTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItemLabels",
                columns: table => new
                {
                    ItemLabelId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ItemId = table.Column<Guid>(type: "TEXT", nullable: false),
                    LabelId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemLabels", x => x.ItemLabelId);
                    table.ForeignKey(
                        name: "FK_ItemLabels_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemLabels_Labels_LabelId",
                        column: x => x.LabelId,
                        principalTable: "Labels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemLabels_ItemId",
                table: "ItemLabels",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemLabels_LabelId",
                table: "ItemLabels",
                column: "LabelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemLabels");
        }
    }
}
