using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroDePacientesBe3.Migrations
{
    public partial class NewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Prontuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 120, nullable: false),
                    Sobrenome = table.Column<string>(maxLength: 20, nullable: false),
                    Dt_Nasc = table.Column<DateTime>(type: "datetime", nullable: false),
                    RG = table.Column<string>(maxLength: 15, nullable: false),
                    CPF = table.Column<string>(maxLength: 14, nullable: false),
                    Sexo = table.Column<byte>(nullable: false),
                    Fone_Res = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    ID_Convenio = table.Column<short>(nullable: false),
                    N_Carteirinha = table.Column<string>(maxLength: 20, nullable: false),
                    Celular = table.Column<string>(maxLength: 20, nullable: true),
                    Nome_Mae = table.Column<string>(maxLength: 50, nullable: false),
                    IdUF = table.Column<short>(nullable: false),
                    DtValidade = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Prontuario);
                });

            migrationBuilder.CreateTable(
                name: "Convenios",
                columns: table => new
                {
                    ID_Convenio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Empresa = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convenios", x => x.ID_Convenio);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Convenios");
        }
    }
}
