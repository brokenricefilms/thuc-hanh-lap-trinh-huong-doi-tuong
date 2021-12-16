using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_9
{
  [Serializable]
  class ClassTruyCapDuLieu
  {
    private static ClassTruyCapDuLieu instance = null;

    private List<ClassHocSinh> danhSachHocSinh;

    private ClassTruyCapDuLieu()
    {
      danhSachHocSinh = new List<ClassHocSinh>();
    }

    public List<ClassHocSinh> GetDanhSachHocsinh()
    {
      return danhSachHocSinh;
    }

    //public static bool DocFile(string tenFile) { }
    //public static bool GhiFile(string tenFile) { }
  }
}