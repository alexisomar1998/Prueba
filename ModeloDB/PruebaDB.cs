using Microsoft.EntityFrameworkCore;
using Prueba.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModeloDB
{
	public class PruebaDB : DbContext
	{
	public DbSet<Store> Stores { get; set; }
	public DbSet<Staff> Staffs { get; set;}
		public DbSet<Address> Address { get; set; }

	}
	
}
