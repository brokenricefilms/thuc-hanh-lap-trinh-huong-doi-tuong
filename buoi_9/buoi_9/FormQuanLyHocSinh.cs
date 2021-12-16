using System;
using System.Collections.Generic; 
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi_9
{
  public partial class FormQuanLyHocSinh : Form
  {
    private void hienthi()
    {
      dataGridViewHocSinh.DataSource = ClassXuLyHocSinh.GetDanhSachHocSinh();
    }
    public FormQuanLyHocSinh()
    {
      InitializeComponent();
    }

    private void buttonThem_Click(object sender, EventArgs e)
    {
      ClassHocSinh hs = new ClassHocSinh();
      hs.Ma = textBoxMaHocVien.Text;
      hs.HoTen = textBoxHoTen.Text;
      hs.NgaySinh = dateTimePickerNgaySinh.Value.Date;
      hs.GioiTinh = radioButtonGioiTinhNam.Checked;
      ClassXuLyHocSinh.them(hs);
      hienthi();
    }

    private void dataGridViewHocSinh_RowEnter(object sender, DataGridViewCellEventArgs e)
    {

      textBoxMaHocVien.Text = dataGridViewHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
      textBoxHoTen.Text = dataGridViewHocSinh.Rows[e.RowIndex].Cells[1].Value.ToString();
      dateTimePickerNgaySinh.Value = Convert.ToDateTime(dataGridViewHocSinh.Rows[e.RowIndex].Cells[2].Value);
      if (dataGridViewHocSinh.Rows[e.RowIndex].Cells[3].Value.ToString() == "True")
        radioButtonGioiTinhNam.Checked = true;
      else
        radioButtonGioiTinhNu.Checked = true;
      textBoxDiemMon1.Text = dataGridViewHocSinh.Rows[e.RowIndex].Cells[4].Value.ToString();
      textBoxDiemMon2.Text = dataGridViewHocSinh.Rows[e.RowIndex].Cells[5].Value.ToString();
      textBoxKetQua.Text = dataGridViewHocSinh.Rows[e.RowIndex].Cells[6].Value.ToString();
    }
  }
}
