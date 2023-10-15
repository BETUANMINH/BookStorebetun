using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShoppingCartMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Genre_GenreId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_CartDetail_Book_BookId",
                table: "CartDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_CartDetail_ShoppingCart_ShoppingCartId",
                table: "CartDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderStatus_OrderStatusId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Book_BookId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderStatus",
                table: "OrderStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartDetail",
                table: "CartDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "ShoppingCart",
                newName: "ShoppingCart_HE176084");

            migrationBuilder.RenameTable(
                name: "OrderStatus",
                newName: "OrderStatus_HE176084");

            migrationBuilder.RenameTable(
                name: "OrderDetail",
                newName: "OrderDetail_HE176084");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Order_HE176084");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genre_HE176084");

            migrationBuilder.RenameTable(
                name: "CartDetail",
                newName: "CartDetail_HE176084");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Book_HE176084");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail_HE176084",
                newName: "IX_OrderDetail_HE176084_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_BookId",
                table: "OrderDetail_HE176084",
                newName: "IX_OrderDetail_HE176084_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_OrderStatusId",
                table: "Order_HE176084",
                newName: "IX_Order_HE176084_OrderStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetail_ShoppingCartId",
                table: "CartDetail_HE176084",
                newName: "IX_CartDetail_HE176084_ShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetail_BookId",
                table: "CartDetail_HE176084",
                newName: "IX_CartDetail_HE176084_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_GenreId",
                table: "Book_HE176084",
                newName: "IX_Book_HE176084_GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCart_HE176084",
                table: "ShoppingCart_HE176084",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderStatus_HE176084",
                table: "OrderStatus_HE176084",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetail_HE176084",
                table: "OrderDetail_HE176084",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order_HE176084",
                table: "Order_HE176084",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre_HE176084",
                table: "Genre_HE176084",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartDetail_HE176084",
                table: "CartDetail_HE176084",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_HE176084",
                table: "Book_HE176084",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_HE176084_Genre_HE176084_GenreId",
                table: "Book_HE176084",
                column: "GenreId",
                principalTable: "Genre_HE176084",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetail_HE176084_Book_HE176084_BookId",
                table: "CartDetail_HE176084",
                column: "BookId",
                principalTable: "Book_HE176084",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetail_HE176084_ShoppingCart_HE176084_ShoppingCartId",
                table: "CartDetail_HE176084",
                column: "ShoppingCartId",
                principalTable: "ShoppingCart_HE176084",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_HE176084_OrderStatus_HE176084_OrderStatusId",
                table: "Order_HE176084",
                column: "OrderStatusId",
                principalTable: "OrderStatus_HE176084",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_HE176084_Book_HE176084_BookId",
                table: "OrderDetail_HE176084",
                column: "BookId",
                principalTable: "Book_HE176084",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_HE176084_Order_HE176084_OrderId",
                table: "OrderDetail_HE176084",
                column: "OrderId",
                principalTable: "Order_HE176084",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_HE176084_Genre_HE176084_GenreId",
                table: "Book_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_CartDetail_HE176084_Book_HE176084_BookId",
                table: "CartDetail_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_CartDetail_HE176084_ShoppingCart_HE176084_ShoppingCartId",
                table: "CartDetail_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_HE176084_OrderStatus_HE176084_OrderStatusId",
                table: "Order_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_HE176084_Book_HE176084_BookId",
                table: "OrderDetail_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_HE176084_Order_HE176084_OrderId",
                table: "OrderDetail_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCart_HE176084",
                table: "ShoppingCart_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderStatus_HE176084",
                table: "OrderStatus_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetail_HE176084",
                table: "OrderDetail_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order_HE176084",
                table: "Order_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre_HE176084",
                table: "Genre_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartDetail_HE176084",
                table: "CartDetail_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_HE176084",
                table: "Book_HE176084");

            migrationBuilder.RenameTable(
                name: "ShoppingCart_HE176084",
                newName: "ShoppingCart");

            migrationBuilder.RenameTable(
                name: "OrderStatus_HE176084",
                newName: "OrderStatus");

            migrationBuilder.RenameTable(
                name: "OrderDetail_HE176084",
                newName: "OrderDetail");

            migrationBuilder.RenameTable(
                name: "Order_HE176084",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Genre_HE176084",
                newName: "Genre");

            migrationBuilder.RenameTable(
                name: "CartDetail_HE176084",
                newName: "CartDetail");

            migrationBuilder.RenameTable(
                name: "Book_HE176084",
                newName: "Book");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_HE176084_OrderId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetail_HE176084_BookId",
                table: "OrderDetail",
                newName: "IX_OrderDetail_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_HE176084_OrderStatusId",
                table: "Order",
                newName: "IX_Order_OrderStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetail_HE176084_ShoppingCartId",
                table: "CartDetail",
                newName: "IX_CartDetail_ShoppingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_CartDetail_HE176084_BookId",
                table: "CartDetail",
                newName: "IX_CartDetail_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_HE176084_GenreId",
                table: "Book",
                newName: "IX_Book_GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCart",
                table: "ShoppingCart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderStatus",
                table: "OrderStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetail",
                table: "OrderDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartDetail",
                table: "CartDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Genre_GenreId",
                table: "Book",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetail_Book_BookId",
                table: "CartDetail",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetail_ShoppingCart_ShoppingCartId",
                table: "CartDetail",
                column: "ShoppingCartId",
                principalTable: "ShoppingCart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderStatus_OrderStatusId",
                table: "Order",
                column: "OrderStatusId",
                principalTable: "OrderStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Book_BookId",
                table: "OrderDetail",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
