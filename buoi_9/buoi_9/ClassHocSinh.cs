using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_9
{
  [Serializable]

  class ClassHocSinh
  {
    private string _ma;
    private string _hoTen;
    private DateTime _ngaySinh;
    private string _gioiTinh;
    private float _diemMon1;
    private float _diemMon2;
    private float _ketQua;

    public string Ma { get => _ma; set => _ma = value; }
    public string HoTen { get => _hoTen; set => _hoTen = value; }
    public DateTime NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
    public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
    public float DiemMon1 { get => _diemMon1; set => _diemMon1 = value; }
    public float DiemMon2 { get => _diemMon2; set => _diemMon2 = value; }
    public float KetQua { get => _ketQua; set => _ketQua = value; }

    public ClassHocSinh()
    {
      _ma = "";
      _hoTen = "";
      _ngaySinh = DateTime.Today;
      _gioiTinh = "";
      _diemMon1 = 0;
      _diemMon2 = 0;
      _ketQua = 0;
    }

    public ClassHocSinh(string ma, string hoTen, DateTime ngaySinh, string gioiTinh, float diemMon1, float diemMon2, float ketQua)
    {
      _ma = ma;
      _hoTen = hoTen;
      _ngaySinh = ngaySinh;
      _gioiTinh = gioiTinh;
      _diemMon1 = diemMon1;
      _diemMon2 = diemMon2;
      _ketQua = ketQua;
    }

  }
}