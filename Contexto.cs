using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVendas2.Entidades;

namespace SysVendas2
{
    internal class Contexto : BdContext
    {
        public BdSet<Cliente> Clientes { get; set; }
        public BdSet<Produto> Produtos { get; set; }
        public BdSet<Venda> Vendas { get; set; }
        public BdSet<ItemVenda> ItensVenda { get; set; }
        public BdSet<Usuario> Usuarios { get; set; }

    }
}
