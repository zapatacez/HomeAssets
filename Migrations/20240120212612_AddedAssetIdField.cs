using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeAssets.Migrations
{
    /// <inheritdoc />
    public partial class AddedAssetIdField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssetId",
                table: "Items",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssetId",
                table: "Items");
        }
    }
}
