using System;

namespace tuan_1 {
  class Program {
    static void NhapMang(int[,] a, out int n) {
      Console.Write("Nhap n=: ");
      n = Convert.ToInt32(Console.ReadLine());
      for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++) {
          Console.Write("Nhap a[{0},{1}] = ", i, j);
          a[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void XuatMang(int[,] a, int n) {
      for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
          Console.Write(a[i, j] + "\t");
        }
        Console.WriteLine();
      }
    }

    static int KTNT(int n) {
      if (n < 2)
        return 0;
      else {
        for (int i = 2; i <= n / 2; i++)
          if (n % i == 0)
            return 0;
        return 1;
      }
    }

    static void TinhTong(int[,] a, int n) {
      int sum = 0;
      for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
          sum += a[i, j];
        }
      }
      Console.Write("tong la: ");
      Console.Write(sum);
    }

    static bool KiemTraSoNguyenTo(int n) {
      bool flag = false;
      int count = 0;
      if (n < 2 || n > 100) {
        flag = false;
      } else {
        for (int i = 2; i <= n / 2; i++) {
          if (n % i == 0) {
            count++;
          }
        }
        if (count == 0) {
          flag = true;
        }
      }
      return flag;
    }

    static void XuatTongCacSoNguyenTo(int[,] a, int n) {
      int sum = 0;
      for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
          if (KiemTraSoNguyenTo(a[i, j]) == true) {
            sum += a[i, j];
          }
        }
      }
      Console.WriteLine();
      Console.Write("tong cac so nguyen to la: ");
      Console.Write(sum);
    }

    static void XuatTongCacPhanTuDongK(int[,] a, int n, int k) {
      int sum = 0;
      k--;
      for (int i = 0; i < n; i++) {
        sum += a[k, i];
      }
      Console.WriteLine();
      Console.Write("tong cac so nguyen to la: ");
      Console.Write(sum);
    }

    static void XuatSoPhanTuAmPhanTuDuong(int[,] a, int n) {
      int countPhanTuAm = 0;
      int countPhanTuDuong = 0;
      for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
          if (a[i, j] > 0) {
            countPhanTuDuong++;
          } else {
            countPhanTuAm++;
          }
        }
      }
      Console.Write("\n");
      Console.Write("tong cac so phan tu duong: ");
      Console.Write(countPhanTuDuong);
      Console.Write("\n");
      Console.Write("tong cac so phan tu am: ");
      Console.Write(countPhanTuAm);
    }

    static void XuatSoLanXuatHienPhanTuX(int[,] a, int n, int x) {
      int count = 0;
      for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
          if (a[i, j] == x) {
            count++;
          }
        }
      }
      Console.Write("So lan xuat hien cua phan tu x: ");
      Console.Write(count);
    }

    static void Main(string[] args) {
      const int MAX = 10;
      int n;
      int[,] a = new int[MAX, MAX];
      NhapMang(a, out n);
      XuatMang(a, n);
      TinhTong(a, n);
      XuatTongCacSoNguyenTo(a, n);

      int k;
      do {
        Console.Write("Nhap dong = ");
        k = Convert.ToInt32(Console.ReadLine());
      } while (k > n);

      XuatTongCacPhanTuDongK(a, n, k);

      XuatSoPhanTuAmPhanTuDuong(a, n);

      int x;
      Console.Write("Nhap x = ");
      x = Convert.ToInt32(Console.ReadLine());
      XuatSoLanXuatHienPhanTuX(a, n, x);
    }
  }
}
