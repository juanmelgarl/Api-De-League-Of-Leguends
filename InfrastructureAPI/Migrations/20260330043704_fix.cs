using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfrastructureAPI.Migrations
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RolPrincipal",
                table: "Campeones",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RolPrincipal",
                table: "Campeones");
        }
    }
}
