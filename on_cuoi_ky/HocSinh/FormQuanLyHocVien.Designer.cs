namespace HocSinh
{
    partial class FormQuanLyHocVien
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtMaHS = new System.Windows.Forms.TextBox();
      this.txtHoTen = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
      this.label4 = new System.Windows.Forms.Label();
      this.txtDiaChi = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radNu = new System.Windows.Forms.RadioButton();
      this.radNam = new System.Windows.Forms.RadioButton();
      this.btnThem = new System.Windows.Forms.Button();
      this.btnXoa = new System.Windows.Forms.Button();
      this.btnSua = new System.Windows.Forms.Button();
      this.btnLuuFile = new System.Windows.Forms.Button();
      this.dgvHS = new System.Windows.Forms.DataGridView();
      this.label5 = new System.Windows.Forms.Label();
      this.txtDiemMon1 = new System.Windows.Forms.TextBox();
      this.txtDiemMon2 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.txtKetQua = new System.Windows.Forms.TextBox();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(18, 28);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Mã số học sinh";
      // 
      // txtMaHS
      // 
      this.txtMaHS.Location = new System.Drawing.Point(133, 26);
      this.txtMaHS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.txtMaHS.Name = "txtMaHS";
      this.txtMaHS.Size = new System.Drawing.Size(188, 20);
      this.txtMaHS.TabIndex = 1;
      // 
      // txtHoTen
      // 
      this.txtHoTen.Location = new System.Drawing.Point(133, 55);
      this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.txtHoTen.Name = "txtHoTen";
      this.txtHoTen.Size = new System.Drawing.Size(188, 20);
      this.txtHoTen.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(18, 57);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(82, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Họ tên học sinh";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(18, 88);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(54, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Ngày sinh";
      // 
      // dtpNgaySinh
      // 
      this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpNgaySinh.Location = new System.Drawing.Point(133, 85);
      this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.dtpNgaySinh.Name = "dtpNgaySinh";
      this.dtpNgaySinh.Size = new System.Drawing.Size(187, 20);
      this.dtpNgaySinh.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(18, 116);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Địa chỉ";
      // 
      // txtDiaChi
      // 
      this.txtDiaChi.Location = new System.Drawing.Point(133, 114);
      this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.txtDiaChi.Name = "txtDiaChi";
      this.txtDiaChi.Size = new System.Drawing.Size(188, 20);
      this.txtDiaChi.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radNu);
      this.groupBox1.Controls.Add(this.radNam);
      this.groupBox1.Location = new System.Drawing.Point(382, 28);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBox1.Size = new System.Drawing.Size(91, 101);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Phái";
      // 
      // radNu
      // 
      this.radNu.AutoSize = true;
      this.radNu.Checked = true;
      this.radNu.Location = new System.Drawing.Point(10, 56);
      this.radNu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.radNu.Name = "radNu";
      this.radNu.Size = new System.Drawing.Size(39, 17);
      this.radNu.TabIndex = 0;
      this.radNu.TabStop = true;
      this.radNu.Text = "Nữ";
      this.radNu.UseVisualStyleBackColor = true;
      // 
      // radNam
      // 
      this.radNam.AutoSize = true;
      this.radNam.Location = new System.Drawing.Point(10, 27);
      this.radNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.radNam.Name = "radNam";
      this.radNam.Size = new System.Drawing.Size(47, 17);
      this.radNam.TabIndex = 0;
      this.radNam.TabStop = true;
      this.radNam.Text = "Nam";
      this.radNam.UseVisualStyleBackColor = true;
      // 
      // btnThem
      // 
      this.btnThem.Location = new System.Drawing.Point(523, 23);
      this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnThem.Name = "btnThem";
      this.btnThem.Size = new System.Drawing.Size(88, 29);
      this.btnThem.TabIndex = 6;
      this.btnThem.Text = "Thêm";
      this.btnThem.UseVisualStyleBackColor = true;
      this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
      // 
      // btnXoa
      // 
      this.btnXoa.Location = new System.Drawing.Point(523, 55);
      this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnXoa.Name = "btnXoa";
      this.btnXoa.Size = new System.Drawing.Size(88, 29);
      this.btnXoa.TabIndex = 6;
      this.btnXoa.Text = "Xóa";
      this.btnXoa.UseVisualStyleBackColor = true;
      this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
      // 
      // btnSua
      // 
      this.btnSua.Location = new System.Drawing.Point(523, 88);
      this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnSua.Name = "btnSua";
      this.btnSua.Size = new System.Drawing.Size(88, 29);
      this.btnSua.TabIndex = 6;
      this.btnSua.Text = "Sửa";
      this.btnSua.UseVisualStyleBackColor = true;
      this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
      // 
      // btnLuuFile
      // 
      this.btnLuuFile.Location = new System.Drawing.Point(523, 121);
      this.btnLuuFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnLuuFile.Name = "btnLuuFile";
      this.btnLuuFile.Size = new System.Drawing.Size(88, 29);
      this.btnLuuFile.TabIndex = 6;
      this.btnLuuFile.Text = "Lưu File";
      this.btnLuuFile.UseVisualStyleBackColor = true;
      this.btnLuuFile.Click += new System.EventHandler(this.btnLuuFile_Click);
      // 
      // dgvHS
      // 
      this.dgvHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvHS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
      this.dgvHS.Location = new System.Drawing.Point(19, 233);
      this.dgvHS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.dgvHS.Name = "dgvHS";
      this.dgvHS.RowTemplate.Height = 28;
      this.dgvHS.Size = new System.Drawing.Size(617, 144);
      this.dgvHS.TabIndex = 7;
      this.dgvHS.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHS_RowEnter);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(18, 149);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(63, 13);
      this.label5.TabIndex = 0;
      this.label5.Text = "Điểm môn 1";
      // 
      // txtDiemMon1
      // 
      this.txtDiemMon1.Location = new System.Drawing.Point(133, 147);
      this.txtDiemMon1.Margin = new System.Windows.Forms.Padding(2);
      this.txtDiemMon1.Name = "txtDiemMon1";
      this.txtDiemMon1.Size = new System.Drawing.Size(188, 20);
      this.txtDiemMon1.TabIndex = 1;
      // 
      // txtDiemMon2
      // 
      this.txtDiemMon2.Location = new System.Drawing.Point(133, 174);
      this.txtDiemMon2.Margin = new System.Windows.Forms.Padding(2);
      this.txtDiemMon2.Name = "txtDiemMon2";
      this.txtDiemMon2.Size = new System.Drawing.Size(188, 20);
      this.txtDiemMon2.TabIndex = 9;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(18, 176);
      this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(63, 13);
      this.label6.TabIndex = 8;
      this.label6.Text = "Điểm môn 2";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(17, 204);
      this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(44, 13);
      this.label7.TabIndex = 8;
      this.label7.Text = "Kết quả";
      // 
      // txtKetQua
      // 
      this.txtKetQua.Location = new System.Drawing.Point(132, 202);
      this.txtKetQua.Margin = new System.Windows.Forms.Padding(2);
      this.txtKetQua.Name = "txtKetQua";
      this.txtKetQua.ReadOnly = true;
      this.txtKetQua.Size = new System.Drawing.Size(188, 20);
      this.txtKetQua.TabIndex = 9;
      // 
      // Column1
      // 
      this.Column1.DataPropertyName = "MaHS";
      this.Column1.HeaderText = "Mã số";
      this.Column1.Name = "Column1";
      // 
      // Column2
      // 
      this.Column2.DataPropertyName = "HoTen";
      this.Column2.HeaderText = "Họ tên";
      this.Column2.Name = "Column2";
      // 
      // Column3
      // 
      this.Column3.DataPropertyName = "NgaySinh";
      this.Column3.HeaderText = "Ngày sinh";
      this.Column3.Name = "Column3";
      // 
      // Column4
      // 
      this.Column4.DataPropertyName = "Phai";
      this.Column4.HeaderText = "Phái";
      this.Column4.Name = "Column4";
      // 
      // Column5
      // 
      this.Column5.DataPropertyName = "DiaChi";
      this.Column5.HeaderText = "Địa chỉ";
      this.Column5.Name = "Column5";
      // 
      // Column6
      // 
      this.Column6.HeaderText = "Diểm môn 1";
      this.Column6.Name = "Column6";
      // 
      // Column7
      // 
      this.Column7.HeaderText = "Điểm môn 2";
      this.Column7.Name = "Column7";
      // 
      // Column8
      // 
      this.Column8.HeaderText = "kết Quả";
      this.Column8.Name = "Column8";
      // 
      // FormQuanLyHocVien
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(655, 382);
      this.Controls.Add(this.txtKetQua);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtDiemMon2);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.dgvHS);
      this.Controls.Add(this.btnLuuFile);
      this.Controls.Add(this.btnXoa);
      this.Controls.Add(this.btnSua);
      this.Controls.Add(this.btnThem);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.dtpNgaySinh);
      this.Controls.Add(this.txtHoTen);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtDiemMon1);
      this.Controls.Add(this.txtDiaChi);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtMaHS);
      this.Controls.Add(this.label1);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "FormQuanLyHocVien";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FormQuanLyHocVien_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuuFile;
        private System.Windows.Forms.DataGridView dgvHS;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtDiemMon1;
    private System.Windows.Forms.TextBox txtDiemMon2;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtKetQua;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
  }
}

