using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_8_thuc_hanh_1_window_blue_screen_fak
{
    class ClassXuLyHangHoa
    {
        private List<ClassHangHoa> danhSach;
        public ClassXuLyHangHoa()
        {
            ClassTruyCapDuLieu truyCap = ClassTruyCapDuLieu.khoitao();
            danhSach = truyCap.getDanhSachHangHoa();
        }
        public List<ClassHangHoa> getdanhSachHangHoa()
        {
            return danhSach;
        }
        public ClassHangHoa tim(string ma)
        {
            foreach (ClassHangHoa i in danhSach)
                if (i.MaHang == ma)
                    return i;
            return null;
        }
        public void them(ClassHangHoa a)
        { 
                danhSach.Add(a);

        }
        public void xoa(string mahang)
        {
            ClassHangHoa h = tim(mahang);
          
            danhSach.Remove(h);
         
        }
        public void sua(ClassHangHoa a)
        {
            ClassHangHoa h = tim(a.MaHang);
            h.TenHang = a.TenHang;
            h.DonGia = a.DonGia;
            h.DonViTinh = a.DonViTinh;
            
        }

    }
}
