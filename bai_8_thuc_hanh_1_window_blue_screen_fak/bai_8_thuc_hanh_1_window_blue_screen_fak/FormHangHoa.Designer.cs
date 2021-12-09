namespace bai_8_thuc_thanh_1
{
    partial class FormHangHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewHangHoa = new System.Windows.Forms.DataGridView();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBoxTenHang = new System.Windows.Forms.TextBox();
            this.textBoxDonViTinh = new System.Windows.Forms.TextBox();
            this.textBoxDonGia = new System.Windows.Forms.TextBox();
            this.textBoxMaHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNhaSanXuat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHangHoa
            // 
            this.dataGridViewHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHangHoa.Location = new System.Drawing.Point(41, 159);
            this.dataGridViewHangHoa.Name = "dataGridViewHangHoa";
            this.dataGridViewHangHoa.Size = new System.Drawing.Size(493, 279);
            this.dataGridViewHangHoa.TabIndex = 23;
            this.dataGridViewHangHoa.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHangHoa_RowEnter);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(325, 89);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 22;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(325, 48);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 21;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(325, 19);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 20;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // textBoxTenHang
            // 
            this.textBoxTenHang.Location = new System.Drawing.Point(153, 45);
            this.textBoxTenHang.Name = "textBoxTenHang";
            this.textBoxTenHang.Size = new System.Drawing.Size(100, 20);
            this.textBoxTenHang.TabIndex = 19;
            // 
            // textBoxDonViTinh
            // 
            this.textBoxDonViTinh.Location = new System.Drawing.Point(153, 71);
            this.textBoxDonViTinh.Name = "textBoxDonViTinh";
            this.textBoxDonViTinh.Size = new System.Drawing.Size(100, 20);
            this.textBoxDonViTinh.TabIndex = 18;
            // 
            // textBoxDonGia
            // 
            this.textBoxDonGia.Location = new System.Drawing.Point(153, 97);
            this.textBoxDonGia.Name = "textBoxDonGia";
            this.textBoxDonGia.Size = new System.Drawing.Size(100, 20);
            this.textBoxDonGia.TabIndex = 17;
            // 
            // textBoxMaHang
            // 
            this.textBoxMaHang.Location = new System.Drawing.Point(155, 19);
            this.textBoxMaHang.Name = "textBoxMaHang";
            this.textBoxMaHang.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaHang.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "đơn vị tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "tên hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "nhà sản xuất";
            // 
            // comboBoxNhaSanXuat
            // 
            this.comboBoxNhaSanXuat.FormattingEnabled = true;
            this.comboBoxNhaSanXuat.Location = new System.Drawing.Point(153, 122);
            this.comboBoxNhaSanXuat.Name = "comboBoxNhaSanXuat";
            this.comboBoxNhaSanXuat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNhaSanXuat.TabIndex = 25;
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.comboBoxNhaSanXuat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewHangHoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxTenHang);
            this.Controls.Add(this.textBoxDonViTinh);
            this.Controls.Add(this.textBoxDonGia);
            this.Controls.Add(this.textBoxMaHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHangHoa";
            this.Text = "form hàng hóa";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHangHoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox textBoxTenHang;
        private System.Windows.Forms.TextBox textBoxDonViTinh;
        private System.Windows.Forms.TextBox textBoxDonGia;
        private System.Windows.Forms.TextBox textBoxMaHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxNhaSanXuat;
    }
}