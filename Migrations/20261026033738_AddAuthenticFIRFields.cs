using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrimeRecordsSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthenticFIRFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CrimeType",
                table: "FIRs",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "LegalSection",
                table: "FIRs",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PoliceStation",
                table: "FIRs",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CrimeType",
                table: "FIRs");

            migrationBuilder.DropColumn(
                name: "LegalSection",
                table: "FIRs");

            migrationBuilder.DropColumn(
                name: "PoliceStation",
                table: "FIRs");
        }
    }
}
