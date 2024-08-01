using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SysVenda_OBSEQUION.Migrations
{
    /// <inheritdoc />
    public partial class V3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Produtos_ProdutoId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_ProdutoId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "ItensVendas");

            migrationBuilder.DropColumn(
                name: "ImagemURL",
                table: "ItensVendas");

            migrationBuilder.RenameColumn(
                name: "QuantidadeEmEstoque",
                table: "ItensVendas",
                newName: "VendaId");

            migrationBuilder.AddColumn<decimal>(
                name: "ValorTotal",
                table: "Vendas",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "ItensVendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProdutosId",
                table: "ItensVendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Quantidade",
                table: "ItensVendas",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorUnitario",
                table: "ItensVendas",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_ItensVendas_ProdutosId",
                table: "ItensVendas",
                column: "ProdutosId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVendas_VendaId",
                table: "ItensVendas",
                column: "VendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensVendas_Produtos_ProdutosId",
                table: "ItensVendas",
                column: "ProdutosId",
                principalTable: "Produtos",
                principalColumn: "ProdutosId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensVendas_Vendas_VendaId",
                table: "ItensVendas",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "VendaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensVendas_Produtos_ProdutosId",
                table: "ItensVendas");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensVendas_Vendas_VendaId",
                table: "ItensVendas");

            migrationBuilder.DropIndex(
                name: "IX_ItensVendas_ProdutosId",
                table: "ItensVendas");

            migrationBuilder.DropIndex(
                name: "IX_ItensVendas_VendaId",
                table: "ItensVendas");

            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "ItensVendas");

            migrationBuilder.DropColumn(
                name: "ProdutosId",
                table: "ItensVendas");

            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "ItensVendas");

            migrationBuilder.DropColumn(
                name: "ValorUnitario",
                table: "ItensVendas");

            migrationBuilder.RenameColumn(
                name: "VendaId",
                table: "ItensVendas",
                newName: "QuantidadeEmEstoque");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "ItensVendas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ImagemURL",
                table: "ItensVendas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ProdutoId",
                table: "Vendas",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Produtos_ProdutoId",
                table: "Vendas",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutosId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
