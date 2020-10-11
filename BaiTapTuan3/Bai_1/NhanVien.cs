using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
	class NhanVien : CanBo
	{

		private string job;

		public NhanVien(string name, int age, string gender, string address, string job)
			: base(name, age, gender, address)
		{
			this.Job = job;
		}

		public string Job { get => job; set => job = value; }

		public new void Display()
		{
			Console.WriteLine("Nhan vien:\n Ho ten: {0} | Tuoi: {1} | Gioi tinh: {2} | Dia chi: {3} | Cong viec: {4}",
								Name, Age, Gender, Address, Job);
		}

	}
}
