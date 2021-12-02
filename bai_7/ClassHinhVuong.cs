namespace bai_7 {
  class ClassHinhVuong : ClassHinhChuNhat {
    public ClassHinhVuong() : base() {}

    public ClassHinhVuong(double canh) : base(canh, canh) {}

    public override double ChieuDai {
      get => base.ChieuDai;
      set => base.ChieuDai = value;
    }

    public override double ChieuRong {
      get => base.ChieuDai;
      set => base.ChieuDai = value;
    }

    public override KieuHinh kieuDoiTuong() {
      return KieuHinh.HinhVuong;
    }
  }
}
