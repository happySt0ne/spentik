using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeedService.Migrations
{
    /// <inheritdoc />
    public partial class TableRenaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TableId",
                table: "Tables",
                newName: "DayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DayId",
                table: "Tables",
                newName: "TableId");
        }
    }
}
