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
    public partial class FrmChucDanh : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public FrmChucDanh()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "ChucDanh_select").Tables[0];
                grvchucdanh.AutoGenerateColumns = false;
                grvchucdanh.DataSource = dtData;
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
                string strSQL = "SELECT MaChucDanh, TenChucDanh FROM ChucDanh";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                grvchucdanh.AutoGenerateColumns = false;
                grvchucdanh.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= grvchucdanh.Rows.Count; i++)
                grvchucdanh["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void FrmChucDanh_Load(object sender, EventArgs e)
        {
            FillData_sqlHelper();
            txtmachucdanh.Enabled = false;
            btnSave.Visible = false;
            lblSave.Visible = false;

        }

        private void grvchucdanh_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillNO();
        }
        private bool CheckExit()
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "ChucDanh_SelectByID", txtmachucdanh.Text.Trim());
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
            if (txtmachucdanh.Text.Trim() == "")
                strError = "Bạn chưa nhập mã chức danh\n";
            //kiểm tra xem mã phòng ban đã tồn tại hay chưa?
            if (CheckExit() == true)
                strError = "Mã này đã tồn tại. Vui lòng nhập mã khác\n";
            if (txttenchucdanh.Text.Trim() == "")
                strError += "Bạn chưa nhập tên chức danh";
            if (strError != "")
            {
                MessageBox.Show("Lỗi" + strError, "Thông Báo");
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmachucdanh.Enabled = true;
            txtmachucdanh.Text = "";
            txttenchucdanh.Text = "";
            btnthem.Visible = false;
            lblThem.Visible = false;
            btnSave.Visible = true;
            lblSave.Visible = true;

        }
        private int rowIndex = 0;

        private void grvchucdanh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = grvchucdanh.Rows[e.RowIndex];
            try
            {
                txtmachucdanh.Text = row.Cells["MaChucDanh"].Value.ToString();
                txttenchucdanh.Text = row.Cells["TenChucDanh"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaChucDanh = txtmachucdanh.Text.Trim();
            string TenChucDanh = txttenchucdanh.Text.Trim();

            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "ChucDanh_update", MaChucDanh, TenChucDanh);
                //FillData_sqlHelper();
                grvchucdanh["MaChucDanh", rowIndex].Value = MaChucDanh;
                grvchucdanh["TenChucDanh", rowIndex].Value = TenChucDanh;
                MessageBox.Show("Sửa thông tin thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MaChucDanh = txtmachucdanh.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa:" + MaChucDanh, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "ChucDanh_delete", MaChucDanh);
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
            string MaChucDanh = txtmachucdanh.Text.Trim();
            string TenChucDanh = txttenchucdanh.Text.Trim();

            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "ChucDanh_insert", MaChucDanh, TenChucDanh);
                FillData_sqlHelper();
                btnSave.Visible = false;
                lblSave.Visible = false;
                btnthem.Visible = true;
                lblThem.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
    }
}
