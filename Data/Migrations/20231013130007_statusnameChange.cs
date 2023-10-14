using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShoppingCartMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class statusnameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "OrderStatus",
                newName: "StatusName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatusName",
                table: "OrderStatus",
                newName: "Status");
        }
    }
}
