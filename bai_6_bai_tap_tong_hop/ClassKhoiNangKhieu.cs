namespace bai_6_bai_tap_tong_hop {
  class ClassKhoiNangKhieu : ClassThiSinh {
    protected double _diemToan;
    protected double _DiemNangKhieu;
    public double DiemToan {
      get => _diemToan;
      set => _diemToan = value;
    }
    public double DiemNangKhieu {
      get => _DiemNangKhieu;
      set => _DiemNangKhieu = value;
    }
    public ClassKhoiNangKhieu() : base() {
      _diemToan = 0;
      _DiemNangKhieu = 0;
    }
    public ClassKhoiNangKhieu(string ma, string ht, double toan, double nangkhieu) : base(ma, ht) {
      _diemToan = toan;
      _DiemNangKhieu = nangkhieu;
    }
    public override double TongDiem() {
      return DiemToan + DiemNangKhieu * 2;
    }
    public override KieuKetQua KetQua() {
      if (this.TongDiem() >= 17)
        return KieuKetQua.Dat;
      else
        return KieuKetQua.KhongDat;
    }
    public override bool laKhoiA() {
      return false;
    }
    public override bool laKhoiNangKhieu() {
      return true;
    }
  }
}
