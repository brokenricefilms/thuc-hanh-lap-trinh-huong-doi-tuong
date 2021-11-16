using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DictionaryHocSinh
{
    public partial class Form1 : Form
    {
        private Dictionary<string, CHocSinh> dsHS;
        private void hienThi()
        {
            dgvHocSinh.DataSource = dsHS.Values.ToList();
        }
        private CHocSinh timHS(string masv)
        {
            try
            {
                return dsHS[masv];
            }
            catch
            {
                return null;
            }
        }
        public Form1()
        {
            InitializeComponent();
            dsHS = new Dictionary<string, CHocSinh>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dsHS = new Dictionary<string, CHocSinh>();
            if (docFile("fileDictionary.txt") == true)
            {
                hienThi();
            }
            else
                MessageBox.Show("Khong doc duoc");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CHocSinh hs = new CHocSinh();
            hs.TenSV = txtTenSv.Text;
            hs.MaSV = txtMaSv.Text;
            hs.DiaChi = txtDiaChi.Text;
            if(radNam.Checked==true)
                hs.Phai = "Nam";
            else 
                hs.Phai = "Nữ";
            hs.NgaySinh = dtpNgaysinh.Value;
            if (timHS(hs.MaSV) == null)
            {
                dsHS.Add(hs.MaSV,hs);
                hienThi();
            }
            else
                MessageBox.Show("Ma hoc sinh da co trong ds.");
        }

        private void dgvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenSv.Text = dgvHocSinh.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaSv.Text = dgvHocSinh.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpNgaysinh.Value = Convert.ToDateTime(dgvHocSinh.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtDiaChi.Text = dgvHocSinh.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dgvHocSinh.Rows[e.RowIndex].Cells[4].Value.ToString() == "Nam")
                radNam.Checked = true;
            else
                radNu.Checked = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            CHocSinh hs =timHS(txtMaSv.Text);
            if(hs==null)  
                MessageBox.Show("Khong co sv trong ds");
            else
            {
                dsHS.Remove(hs.MaSV);
                hienThi();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            CHocSinh hs = timHS(txtMaSv.Text);
            if (hs == null)
                MessageBox.Show("Khong tim thay sv trong ds");
            else
            {
                hs.TenSV = txtTenSv.Text;
                hs.MaSV = txtMaSv.Text;
                hs.NgaySinh = dtpNgaysinh.Value;
                hs.DiaChi = txtDiaChi.Text;
                if (radNam.Checked == true)
                    hs.Phai = "Nam";
                else
                    hs.Phai = "Nữ";
                hienThi();
                return;
            }
        }
        private void btnLuufile_Click(object sender, EventArgs e)
        {
            if (ghiFile("fileDictionary.txt") == true)
                MessageBox.Show("Ghi file thanh cong");
            else
                MessageBox.Show("Ghi file khong thanh cong");
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
                Dictionary<string, CHocSinh> dictionaries = bf.Deserialize(f) as Dictionary<string, CHocSinh>;
                dsHS = dictionaries;
                if (dsHS == null)
                    dsHS = new Dictionary<string, CHocSinh>();
                f.Close();
                return true;
            }
        }
    }
}
