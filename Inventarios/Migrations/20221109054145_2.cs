using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventarios.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquipoId",
                table: "Componentes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EquipoId",
                table: "Componentes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
