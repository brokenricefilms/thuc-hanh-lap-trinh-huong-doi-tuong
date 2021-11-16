using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable] public class CHocSinh
    {
        private string m_mshs, m_hoten, m_diachi;
        private DateTime m_ngaysinh;
        private string m_phai;
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
        public string DiaChi
        {
            get { return m_diachi; }
            set { m_diachi = value; }
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
        public CHocSinh()
        {
            m_mshs = "";
            m_hoten = "";
            m_diachi = "";
            m_phai = "";
            m_ngaysinh = DateTime.Now;     
        }
        public CHocSinh(string ma, string hoten, string diachi, string phai, DateTime ngaysinh)
        {
            m_mshs = ma;
            m_hoten = hoten;
            m_diachi = diachi;
            m_phai = phai;
            m_ngaysinh = ngaysinh;
        }
    }
}
