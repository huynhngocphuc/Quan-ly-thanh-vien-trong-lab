using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyNhanSu2;
using System.Configuration;

namespace QuanLyNhanSu2
{
    public partial class FrmCapnhatBH : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        public FrmCapnhatBH()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);

            InitializeComponent();
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "CNBaoHiem_Select").Tables[0];
                dgvCapNhatBH.AutoGenerateColumns = false;
                dgvCapNhatBH.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
        private void FillData_sqlHelper()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                string strSQL = "SELECT MaLoaiBH,LoaiBH FROM CapnhatBH";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                dgvCapNhatBH.AutoGenerateColumns = false;
                dgvCapNhatBH.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgvCapNhatBH.Rows.Count; i++)
                dgvCapNhatBH["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void FrmCapnhatBH_Load(object sender, EventArgs e)
        {
            FillData_sqlHelper();
            txtmaloaibaohiem.Enabled = false;
            btnSave.Visible = false;
            lblSave.Visible = false;
        }

        private void dgvCapNhatBH_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillNO();
        }
        private bool CheckExit()
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "CNBaoHiem_SelectById", txtmaloaibaohiem.Text.Trim());
                if (reader.Read())
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
            return false;
        }
        private bool CheckValid()
        {
            string strError = "";
            if (txtmaloaibaohiem.Text.Trim() == "")
                strError = "Bạn chưa nhập mã loại bảo hiểm\n";
            //kiểm tra xem mã phòng ban đã tồn tại hay chưa?
            if (CheckExit() == true)
                strError = "Mã này đã tồn tại. Vui lòng nhập mã khác\n";
            if (txtloaibaohiem.Text.Trim() == "")
                strError += "Bạn chưa nhập tên loại bảo hiểm";
            if (strError != "")
            {
                MessageBox.Show("Lỗi" + strError, "Thông Báo");
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmaloaibaohiem.Enabled = true;
            btnthem.Visible = false;
            lblThem.Visible = false;
            btnSave.Visible = true;
            lblSave.Visible = true;
            txtmaloaibaohiem.Text = "";
            txtloaibaohiem.Text = "";
        }
        private int rowIndex = 0;

        private void dgvCapNhatBH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = dgvCapNhatBH.Rows[e.RowIndex];
            try
            {
                txtmaloaibaohiem.Text = row.Cells["MaLoaiBH"].Value.ToString();
                txtloaibaohiem.Text = row.Cells["LoaiBH"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaLoaiBH = txtmaloaibaohiem.Text.Trim();
            string LoaiBH = txtloaibaohiem.Text.Trim();

            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "CNBaoHiem_update", MaLoaiBH, LoaiBH);
                //FillData_sqlHelper();
                dgvCapNhatBH["MaLoaiBH", rowIndex].Value = MaLoaiBH;
                dgvCapNhatBH["LoaiBH", rowIndex].Value = LoaiBH;
                MessageBox.Show("Sửa thông tin thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MaLoaiBH = txtmaloaibaohiem.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa:" + MaLoaiBH, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "CNBaoHiem_delete", MaLoaiBH);
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
            string MaLoaiBH = txtmaloaibaohiem.Text.Trim();
            string LoaiBH = txtloaibaohiem.Text.Trim();

            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "CNBaoHiem_insert", MaLoaiBH, LoaiBH);
                FillData_sqlHelper();
                btnSave.Visible = false;
                lblSave.Visible = false;
                btnthem.Visible = true;
                lblThem.Visible = true;
                txtmaloaibaohiem.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
    }
}
