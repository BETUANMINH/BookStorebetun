using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShoppingCartMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class changetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "AspNetUserTokens_HE176084");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "AspNetUserRoles_HE176084");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "AspNetUserLogins_HE176084");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "AspNetUserClaims_HE176084");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "AspNetRoles_HE176084");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "AspNetRoleClaims_HE176084");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles_HE176084",
                newName: "IX_AspNetUserRoles_HE176084_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins_HE176084",
                newName: "IX_AspNetUserLogins_HE176084_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims_HE176084",
                newName: "IX_AspNetUserClaims_HE176084_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims_HE176084",
                newName: "IX_AspNetRoleClaims_HE176084_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens_HE176084",
                table: "AspNetUserTokens_HE176084",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles_HE176084",
                table: "AspNetUserRoles_HE176084",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins_HE176084",
                table: "AspNetUserLogins_HE176084",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims_HE176084",
                table: "AspNetUserClaims_HE176084",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles_HE176084",
                table: "AspNetRoles_HE176084",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims_HE176084",
                table: "AspNetRoleClaims_HE176084",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_HE176084_AspNetRoles_HE176084_RoleId",
                table: "AspNetRoleClaims_HE176084",
                column: "RoleId",
                principalTable: "AspNetRoles_HE176084",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_AspNetUserRoles_HE176084_AspNetRoles_HE176084_RoleId",
                table: "AspNetUserRoles_HE176084",
                column: "RoleId",
                principalTable: "AspNetRoles_HE176084",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_HE176084_AspNetRoles_HE176084_RoleId",
                table: "AspNetRoleClaims_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_HE176084_AspNetUsers_UserId",
                table: "AspNetUserClaims_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_HE176084_AspNetUsers_UserId",
                table: "AspNetUserLogins_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_HE176084_AspNetRoles_HE176084_RoleId",
                table: "AspNetUserRoles_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_HE176084_AspNetUsers_UserId",
                table: "AspNetUserRoles_HE176084");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_HE176084_AspNetUsers_UserId",
                table: "AspNetUserTokens_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens_HE176084",
                table: "AspNetUserTokens_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles_HE176084",
                table: "AspNetUserRoles_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins_HE176084",
                table: "AspNetUserLogins_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims_HE176084",
                table: "AspNetUserClaims_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles_HE176084",
                table: "AspNetRoles_HE176084");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims_HE176084",
                table: "AspNetRoleClaims_HE176084");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens_HE176084",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles_HE176084",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins_HE176084",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims_HE176084",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles_HE176084",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims_HE176084",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_HE176084_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_HE176084_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_HE176084_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_HE176084_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
