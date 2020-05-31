namespace QuanLyNhanSu2
{
    partial class TinhLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinhLuong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvtest = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thangtangcuoicung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtest)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvtest);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 177);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1040, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvtest
            // 
            this.dgvtest.AllowUserToAddRows = false;
            this.dgvtest.AllowUserToDeleteRows = false;
            this.dgvtest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtest.BackgroundColor = System.Drawing.Color.White;
            this.dgvtest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNV,
            this.HSL,
            this.Thangtangcuoicung});
            this.dgvtest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvtest.Location = new System.Drawing.Point(4, 26);
            this.dgvtest.Margin = new System.Windows.Forms.Padding(4);
            this.dgvtest.Name = "dgvtest";
            this.dgvtest.RowHeadersVisible = false;
            this.dgvtest.Size = new System.Drawing.Size(1032, 328);
            this.dgvtest.TabIndex = 0;
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
            this.Thangtangcuoicung.HeaderText = "Tháng tăng cuối cùng";
            this.Thangtangcuoicung.Name = "Thangtangcuoicung";
            // 
            // btnTinh
            // 
            this.btnTinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Image = ((System.Drawing.Image)(resources.GetObject("btnTinh.Image")));
            this.btnTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinh.Location = new System.Drawing.Point(675, 62);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(136, 52);
            this.btnTinh.TabIndex = 1;
            this.btnTinh.Text = "Tính lương";
            this.btnTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTinh.UseVisualStyleBackColor = false;
            // 
            // btncapnhat
            // 
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncapnhat.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.Image = global::QuanLyNhanSu2.Properties.Resources._1422736882_24350;
            this.btncapnhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncapnhat.Location = new System.Drawing.Point(233, 62);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(136, 52);
            this.btncapnhat.TabIndex = 2;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1049, 543);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TinhLuong";
            this.Text = "Tính lương";
            this.Load += new System.EventHandler(this.TinhLuong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvtest;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thangtangcuoicung;
    }
}