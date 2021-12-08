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

    public static ClassHinhHoc timHinhChuNhatChuViLonNhat(List<ClassHinhHoc> danhSach) {
      ClassHinhHoc max = danhSach[0];
      foreach (ClassHinhHoc i in danhSach) {
        if (i.kieuDoiTuong() == KieuHinh.HinhChuNhat && max.chuVi() < i.chuVi()) {
          max = i;
        }
      }
      return max;
    }

    static void Main(string[] args) {
      List<ClassHinhHoc> danhSach = new List<ClassHinhHoc>();

      danhSach.Add(new ClassHinhChuNhat(2, 2));
      danhSach.Add(new ClassHinhChuNhat(3, 3));
      danhSach.Add(new ClassHinhChuNhat(10, 15));
      danhSach.Add(new ClassHinhVuong(4));
      danhSach.Add(new ClassHinhVuong(5));
      danhSach.Add(new ClassHinhTamGiac(8, 8, 8));
      danhSach.Add(new ClassHinhTamGiac(9, 9, 9));

      // @todo danh sach hinh chu nhat, danh sach hinh tam giac
      foreach (ClassHinhVuong i in timDanhSachHinhVuong(danhSach)) {
        Console.WriteLine("hình vuông có chiều dài " + i.ChieuDai);
      }

      Console.WriteLine("\n");

      // @todo so hinh vuong, so hinh tam giac
      int soHinhChuNhat = demHinhChuNhat(danhSach);
      Console.WriteLine("Số hình chữ nhật: " + soHinhChuNhat);

      Console.WriteLine("\n");

      foreach (ClassHinhHoc i in danhSach) {
        if (i.kieuDoiTuong() == KieuHinh.HinhChuNhat) {
          Console.WriteLine("Hình chữ nhật có hiện tích = " + i.dienTich() +
                            " chu vi = " + i.chuVi());
        } else if (i.kieuDoiTuong() == KieuHinh.HinhVuong) {
          Console.WriteLine("Hình vuông có diện tích = " + i.dienTich() + " chu vi = " + i.chuVi());
          // @todo dien tich -> lam tron so thap phan
        } else if (i.kieuDoiTuong() == KieuHinh.HinhTamGiac) {
          Console.WriteLine("Hình tam giác có diện tích = " + Math.Round(i.dienTich(), 2) +
                            " chu vi = " + i.chuVi());
        }
      }

      Console.WriteLine("\n");

      ClassHinhHoc min = timHinhDienTichNhoNhat(danhSach);
      Console.WriteLine("Diện tích nhỏ nhất: " + min.dienTich());

      Console.WriteLine("\n");

      ClassHinhHoc max = timHinhChuNhatChuViLonNhat(danhSach);
      Console.WriteLine("Hình chữ nhật có chu vi lớn nhất: " + max.chuVi());
    }
  }
}
