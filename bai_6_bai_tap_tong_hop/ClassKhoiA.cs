namespace bai_6_bai_tap_tong_hop {
  class ClassKhoiA : ClassThiSinh {
    protected double _diemToan;
    protected double _diemLy;
    protected double _diemHoa;
    public double DiemToan {
      get { return _diemToan; }
      set { _diemToan = value; }
    }
    public double DiemLy {
      get { return _diemLy; }
      set { _diemLy = value; }
    }
    public double DiemHoa {
      get { return _diemHoa; }
      set { _diemHoa = value; }
    }
    public ClassKhoiA() : base() {
      _diemToan = 0;
      _diemLy = 0;
      _diemHoa = 0;
    }
    public ClassKhoiA(string ma, string ht, double toan, double ly, double hoa) : base(ma, ht) {
      _diemToan = toan;
      _diemLy = ly;
      _diemHoa = hoa;
    }
    public override double TongDiem() {
      return this._diemToan + this._diemLy + this._diemHoa;
    }
    public override KieuKetQua KetQua() {
      if (this.TongDiem() >= 18.5)
        return KieuKetQua.Dat;
      else
        return KieuKetQua.KhongDat;
    }
    public override bool laKhoiA() {
      return true;
    }
    public override bool laKhoiNangKhieu() {
      return false;
    }
  }
}
