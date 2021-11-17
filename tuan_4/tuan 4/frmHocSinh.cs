using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;  
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
        private void hienThi()
        {
            dgvHocSinh.DataSource = dsHS.ToList();
        }

        private CHocSinh timHS(string ma)
        {
            foreach (CHocSinh item in dsHS)
            {
                if (item.MSHS == ma)
                {
                    return item;
                }
                    
            }
            return null;
        }
        private void frmHocSinh_Load(
            object sender, EventArgs e)
        {
            dsHS = new List<CHocSinh>();
            //if (docFile("hs1.out"))
            //{
            //    hienThi();
            //}
            //else
            //{
            //    MessageBox.Show("Không đọc được file");
            //}
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CHocSinh hs = new CHocSinh();
            hs.MSHS = txtMsHocSinh.Text;
            hs.HoTen = txtTenHocSinh.Text;
            hs.DiaChi = txtDiaChi.Text;
            if (radNam.Checked == true)
                hs.Phai = "Nam";
            else
                hs.Phai = "Nữ";
            hs.NgaySinh = dtpNgaySinh.Value;
            if (timHS(hs.MSHS) == null)
            {
                dsHS.Add(hs);
                hienThi();
            }
            else
                MessageBox.Show("Mã học sinh đã có trong danh sách");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahs = txtMsHocSinh.Text;
            if(timHS(mahs)==null)
            {
                MessageBox.Show("Không có học sinh trong danh sách");
                return;
            }
            foreach(CHocSinh item in dsHS)
            {
                if(item.MSHS==mahs)
                {
                    dsHS.Remove(item);
                    hienThi();
                    MessageBox.Show("Xóa thành công");
                    return;
                }    
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahs = txtMsHocSinh.Text;
            if(timHS(mahs)==null)
            {
                MessageBox.Show("Không có học sinh trong danh sách");
                return;
            }    
            foreach( CHocSinh item in dsHS)
            {
                if(item.MSHS==mahs)
                {
                    item.HoTen = txtTenHocSinh.Text;
                    item.MSHS = txtMsHocSinh.Text;
                    item.NgaySinh = dtpNgaySinh.Value;
                    item.DiaChi = txtDiaChi.Text;
                    if (radNam.Checked == true)
                        item.Phai = "Nam";
                    else
                        item.Phai = "Nữ";
                    hienThi();
                    return;
                }
            }
        }
        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMsHocSinh.Text = dgvHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenHocSinh.Text = dgvHocSinh.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dgvHocSinh.Rows[e.RowIndex].Cells[2].Value.ToString());
            if (dgvHocSinh.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam")
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtDiaChi.Text = dgvHocSinh.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
        private void btnLuuFile_Click(object sender, EventArgs e)
        {
            if (ghiFile("hs1.out"))
                MessageBox.Show("Ghi file thành công");
            else
                MessageBox.Show("Ghi file không thành công");
        }
        public bool ghiFile(string tenFile)
        {
            FileStream f = new FileStream(tenFile, FileMode.Create);
            if (f == null)
                return false;
            else
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, dsHS);
                f.Close();
                return true;
            }
        }
        public bool docFile(string tenFile)
        {
            FileStream f = new FileStream(tenFile, FileMode.Open);
            if (f == null)
                return false;
            else
            {
                BinaryFormatter bf = new BinaryFormatter(); 
                dsHS = bf.Deserialize(f) as List<CHocSinh>;
                if (dsHS == null)
                    dsHS = new List<CHocSinh>();
                f.Close();
                return true;
            }
        }
       
    }
}
