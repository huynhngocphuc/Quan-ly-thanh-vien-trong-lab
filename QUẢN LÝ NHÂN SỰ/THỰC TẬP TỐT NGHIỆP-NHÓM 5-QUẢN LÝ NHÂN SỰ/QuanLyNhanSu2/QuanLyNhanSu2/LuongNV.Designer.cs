namespace QuanLyNhanSu2
{
    partial class LuongNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuongNV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNam = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExel = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvluongnhanvien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thangtangcuoicung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BHXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BHYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BHTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongThucLanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvluongnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtNam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnExel);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTinh);
            this.groupBox1.Controls.Add(this.cbMonth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1347, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 91;
            this.label5.Text = "Năm:";
            // 
            // dtNam
            // 
            this.dtNam.CustomFormat = "yyyy";
            this.dtNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNam.Location = new System.Drawing.Point(113, 75);
            this.dtNam.Margin = new System.Windows.Forms.Padding(4);
            this.dtNam.Name = "dtNam";
            this.dtNam.Size = new System.Drawing.Size(83, 29);
            this.dtNam.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1189, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 89;
            this.label4.Text = "Export";
            // 
            // btnExel
            // 
            this.btnExel.BackgroundImage = global::QuanLyNhanSu2.Properties.Resources._1422737132_39412;
            this.btnExel.Location = new System.Drawing.Point(1193, 22);
            this.btnExel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExel.Name = "btnExel";
            this.btnExel.Size = new System.Drawing.Size(49, 48);
            this.btnExel.TabIndex = 88;
            this.btnExel.UseVisualStyleBackColor = true;
            this.btnExel.Click += new System.EventHandler(this.btnExel_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(451, 36);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(181, 29);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1036, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 87;
            this.label3.Text = "Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng thưởng:";
            // 
            // btnTinh
            // 
            this.btnTinh.BackgroundImage = global::QuanLyNhanSu2.Properties.Resources._1422652976_17220;
            this.btnTinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTinh.Location = new System.Drawing.Point(991, 22);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(127, 49);
            this.btnTinh.TabIndex = 86;
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(113, 32);
            this.cbMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(181, 30);
            this.cbMonth.TabIndex = 1;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(717, 75);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 22);
            this.label25.TabIndex = 83;
            this.label25.Text = "Cập nhật";
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = global::QuanLyNhanSu2.Properties.Resources._1422736882_24350;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.Location = new System.Drawing.Point(721, 22);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(69, 49);
            this.btnthem.TabIndex = 82;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvluongnhanvien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1351, 448);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            // 
            // dgvluongnhanvien
            // 
            this.dgvluongnhanvien.AllowUserToAddRows = false;
            this.dgvluongnhanvien.AllowUserToDeleteRows = false;
            this.dgvluongnhanvien.BackgroundColor = System.Drawing.Color.White;
            this.dgvluongnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvluongnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNV,
            this.HoTen,
            this.HSL,
            this.Thangtangcuoicung,
            this.BHXH,
            this.BHYT,
            this.BHTN,
            this.TongPC,
            this.LuongThucLanh});
            this.dgvluongnhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvluongnhanvien.Location = new System.Drawing.Point(4, 26);
            this.dgvluongnhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvluongnhanvien.Name = "dgvluongnhanvien";
            this.dgvluongnhanvien.RowHeadersVisible = false;
            this.dgvluongnhanvien.Size = new System.Drawing.Size(1343, 418);
            this.dgvluongnhanvien.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            // 
            // HSL
            // 
            this.HSL.DataPropertyName = "HSL";
            this.HSL.HeaderText = "HSL";
            this.HSL.Name = "HSL";
            // 
            // Thangtangcuoicung
            // 
            this.Thangtangcuoicung.DataPropertyName = "Thangtangcuoicung";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Thangtangcuoicung.DefaultCellStyle = dataGridViewCellStyle1;
            this.Thangtangcuoicung.HeaderText = "Tháng cuối tăng HSL";
            this.Thangtangcuoicung.Name = "Thangtangcuoicung";
            // 
            // BHXH
            // 
            this.BHXH.DataPropertyName = "BHXH";
            this.BHXH.HeaderText = "BHXH";
            this.BHXH.Name = "BHXH";
            // 
            // BHYT
            // 
            this.BHYT.DataPropertyName = "BHYT";
            this.BHYT.HeaderText = "BHYT";
            this.BHYT.Name = "BHYT";
            // 
            // BHTN
            // 
            this.BHTN.DataPropertyName = "BHTN";
            this.BHTN.HeaderText = "BHTN";
            this.BHTN.Name = "BHTN";
            // 
            // TongPC
            // 
            this.TongPC.DataPropertyName = "TongPC";
            this.TongPC.HeaderText = "Tổng PC";
            this.TongPC.Name = "TongPC";
            // 
            // LuongThucLanh
            // 
            this.LuongThucLanh.DataPropertyName = "LuongThucLanh";
            this.LuongThucLanh.HeaderText = "Lương thực lãnh";
            this.LuongThucLanh.Name = "LuongThucLanh";
            // 
            // LuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1364, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LuongNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lương nhân viên";
            this.Load += new System.EventHandler(this.LuongNV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvluongnhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvluongnhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thangtangcuoicung;
        private System.Windows.Forms.DataGridViewTextBoxColumn BHXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BHYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BHTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongThucLanh;
        private System.Windows.Forms.Button btnExel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNam;
        private System.Windows.Forms.Label label5;
    }
}