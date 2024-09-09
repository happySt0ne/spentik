using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FeedService.Migrations
{
    /// <inheritdoc />
    public partial class TableFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Columns_Tables_TableId",
                table: "Columns");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Tables_TableId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_TableId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Columns_TableId",
                table: "Columns");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "TableId",
                table: "Columns");

            migrationBuilder.AddColumn<int>(
                name: "ColumnId",
                table: "Tables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemId",
                table: "Tables",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tables_ColumnId",
                table: "Tables",
                column: "ColumnId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tables_ItemId",
                table: "Tables",
                column: "ItemId",
                unique: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Columns_ColumnId",
                table: "Tables");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Items_ItemId",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Tables_ColumnId",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Tables_ItemId",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "ColumnId",
                table: "Tables");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Tables");

            migrationBuilder.AddColumn<int>(
                name: "TableId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TableId",
                table: "Columns",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Items_TableId",
                table: "Items",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Columns_TableId",
                table: "Columns",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Columns_Tables_TableId",
                table: "Columns",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Tables_TableId",
                table: "Items",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "TableId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
