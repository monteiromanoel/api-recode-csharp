using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAgenciaRecode.Migrations
{
    public partial class remoceCD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Cliente_ClienteId",
                table: "Reserva");

            migrationBuilder.DropForeignKey(
                name: "FK_Reserva_Destino_DestinoId",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_ClienteId",
                table: "Reserva");

            migrationBuilder.DropIndex(
                name: "IX_Reserva_DestinoId",
                table: "Reserva");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Reserva_ClienteId",
                table: "Reserva",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_DestinoId",
                table: "Reserva",
                column: "DestinoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Cliente_ClienteId",
                table: "Reserva",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reserva_Destino_DestinoId",
                table: "Reserva",
                column: "DestinoId",
                principalTable: "Destino",
                principalColumn: "DestinoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
