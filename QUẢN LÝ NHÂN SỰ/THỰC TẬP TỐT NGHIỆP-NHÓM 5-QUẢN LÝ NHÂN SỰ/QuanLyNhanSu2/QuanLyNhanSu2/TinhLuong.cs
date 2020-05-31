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
    public partial class TinhLuong : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public TinhLuong()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "Test_Select").Tables[0];
                dgvtest.AutoGenerateColumns = false;
                dgvtest.DataSource = dtData;
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
                string strSQL = "Select MaNV,HSL,Thangtangcuoicung from Test";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                dgvtest.AutoGenerateColumns = false;
                dgvtest.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgvtest.Rows.Count; i++)
                dgvtest["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                string strSQL = "Select MaNV,HSL,Thangtangcuoicung from Test";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                SqlCommand com;
                sqlCon.Open();
                for (int i = 0; i < dgvtest.Rows.Count; i++)
                {
                    
                    string date = dtData.Rows[i]["Thangtangcuoicung"].ToString();
                    DateTime startdate = DateTime.Parse(date);
                    DateTime now = DateTime.Now;
                    TimeSpan tinhhieu = now.Subtract(startdate);
                    double daysago = tinhhieu.TotalDays;
                    if (daysago/365 >= 3)
                    {
                        string dateNow = DateTime.Now.ToString("dd/MM/yyyy");
                        string strUpdateSQL = "Update Test Set HSL=HSL+0.33 , Thangtangcuoicung=Convert(date,'"+dateNow +"',105) WHERE MaNV=N'" + dtData.Rows[i]["MaNV"].ToString() + "'";
                        com = new SqlCommand(strUpdateSQL, sqlCon);
                        com.ExecuteNonQuery(); 
                        
                    }
                    
                }
                sqlCon.Close();
                FillData_sqlHelper();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TinhLuong_Load(object sender, EventArgs e)
        {
            FillData_sqlHelper();
        }
    }
}
