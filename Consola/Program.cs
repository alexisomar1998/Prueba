using Prueba.Entidades;
using System;
using System.Collections.Generic;

namespace Consola
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Staff empleado1 = new Staff()
			{
				first_name = "Jose",
				last_name = "Orozco",
				email = "jose@gmail.com",
				store_id = 1,
				active = "empleado",
				username = "jose1",
				password = "123",
				last_update = "2021-01-05",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Staff empleado2 = new Staff()
			{
				first_name = "Alexis",
				last_name = "Jaramilllo",
				email = "Alexis@gmail.com",
				store_id = 2,
				active = "empleado",
				username = "alexis2",
				password = "1234",
				last_update = "2021-01-05",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Staff empleado3 = new Staff()
			{
				first_name = "Julio",
				last_name = "Jaramilllo",
				email = "Jaramillo@gmail.com",
				store_id = 3,
				active = "empleado",
				username = "Julio2",
				password = "12345",
				last_update = "2021-01-06",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Staff empleado4 = new Staff()
			{
				first_name = "Samantha",
				last_name = "Taipe",
				email = "samantha@gmail.com",
				store_id = 4,
				active = "empleado",
				username = "samantha2",
				password = "123456",
				last_update = "2021-01-24",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Staff empleado5 = new Staff()
			{
				first_name = "Salome",
				last_name = "Gallardo",
				email = "salome@gmail.com",
				store_id = 1,
				active = "empleado",
				username = "salome2",
				password = "1234567",
				last_update = "2021-01-24",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Staff empleado6 = new Staff()
			{
				first_name = "Paco",
				last_name = "Lema",
				email = "paco@gmail.com",
				store_id = 4,
				active = "empleado",
				username = "paco2",
				password = "p01",
				last_update = "2021-01-24",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Staff empleado7 = new Staff()
			{
				first_name = "Steven",
				last_name = "Diaz",
				email = "diaz@gmail.com",
				store_id = 2,
				active = "empleado",
				username = "steven2",
				password = "s01",
				last_update = "2021-01-24",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Staff empleado8 = new Staff()
			{
				first_name = "Edgar",
				last_name = "Villacrez",
				email = "edgar@gmail.com",
				store_id = 3,
				active = "empleado",
				username = "edgar2",
				password = "ed01",
				last_update = "2021-01-24",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Staff empleado9 = new Staff()
			{
				first_name = "Carla",
				last_name = "Jaramillo",
				email = "carla@gmail.com",
				store_id = 4,
				active = "empleado",
				username = "carla2",
				password = "car01",
				last_update = "2021-01-24",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Staff empleado10 = new Staff()
			{
				first_name = "Katty",
				last_name = "Taipe",
				email = "katt@gmail.com",
				store_id = 3,
				active = "empleado",
				username = "katt2",
				password = "katt01",
				last_update = "2021-01-24",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Staff jefe1 = new Staff()
			{
				first_name = "Katty",
				last_name = "Mena",
				email = "katty@gmail.com",
				store_id = 1,
				active = "jefe",
				username = "kattyMena2",
				password = "kattyMena01",
				last_update = "2021-01-24",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Staff jefe2 = new Staff()
			{
				first_name = "Rosa",
				last_name = "Delagado",
				email = "rosa@gmail.com",
				store_id = 3,
				active = "jefe",
				username = "Rosa2",
				password = "Rosa01",
				last_update = "2021-01-24",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Staff jefe3 = new Staff()
			{
				first_name = "Omar",
				last_name = "Analuisa",
				email = "Omar@gmail.com",
				store_id = 2,
				active = "jefe",
				username = "Omar",
				password = "Omar01",
				last_update = "2021-01-24",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Staff jefe4 = new Staff()
			{
				first_name = "Erick",
				last_name = "Padilla",
				email = "Erick@gmail.com",
				store_id = 4,
				active = "jefe",
				username = "Erick",
				password = "ErickJ01",
				last_update = "2021-01-24",
				picture = "https://www.prensalibre.com/wp-content/uploads/2018/12/eee060b0-296f-4463-8429-542adef7bb6b.jpg?quality=52&w=760&h=430&crop=1",
			};
			Address direc1 = new Address()
			{
				address="10 de agosto",
				address2="Rumipampa",
				district="Distrito 1",
				postal_code="00025",
				telefono="0526978652"

			};
			Address direc2 = new Address()
			{
				address = "Gaspar de villaruel",
				address2 = "El sol",
				district = "Distrito 2",
				postal_code = "00045",
				telefono = "05269784654"

			};
			Address direc3 = new Address()
			{
				address = "Av de los Shyris",
				address2 = "el coemrcio",
				district = "Distrito 3",
				postal_code = "0002555",
				telefono = "0526974668"

			};
			Address direc4 = new Address()
			{
				address = "Telegrafo",
				address2 = "Ultima notivcia",
				district = "Distrito 4",
				postal_code = "000254654",
				telefono = "0546846846"

			};

			Store tienda1 = new Store()
			{
				staffs = new List<Staff>(){ empleado1, empleado2, empleado3, jefe1 },
				addresses =new List<Address>() {direc1 }				
			};
			Store tienda2 = new Store()
			{
				staffs = new List<Staff>() { empleado4, empleado5, empleado6, jefe2 },
				addresses = new List<Address>() { direc2 }
			};
			Store tienda3 = new Store()
			{
				staffs = new List<Staff>() { empleado7, empleado8, jefe3 },
				addresses = new List<Address>() { direc3 }
			};
			Store tienda4 = new Store()
			{
				staffs = new List<Staff>() { empleado10, empleado9, jefe4 },
				addresses = new List<Address>() { direc4 }
			};


		}
	}
	
}
