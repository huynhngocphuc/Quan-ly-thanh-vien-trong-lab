using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyNhanSu2;
using System.Configuration;

namespace QuanLyNhanSu2
{
    public partial class FrmPhongBancs : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public FrmPhongBancs()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "PhongBan_select").Tables[0];
                grvphongban.AutoGenerateColumns = false;
                grvphongban.DataSource = dtData;
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
                string strSQL = "SELECT MaPhongBan, TenPhongBan FROM PhongBan";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                grvphongban.AutoGenerateColumns = false;
                grvphongban.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
        private void FillData()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                sqlCon.Open();
                //thao tac voi co so du lieu
                string strSQL = "SELECT MaPhongBan, TenPhongBan FROM PhongBan";
                SqlCommand cmd = new SqlCommand(strSQL, sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtData = new DataTable();
                da.Fill(dtData);
                //Hien thi du lieu len datagridview
                grvphongban.AutoGenerateColumns = false;
                grvphongban.DataSource = dtData;
                //hien so thu tu
                FillNO();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Lỗi" + Ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }


        }
        private void FillNO()
        {
            for (int i = 1; i <= grvphongban.Rows.Count; i++)
                grvphongban["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void FrmPhongBancs_Load(object sender, EventArgs e)
        {
           FillData_sqlHelper();
            btnSave.Visible = false;
            lblSave.Visible = false;
            txtmaphongban.Enabled = false;
        }

        private void grvphongban_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillNO();
        }
        private bool CheckExit()
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "PhongBan_SelectByID", txtmaphongban.Text.Trim());
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
            if (txtmaphongban.Text.Trim() == "")
                strError = "Bạn chưa nhập mã phòng ban\n";
            //kiểm tra xem mã phòng ban đã tồn tại hay chưa?
            if (CheckExit() == true)
                strError = "Mã này đã tồn tại. Vui lòng nhập mã khác\n";
            if (txttenphongban.Text.Trim() == "")
                strError += "Bạn chưa nhập tên phòng ban";
            if (strError != "")
            {
                MessageBox.Show("Lỗi" + strError, "Thông Báo");
                return false;
            }
            return true;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmaphongban.Enabled = true;
            txtmaphongban.Text = "";
            txttenphongban.Text = "";
            btnSave.Visible = true;
            lblSave.Visible = true;
        }

        private void grvphongban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0)
            //    return;
            //DataGridViewRow row = grvphongban.Rows[e.RowIndex];
            //try
            //{
            //    txtmaphongban.Text = row.Cells["MaPhongBan"].Value.ToString();
            //    txttenphongban.Text = row.Cells["TenPhongBan"].Value.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            //}
        }

        private int rowIndex = 0;
        private void grvphongban_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = grvphongban.Rows[e.RowIndex];
            try
            {
                txtmaphongban.Text = row.Cells["MaPhongBan"].Value.ToString();
                txttenphongban.Text = row.Cells["TenPhongBan"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaPhongBan = txtmaphongban.Text.Trim();
            string TenPhongBan = txttenphongban.Text.Trim();

            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "PhongBan_update", MaPhongBan, TenPhongBan);
                //FillData_sqlHelper();
                grvphongban["MaPhongBan", rowIndex].Value = MaPhongBan;
                grvphongban["TenPhongBan", rowIndex].Value = TenPhongBan;
                MessageBox.Show("Sửa thông tin thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MaPhongBan = txtmaphongban.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa:" + MaPhongBan, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "PhongBan_delete", MaPhongBan);
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
            string MaPhongBan = txtmaphongban.Text.Trim();
            string TenPhongBan = txttenphongban.Text.Trim();

            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "PhongBan_Inset", MaPhongBan, TenPhongBan);
                FillData_sqlHelper();
                txtmaphongban.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
    }
}
