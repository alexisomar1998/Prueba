using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entidades
{
	public class Store
	{
		public int IdStore { get; set; }
		public int manager_staff_id { get; set; }
		public List<Staff> staffs { get; set; }
		public int addres_id { get; set; }
		public List<Address> addresses { get; set; }
		public string last_update { get; set; }

	}
}
