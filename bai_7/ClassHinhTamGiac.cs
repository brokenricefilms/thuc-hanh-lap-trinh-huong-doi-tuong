using System;

namespace bai_7 {
  class ClassHinhTamGiac : ClassHinhHoc {
    protected double _canh1;
    protected double _canh2;
    protected double _canh3;

    public ClassHinhTamGiac() {
      _canh1 = 0;
      _canh2 = 0;
      _canh3 = 0;
    }

    public ClassHinhTamGiac(double canh1, double canh2, double canh3) {
      _canh1 = canh1;
      _canh2 = canh2;
      _canh3 = canh3;
    }

    public double canh1 {
      get { return this._canh1; }
      set { _canh1 = value; }
    }

    public double canh2 {
      get { return this._canh2; }
      set { _canh2 = value; }
    }

    public double canh3 {
      get { return this._canh3; }
      set { _canh3 = value; }
    }

    public override double chuVi() {
      return _canh1 + _canh2 + _canh3;
    }

    //  Heron formula
    //  https://en.wikipedia.org/wiki/Heron%27s_formula
    public override double dienTich() {
      double p = chuVi() / 2;
      return Math.Sqrt(p * (p - _canh1) * (p - _canh2) * (p - _canh3));
    }

    public override KieuHinh kieuDoiTuong() {
      return KieuHinh.HinhTamGiac;
    }
  }
}
