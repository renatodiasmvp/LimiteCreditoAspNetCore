using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LimiteCreditoAspNetCore.Migrations
{
    public partial class limites_credito : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LIMITES_CREDITOS_LIC",
                columns: table => new
                {
                    IDE_LIMITE_CREDITO = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IDE_CONTRATO_TERCEIRO = table.Column<int>(nullable: false),
                    DAT_EXPIRA_LIMITE = table.Column<DateTime>(type: "datetime", nullable: true),
                    DES_OBSERVACAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    QTD_PARCELAS_APROVACAO = table.Column<int>(nullable: false),
                    VLR_TOTAL_APROVACAO = table.Column<decimal>(type: "money", nullable: false),
                    PER_TAXA_OPERACAO = table.Column<decimal>(type: "numeric", nullable: true),
                    VLR_TARIFA_OPERACAO = table.Column<decimal>(type: "money", nullable: true),
                    VLR_TOTAL_DESCONTOS = table.Column<decimal>(type: "money", nullable: true),
                    VLR_LIQUIDO_APROVACAO = table.Column<decimal>(type: "money", nullable: false),
                    NUM_PARCELA_INICIAL = table.Column<int>(nullable: true),
                    IDE_MOTIVO = table.Column<int>(nullable: true),
                    LIS_SITUACAO = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NOM_LOGIN_APROVACAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DAT_APROVACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    DES_APROVACAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STS_LIMITE = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    DAT_INCLUSAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOM_LOGIN_INCLUSAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NUM_IP_INCLUSAO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DAT_ALTERACAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    NOM_LOGIN_ALTERACAO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LIMITES_CREDITOS_LIC", x => x.IDE_LIMITE_CREDITO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LIMITES_CREDITOS_LIC");
        }
    }
}
