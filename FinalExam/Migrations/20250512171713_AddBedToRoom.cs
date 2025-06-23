using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalExam.Migrations
{
    /// <inheritdoc />
    public partial class AddBedToRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvaiable",
                table: "rooms");

            migrationBuilder.AddColumn<int>(
                name: "Bed",
                table: "rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bed",
                table: "rooms");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvaiable",
                table: "rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
