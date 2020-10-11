using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
	abstract class CongNhan : CanBo
	{
	
		private int level;
		public int Level { get => level; set => level = value; }

		public CongNhan(string name, int age,  string gender, string address, int level) 
			: base(name, age, gender, address) 
		{
			this.level = level;
		}
		

		public override string ToString()
		{
			 return String.Format("Cong nhan:\n Ho ten: {0} | Tuoi: {1} | Gioi tinh: {2} | Dia chi: {3} | Cap bac: {4}/7",
				Name, Age, Gender, Address, level);
		}

	}
}
