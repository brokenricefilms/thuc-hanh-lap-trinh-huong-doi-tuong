namespace bai_7 {
  public enum KieuHinh { HinhHoc, HinhChuNhat, HinhVuong, HinhTamGiac }
  abstract class ClassHinhHoc {
    public abstract double chuVi();

    public abstract double dienTich();

    public virtual KieuHinh kieuDoiTuong() {
      return KieuHinh.HinhHoc;
    }
  }
}
