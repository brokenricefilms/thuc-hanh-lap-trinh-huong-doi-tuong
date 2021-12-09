using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_8_thuc_hanh_1_window_blue_screen_fak
{
    internal class ClassNhaSanXuat
    {
        private string _tenNhaSanXuat;
        private string _maNhaSanXuat;
        private string _soDienthoai;
        private string _diaChi;

        public ClassNhaSanXuat()
        {
            this._tenNhaSanXuat = "";
            this._maNhaSanXuat = "";
            this._soDienthoai = "";
            this._diaChi = "";
        }

        public ClassNhaSanXuat(string _tenNhaSanXuat, string _maNhaSanXuat, string _soDienThoai, string _diaChi)
        {
            this._tenNhaSanXuat = "";
            this._maNhaSanXuat = "";
            this._soDienthoai = "";
            this._diaChi = "";
        } 

        public string TenNhaSanXuat { get => _tenNhaSanXuat; set => _tenNhaSanXuat = value; }
        public string MaNhaSanXuat { get => _maNhaSanXuat; set => _maNhaSanXuat = value; }
        public string SoDienThoai { get => _soDienthoai; set => _soDienthoai = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
    }
}
