namespace bai_8_thuc_thanh_1
{
    partial class formNhaSanXuat
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTenNhaSanXuat = new System.Windows.Forms.TextBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.textBoxMaNhaSanXuat = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.dataGridViewNhaSanXuat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaSanXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tên nhà sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "mã nhà sản xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "địa chỉ";
            // 
            // textBoxTenNhaSanXuat
            // 
            this.textBoxTenNhaSanXuat.Location = new System.Drawing.Point(126, 19);
            this.textBoxTenNhaSanXuat.Name = "textBoxTenNhaSanXuat";
            this.textBoxTenNhaSanXuat.Size = new System.Drawing.Size(100, 20);
            this.textBoxTenNhaSanXuat.TabIndex = 4;
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Location = new System.Drawing.Point(124, 97);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiaChi.TabIndex = 5;
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(124, 71);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoDienThoai.TabIndex = 6;
            // 
            // textBoxMaNhaSanXuat
            // 
            this.textBoxMaNhaSanXuat.Location = new System.Drawing.Point(124, 45);
            this.textBoxMaNhaSanXuat.Name = "textBoxMaNhaSanXuat";
            this.textBoxMaNhaSanXuat.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaNhaSanXuat.TabIndex = 7;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(296, 19);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 8;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(296, 48);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 9;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(296, 89);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 10;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // dataGridViewNhaSanXuat
            // 
            this.dataGridViewNhaSanXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhaSanXuat.Location = new System.Drawing.Point(12, 159);
            this.dataGridViewNhaSanXuat.Name = "dataGridViewNhaSanXuat";
            this.dataGridViewNhaSanXuat.Size = new System.Drawing.Size(493, 279);
            this.dataGridViewNhaSanXuat.TabIndex = 11;
            this.dataGridViewNhaSanXuat.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhaSanXuat_RowEnter);
            // 
            // formNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.dataGridViewNhaSanXuat);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxMaNhaSanXuat);
            this.Controls.Add(this.textBoxSoDienThoai);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.textBoxTenNhaSanXuat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formNhaSanXuat";
            this.Text = "form nhà sản xuất";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhaSanXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTenNhaSanXuat;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.TextBox textBoxMaNhaSanXuat;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.DataGridView dataGridViewNhaSanXuat;
    }
}

