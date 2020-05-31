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
    public partial class FrmChucVu : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public FrmChucVu()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString; ;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "ChucVu_select").Tables[0];
                grvchucvu.AutoGenerateColumns = false;
                grvchucvu.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
        private void FillData_sqlHelper()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString; ;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                string strSQL = "SELECT MaChucVu, TenChucVu FROM ChucVu";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                grvchucvu.AutoGenerateColumns = false;
                grvchucvu.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= grvchucvu.Rows.Count; i++)
                grvchucvu["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            FillData_sqlHelper();
            txtmachucvu.Enabled = false;
            button1.Visible = false;
            lblSave.Visible = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void grvchucvu_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillNO();
        }
        private bool CheckExit()
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "ChucVu_SelectByID", txtmachucvu.Text.Trim());
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
            if (txtmachucvu.Text.Trim() == "")
                strError = "Bạn chưa nhập mã chức vụ\n";
            //kiểm tra xem mã phòng ban đã tồn tại hay chưa?
            if (CheckExit() == true)
                strError = "Mã này đã tồn tại. Vui lòng nhập mã khác\n";
            if (txttenchucvu.Text.Trim() == "")
                strError += "Bạn chưa nhập tên chức vụ";
            if (strError != "")
            {
                MessageBox.Show("Lỗi" + strError, "Thông Báo");
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmachucvu.Enabled = true;
            txtmachucvu.Text = "";
            txttenchucvu.Text = "";
            btnthem.Visible = false;
            lblTHem.Visible = false;
            button1.Visible = true;
            lblSave.Visible = true;


        }
        private int rowIndex = 0;

        private void grvchucvu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = grvchucvu.Rows[e.RowIndex];
            try
            {
                txtmachucvu.Text = row.Cells["MaChucVu"].Value.ToString();
                txttenchucvu.Text = row.Cells["TenChucVu"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaChucVu = txtmachucvu.Text.Trim();
            string TenChucVu = txttenchucvu.Text.Trim();

            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "ChucVu_update", MaChucVu, TenChucVu);
                //FillData_sqlHelper();
                grvchucvu["MaChucVu", rowIndex].Value = MaChucVu;
                grvchucvu["TenChucVu", rowIndex].Value = TenChucVu;
                MessageBox.Show("Sửa thông tin thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MaChucVu = txtmachucvu.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa:" + MaChucVu, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "ChucVu_delete", MaChucVu);
                FillData_SP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckValid() == false)
                return;
            string MaChucVu = txtmachucvu.Text.Trim();
            string TenChucVu = txttenchucvu.Text.Trim();

            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "ChucVu_insert", MaChucVu, TenChucVu);
                FillData_sqlHelper();
                button1.Visible = false;
                lblSave.Visible = false;
                btnthem.Visible = true;
                lblTHem.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
    }
}
