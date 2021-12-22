using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocSinh
{
  [Serializable]
  public class CHocSinh
  {
    private string m_MaHS;
    private string m_HoTen;
    private DateTime m_NgaySinh;
    private bool m_Phai;
    private string m_DiaChi;
    private double m_DiemMon1;
    private double m_DiemMon2;
    private string m_KetQua;


    public string MaHS { get => m_MaHS; set => m_MaHS = value; }
    public string HoTen { get => m_HoTen; set => m_HoTen = value; }
    public DateTime NgaySinh { get => m_NgaySinh; set => m_NgaySinh = value; }
    public bool Phai { get => m_Phai; set => m_Phai = value; }
    public string DiaChi { get => m_DiaChi; set => m_DiaChi = value; }
    public double DiemMon1 { get => m_DiemMon1; set => m_DiemMon1 = value; }
    public double DiemMon2 { get => m_DiemMon2; set => m_DiemMon2 = value; }
    public string KetQua { get => m_KetQua; set => m_KetQua = value; }

    public CHocSinh(string maHS, string hoTen, DateTime ngaySinh, bool phai, string diaChi, double diemMon1, double diemMon2, string ketQua)
    {
      m_MaHS = maHS;
      m_HoTen = hoTen;
      m_NgaySinh = ngaySinh;
      m_Phai = phai;
      m_DiaChi = diaChi;
      m_DiemMon1 = diemMon1;
      m_DiemMon2 = diemMon2;
      m_KetQua = ketQua;
    }

    public CHocSinh()
    {
      m_MaHS = "";
      m_HoTen = "";
      m_NgaySinh = DateTime.Today;
      m_Phai = false;
      m_DiaChi = "";
      m_DiemMon1 = 0;
      m_DiemMon2 = 0;
      m_KetQua = "";
    }

  }
}
