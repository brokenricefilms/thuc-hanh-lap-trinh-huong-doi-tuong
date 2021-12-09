using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_8_thuc_hanh_1_window_blue_screen_fak
{
    class ClassHangHoa
    {
        private string _maHang;
        private string _tenHang;
        private string _donViTinh;
        private double _donGia;

        public ClassHangHoa()
        {
            this._maHang = "";
            this._tenHang = "";
            this._donViTinh= "";
            this._donGia = 0;
        }

        public ClassHangHoa(string _maHang, string _tenHang, string _donViTinh, double _donGia)
        {
            this._maHang = _maHang;
            this._tenHang = _tenHang;
            this._donViTinh = _donViTinh;
            this._donGia = _donGia;
        }

        public string MaHang { get => _maHang; set => _maHang = value; }
        public string TenHang { get => _tenHang; set => _tenHang = value; }
        public string DonViTinh { get => _donViTinh; set => _donViTinh = value; }       
        public double DonGia { get => _donGia; set => _donGia= value; }
    }
}
