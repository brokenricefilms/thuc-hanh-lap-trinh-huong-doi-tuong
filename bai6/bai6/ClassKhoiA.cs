using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    public class ClassKhoiA : ClassThiSinh
    {
        protected double _diemToan;
        protected double _diemLy;
        protected double _diemHoa;
        public double DiemToan
        {
            get { return _diemToan; }
            set { _diemToan = value; }
        }
        public double DiemLy
        {
            get { return _diemLy; }
            set { _diemLy = value; }
        }
        public double DiemHoa
        {
            get { return _diemHoa; }
            set { _diemHoa = value; }
        }
        public ClassKhoiA(){
            _diemToan = 0;
            _diemHoa = 0;
            _diemLy = 0;
        }
        public ClassKhoiA(string ma, string ht, double toan, double ly, double hoa){
            _maTs = ma;
            _hoTen = ht;
            _diemToan = toan;
            _diemLy = ly;
            _diemHoa = hoa;
        }
        public override double TongDiem()
        {
            return _diemToan + _diemLy + _diemHoa;
        }
        public override KieuKetQua KetQua()
        {
            if (_diemHoa + _diemLy + _diemToan >= 18.5)
            {
            }
        }
        public override bool laKhoiA()
        {
            return true;
        }
        public override bool laKhoiNangKhieu()
        {
            return false;
        }
    }
}
