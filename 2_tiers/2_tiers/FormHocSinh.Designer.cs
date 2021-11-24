namespace _2_tiers
{
    partial class FormHocSinh
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMaSoHocSinh = new System.Windows.Forms.TextBox();
            this.textBoxHoTenHocSinh = new System.Windows.Forms.TextBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.groupBoxPhai = new System.Windows.Forms.GroupBox();
            this.radioButtonPhaiNu = new System.Windows.Forms.RadioButton();
            this.radioButtonPhaiNam = new System.Windows.Forms.RadioButton();
            this.dataGridViewFromHocSinh = new System.Windows.Forms.DataGridView();
            this.ColumnMaSoHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHoTenHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPhai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFromHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số học sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(27, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(27, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(27, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // textBoxMaSoHocSinh
            // 
            this.textBoxMaSoHocSinh.Location = new System.Drawing.Point(173, 40);
            this.textBoxMaSoHocSinh.Name = "textBoxMaSoHocSinh";
            this.textBoxMaSoHocSinh.Size = new System.Drawing.Size(176, 20);
            this.textBoxMaSoHocSinh.TabIndex = 4;
            // 
            // textBoxHoTenHocSinh
            // 
            this.textBoxHoTenHocSinh.Location = new System.Drawing.Point(173, 83);
            this.textBoxHoTenHocSinh.Name = "textBoxHoTenHocSinh";
            this.textBoxHoTenHocSinh.Size = new System.Drawing.Size(176, 20);
            this.textBoxHoTenHocSinh.TabIndex = 5;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(173, 164);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(262, 20);
            this.textBoxDiaChi.TabIndex = 6;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(173, 122);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgaySinh.TabIndex = 7;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(510, 40);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 8;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(510, 80);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 9;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(510, 121);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 10;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(510, 162);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(75, 23);
            this.buttonLuu.TabIndex = 11;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // groupBoxPhai
            // 
            this.groupBoxPhai.Controls.Add(this.radioButtonPhaiNu);
            this.groupBoxPhai.Controls.Add(this.radioButtonPhaiNam);
            this.groupBoxPhai.Location = new System.Drawing.Point(388, 40);
            this.groupBoxPhai.Name = "groupBoxPhai";
            this.groupBoxPhai.Size = new System.Drawing.Size(97, 100);
            this.groupBoxPhai.TabIndex = 12;
            this.groupBoxPhai.TabStop = false;
            this.groupBoxPhai.Text = "Phái";
            // 
            // radioButtonPhaiNu
            // 
            this.radioButtonPhaiNu.AutoSize = true;
            this.radioButtonPhaiNu.Checked = true;
            this.radioButtonPhaiNu.Location = new System.Drawing.Point(6, 61);
            this.radioButtonPhaiNu.Name = "radioButtonPhaiNu";
            this.radioButtonPhaiNu.Size = new System.Drawing.Size(39, 17);
            this.radioButtonPhaiNu.TabIndex = 1;
            this.radioButtonPhaiNu.TabStop = true;
            this.radioButtonPhaiNu.Text = "Nữ";
            this.radioButtonPhaiNu.UseVisualStyleBackColor = true;
            this.radioButtonPhaiNu.CheckedChanged += new System.EventHandler(this.radioButtonPhaiNu_CheckedChanged);
            // 
            // radioButtonPhaiNam
            // 
            this.radioButtonPhaiNam.AutoSize = true;
            this.radioButtonPhaiNam.Location = new System.Drawing.Point(7, 29);
            this.radioButtonPhaiNam.Name = "radioButtonPhaiNam";
            this.radioButtonPhaiNam.Size = new System.Drawing.Size(47, 17);
            this.radioButtonPhaiNam.TabIndex = 0;
            this.radioButtonPhaiNam.Text = "Nam";
            this.radioButtonPhaiNam.UseVisualStyleBackColor = true;
            this.radioButtonPhaiNam.CheckedChanged += new System.EventHandler(this.radioButtonPhaiNam_CheckedChanged);
            // 
            // dataGridViewFromHocSinh
            // 
            this.dataGridViewFromHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFromHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaSoHocSinh,
            this.ColumnHoTenHocSinh,
            this.ColumnNgaySinh,
            this.ColumnPhai,
            this.ColumnDiaChi});
            this.dataGridViewFromHocSinh.Location = new System.Drawing.Point(31, 231);
            this.dataGridViewFromHocSinh.Name = "dataGridViewFromHocSinh";
            this.dataGridViewFromHocSinh.Size = new System.Drawing.Size(554, 190);
            this.dataGridViewFromHocSinh.TabIndex = 13;
            this.dataGridViewFromHocSinh.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFromHocSinh_RowEnter);
            // 
            // ColumnMaSoHocSinh
            // 
            this.ColumnMaSoHocSinh.HeaderText = "Mã số học sinh";
            this.ColumnMaSoHocSinh.Name = "ColumnMaSoHocSinh";
            // 
            // ColumnHoTenHocSinh
            // 
            this.ColumnHoTenHocSinh.HeaderText = "Họ tên";
            this.ColumnHoTenHocSinh.Name = "ColumnHoTenHocSinh";
            // 
            // ColumnNgaySinh
            // 
            this.ColumnNgaySinh.HeaderText = "Ngày sinh";
            this.ColumnNgaySinh.Name = "ColumnNgaySinh";
            // 
            // ColumnPhai
            // 
            this.ColumnPhai.HeaderText = "Phái";
            this.ColumnPhai.Name = "ColumnPhai";
            // 
            // ColumnDiaChi
            // 
            this.ColumnDiaChi.HeaderText = "Địa chỉ";
            this.ColumnDiaChi.Name = "ColumnDiaChi";
            // 
            // FormHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.dataGridViewFromHocSinh);
            this.Controls.Add(this.groupBoxPhai);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.textBoxHoTenHocSinh);
            this.Controls.Add(this.textBoxMaSoHocSinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormHocSinh";
            this.Text = "Form học sinh";
            this.Load += new System.EventHandler(this.FormHocSinh_Load);
            this.groupBoxPhai.ResumeLayout(false);
            this.groupBoxPhai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFromHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMaSoHocSinh;
        private System.Windows.Forms.TextBox textBoxHoTenHocSinh;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.GroupBox groupBoxPhai;
        private System.Windows.Forms.RadioButton radioButtonPhaiNu;
        private System.Windows.Forms.RadioButton radioButtonPhaiNam;
        private System.Windows.Forms.DataGridView dataGridViewFromHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaSoHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHoTenHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiaChi;
    }
}

