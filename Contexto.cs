﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysVenda_OBSEQUION.entidades;

namespace SysVenda_OBSEQUION {
	internal class Contexto : DbContext {
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Produtos> Produtos { get; set; }
		public DbSet<Venda> Vendas { get; set; }
		public DbSet<ItemVenda> ItensVendas { get; set; }
		public DbSet<Usuario> Usuarios { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseMySql("server=192.168.30.145;database=sysvendas_obq;user=sysvendas_bdv;password=senac123#", new MySqlServerVersion(new Version(8, 0, 37)));
		}
	}
}
