using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_8_thuc_thanh_1
{
    public partial class formNhaSanXuat : Form
    {
        public formNhaSanXuat()
        {
            InitializeComponent();
        }


        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewNhaSanXuat_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTenNhaSanXuat.Text = dataGridViewNhaSanXuat.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxMaNhaSanXuat.Text = dataGridViewNhaSanXuat.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxDiaChi.Text = dataGridViewNhaSanXuat.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxSoDienThoai.Text = dataGridViewNhaSanXuat.Rows[e.RowIndex].Cells[4].Value.ToString(); textBoxDiaChi.Text = dataGridViewNhaSanXuat.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
