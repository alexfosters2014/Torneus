using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BDTorneus.Migrations
{
    /// <inheritdoc />
    public partial class NotificacionEquipoNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_Equipos_EquipoId",
                table: "Notificaciones");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "Notificaciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_Equipos_EquipoId",
                table: "Notificaciones",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_Equipos_EquipoId",
                table: "Notificaciones");

            migrationBuilder.AlterColumn<int>(
                name: "EquipoId",
                table: "Notificaciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_Equipos_EquipoId",
                table: "Notificaciones",
                column: "EquipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
