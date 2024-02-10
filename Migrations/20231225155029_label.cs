using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAgenciaRecode.Migrations
{
    public partial class label : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "label_promocao",
                table: "Destino",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "label_promocao",
                table: "Destino");
        }
    }
}
