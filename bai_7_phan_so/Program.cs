using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Interface {
  class Program {
    public static void nhap(List<KieuSo> daySo) {
      int n, c;
      Console.WriteLine("Nhap so phan tu:");
      n = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i < n; i++) {
        do {
          Console.WriteLine("1.Nhap phan so");
          Console.WriteLine("2.Nhap sp phuc");
          Console.Write("Nhap lua chon:");
          c = Convert.ToInt32(Console.ReadLine());
        } while (c != 1 && c != 2);
        if (c == 1) {
          PhanSo p = new PhanSo();
          Console.Write("Nhap tu so:");
          p.tuSo = Convert.ToInt32(Console.ReadLine());
          Console.Write("Nhap mau so:");
          p.mauSo = Convert.ToInt32(Console.ReadLine());
          daySo.Add(p);
        } else {
          SoPhuc s = new SoPhuc();
          Console.Write("Nhap phan thuc:");
          s.phanThuc = Convert.ToInt32(Console.ReadLine());
          Console.Write("Nhap phan ao:");
          s.phanAo = Convert.ToInt32(Console.ReadLine());
          daySo.Add(s);
        }
      }
    }
    public static void xuat(List<KieuSo> daySo) {
      foreach (KieuSo k in daySo) {
        if (k.laPhanSo()) {
          Console.Write("Phan so:");
          Console.WriteLine(k.xuat());
        } else {
          Console.Write("So phuc:");
          Console.WriteLine(k.xuat());
        }
      }
    }
    static void Main(string[] args) {
      List<KieuSo> daySo = new List<KieuSo>();
      Console.WriteLine("Nhập dãy số: ");
      nhap(daySo);
      Console.WriteLine("Xuất dãy số: ");
      xuat(daySo);

      PhanSo phanSo1 = new PhanSo(1, 2);
      PhanSo phanSo2 = new PhanSo(3, 4);

      KieuSo tong = new PhanSo();
      tong = phanSo1.cong(phanSo2);
      string ketQua = tong.xuat();
      Console.WriteLine("Tổng 2 phân số: " + ketQua);
    }
  }
}
