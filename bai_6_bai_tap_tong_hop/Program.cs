using System;
using System.Collections.Generic;

namespace bai_6_bai_tap_tong_hop {
  class Program {
    static int demSoThiSinhKhoiNangkhieu(List<ClassThiSinh> ds) {
      int dem = 0;

      foreach (ClassThiSinh ts in ds) {
        if (ts.laKhoiNangKhieu() == true)
          dem++;
      }

      return dem;
    }
    static List<ClassThiSinh> getDSThiSinhKhoiA(List<ClassThiSinh> ds) {
      List<ClassThiSinh> ts = new List<ClassThiSinh>();
      foreach (ClassThiSinh i in ds) {
        if (i is ClassKhoiA)
          ts.Add(i);
      }
      return ts;
    }
    static double getDiemLonNhatKhoiA(List<ClassThiSinh> ds) {
      double m = 0;
      foreach (ClassThiSinh i in ds) {
        if (i is ClassKhoiA) {
          if (i.TongDiem() > m)
            m = i.TongDiem();
        }
      }
      return m;
    }
    static List<ClassThiSinh> getDSThiSinhDat(List<ClassThiSinh> ds) {
      List<ClassThiSinh> tmp = new List<ClassThiSinh>();
      foreach (ClassThiSinh i in ds) {
        if (i.KetQua() == KieuKetQua.Dat) {
          tmp.Add(i);
        }
      }
      return tmp;
    }

    static void Main(string[] args) {
      List<ClassThiSinh> dsts = new List<ClassThiSinh>();
      List<ClassThiSinh> n = new List<ClassThiSinh>();
      dsts.Add(new ClassKhoiA("001", "abc1", 5, 6, 7));
      dsts.Add(new ClassKhoiA("002", "abc2", 1, 2, 7));
      dsts.Add(new ClassKhoiA("003", "abc3", 6, 2, 8));
      dsts.Add(new ClassKhoiNangKhieu("004", "abc4", 6, 8));
      dsts.Add(new ClassKhoiNangKhieu("005", "abc5", 9, 8));

      Console.WriteLine("\nSo thi sinh thuoc khoi nang khieu la " +
                        demSoThiSinhKhoiNangkhieu(dsts));

      Console.WriteLine("\nDanh sach thi sinh Khoi A:\n");
      foreach (ClassThiSinh ts in getDSThiSinhKhoiA(dsts)) {
        Console.WriteLine(ts.MaThiSinh + " - " + ts.Hoten);
      }
      Console.WriteLine("Diem lon nhat la" + getDiemLonNhatKhoiA(dsts));
      Console.ReadLine();
    }
  }
}
