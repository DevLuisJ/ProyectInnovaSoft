using Microsoft.EntityFrameworkCore.Migrations;

namespace GymEnCasa.App.Persistencia.Migrations
{
    public partial class MigracionSiete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "frecuencia",
                table: "Personas",
                newName: "frecuenciaRutinas");

            migrationBuilder.RenameColumn(
                name: "Frecuencia",
                table: "Personas",
                newName: "FrecuenciaNutricion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "frecuenciaRutinas",
                table: "Personas",
                newName: "frecuencia");

            migrationBuilder.RenameColumn(
                name: "FrecuenciaNutricion",
                table: "Personas",
                newName: "Frecuencia");
        }
    }
}
