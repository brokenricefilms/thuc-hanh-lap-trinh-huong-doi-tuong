namespace bai_7 {
  class ClassHinhChuNhat : ClassHinhHoc {
    protected double _dai;
    protected double _rong;

    public ClassHinhChuNhat() {
      _dai = 0;
      _rong = 0;
    }

    public ClassHinhChuNhat(double dai, double rong) {
      _dai = dai;
      _rong = rong;
    }

    public virtual double ChieuDai {
      get { return _dai; }
      set { _dai = value; }
    }

    public virtual double ChieuRong {
      get { return _rong; }
      set { _rong = value; }
    }

    public override double chuVi() {
      return (_dai + _rong) * 2;
    }

    public override double dienTich() {
      return _dai * _rong;
    }

    public override KieuHinh kieuDoiTuong() {
      return KieuHinh.HinhChuNhat;
    }
  }
}
