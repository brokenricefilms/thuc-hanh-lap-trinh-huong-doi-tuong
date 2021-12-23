using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy
{
    class CTruycapDL
    {
        private static CTruycapDL m_data = null;
        private static List<CNhanVien> m_dsNV;
        public CTruycapDL()
        {
            m_dsNV = new List<CNhanVien>();

        }
        public static CTruycapDL KhoiTao()
        {
            if (m_data == null)
                m_data = new CTruycapDL();
            return m_data;
        }
        public List<CNhanVien> getdsNV()
        {
            return m_dsNV;
        }
    }
}
