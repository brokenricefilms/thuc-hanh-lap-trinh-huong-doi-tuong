using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CuoiKy
{
  public class CXulyNhanVien
  {
    private List<CNhanVien> dsNV;

    public CXulyNhanVien()
    {
      dsNV = CTruycapDL.KhoiTao().getdsNV();
    }

    public List<CNhanVien> getDSNhanVien()
    {
      return dsNV.ToList();
    }

    public CNhanVien tim(string msnv)
    {
      foreach (CNhanVien nv in dsNV)
      {
        if (nv.MaNV == msnv)
          return nv;
      }
      return null;
    }

    public void them(CNhanVien nv)
    {
      CNhanVien n = new CNhanVien();
      if (tim(nv.MaNV) == null)
      {
        dsNV.Add(nv);
      }
      else
        MessageBox.Show("Mã nhân viên" + nv.MaNV + " đã tồn tại");
    }

    public void sua(CNhanVien nv)
    {
      CNhanVien n = tim(nv.MaNV);
      if (n == null)
      {
        MessageBox.Show("Mã nhân viên không tồn tại");
      }
      else
      {
        n.TenNV = nv.TenNV;
        n.NgaySinh = nv.NgaySinh;
        n.Phai = nv.Phai;
        n.Luong = nv.Luong;
        n.LuongCoBan = nv.LuongCoBan;
        n.TongLuong = nv.TongLuong;
      }
    }
  }
}
