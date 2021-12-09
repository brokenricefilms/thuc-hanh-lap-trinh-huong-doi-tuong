using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_8_thuc_thanh_1
{
    internal class ClassTruyCapDuLieu
    {
        private static ClassTruyCapDuLieu m_data = null;
        private List<ClassHangHoa> _danhSachHangHoa;
        private List<ClassNhaSanXuat> _danhSachNhaSanXuat;

        public ClassTruyCapDuLieu()
        {
            _danhSachHangHoa = new List<ClassHangHoa>();
            _danhSachNhaSanXuat = new List<ClassNhaSanXuat>();
        }

        public static ClassTruyCapDuLieu khoitao()
        {
            if (m_data == null)
                m_data = new ClassTruyCapDuLieu();
            return m_data;
        }

        public List<ClassHangHoa> getDanhSachHangHoa()
        {
            return _danhSachHangHoa;
        }

        public List<ClassNhaSanXuat> getDanhSachNhaSanXuat()
        {
            return _danhSachNhaSanXuat;
        }
    }
}
