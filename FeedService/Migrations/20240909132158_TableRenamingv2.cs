using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeedService.Migrations
{
    /// <inheritdoc />
    public partial class TableRenamingv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Columns_ColumnId",
                table: "Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Items_ItemId",
                table: "Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tables",
                table: "Tables");

            migrationBuilder.RenameTable(
                name: "Tables",
                newName: "Days");

            migrationBuilder.RenameIndex(
                name: "IX_Tables_ItemId",
                table: "Days",
                newName: "IX_Days_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Tables_ColumnId",
                table: "Days",
                newName: "IX_Days_ColumnId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Days",
                table: "Days",
                column: "DayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Days_Columns_ColumnId",
                table: "Days",
                column: "ColumnId",
                principalTable: "Columns",
                principalColumn: "ColumnId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Days_Items_ItemId",
                table: "Days",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Days_Columns_ColumnId",
                table: "Days");

            migrationBuilder.DropForeignKey(
                name: "FK_Days_Items_ItemId",
                table: "Days");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Days",
                table: "Days");

            migrationBuilder.RenameTable(
                name: "Days",
                newName: "Tables");

            migrationBuilder.RenameIndex(
                name: "IX_Days_ItemId",
                table: "Tables",
                newName: "IX_Tables_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Days_ColumnId",
                table: "Tables",
                newName: "IX_Tables_ColumnId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tables",
                table: "Tables",
                column: "DayId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Columns_ColumnId",
                table: "Tables",
                column: "ColumnId",
                principalTable: "Columns",
                principalColumn: "ColumnId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Items_ItemId",
                table: "Tables",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
