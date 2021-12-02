using System;
using System.Collections.Generic;

namespace bai_6_bai_tap_tong_hop {
  class Program {
    static int demSoThiSinhKhoiNangkhieu(List<ClassThiSinh> danhSach) {
      int count = 0;
      foreach (ClassThiSinh thiSinh in danhSach) {
        if (thiSinh.laKhoiNangKhieu() == true) {
          count++;
        }
      }
      return count;
    }

    static int demSoThiSinhKhoiA(List<ClassThiSinh> danhSach) {
      int count = 0;
      foreach (ClassThiSinh thiSinh in danhSach) {
        if (thiSinh.laKhoiA() == true) {
          count++;
        }
      }
      return count;
    }

    static List<ClassThiSinh> getDanhSachThiSinhKhoiNangKhieu(List<ClassThiSinh> danhSach) {
      List<ClassThiSinh> thiSinh = new List<ClassThiSinh>();
      foreach (ClassThiSinh i in danhSach) {
        if (i is ClassKhoiNangKhieu) {
          thiSinh.Add(i);
        }
      }
      return thiSinh;
    }

    static List<ClassThiSinh> getDanhSachThiSinhKhoiA(List<ClassThiSinh> danhSach) {
      List<ClassThiSinh> thiSinh = new List<ClassThiSinh>();
      foreach (ClassThiSinh i in danhSach) {
        if (i is ClassKhoiA) {
          thiSinh.Add(i);
        }
      }
      return thiSinh;
    }

    static double getDiemLonNhatKhoiA(List<ClassThiSinh> danhSach) {
      double max = 0;
      foreach (ClassThiSinh i in danhSach) {
        if (i is ClassKhoiA) {
          if (i.TongDiem() > max) {
            max = i.TongDiem();
          }
        }
      }
      return max;
    }

    static double getDiemLonNhatKhoiNangKhieu(List<ClassThiSinh> danhSach) {
      double max = 0;
      foreach (ClassThiSinh i in danhSach) {
        if (i is ClassKhoiNangKhieu) {
          if (i.TongDiem() > max) {
            max = i.TongDiem();
          }
        }
      }
      return max;
    }

    static List<ClassThiSinh> getDanhSachThiSinhDat(List<ClassThiSinh> danhSach) {
      List<ClassThiSinh> tmp = new List<ClassThiSinh>();
      foreach (ClassThiSinh i in danhSach) {
        if (i.KetQua() == KieuKetQua.Dat) {
          tmp.Add(i);
        }
      }
      return tmp;
    }

    static List<ClassThiSinh> getDanhSachThiSinhKhongDat(List<ClassThiSinh> danhSach) {
      List<ClassThiSinh> tmp = new List<ClassThiSinh>();
      foreach (ClassThiSinh i in danhSach) {
        if (i.KetQua() == KieuKetQua.KhongDat) {
          tmp.Add(i);
        }
      }
      return tmp;
    }

    // @todo use ClassKhoiNangKhieu
    // static List<ClassThiSinh> getDanhSachThiSinhNangKhieuKhongDat(List<ClassThiSinh> danhSach) {
    // List<ClassThiSinh> tmp = new List<ClassThiSinh>();
    // foreach (ClassThiSinh i in danhSach) {
    // if (i is ClassKhoiNangKhieu && i.KetQua() == KieuKetQua.KhongDat) {
    // tmp.Add(i);
    // }
    // }
    // return tmp;
    // }

    static List<ClassKhoiNangKhieu> getDanhSachThiSinhNangKhieuKhongDat(
        List<ClassThiSinh> danhSach) {
      List<ClassKhoiNangKhieu> tmp = new List<ClassKhoiNangKhieu>();
      foreach (ClassThiSinh i in danhSach) {
        if (i is ClassKhoiNangKhieu && i.KetQua() == KieuKetQua.KhongDat) {
          tmp.Add(i);
        }
      }
      return tmp;
    }

    // static List<ClassThiSinh> getDanhSachThiSinhKhoiAdiemLiet(List<ClassThiSinh> danhSach) {
    // List<ClassThiSinh> tmp = new List<ClassThiSinh>();
    // foreach (ClassThiSinh i in danhSach) {
    // if (i is ClassKhoiA && i.DiemToan() <= 1) {
    // tmp.Add(i);
    // }
    // }
    // return tmp;
    // }

    static void Main(string[] args) {
      List<ClassThiSinh> danhSachThiSinh = new List<ClassThiSinh>();

      // data gia phả nồi giống Thuận Bá Vương
      danhSachThiSinh.Add(new ClassKhoiA("dh51", "Thuận ngiu ngốc", 3, 3, 3));
      danhSachThiSinh.Add(new ClassKhoiA("dh52", "Thuận cái bang", 1, 1.5, 2));
      danhSachThiSinh.Add(new ClassKhoiA("dh53", "Thuận tính nam", 7, 7, 7.5));
      danhSachThiSinh.Add(new ClassKhoiNangKhieu("dh54", "Thuận tham ngủ", 10, 0));
      danhSachThiSinh.Add(new ClassKhoiNangKhieu("dh55", "Thuận đẹp trai", 10, 10));
      danhSachThiSinh.Add(new ClassKhoiNangKhieu("dh56", "Thuận siêu cute", 9.5, 10));

      Console.WriteLine("\nDanh sách thí sinh khối năng khiếu:");
      Console.WriteLine("-----------------------------");
      Console.WriteLine("Mã thí sinh" + " | " + "Họ và tên");
      Console.WriteLine("-----------------------------");
      foreach (ClassThiSinh thiSinh in getDanhSachThiSinhKhoiNangKhieu(danhSachThiSinh)) {
        Console.WriteLine(thiSinh.MaThiSinh + "        | " + thiSinh.Hoten);
      }
      Console.WriteLine("→ Số thí sinh thuộc khối năng khiếu = " +
                        demSoThiSinhKhoiNangkhieu(danhSachThiSinh));
      Console.WriteLine("→ Điểm lớn nhất là " + getDiemLonNhatKhoiNangKhieu(danhSachThiSinh));

      Console.WriteLine("\nDanh sách thí sinh khối A");
      Console.WriteLine("-----------------------------");
      Console.WriteLine("Mã thí sinh" + " | " + "Họ và tên");
      Console.WriteLine("-----------------------------");
      foreach (ClassThiSinh thiSinh in getDanhSachThiSinhKhoiA(danhSachThiSinh)) {
        Console.WriteLine(thiSinh.MaThiSinh + "        | " + thiSinh.Hoten);
      }
      Console.WriteLine("→ Số thí sinh thuộc khối A = " + demSoThiSinhKhoiA(danhSachThiSinh));
      Console.WriteLine("→ Điểm lớn nhất là " + getDiemLonNhatKhoiA(danhSachThiSinh));

      Console.WriteLine("\nDanh sách thí sinh đạt");
      Console.WriteLine("-----------------------------");
      Console.WriteLine("Mã thí sinh" + " | " + "Họ và tên");
      Console.WriteLine("-----------------------------");
      foreach (ClassThiSinh thiSinh in getDanhSachThiSinhDat(danhSachThiSinh)) {
        Console.WriteLine(thiSinh.MaThiSinh + "        | " + thiSinh.Hoten);
      }

      Console.WriteLine("\nDanh sách thí sinh không đạt");
      Console.WriteLine("-----------------------------");
      Console.WriteLine("Mã thí sinh" + " | " + "Họ và tên");
      Console.WriteLine("-----------------------------");
      foreach (ClassThiSinh thiSinh in getDanhSachThiSinhKhongDat(danhSachThiSinh)) {
        Console.WriteLine(thiSinh.MaThiSinh + "        | " + thiSinh.Hoten);
      }

      Console.WriteLine("\nDanh sách thí sinh năng khiếu không đạt");
      Console.WriteLine("-----------------------------");
      Console.WriteLine("Mã thí sinh" + " | " + "Họ và tên");
      Console.WriteLine("-----------------------------");
      foreach (ClassThiSinh thiSinh in getDanhSachThiSinhNangKhieuKhongDat(danhSachThiSinh)) {
        Console.WriteLine(thiSinh.MaThiSinh + "        | " + thiSinh.Hoten);
      }

      // Console.WriteLine("\nDanh sách thí sinh Khối A bị điểm liệt");
      // Console.WriteLine("-----------------------------");
      // Console.WriteLine("Mã thí sinh" + " | " + "Họ và tên");
      // Console.WriteLine("-----------------------------");
      // foreach (ClassThiSinh thiSinh in getDanhSachThiSinhKhoiADiemLiet(danhSachThiSinh)) {
      // Console.WriteLine(thiSinh.MaThiSinh + "        | " + thiSinh.Hoten);
      // }
    }
  }
}
