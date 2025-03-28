using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "System");

            migrationBuilder.DropColumn(
                name: "Parameter",
                table: "System");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "System");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "System");

            migrationBuilder.AlterColumn<double>(
                name: "GeneratedEnergy",
                table: "System",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<double>(
                name: "CostPerKWh",
                table: "System",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PricePerKWh",
                table: "System",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Ratio",
                table: "System",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SunHours",
                table: "System",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WaterFlow",
                table: "System",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WindSpeed",
                table: "System",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostPerKWh",
                table: "System");

            migrationBuilder.DropColumn(
                name: "PricePerKWh",
                table: "System");

            migrationBuilder.DropColumn(
                name: "Ratio",
                table: "System");

            migrationBuilder.DropColumn(
                name: "SunHours",
                table: "System");

            migrationBuilder.DropColumn(
                name: "WaterFlow",
                table: "System");

            migrationBuilder.DropColumn(
                name: "WindSpeed",
                table: "System");

            migrationBuilder.AlterColumn<float>(
                name: "GeneratedEnergy",
                table: "System",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<float>(
                name: "Cost",
                table: "System",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Parameter",
                table: "System",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "System",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Rate",
                table: "System",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
