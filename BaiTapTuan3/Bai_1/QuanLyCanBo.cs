using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
	class QuanLyCanBo //: CanBo
	{
		public List<CanBo> dsCANBO;
		public QuanLyCanBo()
		{
			this.dsCANBO = new List<CanBo>();
		}

		public void ThemCanBo(CanBo canbo)
		{
			this.dsCANBO.Add(canbo);
		}
		/*
		public List<CanBo> timCanBoTheoTen(string name)
		{
			return dsCANBO.Contains(ToString(name));
			
		}
			*/
		public void HienThiDanhSachCanBo()
		{
			//this.CANBO
			foreach(CanBo cb in dsCANBO)
			{
				cb.Display();
			}
			Console.ReadLine();
		}

	}
}
