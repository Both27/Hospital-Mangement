using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalExam.Migrations
{
    /// <inheritdoc />
    public partial class AddPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillingItems_Medicine_MedicineId",
                table: "BillingItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_medCategories_MedCategoryId",
                table: "Medicine");

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

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Billings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_medicines",
                table: "medicines",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Billings_PatientId",
                table: "Billings",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_RoomId",
                table: "Patients",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_BillingItems_medicines_MedicineId",
                table: "BillingItems",
                column: "MedicineId",
                principalTable: "medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Billings_Patients_PatientId",
                table: "Billings",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_medicines_medCategories_MedCategoryId",
                table: "medicines",
                column: "MedCategoryId",
                principalTable: "medCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillingItems_medicines_MedicineId",
                table: "BillingItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Billings_Patients_PatientId",
                table: "Billings");

            migrationBuilder.DropForeignKey(
                name: "FK_medicines_medCategories_MedCategoryId",
                table: "medicines");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Billings_PatientId",
                table: "Billings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_medicines",
                table: "medicines");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Billings");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BillingItems_Medicine_MedicineId",
                table: "BillingItems",
                column: "MedicineId",
                principalTable: "Medicine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_medCategories_MedCategoryId",
                table: "Medicine",
                column: "MedCategoryId",
                principalTable: "medCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
