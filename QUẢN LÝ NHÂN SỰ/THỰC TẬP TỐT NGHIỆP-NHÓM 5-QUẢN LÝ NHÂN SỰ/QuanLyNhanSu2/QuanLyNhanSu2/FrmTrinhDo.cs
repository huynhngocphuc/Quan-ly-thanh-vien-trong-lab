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
    public partial class FrmTrinhDo : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public FrmTrinhDo()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "TrinhDo_select").Tables[0];
                grvtrinhdo.AutoGenerateColumns = false;
                grvtrinhdo.DataSource = dtData;
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
                string strSQL = "SELECT MaTrinhDo, TenTrinhDo FROM TrinhDo";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                grvtrinhdo.AutoGenerateColumns = false;
                grvtrinhdo.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= grvtrinhdo.Rows.Count; i++)
                grvtrinhdo["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }

        private void FrmTrinhDo_Load(object sender, EventArgs e)
        {
            FillData_sqlHelper();
            btnSave.Visible = false;
            lblSave.Visible = false;
            txtmatrinhdo.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void grvtrinhdo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillNO();
        }
        private bool CheckExit()
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "TrinhDo_SelectByID", txtmatrinhdo.Text.Trim());
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
            if (txtmatrinhdo.Text.Trim() == "")
                strError = "Bạn chưa nhập mã trình độ\n";
            //kiểm tra xem mã phòng ban đã tồn tại hay chưa?
            if (CheckExit() == true)
                strError = "Mã này đã tồn tại. Vui lòng nhập mã khác\n";
            if (txttentrinhdo.Text.Trim() == "")
                strError += "Bạn chưa nhập tên trình độ";
            if (strError != "")
            {
                MessageBox.Show("Lỗi" + strError, "Thông Báo");
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmatrinhdo.Text = "";
            txtmatrinhdo.Enabled = true;
            txttentrinhdo.Text = "";
            btnSave.Visible = true;
            lblSave.Visible = true;
        {

        }
        }
        private int rowIndex = 0;

        private void grvtrinhdo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = grvtrinhdo.Rows[e.RowIndex];
            try
            {
                txtmatrinhdo.Text = row.Cells["MaTrinhDo"].Value.ToString();
                txttentrinhdo.Text = row.Cells["TenTrinhDo"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaTrinhDo = txtmatrinhdo.Text.Trim();
            string TenTrinhDo = txttentrinhdo.Text.Trim();

            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "TrinhDo_update", MaTrinhDo, TenTrinhDo);
                //FillData_sqlHelper();
                grvtrinhdo["MaTrinhDo", rowIndex].Value = MaTrinhDo;
                grvtrinhdo["TenTrinhDo", rowIndex].Value = TenTrinhDo;
                MessageBox.Show("Sửa thông tin thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MaTrinhDo = txtmatrinhdo.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa:" + MaTrinhDo, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "TrinhDo_delete", MaTrinhDo);
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
            string MaTrinhDo = txtmatrinhdo.Text.Trim();
            string TenTrinhDo = txttentrinhdo.Text.Trim();
            txtmatrinhdo.Enabled = false;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "TrinhDo_insert", MaTrinhDo, TenTrinhDo);
                FillData_sqlHelper();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
    }
}
