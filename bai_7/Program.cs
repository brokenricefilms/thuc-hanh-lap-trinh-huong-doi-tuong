using System;
using System.Collections.Generic;

namespace bai_7 {
  class Program {
    private static List<ClassHinhHoc> timDanhSachHinhVuong(List<ClassHinhHoc> danhSach) {
      List<ClassHinhHoc> dsHinhVuong = new List<ClassHinhHoc>();
      foreach (ClassHinhHoc i in danhSach) {
        if (i.kieuDoiTuong().Equals(KieuHinh.HinhVuong)) {
          dsHinhVuong.Add(i);
        }
      }
      return dsHinhVuong;
    }

    private static int demHinhChuNhat(List<ClassHinhHoc> danhSach) {
      int soLuongHinhChuNhat = 0;
      foreach (ClassHinhHoc i in danhSach) {
        if (i.kieuDoiTuong().Equals(KieuHinh.HinhChuNhat)) {
          soLuongHinhChuNhat++;
        }
      }
      return soLuongHinhChuNhat;
    }

    public static ClassHinhHoc timHinhDienTichNhoNhat(List<ClassHinhHoc> danhSach) {
      ClassHinhHoc min = danhSach[0];
      foreach (ClassHinhHoc i in danhSach) {
        if (i.dienTich() < min.dienTich()) {
          min = i;
        }
      }
      return min;
    }

    public static ClassHinhChuNhat timHinhChuNhatChuViLonNhat(List<ClassHinhHoc> danhSach) {
      ClassHinhChuNhat max = null;
      foreach (ClassHinhHoc h in danhSach) {
        if (h.kieuDoiTuong() == KieuHinh.HinhChuNhat) {
          if (max == null)
            max = (ClassHinhChuNhat)h;
        } else if (max.chuVi() < h.chuVi()) {
          max = (ClassHinhChuNhat)h;
        }
      }
      return max;
    }

    static void Main(string[] args) {
      List<ClassHinhHoc> danhSach = new List<ClassHinhHoc>();

      danhSach.Add(new ClassHinhChuNhat(2, 2));
      danhSach.Add(new ClassHinhChuNhat(3, 3));
      danhSach.Add(new ClassHinhVuong(4));
      danhSach.Add(new ClassHinhVuong(5));
      danhSach.Add(new ClassHinhTamGiac(9, 9, 9));
      danhSach.Add(new ClassHinhTamGiac(8, 8, 8));

      foreach (ClassHinhHoc i in danhSach) {
        if (i.kieuDoiTuong() == KieuHinh.HinhChuNhat) {
          Console.WriteLine("Hình chữ nhật có hiện tích = " + i.dienTich() +
                            " chu vi = " + i.chuVi());
        } else if (i.kieuDoiTuong() == KieuHinh.HinhVuong) {
          Console.WriteLine("Hình vuông có diện tích = " + i.dienTich() + " chu vi = " + i.chuVi());
        } else if (i.kieuDoiTuong() == KieuHinh.HinhTamGiac) {
          Console.WriteLine("Hình tam giác có diện tích = " + i.dienTich() +
                            " chu vi = " + i.chuVi());
        }
      }

      int soHinhChuNhat = demHinhChuNhat(danhSach);
      Console.WriteLine("Số hình chữ nhật: " + soHinhChuNhat);

      ClassHinhHoc min = timHinhDienTichNhoNhat(danhSach);
      Console.WriteLine("Diện tích nhỏ nhất: " + min.dienTich());
    }
  }
}
