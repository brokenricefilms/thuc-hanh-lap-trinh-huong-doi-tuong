﻿namespace bai_7_phan_so {
  class PhanSo : KieuSo {
    private int _tuSo;
    private int _mauSo;

    public int tuSo {
      get { return this._tuSo; }
      set { this._tuSo = value; }
    }

    public int mauSo {
      get { return this._mauSo; }
      set { this._mauSo = value; }
    }

    public PhanSo() {
      this._tuSo = 1;
      this._mauSo = 1;
    }

    public PhanSo(int tuSo, int mauSo) {
      this._tuSo = tuSo;
      this._mauSo = mauSo;
    }

    public int timUocChungLonNhat(PhanSo x) {
      int tu = Math.Abs(x._tuSo);
      int mau = Math.Abs(x._mauSo);
      while (tu != mau) {
        if (tu > mau)
          tu = tu - mau;
        else
          mau = mau - tu;
      }
      return tu;
    }

    public PhanSo rutGon(PhanSo x) {
      PhanSo ketQua = new PhanSo();
      int uocChungLonNhat = timUocChungLonNhat(x);
      ketQua._tuSo = x._tuSo / uocChungLonNhat;
      ketQua._mauSo = x._mauSo / uocChungLonNhat;
      return ketQua;
    }

    public KieuSo cong(KieuSo x) {
      PhanSo tong = new PhanSo();
      tong._tuSo = this._tuSo * ((PhanSo)x).mauSo + this._mauSo * ((PhanSo)x)._tuSo;
      tong._mauSo = this._mauSo * ((PhanSo)x)._mauSo;
      PhanSo ketQua = new PhanSo();
      ketQua = rutGon(tong);
      return ketQua;
    }

    public bool laPhanSo() {
      return true;
    }

    public bool laSoPhuc() {
      return false;
    }

    public string xuat() {
      return this._tuSo + "/" + this._mauSo;
    }
  }
}
