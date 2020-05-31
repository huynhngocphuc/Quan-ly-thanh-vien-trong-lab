using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyNhanSu2;

namespace QuanLyNhanSu2
{
    public partial class FormTimKiem2 : Form
    {
        Clsdatabase cls = new Clsdatabase();
        //string strCon = "Data Source=Sakura-PC;Initial Catalog=QuanLyNhanSu2;Integrated Security=True;Pooling=False";
        public FormTimKiem2()
        {
            InitializeComponent();
        }
        int i = 0;
        private void radioMaNV_CheckedChanged(object sender, EventArgs e)
        {
            i = 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioHoten_CheckedChanged(object sender, EventArgs e)
        {
            i = 2;
        }

        private void radioCMTND_CheckedChanged(object sender, EventArgs e)
        {
            i = 3;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txttukhoa.Text == "") || (txttukhoa.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    MessageBox.Show("Bạn chưa nhập từ khóa", "Nhập từ khóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (i == 1)
                    {
                        cls.LoadDatagridview(dgvThongtinTimkiem, "Select * from ChiTietHS where MaNV=N'" + txttukhoa.Text + "'");
                    }
                    if (i == 2)
                    {
                        cls.LoadDatagridview(dgvThongtinTimkiem, "Select * from ChiTietHS where Hoten=N'" + txttukhoa.Text + "'");
                    }
                    if (i == 3)
                    {
                        cls.LoadDatagridview(dgvThongtinTimkiem, "Select * from ChiTietHS where CMTND=N'" + txttukhoa.Text + "'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }

        private void FormTimKiem2_Load(object sender, EventArgs e)
        {
            radioMaNV.Checked = true;
            cls.LoadDatagridview(dgvThongtinTimkiem, "Select * from ChiTietHS");
        }

        private void txttukhoa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((txttukhoa.Text == "") || (txttukhoa.Text == "Nhập vào từ khóa tìm kiếm"))
                {
                    cls.LoadDatagridview(dgvThongtinTimkiem, "Select * from ChiTietHS");
                }
                else
                {
                    if (i == 1)
                    {
                        cls.loatextbox(txttukhoa, "Select * from ChiTietHS where MaNV like N'" + txttukhoa.Text + "%'", 0);
                        cls.LoadDatagridview(dgvThongtinTimkiem, "Select * from ChiTietHS where MaNV like N'" + txttukhoa.Text + "%'");
                    }
                    if (i == 2)
                    {
                        cls.loatextbox(txttukhoa, "Select * from ChiTietHS where MaNV like N'" + txttukhoa.Text + "%'", 1);
                        cls.LoadDatagridview(dgvThongtinTimkiem, "Select * from ChiTietHS where HoTen like N'" + txttukhoa.Text + "%'");
                    }
                    if (i == 3)
                    {
                        cls.loatextbox(txttukhoa, "Select * from ChiTietHS where MaNV like N'" + txttukhoa.Text + "%'", 17);
                        cls.LoadDatagridview(dgvThongtinTimkiem, "Select * from ChiTietHS where CMTND like N'" + txttukhoa.Text + "%'");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm sai");
            }
        }


    }
}
