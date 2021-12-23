using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CuoiKy
{
  public partial class FrmThi6 : Form
  {
    private CXulyNhanVien xl;
    private void hienthi()
    {
      dgvNV.DataSource = xl.getDSNhanVien();
    }
    public FrmThi6()
    {
      InitializeComponent();
    }

    private void FrmThi6_Load(object sender, EventArgs e)
    {
      xl = new CXulyNhanVien();
      hienthi();
    }

    private void btnThem_Click(object sender, EventArgs e)
    {
      CNhanVien nv = new CNhanVien();
      nv.MaNV = txtMaNV.Text;
      nv.TenNV = txtTenNVNV.Text;
      nv.NgaySinh = dtpNgaySinh.Value.Date;
      nv.Phai = radNam.Checked;
      nv.Luong = Convert.ToInt32(txtLuong.Text);
      nv.LuongCoBan = Convert.ToInt32(txtLuongCoBan.Text);
      nv.TongLuong = Convert.ToInt32(txtTongLuong.Text);

      xl.them(nv);
      hienthi();
    }

    private void dgvnv_RowEnter(object sender, DataGridViewCellEventArgs e)
    {
      txtMaNV.Text = dgvNV.Rows[e.RowIndex].Cells[0].Value.ToString();
      txtTenNVNV.Text = dgvNV.Rows[e.RowIndex].Cells[1].Value.ToString();
      dtpNgaySinh.Value = Convert.ToDateTime(dgvNV.Rows[e.RowIndex].Cells[2].Value);
      if (dgvNV.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
      {
        radNam.Checked = true;
      }
      else
      {
        radNu.Checked = true;
      }
      txtLuong.Text = dgvNV.Rows[e.RowIndex].Cells[4].Value.ToString();
      txtLuongCoBan.Text = dgvNV.Rows[e.RowIndex].Cells[5].Value.ToString();
      txtTongLuong.Text = dgvNV.Rows[e.RowIndex].Cells[6].Value.ToString();
    }

    private void btnSua_Click(object sender, EventArgs e)
    {
      CNhanVien nv = new CNhanVien();
      nv.MaNV = txtMaNV.Text;
      nv.TenNV = txtTenNVNV.Text;
      nv.NgaySinh = dtpNgaySinh.Value.Date;
      nv.Phai = radNam.Checked;
      nv.Luong = Convert.ToInt32(txtLuong.Text);
      nv.LuongCoBan = Convert.ToInt32(txtLuongCoBan.Text);
      nv.TongLuong = Convert.ToInt32(txtLuongCoBan.Text);
      xl.sua(nv);
      hienthi();
    }
  }
}
