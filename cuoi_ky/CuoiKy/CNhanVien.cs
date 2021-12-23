using System;

namespace CuoiKy
{
  [Serializable]
  public class CNhanVien
  {
    private string m_MaNV;
    private string m_TenNV;
    private DateTime m_NgaySinh;
    private bool m_Phai;
    private double m_Luong;
    private double m_LuongCoBan;
    private double m_TongLuong;

    public string MaNV { get => m_MaNV; set => m_MaNV = value; }
    public string TenNV { get => m_TenNV; set => m_TenNV = value; }
    public DateTime NgaySinh { get => m_NgaySinh; set => m_NgaySinh = value; }
    public bool Phai { get => m_Phai; set => m_Phai = value; }
    public double Luong { get => m_Luong; set => m_Luong = value; }
    public double LuongCoBan { get => m_LuongCoBan; set => m_LuongCoBan = value; }
    public double TongLuong { get => m_TongLuong; set => m_TongLuong = value; }

    public CNhanVien(string MaNV, string TenNV, DateTime ngaySinh, bool phai, double luong, double luongCoBan, double tongLuong)
    {
      m_MaNV = MaNV;
      m_TenNV = TenNV;
      m_NgaySinh = ngaySinh;
      m_Phai = phai;
      m_Luong = luong;
      m_LuongCoBan = luongCoBan;
      m_TongLuong = tongLuong;
    }

    public CNhanVien()
    {
      m_MaNV = "";
      m_TenNV = "";
      m_NgaySinh = DateTime.Today;
      m_Phai = false;
      m_Luong = 0;
      m_LuongCoBan = 0;
      m_TongLuong = 0;
    }

  }
}
