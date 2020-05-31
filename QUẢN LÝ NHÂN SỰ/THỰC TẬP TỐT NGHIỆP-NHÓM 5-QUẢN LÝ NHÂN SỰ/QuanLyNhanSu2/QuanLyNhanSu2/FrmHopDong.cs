using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace QuanLyNhanSu2
{
    public partial class FrmHopDong : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public FrmHopDong()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            //SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "HOPDONG_Select").Tables[0];
                dgvHopDong.AutoGenerateColumns = false;
                dgvHopDong.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private void FillData_sqlHelper()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                string strSQL = "SELECT MaHD, LoaiHD, GhiChu FROM HOPDONG";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                dgvHopDong.AutoGenerateColumns = false;
                dgvHopDong.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgvHopDong.Rows.Count; i++)
                dgvHopDong["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }


        private void FrmHopDong_Load(object sender, EventArgs e)
        {
            FillData_sqlHelper();
            txtMaHD.Enabled = false;
            btnSave.Visible = false;
            lbnSave.Visible = false;
        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void dgvHopDong_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillNO();
        }
        private bool CheckExit()
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "HOPDONG_SelectByID", txtMaHD.Text.Trim());
                if (reader.Read())
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
            return false;
        }
        private bool CheckValid()
        {
            string strError = "";
            if (txtMaHD.Text.Trim() == "")
                strError = "Bạn chưa nhập mã nhân viên\n";
            
            if (CheckExit() == true)
                strError = "Đã có loại hợp đồng này\n";
            if (txtLoaiHD.Text.Trim() == "")
                strError += "Bạn chưa nhập loại hợp đồng\n";
            if (strError != "")
            {
                MessageBox.Show("Lỗi" + strError, "Thông Báo");
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = true;
            txtMaHD.Text = "";
            txtLoaiHD.Text = "";
            rtbghichuhopdong.Text = "";
            btnthem.Visible = false;
            label12.Visible = false;
            btnSave.Visible = true;
            lbnSave.Visible = true;
        }
        private int rowIndex = 0;

        private void dgvHopDong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = dgvHopDong.Rows[e.RowIndex];
            try
            {
                txtMaHD.Text = row.Cells["MaHD"].Value.ToString();
                txtLoaiHD.Text = row.Cells["LoaiHD"].Value.ToString();
                rtbghichuhopdong.Text = row.Cells["GhiChu"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaHD = txtMaHD.Text.Trim();
            string TenHD = txtLoaiHD.Text.Trim();
            string GhiChu = rtbghichuhopdong.Text.Trim();

            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "HOPDONG_Update", MaHD, TenHD,GhiChu);
                //FillData_sqlHelper();
                dgvHopDong["MaHD", rowIndex].Value = MaHD;
                dgvHopDong["LoaiHD", rowIndex].Value = TenHD;
                dgvHopDong["GhiChu", rowIndex].Value = GhiChu;
                MessageBox.Show("Sửa thông tin thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MaHD = txtMaHD.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa:" + MaHD, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "HOPDONG_Delete", MaHD);
                FillData_SP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckValid() == false)
                return;
            string MaHD = txtMaHD.Text.Trim();
            string LoaiHD = txtLoaiHD.Text.Trim();
            string GhiChu = rtbghichuhopdong.Text.Trim();

            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "HOPDONG_Insert", MaHD, LoaiHD, GhiChu);
                FillData_sqlHelper();
                btnSave.Visible = false;
                lbnSave.Visible = false;
                btnthem.Visible = true;
                label12.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
    }
}
