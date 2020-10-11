using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
	class CanBo
	{
		
		private string name;
		private int age;
		private string gender;
		private string address;

		protected string Name { get => name; set => name = value; }
		protected int Age { get => age; set => age = value; }
		protected string Gender { get => gender; set => gender = value; }
		protected string Address { get => address; set => address = value; }

		public CanBo()
		{
			Name = "";
			Age = 0;
			Gender = "";
			Address = "";
		}

		public CanBo(string name, int age, string gender, string address)
		{
			this.name = name;
			this.age = age;
			this.gender = gender;
			this.address = address;
		}

		public string ToString() { }

	}
}
