namespace QuanLyNhanSu2
{
    partial class FrmBaoHiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoHiem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbbLoaiBH = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.txtMaNS = new System.Windows.Forms.TextBox();
            this.cbbhoten = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblThem = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.datetimeBH = new System.Windows.Forms.DateTimePicker();
            this.txtnoicapBH = new System.Windows.Forms.TextBox();
            this.txtMaBH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbghichubaohiem = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvBaoHiem = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaycapBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoicapBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cbbLoaiBH);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnBaocao);
            this.groupBox1.Controls.Add(this.txtMaNS);
            this.groupBox1.Controls.Add(this.cbbhoten);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblSave);
            this.groupBox1.Controls.Add(this.lblThem);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.datetimeBH);
            this.groupBox1.Controls.Add(this.txtnoicapBH);
            this.groupBox1.Controls.Add(this.txtMaBH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(996, 420);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bảo Hiểm của Nhân Viên";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QuanLyNhanSu2.Properties.Resources.iconfinder_pencil_3688460;
            this.btnSave.Location = new System.Drawing.Point(225, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 49);
            this.btnSave.TabIndex = 35;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbbLoaiBH
            // 
            this.cbbLoaiBH.FormattingEnabled = true;
            this.cbbLoaiBH.Location = new System.Drawing.Point(184, 231);
            this.cbbLoaiBH.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiBH.Name = "cbbLoaiBH";
            this.cbbLoaiBH.Size = new System.Drawing.Size(223, 31);
            this.cbbLoaiBH.TabIndex = 34;
            this.cbbLoaiBH.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiBH_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(667, 353);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "Sao lưu";
            // 
            // btnBaocao
            // 
            this.btnBaocao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBaocao.BackgroundImage")));
            this.btnBaocao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBaocao.Location = new System.Drawing.Point(672, 300);
            this.btnBaocao.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(57, 49);
            this.btnBaocao.TabIndex = 32;
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // txtMaNS
            // 
            this.txtMaNS.Location = new System.Drawing.Point(184, 65);
            this.txtMaNS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNS.Name = "txtMaNS";
            this.txtMaNS.Size = new System.Drawing.Size(223, 30);
            this.txtMaNS.TabIndex = 30;
            // 
            // cbbhoten
            // 
            this.cbbhoten.FormattingEnabled = true;
            this.cbbhoten.Location = new System.Drawing.Point(640, 59);
            this.cbbhoten.Margin = new System.Windows.Forms.Padding(4);
            this.cbbhoten.Name = "cbbhoten";
            this.cbbhoten.Size = new System.Drawing.Size(329, 31);
            this.cbbhoten.TabIndex = 29;
            this.cbbhoten.SelectedIndexChanged += new System.EventHandler(this.cbbhoten_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 69);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 23);
            this.label14.TabIndex = 27;
            this.label14.Text = "Mã nhân viên";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(449, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "Họ và tên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(797, 353);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "Back";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(543, 353);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Xóa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Sửa";
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(234, 353);
            this.lblSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(45, 23);
            this.lblSave.TabIndex = 17;
            this.lblSave.Text = "Lưu";
            // 
            // lblThem
            // 
            this.lblThem.AutoSize = true;
            this.lblThem.Location = new System.Drawing.Point(221, 353);
            this.lblThem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThem.Name = "lblThem";
            this.lblThem.Size = new System.Drawing.Size(58, 23);
            this.lblThem.TabIndex = 17;
            this.lblThem.Text = "Thêm";
            // 
            // btnthoat
            // 
            this.btnthoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat.BackgroundImage")));
            this.btnthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat.Location = new System.Drawing.Point(803, 300);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(57, 49);
            this.btnthoat.TabIndex = 15;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackgroundImage = global::QuanLyNhanSu2.Properties.Resources.table3_delete;
            this.btnxoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxoa.Location = new System.Drawing.Point(533, 300);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(57, 49);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackgroundImage = global::QuanLyNhanSu2.Properties.Resources.sửa1;
            this.btnsua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsua.Location = new System.Drawing.Point(395, 300);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(57, 49);
            this.btnsua.TabIndex = 11;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackgroundImage = global::QuanLyNhanSu2.Properties.Resources.more_32;
            this.btnthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthem.Location = new System.Drawing.Point(227, 300);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(57, 49);
            this.btnthem.TabIndex = 10;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // datetimeBH
            // 
            this.datetimeBH.CustomFormat = "dd/MM/yyy";
            this.datetimeBH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimeBH.Location = new System.Drawing.Point(640, 146);
            this.datetimeBH.Margin = new System.Windows.Forms.Padding(4);
            this.datetimeBH.Name = "datetimeBH";
            this.datetimeBH.Size = new System.Drawing.Size(329, 30);
            this.datetimeBH.TabIndex = 8;
            // 
            // txtnoicapBH
            // 
            this.txtnoicapBH.Location = new System.Drawing.Point(640, 233);
            this.txtnoicapBH.Margin = new System.Windows.Forms.Padding(4);
            this.txtnoicapBH.Name = "txtnoicapBH";
            this.txtnoicapBH.Size = new System.Drawing.Size(329, 30);
            this.txtnoicapBH.TabIndex = 7;
            // 
            // txtMaBH
            // 
            this.txtMaBH.Location = new System.Drawing.Point(184, 143);
            this.txtMaBH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBH.Name = "txtMaBH";
            this.txtMaBH.Size = new System.Drawing.Size(223, 30);
            this.txtMaBH.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chức Năng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nơi Cấp Bảo Hiểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Cấp Bảo Hiểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại Bảo Hiểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sổ Bảo Hiểm";
            // 
            // rtbghichubaohiem
            // 
            this.rtbghichubaohiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbghichubaohiem.Location = new System.Drawing.Point(115, 442);
            this.rtbghichubaohiem.Margin = new System.Windows.Forms.Padding(4);
            this.rtbghichubaohiem.Name = "rtbghichubaohiem";
            this.rtbghichubaohiem.Size = new System.Drawing.Size(899, 62);
            this.rtbghichubaohiem.TabIndex = 18;
            this.rtbghichubaohiem.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 442);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ghi Chú";
            // 
            // dgvBaoHiem
            // 
            this.dgvBaoHiem.AllowUserToAddRows = false;
            this.dgvBaoHiem.AllowUserToDeleteRows = false;
            this.dgvBaoHiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBaoHiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoHiem.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoHiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoHiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNV,
            this.Hoten,
            this.MaBH,
            this.LoaiBH,
            this.NgaycapBH,
            this.NoicapBH});
            this.dgvBaoHiem.Location = new System.Drawing.Point(19, 512);
            this.dgvBaoHiem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBaoHiem.Name = "dgvBaoHiem";
            this.dgvBaoHiem.RowHeadersVisible = false;
            this.dgvBaoHiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoHiem.Size = new System.Drawing.Size(996, 246);
            this.dgvBaoHiem.TabIndex = 19;
            this.dgvBaoHiem.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBaoHiem_ColumnHeaderMouseClick);
            this.dgvBaoHiem.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaoHiem_RowEnter);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.FillWeight = 88.83247F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 35;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân sự";
            this.MaNV.Name = "MaNV";
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "HoTen";
            this.Hoten.HeaderText = "Họ tên nhân sự";
            this.Hoten.Name = "Hoten";
            // 
            // MaBH
            // 
            this.MaBH.DataPropertyName = "MaBH";
            this.MaBH.FillWeight = 102.7919F;
            this.MaBH.HeaderText = "Mã sổ bảo hiểm";
            this.MaBH.Name = "MaBH";
            // 
            // LoaiBH
            // 
            this.LoaiBH.DataPropertyName = "LoaiBH";
            this.LoaiBH.FillWeight = 102.7919F;
            this.LoaiBH.HeaderText = "Loại bảo hiểm";
            this.LoaiBH.Name = "LoaiBH";
            // 
            // NgaycapBH
            // 
            this.NgaycapBH.DataPropertyName = "NgaycapBH";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.NgaycapBH.DefaultCellStyle = dataGridViewCellStyle3;
            this.NgaycapBH.FillWeight = 102.7919F;
            this.NgaycapBH.HeaderText = "Ngày cấp";
            this.NgaycapBH.Name = "NgaycapBH";
            // 
            // NoicapBH
            // 
            this.NoicapBH.DataPropertyName = "NoicapBH";
            this.NoicapBH.FillWeight = 102.7919F;
            this.NoicapBH.HeaderText = "Nơi cấp";
            this.NoicapBH.Name = "NoicapBH";
            // 
            // FrmBaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1031, 766);
            this.Controls.Add(this.dgvBaoHiem);
            this.Controls.Add(this.rtbghichubaohiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBaoHiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảo hiểm";
            this.Load += new System.EventHandler(this.FrmBaoHiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbhoten;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblThem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DateTimePicker datetimeBH;
        private System.Windows.Forms.TextBox txtnoicapBH;
        private System.Windows.Forms.TextBox txtMaBH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbghichubaohiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvBaoHiem;
        private System.Windows.Forms.TextBox txtMaNS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.ComboBox cbbLoaiBH;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaycapBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoicapBH;
    }
}