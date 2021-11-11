using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tuan_4
{
    public partial class frmHocSinh : Form
    {
        private List<CHocSinh> dsHS;
 
        public frmHocSinh()
        {
            InitializeComponent();
        }

        private void HienThi()
        {
            dgvHocSinh.DataSource = dsHS.ToList();
        }
        
        private CHocSinh timHS(string ma)
        {
            foreach(CHocSinh item in dsHS)
            {
                if (item.MSHS == ma)
                {
                    return item;
                }
            }
            return null;
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CHocSinh hs = new CHocSinh();
            hs.MSHS = txtMSHS.Text;
            hs.HoTen = txtHoTen.Text;
            hs.DiaChi = txtDiaChi.Text;

            if (btnPhaiNam.Checked == true)
            {
                hs.Phai = "Nam";
            } else
            {
                hs.Phai = "Nữ";
            }
            hs.NgaySinh = dtpNgaySinh.Value;
            if (timHS(hs.MSHS) == null)
            {
                dsHS.Add(hs);
                HienThi();
            } else
            {
                MessageBox.Show("ma hoc da co trong danh sach");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahs = txtMSHS.Text;
            if (timHS(mahs) == null)
            {
                MessageBox.Show("khong co hoc sinh trong danh sach");
                return;
            }
            foreach(CHocSinh item in dsHS)
            {
                if (item.MSHS == mahs)
                {
                    dsHS.Remove(item);
                    HienThi();
                    MessageBox.Show("xoa thanh cong");
                    return;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahs = txtMSHS.Text;
            if (timHS(mahs) == null)
            {
                MessageBox.Show("khong co hoc sinh trong danh sach");
                return;
            }
            foreach(CHocSinh item in dsHS)
            {
                item.HoTen = txtHoTen.Text;
                item.DiaChi = txtDiaChi.Text;
                item.NgaySinh = dtpNgaySinh.Value;
                if (btnPhaiNam.Checked == true)
                {
                    item.Phai = "Nam";
                } else
                {
                    item.Phai = "Nữ";
                }
                HienThi();
            }
        }

        private void btnLuuFile_Click(object sender, EventArgs e)
        {

        }

        private void dgvHocSinh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMSHS.Text = dgvHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoTen.Text = dgvHocSinh.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvHocSinh.Rows[e.RowIndex].Cells[2].Value.ToString());

            if (dgvHocSinh.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
            {
                btnPhaiNam.Checked = true;
            } else
            {
                btnPhaiNu.Checked = true;
            }
            txtDiaChi.Text = dgvHocSinh.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
