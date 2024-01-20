using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeAssets.Migrations
{
    /// <inheritdoc />
    public partial class ModifytemLabelTableId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemLabelId",
                table: "ItemLabels",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ItemLabels",
                newName: "ItemLabelId");
        }
    }
}
