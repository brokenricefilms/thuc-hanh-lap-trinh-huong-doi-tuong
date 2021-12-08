namespace VD_Interface {
  class Program {
    public static void nhap(List<KieuSo> daySo) {
      int n, input;
      Console.Write("Nhập số lượng phần tử n = ");
      n = Convert.ToInt32(Console.ReadLine());

      for (int i = 0; i < n; i++) {
        do {
          Console.WriteLine("1. Nhập phân số");
          Console.WriteLine("2. Nhập số phức");
          Console.Write("Nhập lựa chọn: ");
          input = Convert.ToInt32(Console.ReadLine());
        } while (input != 1 && input != 2);

        if (input == 1) {
          PhanSo phanSo = new PhanSo();
          Console.Write("Nhập tử số: ");

          phanSo.tuSo = Convert.ToInt32(Console.ReadLine());
          Console.Write("Nhập mẫu số: ");

          phanSo.mauSo = Convert.ToInt32(Console.ReadLine());
          daySo.Add(phanSo);
        } else if (input == 2) {
          SoPhuc soPhuc = new SoPhuc();
          Console.Write("Nhập phần thực: ");

          soPhuc.phanThuc = Convert.ToInt32(Console.ReadLine());
          Console.Write("Nhập phần ảo: ");

          soPhuc.phanAo = Convert.ToInt32(Console.ReadLine());
          daySo.Add(soPhuc);
        } else {
        }
      }
    }

    public static void xuat(List<KieuSo> daySo) {
      foreach (KieuSo i in daySo) {
        if (i.laPhanSo()) {
          Console.Write("Phân số: ");
          Console.WriteLine(i.xuat());
        } else {
          Console.Write("Số phức: ");
          Console.WriteLine(i.xuat());
        }
      }
    }

    static void Main(string[] args) {
      List<KieuSo> daySo = new List<KieuSo>();

      Console.WriteLine("\n==Nhập dãy số==\n");
      nhap(daySo);
      Console.WriteLine("\n==Xuất dãy số==\n");
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
