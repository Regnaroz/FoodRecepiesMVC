using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspnetCoreMvcFull.Migrations
{
    /// <inheritdoc />
    public partial class fix0UserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_BaseUsers_UserId",
                table: "Testimonials");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPaymentMethods_BaseUsers_UserId",
                table: "UserPaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRecepies_BaseUsers_UserId",
                table: "UserRecepies");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseUsers");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    LastModifedBy = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_BaseUsers_BaseUserId",
                        column: x => x.BaseUserId,
                        principalTable: "BaseUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_BaseUserId",
                table: "Users",
                column: "BaseUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_Users_UserId",
                table: "Testimonials",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPaymentMethods_Users_UserId",
                table: "UserPaymentMethods",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRecepies_Users_UserId",
                table: "UserRecepies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_Users_UserId",
                table: "Testimonials");

            migrationBuilder.DropForeignKey(
                name: "FK_UserPaymentMethods_Users_UserId",
                table: "UserPaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRecepies_Users_UserId",
                table: "UserRecepies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseUsers",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_BaseUsers_UserId",
                table: "Testimonials",
                column: "UserId",
                principalTable: "BaseUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserPaymentMethods_BaseUsers_UserId",
                table: "UserPaymentMethods",
                column: "UserId",
                principalTable: "BaseUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRecepies_BaseUsers_UserId",
                table: "UserRecepies",
                column: "UserId",
                principalTable: "BaseUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
