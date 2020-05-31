using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using QuanLyNhanSu2;
using System.Configuration;
namespace QuanLyNhanSu2
{
    public partial class FrmPhucap : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public FrmPhucap()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "PhuCap_Select").Tables[0];
                dgvphucap.AutoGenerateColumns = false;
                dgvphucap.DataSource = dtData;
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
                string strSQL = "Select Thang,Phucap,LyDo from PhuCap";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                dgvphucap.AutoGenerateColumns = false;
                dgvphucap.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgvphucap.Rows.Count; i++)
                dgvphucap["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }

        private void FrmPhucap_Load(object sender, EventArgs e)
        {
            
            FillData_sqlHelper();
        }
        

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
        /*private bool CheckExit()
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "PhuCap_SelectByID", cbbthang.Text.Trim());
                if (reader.Read())
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
            return false;
        }*/
        private bool CheckValid()
        {
            string strError = "";
            if (cbbthang.Text.Trim() == "")
                strError = "Bạn chưa nhập tháng\n";
            
            if (txtphucap.Text.Trim() == "")
                strError = "Bạn chưa nhập tiền phụ cấp";
            
            if (strError != "")
            {
                MessageBox.Show("Lỗi" + strError, "Thông Báo");
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (CheckValid() == false)
                return;
            string Thang = cbbthang.Text.Trim();
            string PhuCap = txtphucap.Text.Trim();
            string LyDo = txtlydo.Text.Trim();
            
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "PhuCap_Insert", Thang, PhuCap, LyDo);
                
                FillData_sqlHelper();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private int rowIndex = 0;

        private void dgvphucap_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = dgvphucap.Rows[e.RowIndex];
            try
            {
                cbbthang.Text = row.Cells["Thang"].Value.ToString();
                txtphucap.Text = row.Cells["PhuCap"].Value.ToString();
                txtlydo.Text = row.Cells["LyDo"].Value.ToString();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        
        private void dgvphucap_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillNO();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string Thang = cbbthang.Text.Trim();
            string Phucap = txtphucap.Text.Trim();
            string LyDo = txtlydo.Text.Trim();
            
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "PhuCap_Update", Thang, Phucap, LyDo);
                //FillData_sqlHelper();
                dgvphucap["Thang", rowIndex].Value = Thang;
                dgvphucap["Phucap", rowIndex].Value = Phucap;
                dgvphucap["LyDo", rowIndex].Value = LyDo;
                

                MessageBox.Show("Sửa thông tin thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string Thang = cbbthang.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa tháng " + Thang, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "PhuCap_Delete", Thang);
                FillData_SP();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(strCon);
                SqlCommand com;
                sqlCon.Open();
                string strSQL = "Select Thang,TongPC from Tong";
                string capnhat = "Select Thang,SUM (Phucap) Tong  from PhuCap group by Thang";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                com = new SqlCommand(capnhat, sqlCon);
                com.ExecuteNonQuery();
                sqlCon.Close();
                MessageBox.Show("Cập nhật thành công");
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
