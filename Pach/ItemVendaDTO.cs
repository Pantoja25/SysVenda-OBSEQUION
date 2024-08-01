using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVendas2.DTO{
    internal class ItemVendaDTO{
        public string IdItemDaVenda {get; set;}
        public string Nome { get; set;}
        public string PrecoUnitario {get; set;}
        public string QuantidadeVendida {get; set;}
        public string SubTotalDoItem { get; set;}
    }
}
