using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryHocSinh
{
    [Serializable]
    public class CHocSinh
    {
        private string m_tensv, m_masv, m_diachi, m_phai;
        private DateTime m_ngaysinh;
        public string TenSV
        {
            get { return m_tensv; }
            set { m_tensv = value; }
        }
        public string MaSV
        {
            get { return m_masv; }
            set { m_masv = value; }
        }
        public string DiaChi
        {
            get { return m_diachi; }
            set { m_diachi = value; }
        }
        public string Phai
        {
            get { return m_phai; }
            set { m_phai = value; }
        }
        public DateTime NgaySinh
        {
            get { return m_ngaysinh; }
            set { m_ngaysinh = value; }
        }
        public CHocSinh()
        {
            m_tensv = "";
            m_masv = "";
            m_diachi = "";
            m_phai = "";
            m_ngaysinh = DateTime.Now;
        }
        public CHocSinh(string tensv, string masv, string diachi, string phai, DateTime ngaysinh)
        {
            m_tensv = tensv;
            m_masv = masv;
            m_diachi = diachi;
            m_phai = phai;
            m_ngaysinh = ngaysinh;
        }
    }
}
