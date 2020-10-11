using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
	class Program
	{
	
		static void Main(string[] args)
		{
			

            QuanLyCanBo QLCB = new QuanLyCanBo();
            while (true)
            {
                Console.WriteLine("----------------- Quan ly can bo -----------------");
                
                Console.WriteLine("1: Nhap can bo ");
                Console.WriteLine("2: Tim kiem can bo theo ten");
                Console.WriteLine("3: Hien danh sach thong tin can bo");
                Console.WriteLine("4: Thoat chuong trinh");
                Console.Write(" ------- Xin moi chon menu: --------");
                int line = int.Parse(Console.ReadLine());
                switch (line)
                {
                    case 1:
                        {
                            Console.WriteLine("Moi chon loai Can bo: ");
                            Console.WriteLine("1: Ky su");
                            Console.WriteLine("2: Cong nhan");
                            Console.WriteLine("3: Nhan vien");
                            int type = int.Parse(Console.ReadLine());
                            switch (type)
                            {
                                case 1:
                                    {
                                        Console.Write("\nNhap ho ten: ");
                                        String name = Console.ReadLine();;
                                        Console.Write("Nhap tuoi:");
                                        int age = int.Parse(Console.ReadLine());;
                                        Console.Write("Nhap gioi tinh: ");
                                        String gender = Console.ReadLine();;
                                        Console.Write("Nhap dia chi: ");
                                        String address = Console.ReadLine();;
                                        Console.Write("Nhap chuyen nganh dao tao: ");
                                        String branch = Console.ReadLine();;
                                        CanBo ks = new KySu(name, age, gender, address, branch);
                                        QLCB.ThemCanBo(ks);
                                        ks.Display();
                                        //Console.ReadLine();
                                        break;

                                    }
                                case 2:
                                    {
                                        Console.Write("\nNhap ho ten: ");
                                        String name = Console.ReadLine();;
                                        Console.Write("Nhap tuoi:");
                                        int age = int.Parse(Console.ReadLine());;
                                        Console.Write("Nhap gioi tinh: ");
                                        String gender = Console.ReadLine();;
                                        Console.Write("Nhap dia chi: ");
                                        String address = Console.ReadLine();;
                                        Console.Write("Nhap cap bac: ");
                                        int level = int.Parse(Console.ReadLine());;
                                        CanBo cn = new CongNhan(name, age, gender, address, level);
                                        QLCB.ThemCanBo(cn);
                                        cn.Display();
                                        //Console.ReadLine();
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write("\nNhap ho ten: ");
                                        String name = Console.ReadLine();;
                                        Console.Write("Nhap tuoi: ");
                                        int age = int.Parse(Console.ReadLine());;
                                        Console.Write("Nhap gioi tinh: ");
                                        String gender = Console.ReadLine();;
                                        Console.Write("Nhap dia chi: ");
                                        String address = Console.ReadLine();;
                                        Console.Write("Nhap cong viec: ");
                                        String task = Console.ReadLine();;
                                        CanBo nv = new NhanVien(name, age, gender, address, task);
                                        QLCB.ThemCanBo(nv);
                                        nv.Display();
                                        //Console.ReadLine();
                                        break;
                                    }
                                default:
                                    Console.WriteLine("Nhap sai! Ban vui long nhap lai");
                                    break;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Nhap ten can bo can tim: ");
                            String name = Console.ReadLine();
                           // QuanLyCanBo.timCanBoTheoTen(name).foreach(CanBo
                             //   Console.WriteLine(CanBo.);
                            
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Danh sach can bo da nhap: ");
                            QLCB.HienThiDanhSachCanBo();
                            break;
                        }
                    case 4:
                        {
                            return;
                        }
                    default:
                        Console.WriteLine("Invalid");
                        continue;
                }

            }


        }
    }
}
