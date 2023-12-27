namespace _22880041
{
    public class NghiepVu
    {

        public static void XoaSanPham(int MaSp)
        {
            XuLyFile.XoaSanPham(MaSp);
        }
        public static string CapNhapSanPham(SanPham s)
        {
            string kq = string.Empty;
            if (s.MaSp < 0
                || string.IsNullOrEmpty(s.TenSp)
                || string.IsNullOrEmpty(s.Loai)
                || s.Gia < 0
                || string.IsNullOrEmpty(s.HSD)
                || s.SoLuong < 0
                )
            {
                kq = "Du lieu khong hop le";
            }
            else
            {
                XuLyFile.SuaSanPham(s);
                kq = "Da luu thanh cong";

            }
            return kq;
        }
        public static string ThemSanPham(SanPham s)
        {
            string kq = string.Empty;
            if (
                s.MaSp < 0
            || string.IsNullOrEmpty(s.TenSp)
            || string.IsNullOrEmpty(s.Loai)
            || s.Gia < 0
            || string.IsNullOrEmpty(s.HSD)
            || s.SoLuong < 0
                )
            {
                kq = "Du lieu khong hop le";
            }
            else
            {
                XuLyFile.ThemSanPham(s);
                kq = "Da them thanh cong";
            }
            return kq;
        }
        public static SanPham? DocSanPham(int MaSp)
        {
            SanPham[] ds = XuLyFile.DocDuLieu();
            foreach (SanPham s in ds)
            {
                if (s.MaSp == MaSp)
                {
                    return s;
                }
            }
            return null;

        }
        public static string SuaSanPham(SanPham s)
        {
            string kq = string.Empty;
			if (
			   s.MaSp < 0
		   || string.IsNullOrEmpty(s.TenSp)
		   || string.IsNullOrEmpty(s.Loai)
		   || s.Gia < 0
		   || string.IsNullOrEmpty(s.HSD)
		   || s.SoLuong < 0
			   )
			{
				kq = "Du lieu khong hop le";
			}
			else
			{
				XuLyFile.SuaSanPham(s);
				kq = "Da cap nhap thanh cong";
			}
            return kq;
		}
    }
}
