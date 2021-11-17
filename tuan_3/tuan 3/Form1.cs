using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuan_3
{

    public partial class frmNSX : Form
    {
        private Dictionary<string, CNhaSanXuat> dsNSX;
        private void hienDSNhaSanXuat()
        {
            dgvNSX.DataSource = dsNSX.Values.ToList();
        }
        private CNhaSanXuat timNSX(string ma)
        {
            try
            {
                return dsNSX[ma];
            }
            catch
            {
                return null;
            }
        }
        public frmNSX()
        {
            InitializeComponent();
        }
        private void frmNSX_Load(object sender, EventArgs e)
        {
            dsNSX = new Dictionary<string, CNhaSanXuat>();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CNhaSanXuat n = new CNhaSanXuat();
            n.MaNSX = txtMaNSX.Text;
            n.TenNSX = txtTenNSX.Text;
            n.SoDT = txtSoDT.Text;
            n.DiaChi = txtDiaChi.Text;
            if (timNSX(n.MaNSX) == null)
            {
                dsNSX.Add(n.MaNSX, n);
                hienDSNhaSanXuat();
            }
            else
                MessageBox.Show("Mã nhà sản xuất " + n.MaNSX + " đã tồn tại. Không thêm được.");
        }
        private void dgvNSX_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNSX.Text = dgvNSX.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNSX.Text = dgvNSX.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoDT.Text = dgvNSX.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNSX.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class CNhaSanXuat
    {
        private string m_mansx, m_tennsx, m_sodt, m_diachi;
        public string MaNSX
        {
            get { return m_mansx; }
            set { m_mansx = value; }
        }
        public string TenNSX
        {
            get { return m_tennsx; }
            set { m_tennsx = value; }
        }
        public string SoDT
        {
            get { return m_sodt; }
            set { m_sodt = value; }
        }
        public string DiaChi
        {
            get { return m_diachi; }
            set { m_diachi = value; }
        }
        public CNhaSanXuat()
        {
            m_mansx = "";
            m_tennsx = "";
            m_sodt = "";
            m_diachi = "";
        }
        public CNhaSanXuat(string ma, string ten, string sodt, string dc)
        {
            m_mansx = ma;
            m_tennsx = ten;
            m_sodt = sodt;
            m_diachi = dc;
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            CNhaSanXuat n = timNSX(txtMaNSX.Text);
            if (n == null)
            {
                MessageBox.Show("Khong co nsx nay");
            }
            else
            {
                if (MessageBox.Show("Ban muon xoa NSX nay?", "Thong bao", MessageBoxButtons.OKCancel,
                                    MessageBoxButtons.Question) == DialogResult.OK)
                {
                    dsNSX.Remove(n.MaNSX);
                    hienDSNhaSanXuat();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) { }

        private void button4_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            CNhaSanXuat n = timNSX(txtMaNSX.Text);
            if (n == null)
            {
                MessageBox.Show("Khong tim thay");
            }
            else
            {
                n.TenNSX = txtTenNSX.Text;
                n.SoDT = txtSoDT.Text;
                n.DiaChi = txtDiaChi.text;
                hienDSNhaSanXuat();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
