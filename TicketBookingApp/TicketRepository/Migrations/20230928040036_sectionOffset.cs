using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketRepository.Migrations
{
    /// <inheritdoc />
    public partial class sectionOffset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "XOffset",
                table: "Sections",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "YOffset",
                table: "Sections",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "XOffset",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "YOffset",
                table: "Sections");
        }
    }
}
