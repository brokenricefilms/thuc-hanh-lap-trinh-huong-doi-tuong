namespace bai_6_bai_tap_tong_hop {
  public enum KieuKetQua { Dat, KhongDat }
  public class ClassThiSinh {
    protected string _maThiSinh;
    protected string _hoTen;

    public string MaThiSinh {
      get { return _maThiSinh; }
      set { _maThiSinh = value; }
    }

    public string Hoten {
      get { return _hoTen; }
      set { _hoTen = value; }
    }

    public ClassThiSinh() {
      _maThiSinh = "";
      _hoTen = "";
    }

    public ClassThiSinh(string ma, string hoTen) {
      _maThiSinh = ma;
      _hoTen = hoTen;
    }

    public virtual double TongDiem() {
      return 0;
    }

    public virtual KieuKetQua KetQua() {
      return KieuKetQua.KhongDat;
    }

    public virtual bool laKhoiA() {
      return false;
    }

    public virtual bool laKhoiNangKhieu() {
      return false;
    }
  }
}
