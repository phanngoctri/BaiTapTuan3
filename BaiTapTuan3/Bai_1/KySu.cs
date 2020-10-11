using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
	class KySu : CanBo
	{
		
		private string branch;
		public KySu(string name, int age, string gender, string address, string branch)
			: base(name, age, gender, address)
		{
			this.Branch = branch;
		}

		public string Branch { get => branch; set => branch = value; }

		public new void Display()
		{
			Console.WriteLine("Ky su:\n Ho ten: {0} | Tuoi: {1} | Gioi tinh: {2} | Dia chi: {3} | Nghanh dao tao: {4}",
								Name, Age, Gender, Address, Branch);
		}
	}
}
