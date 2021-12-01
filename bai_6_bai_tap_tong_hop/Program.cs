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

    static List<ClassThiSinh> getDSThiSinhDat(List<ClassThiSinh> danhSach) {
      List<ClassThiSinh> tmp = new List<ClassThiSinh>();
      foreach (ClassThiSinh i in danhSach) {
        if (i.KetQua() == KieuKetQua.Dat) {
          tmp.Add(i);
        }
      }
      return tmp;
    }

    static void Main(string[] args) {
      List<ClassThiSinh> danhSachThiSinh = new List<ClassThiSinh>();
      List<ClassThiSinh> n = new List<ClassThiSinh>();

      danhSachThiSinh.Add(new ClassKhoiA("dh51", "Nicholas", 5, 5, 5));
      danhSachThiSinh.Add(new ClassKhoiA("dh52", "Nick", 9, 9, 9.5));
      danhSachThiSinh.Add(new ClassKhoiA("dh53", "Nico", 7, 7, 7));
      danhSachThiSinh.Add(new ClassKhoiNangKhieu("dh54", "Thuận good boy", 9.5, 9.5));
      danhSachThiSinh.Add(new ClassKhoiNangKhieu("dh55", "Thuận đẹp trai", 10, 10));
      danhSachThiSinh.Add(new ClassKhoiNangKhieu("dh56", "Thuận siêu cute", 9.5, 10));

      Console.WriteLine("\nDanh sách thí sinh khối năng khiếu:");
      Console.WriteLine("Số thí sinh thuộc khối năng khiếu = " +
                        demSoThiSinhKhoiNangkhieu(danhSachThiSinh));
      foreach (ClassThiSinh thiSinh in getDanhSachThiSinhKhoiNangKhieu(danhSachThiSinh)) {
        Console.WriteLine(thiSinh.MaThiSinh + " - " + thiSinh.Hoten);
      }
      Console.WriteLine("Điểm lớn nhất là " + getDiemLonNhatKhoiNangKhieu(danhSachThiSinh));

      Console.WriteLine("\nDanh sách thí sinh khối A:");
      Console.WriteLine("Số thí sinh thuộc khối A = " + demSoThiSinhKhoiA(danhSachThiSinh));
      foreach (ClassThiSinh thiSinh in getDanhSachThiSinhKhoiA(danhSachThiSinh)) {
        Console.WriteLine(thiSinh.MaThiSinh + " - " + thiSinh.Hoten);
      }
      Console.WriteLine("Điểm lớn nhất là " + getDiemLonNhatKhoiA(danhSachThiSinh));
      Console.ReadLine();
    }
  }
}
