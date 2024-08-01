using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SysVenda_OBSEQUION.Migrations
{
    /// <inheritdoc />
    public partial class V31 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensVendas_Produtos_ProdutosId",
                table: "ItensVendas");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensVendas_Vendas_VendaId",
                table: "ItensVendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItensVendas",
                table: "ItensVendas");

            migrationBuilder.DropColumn(
                name: "Disponivel",
                table: "ItensVendas");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "ItensVendas");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "ItensVendas");

            migrationBuilder.RenameTable(
                name: "ItensVendas",
                newName: "ItensVenda");

            migrationBuilder.RenameIndex(
                name: "IX_ItensVendas_VendaId",
                table: "ItensVenda",
                newName: "IX_ItensVenda_VendaId");

            migrationBuilder.RenameIndex(
                name: "IX_ItensVendas_ProdutosId",
                table: "ItensVenda",
                newName: "IX_ItensVenda_ProdutosId");

            migrationBuilder.AddColumn<double>(
                name: "QtdEstoque",
                table: "Produtos",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "ItensVenda",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItensVenda",
                table: "ItensVenda",
                column: "ItemVendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensVenda_Produtos_ProdutosId",
                table: "ItensVenda",
                column: "ProdutosId",
                principalTable: "Produtos",
                principalColumn: "ProdutosId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensVenda_Vendas_VendaId",
                table: "ItensVenda",
                column: "VendaId",
                principalTable: "Vendas",
                principalColumn: "VendaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensVenda_Produtos_ProdutosId",
                table: "ItensVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensVenda_Vendas_VendaId",
                table: "ItensVenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItensVenda",
                table: "ItensVenda");

            migrationBuilder.DropColumn(
                name: "QtdEstoque",
                table: "Produtos");

            migrationBuilder.RenameTable(
                name: "ItensVenda",
                newName: "ItensVendas");

            migrationBuilder.RenameIndex(
                name: "IX_ItensVenda_VendaId",
                table: "ItensVendas",
                newName: "IX_ItensVendas_VendaId");

            migrationBuilder.RenameIndex(
                name: "IX_ItensVenda_ProdutosId",
                table: "ItensVendas",
                newName: "IX_ItensVendas_ProdutosId");

            migrationBuilder.UpdateData(
                table: "ItensVendas",
                keyColumn: "Descricao",
                keyValue: null,
                column: "Descricao",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "ItensVendas",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "Disponivel",
                table: "ItensVendas",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "ItensVendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "ItensVendas",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItensVendas",
                table: "ItensVendas",
                column: "ItemVendaId");

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
    }
}
