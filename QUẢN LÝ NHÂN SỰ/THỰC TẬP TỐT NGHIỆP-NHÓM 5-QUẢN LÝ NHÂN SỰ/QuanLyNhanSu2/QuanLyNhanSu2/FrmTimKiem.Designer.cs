namespace QuanLyNhanSu2
{
    partial class FrmTimKiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.cbbtrinhdo = new System.Windows.Forms.ComboBox();
            this.cbbchucvu = new System.Windows.Forms.ComboBox();
            this.cbbSearchBy = new System.Windows.Forms.ComboBox();
            this.cbbchucdanh = new System.Windows.Forms.ComboBox();
            this.cbbphongban = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grvtimkiem = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvtimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btntim);
            this.groupBox1.Controls.Add(this.cbbtrinhdo);
            this.groupBox1.Controls.Add(this.cbbchucvu);
            this.groupBox1.Controls.Add(this.cbbSearchBy);
            this.groupBox1.Controls.Add(this.cbbchucdanh);
            this.groupBox1.Controls.Add(this.cbbphongban);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1096, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Tìm Kiếm";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::QuanLyNhanSu2.Properties.Resources.iconfinder_Arrow_Right_1063918;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(486, 175);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 42);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btntim
            // 
            this.btntim.Image = global::QuanLyNhanSu2.Properties.Resources.iconfinder_search_magnifying_glass_find_103857;
            this.btntim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntim.Location = new System.Drawing.Point(486, 79);
            this.btntim.Margin = new System.Windows.Forms.Padding(4);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(116, 42);
            this.btntim.TabIndex = 10;
            this.btntim.Text = "Tìm";
            this.btntim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // cbbtrinhdo
            // 
            this.cbbtrinhdo.FormattingEnabled = true;
            this.cbbtrinhdo.Location = new System.Drawing.Point(724, 164);
            this.cbbtrinhdo.Margin = new System.Windows.Forms.Padding(4);
            this.cbbtrinhdo.Name = "cbbtrinhdo";
            this.cbbtrinhdo.Size = new System.Drawing.Size(312, 31);
            this.cbbtrinhdo.TabIndex = 9;
            this.cbbtrinhdo.SelectionChangeCommitted += new System.EventHandler(this.cbbtrinhdo_SelectionChangeCommitted);
            // 
            // cbbchucvu
            // 
            this.cbbchucvu.FormattingEnabled = true;
            this.cbbchucvu.Location = new System.Drawing.Point(724, 85);
            this.cbbchucvu.Margin = new System.Windows.Forms.Padding(4);
            this.cbbchucvu.Name = "cbbchucvu";
            this.cbbchucvu.Size = new System.Drawing.Size(312, 31);
            this.cbbchucvu.TabIndex = 8;
            this.cbbchucvu.SelectionChangeCommitted += new System.EventHandler(this.cbbchucvu_SelectionChangeCommitted);
            // 
            // cbbSearchBy
            // 
            this.cbbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSearchBy.FormattingEnabled = true;
            this.cbbSearchBy.Items.AddRange(new object[] {
            "Phòng Ban",
            "Chức Danh",
            "Chức Vụ",
            "Trình Độ"});
            this.cbbSearchBy.Location = new System.Drawing.Point(439, 25);
            this.cbbSearchBy.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSearchBy.Name = "cbbSearchBy";
            this.cbbSearchBy.Size = new System.Drawing.Size(276, 31);
            this.cbbSearchBy.TabIndex = 7;
            this.cbbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbbSearchBy_SelectedIndexChanged);
            // 
            // cbbchucdanh
            // 
            this.cbbchucdanh.FormattingEnabled = true;
            this.cbbchucdanh.Location = new System.Drawing.Point(181, 170);
            this.cbbchucdanh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbchucdanh.Name = "cbbchucdanh";
            this.cbbchucdanh.Size = new System.Drawing.Size(267, 31);
            this.cbbchucdanh.TabIndex = 6;
            this.cbbchucdanh.SelectionChangeCommitted += new System.EventHandler(this.cbbchucdanh_SelectionChangeCommitted);
            // 
            // cbbphongban
            // 
            this.cbbphongban.FormattingEnabled = true;
            this.cbbphongban.Location = new System.Drawing.Point(181, 85);
            this.cbbphongban.Margin = new System.Windows.Forms.Padding(4);
            this.cbbphongban.Name = "cbbphongban";
            this.cbbphongban.Size = new System.Drawing.Size(267, 31);
            this.cbbphongban.TabIndex = 5;
            this.cbbphongban.SelectionChangeCommitted += new System.EventHandler(this.cbbphongban_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trình Độ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chức Vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức Danh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phòng Ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Kiếm Theo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grvtimkiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 271);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1096, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // grvtimkiem
            // 
            this.grvtimkiem.BackgroundColor = System.Drawing.Color.White;
            this.grvtimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvtimkiem.Location = new System.Drawing.Point(8, 23);
            this.grvtimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.grvtimkiem.Name = "grvtimkiem";
            this.grvtimkiem.Size = new System.Drawing.Size(1029, 256);
            this.grvtimkiem.TabIndex = 0;
            // 
            // FrmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1097, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu - Tìm kiếm";
            this.Load += new System.EventHandler(this.FrmTimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvtimkiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbtrinhdo;
        private System.Windows.Forms.ComboBox cbbchucvu;
        private System.Windows.Forms.ComboBox cbbSearchBy;
        private System.Windows.Forms.ComboBox cbbchucdanh;
        private System.Windows.Forms.ComboBox cbbphongban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grvtimkiem;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnBack;
    }
}