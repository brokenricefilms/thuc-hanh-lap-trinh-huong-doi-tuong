using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    public enum KieuKetQua { Dat, KhongDat }
    public class ClassThiSinh
    {
        protected string _maTs;
        protected string _hoTen;
        public string maTs
        {
            get { return _maTs; }
            set { _maTs = value; }
        }
        public string Hoten
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        public ClassThiSinh()
        {
            _maTs = "";
            _hoTen = "";
        }
        public ClassThiSinh(string ma, string ht)
        {
            _maTs = ma;
            _hoTen = ht;
        }
        public virtual double TongDiem()
        {
            return 0;
        }
        public virtual KieuKetQua KetQua()
        {
            return KieuKetQua.KhongDat;
        }
    }
}
