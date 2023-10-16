using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShoppingCartMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixconflict1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "statusId",
                table: "OrderStatus_HE176084");
        }

    }
}
