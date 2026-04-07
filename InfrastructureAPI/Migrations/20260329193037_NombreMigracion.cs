using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfrastructureAPI.Migrations
{
    /// <inheritdoc />
    public partial class NombreMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campeones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VidaBase = table.Column<double>(type: "float", nullable: false),
                    AtaqueBase = table.Column<double>(type: "float", nullable: false),
                    ArmaduraBase = table.Column<double>(type: "float", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dificultad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campeones", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campeones");
        }
    }
}
