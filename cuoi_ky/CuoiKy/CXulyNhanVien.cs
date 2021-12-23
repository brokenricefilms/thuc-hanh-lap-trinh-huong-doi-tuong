using System.Collections.Generic;
using System.Linq;

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
    }

    public void sua(CNhanVien nv)
    {
      CNhanVien n = tim(nv.MaNV);
        n.TenNV = nv.TenNV;
        n.NgaySinh = nv.NgaySinh;
        n.Phai = nv.Phai;
        n.Luong = nv.Luong;
        n.LuongCoBan = nv.LuongCoBan;
        n.TongLuong = nv.TongLuong;
    }
  }
}
