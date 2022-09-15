using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymEnCasa.App.Persistencia.Migrations
{
    public partial class MigracionSeis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "CaloriasAgregadas",
                table: "Personas",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "CaloriasQuemadas",
                table: "Personas",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Dieta",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoDieta",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoRutina",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Personas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Frecuencia",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PlanDeRutinas_Fecha",
                table: "Personas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Repeticiones",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rutina",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rutinas",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "frecuencia",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaloriasAgregadas",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "CaloriasQuemadas",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Dieta",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "EstadoDieta",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "EstadoRutina",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Frecuencia",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "PlanDeRutinas_Fecha",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Repeticiones",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Rutina",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Rutinas",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "frecuencia",
                table: "Personas");
        }
    }
}
