using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeAssets.Migrations
{
    /// <inheritdoc />
    public partial class AddVendorProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Items",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Items");
        }
    }
}
