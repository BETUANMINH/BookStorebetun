using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShoppingCartMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class changetable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "ShoppingCart_HE176084",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Order_HE176084",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCart_HE176084_UserID",
                table: "ShoppingCart_HE176084",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_HE176084_UserID",
                table: "Order_HE176084",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_HE176084_AspNetUsers_HE176084_UserID",
                table: "Order_HE176084",
                column: "UserID",
                principalTable: "AspNetUsers_HE176084",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCart_HE176084_AspNetUsers_HE176084_UserID",
                table: "ShoppingCart_HE176084",
                column: "UserID",
                principalTable: "AspNetUsers_HE176084",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_HE176084_AspNetUsers_HE176084_UserID",
                table: "Order_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCart_HE176084_AspNetUsers_HE176084_UserID",
                table: "ShoppingCart_HE176084");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCart_HE176084_UserID",
                table: "ShoppingCart_HE176084");

            migrationBuilder.DropIndex(
                name: "IX_Order_HE176084_UserID",
                table: "Order_HE176084");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "ShoppingCart_HE176084",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Order_HE176084",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
