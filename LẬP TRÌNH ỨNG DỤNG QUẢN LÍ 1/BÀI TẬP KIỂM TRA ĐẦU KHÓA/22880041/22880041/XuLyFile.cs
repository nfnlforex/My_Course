using System;
using Newtonsoft.Json;
namespace _22880041
{
    public class XuLyFile
    {
        public static string getlink()
        {
            var path = "LuuTru/fileData.txt";
            var fullpath = Path.GetFullPath(path);
            return fullpath;
        }
        public static SanPham[] DocDuLieu()
        {
            SanPham[] ds;
            StreamReader file = new StreamReader(getlink());
            int n;
         
			n = int.Parse(file.ReadLine());
		 if(n>0)
            {
				ds = new SanPham[n];
				for (int i = 0; i < ds.Length; i++)
				{
					string s = file.ReadLine();
					SanPham sp;
					string[] m = s.Split(",");
					sp.MaSp = int.Parse(m[0]);
					sp.TenSp = m[1];
					sp.Loai = m[2];
					sp.Gia = int.Parse(m[3]);
					sp.HSD = m[4];
					sp.SoLuong = int.Parse(m[5]);
					ds[i] = sp;
				}
			}
            else
            {
				ds = new SanPham[0];
			}
	

			file.Close();
			return ds;
	            
        }


        public static void LuuDanhSach(SanPham[] ds)
        {
            StreamWriter file = new StreamWriter(getlink());
            file.WriteLine(ds.Length);
            for (int i = 0; i < ds.Length; i++)
            {
                file.WriteLine($"{ds[i].MaSp},{ds[i].TenSp},{ds[i].Loai},{ds[i].Gia},{ds[i].HSD},{ds[i].SoLuong}");
            }
            file.Close();

        }
        public static void ThemSanPham(SanPham s)
        {
            SanPham[] ds = DocDuLieu();
            // them san pham vao cuoi danh sach
            SanPham[] dsMoi = new SanPham[ds.Length + 1];
            for (int i = 0; i < ds.Length; i++)
            {
                dsMoi[i] = ds[i];
            }
            dsMoi[dsMoi.Length - 1] = s;
            LuuDanhSach(dsMoi);

        }
        public static void XoaSanPham(int MaSp)
        {
            SanPham[] ds = DocDuLieu();
            SanPham[] dsMoi = new SanPham[ds.Length - 1];
            int n = 0;
            for(int i = 0;i < ds.Length;i++) 
            {
                if (ds[i].MaSp!= MaSp)
                {
                    n++;
                    dsMoi[n - 1] = ds[i];
                }
            }
            LuuDanhSach(dsMoi);
        }
        public static void SuaSanPham(SanPham sp)
        {
            SanPham[] ds = DocDuLieu();
            for (int i = 0;i<ds.Length;i++)
            {
                if (ds[i].MaSp==sp.MaSp)
                {
                    ds[i] = sp; break;
                }
            }
            LuuDanhSach(ds);
        }

    }
}
      
