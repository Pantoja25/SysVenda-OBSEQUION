using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVenda_OBSEQUION.entidades;
using Vip.Printer.Enums;
using Vip.Printer;

namespace SysVenda_OBSEQUION.Impressora
{
    internal static class ImprimirNota
    {
        private static Printer ObterPrinter()
        {
            // Ajuste do Encoding para se adequar à impressora.
            return new Printer("192.168.30.75", PrinterType.Bematech, 1, 1, 1, null, ProtocolType.Network);
        }

        static void Imprimir(List<ItemVenda> itens, Venda venda, Cliente cliente)
        {
            Printer printer = ObterPrinter();

            try
            {
                printer.InitializePrint();
                printer.AlignCenter();
                printer.NewLines(2);

                printer.Image(Properties.Resources.logo_senac, true);

                printer.InitializePrint();
                printer.AlignCenter();
                //printer.NewLines(5);

                printer.WriteLine("SISTEMA DE VENDAS");
                printer.WriteLine("SENAC CASTANHAL");
                printer.WriteLine("*OBSEQUION*");

                printer.NewLines(1);
                printer.AlignLeft();

                Produtos produto = new Produtos
                {
                    ProdutosId = 2,
                    Descricao = "Melancia",
                    Unidade = "Unid",
                    Preco = 10
                };


                printer.WriteLine("   id | Nome");
                printer.WriteLine("      | Preço |  UNID  |   Quant   |   Subtotal");
                printer.WriteLine("------------------------------------------------");

                itens.ForEach(it =>
                {
                    printer.WriteLine(FazerLinha1(it));
                    printer.WriteLine(FazerLinha2(it));
                });

                printer.NewLines(10);
                printer.Separator();
                printer.PartialPaperCut(true);

                printer.PrintDocument();
            }
            catch (Exception ex)
            {
                // Mostra uma mensagem de erro e registra o erro usando o método LogError.
                MessageBox.Show($"Erro ao tentar imprimir: {ex.Message}", "Erro de Impressão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogError(ex);
            }
        }

        static string FazerLinha1(ItemVenda iv)
        {
            StringBuilder linhaProduto = new StringBuilder();
            string idProduto = iv.ItemVendaId.ToString();
            linhaProduto.Append(idProduto.PadLeft(5))
                        .Append(" | ")
                        .Append(iv.Descricao);
            return linhaProduto.ToString();
        }
        static string FazerLinha2(ItemVenda iv)
        {
            int quantidade = 5;


            string precoProduto = iv.Preco.ToString("C2", CultureInfo.CurrentCulture);
            StringBuilder linhaPreco = new StringBuilder();
            linhaPreco.Append(precoProduto.PadLeft(13))
                      .Append(" | ")
                      .Append(precoProduto.PadLeft(5))
                      .Append("  | ")
                      .Append(quantidade.ToString().PadLeft(9))
                      .Append(" | ")
                      .Append((iv.Preco * quantidade).ToString("C2", CultureInfo.CurrentCulture).PadLeft(10));
            return linhaPreco.ToString();
        }

        private static void LogError(Exception ex)
        {
            // Caminho para o arquivo de log
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");

            // Mensagem de erro a ser gravada no log
            string errorMessage = $"{DateTime.Now}: {ex.Message}\n{ex.StackTrace}\n\n";

            try
            {
                // Adiciona a mensagem de erro ao arquivo de log
                File.AppendAllText(logFilePath, errorMessage);
            }
            catch (Exception fileEx)
            {
                // Se ocorrer um erro ao gravar o log, você pode querer notificar o usuário ou registrar de outra forma
                MessageBox.Show($"Erro ao registrar o erro: {fileEx.Message}", "Erro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
