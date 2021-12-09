namespace bai_7_phan_so {
  class SoPhuc : KieuSo {
    private double _phanThuc;
    private double _phanAo;

    public double phanThuc {
      get { return this._phanThuc; }
      set { this._phanThuc = value; }
    }

    public double phanAo {
      get { return this._phanAo; }
      set { this._phanAo = value; }
    }

    public SoPhuc() {
      this._phanThuc = 1;
      this._phanAo = 1;
    }

    public SoPhuc(double thuc, double ao) {
      this._phanThuc = thuc;
      this._phanAo = ao;
    }

    // https://vi.wikipedia.org/wiki/S%E1%BB%91_ph%E1%BB%A9c
    public KieuSo cong(KieuSo x) {
      SoPhuc tong = new SoPhuc();
      tong._phanThuc = this._phanThuc + ((SoPhuc)x)._phanThuc;
      tong._phanAo = this._phanAo + ((SoPhuc)x)._phanAo;
      return tong;
    }

    public bool laPhanSo() {
      return false;
    }

    public bool laSoPhuc() {
      return true;
    }

    public string xuat() {
      return this._phanThuc + "+" + this._phanAo + "i";
    }
  }
}
