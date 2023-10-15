using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShoppingCartMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class changetable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_HE176084_AspNetUsers_UserId",
                table: "AspNetUserClaims_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_HE176084_AspNetUsers_UserId",
                table: "AspNetUserLogins_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_HE176084_AspNetUsers_UserId",
                table: "AspNetUserRoles_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_HE176084_AspNetUsers_UserId",
                table: "AspNetUserTokens_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "AspNetUsers_HE176084");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers_HE176084",
                table: "AspNetUsers_HE176084",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_HE176084_AspNetUsers_HE176084_UserId",
                table: "AspNetUserClaims_HE176084",
                column: "UserId",
                principalTable: "AspNetUsers_HE176084",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_HE176084_AspNetUsers_HE176084_UserId",
                table: "AspNetUserLogins_HE176084",
                column: "UserId",
                principalTable: "AspNetUsers_HE176084",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_HE176084_AspNetUsers_HE176084_UserId",
                table: "AspNetUserRoles_HE176084",
                column: "UserId",
                principalTable: "AspNetUsers_HE176084",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_HE176084_AspNetUsers_HE176084_UserId",
                table: "AspNetUserTokens_HE176084",
                column: "UserId",
                principalTable: "AspNetUsers_HE176084",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_HE176084_AspNetUsers_HE176084_UserId",
                table: "AspNetUserClaims_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_HE176084_AspNetUsers_HE176084_UserId",
                table: "AspNetUserLogins_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_HE176084_AspNetUsers_HE176084_UserId",
                table: "AspNetUserRoles_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_HE176084_AspNetUsers_HE176084_UserId",
                table: "AspNetUserTokens_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers_HE176084",
                table: "AspNetUsers_HE176084");

            migrationBuilder.RenameTable(
                name: "AspNetUsers_HE176084",
                newName: "AspNetUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_HE176084_AspNetUsers_UserId",
                table: "AspNetUserClaims_HE176084",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_HE176084_AspNetUsers_UserId",
                table: "AspNetUserLogins_HE176084",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_HE176084_AspNetUsers_UserId",
                table: "AspNetUserRoles_HE176084",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_HE176084_AspNetUsers_UserId",
                table: "AspNetUserTokens_HE176084",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
