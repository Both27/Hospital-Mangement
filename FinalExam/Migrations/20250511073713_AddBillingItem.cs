using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalExam.Migrations
{
    /// <inheritdoc />
    public partial class AddBillingItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_medicines_medCategories_MedCategoryId",
                table: "medicines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_medicines",
                table: "medicines");

            migrationBuilder.RenameTable(
                name: "medicines",
                newName: "Medicine");

            migrationBuilder.RenameIndex(
                name: "IX_medicines_MedCategoryId",
                table: "Medicine",
                newName: "IX_Medicine_MedCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicine",
                table: "Medicine",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Billings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillingItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillingId = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    QuantityUsed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillingItems_Billings_BillingId",
                        column: x => x.BillingId,
                        principalTable: "Billings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillingItems_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BillingItems_BillingId",
                table: "BillingItems",
                column: "BillingId");

            migrationBuilder.CreateIndex(
                name: "IX_BillingItems_MedicineId",
                table: "BillingItems",
                column: "MedicineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_medCategories_MedCategoryId",
                table: "Medicine",
                column: "MedCategoryId",
                principalTable: "medCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_medCategories_MedCategoryId",
                table: "Medicine");

            migrationBuilder.DropTable(
                name: "BillingItems");

            migrationBuilder.DropTable(
                name: "Billings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicine",
                table: "Medicine");

            migrationBuilder.RenameTable(
                name: "Medicine",
                newName: "medicines");

            migrationBuilder.RenameIndex(
                name: "IX_Medicine_MedCategoryId",
                table: "medicines",
                newName: "IX_medicines_MedCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_medicines",
                table: "medicines",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_medicines_medCategories_MedCategoryId",
                table: "medicines",
                column: "MedCategoryId",
                principalTable: "medCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
