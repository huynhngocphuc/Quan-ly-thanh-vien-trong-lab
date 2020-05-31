namespace QuanLyNhanSu2
{
    partial class FormTimKiem2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimKiem2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioMaNV = new System.Windows.Forms.RadioButton();
            this.radioHoten = new System.Windows.Forms.RadioButton();
            this.radioCMTND = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txttukhoa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvThongtinTimkiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinTimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radioMaNV
            // 
            this.radioMaNV.AutoSize = true;
            this.radioMaNV.Location = new System.Drawing.Point(35, 18);
            this.radioMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.radioMaNV.Name = "radioMaNV";
            this.radioMaNV.Size = new System.Drawing.Size(146, 27);
            this.radioMaNV.TabIndex = 1;
            this.radioMaNV.TabStop = true;
            this.radioMaNV.Text = "Mã nhân viên";
            this.radioMaNV.UseVisualStyleBackColor = true;
            this.radioMaNV.CheckedChanged += new System.EventHandler(this.radioMaNV_CheckedChanged);
            // 
            // radioHoten
            // 
            this.radioHoten.AutoSize = true;
            this.radioHoten.Location = new System.Drawing.Point(200, 18);
            this.radioHoten.Margin = new System.Windows.Forms.Padding(4);
            this.radioHoten.Name = "radioHoten";
            this.radioHoten.Size = new System.Drawing.Size(111, 27);
            this.radioHoten.TabIndex = 2;
            this.radioHoten.TabStop = true;
            this.radioHoten.Text = "Họ và tên";
            this.radioHoten.UseVisualStyleBackColor = true;
            this.radioHoten.CheckedChanged += new System.EventHandler(this.radioHoten_CheckedChanged);
            // 
            // radioCMTND
            // 
            this.radioCMTND.AutoSize = true;
            this.radioCMTND.Location = new System.Drawing.Point(361, 18);
            this.radioCMTND.Margin = new System.Windows.Forms.Padding(4);
            this.radioCMTND.Name = "radioCMTND";
            this.radioCMTND.Size = new System.Drawing.Size(102, 27);
            this.radioCMTND.TabIndex = 3;
            this.radioCMTND.TabStop = true;
            this.radioCMTND.Text = "CMTND";
            this.radioCMTND.UseVisualStyleBackColor = true;
            this.radioCMTND.CheckedChanged += new System.EventHandler(this.radioCMTND_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txttukhoa);
            this.groupBox1.Controls.Add(this.radioHoten);
            this.groupBox1.Controls.Add(this.radioCMTND);
            this.groupBox1.Controls.Add(this.radioMaNV);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(235, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(508, 199);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(295, 130);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(137, 55);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(55, 130);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(139, 55);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txttukhoa
            // 
            this.txttukhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttukhoa.Location = new System.Drawing.Point(35, 76);
            this.txttukhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txttukhoa.Name = "txttukhoa";
            this.txttukhoa.Size = new System.Drawing.Size(437, 29);
            this.txttukhoa.TabIndex = 4;
            this.txttukhoa.Text = "Nhập vào từ khóa tìm kiếm";
            this.txttukhoa.TextChanged += new System.EventHandler(this.txttukhoa_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvThongtinTimkiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(856, 270);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dgvThongtinTimkiem
            // 
            this.dgvThongtinTimkiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongtinTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongtinTimkiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongtinTimkiem.Location = new System.Drawing.Point(4, 23);
            this.dgvThongtinTimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThongtinTimkiem.Name = "dgvThongtinTimkiem";
            this.dgvThongtinTimkiem.Size = new System.Drawing.Size(848, 243);
            this.dgvThongtinTimkiem.TabIndex = 0;
            // 
            // FormTimKiem2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(880, 533);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTimKiem2";
            this.Text = " Tra cứu - Tìm kiếm";
            this.Load += new System.EventHandler(this.FormTimKiem2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongtinTimkiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioMaNV;
        private System.Windows.Forms.RadioButton radioHoten;
        private System.Windows.Forms.RadioButton radioCMTND;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txttukhoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvThongtinTimkiem;
    }
}