using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan_4
{
    public class CHocSinh
    {
        private string m_mshs;
        private string m_hoten;
        private DateTime m_ngaysinh;
        private string m_phai;
        private string m_diachi;

        public string MSHS
        {
            get { return m_mshs; }
            set { m_mshs = value; }
        }
        public string HoTen
        {
            get { return m_hoten; }
            set { m_hoten = value; }
        }
        public DateTime NgaySinh
        {
            get { return m_ngaysinh; }
            set { m_ngaysinh = value; }
        }
        public string Phai
        {
            get { return m_phai; }
            set { m_phai = value; }
        }
        public string DiaChi
        {
            get { return m_diachi; }
            set { m_diachi = value; }
        }

        public CHocSinh()
        {
            m_mshs = "";
            m_hoten = "";
            m_ngaysinh = new DateTime(1960, 12, 25);
            m_phai = "";
            m_diachi = "";
        }
        public CHocSinh(string hs, string ht, DateTime ns, string p, string dc)
        {
            m_mshs = hs;
            m_hoten = ht;
            m_ngaysinh = ns;
            m_phai = p;
            m_diachi = dc;
        }
    }
}
