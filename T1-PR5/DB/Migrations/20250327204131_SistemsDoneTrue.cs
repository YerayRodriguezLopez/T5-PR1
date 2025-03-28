using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class SistemsDoneTrue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SunHours",
                table: "System");

            migrationBuilder.DropColumn(
                name: "WaterThorough",
                table: "System");

            migrationBuilder.DropColumn(
                name: "WindSpeed",
                table: "System");

            migrationBuilder.AddColumn<float>(
                name: "Parameter",
                table: "System",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Parameter",
                table: "System");

            migrationBuilder.AddColumn<float>(
                name: "SunHours",
                table: "System",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "WaterThorough",
                table: "System",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "WindSpeed",
                table: "System",
                type: "real",
                nullable: true);
        }
    }
}
