using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalExam.Migrations
{
    /// <inheritdoc />
    public partial class RelationShipUserToBilling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Billings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Billings_UserId",
                table: "Billings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Billings_users_UserId",
                table: "Billings",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Billings_users_UserId",
                table: "Billings");

            migrationBuilder.DropIndex(
                name: "IX_Billings_UserId",
                table: "Billings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Billings");
        }
    }
}
