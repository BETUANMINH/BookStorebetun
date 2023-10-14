using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShoppingCartMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class addstatuscodeinorderstatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "statusId",
                table: "OrderStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "statusId",
                table: "OrderStatus");
        }
    }
}
