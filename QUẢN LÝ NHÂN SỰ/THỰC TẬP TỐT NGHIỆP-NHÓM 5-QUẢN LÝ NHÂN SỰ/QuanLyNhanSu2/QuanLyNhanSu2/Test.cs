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
using System.IO;
using System.Configuration;

namespace QuanLyNhanSu2
{
    public partial class Test : Form
    {

        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Test()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "TestLuong_Select").Tables[0];
                dgvluong.AutoGenerateColumns = false;
                dgvluong.DataSource = dtData;
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
                string strSQL = "SELECT MaVN, HoTen, HSL, LuongCB, Luong FROM TestLuong";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                dgvluong.AutoGenerateColumns = false;
                dgvluong.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgvluong.Rows.Count; i++)
                dgvluong["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }
        private void Test_Load(object sender, EventArgs e)
        {
            FillData_sqlHelper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);

            try
            {
                string strSQL = "SELECT MaVN, HoTen, HSL, LuongCB, Luong FROM TestLuong";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                Double Luong = 0;
                SqlCommand com;
                sqlCon.Open();
                int LCB=1500;
                for (int i = 0; i < dgvluong.Rows.Count - 1; i++)
                    
                {
                    Luong = Convert.ToDouble(dtData.Rows[i]["HSL"].ToString()) * Convert.ToInt32(LCB);
                    string strUpdateSQL = "UPDATE TestLuong SET Luong = N'" + Luong + "' WHERE MaVN=N'" + dtData.Rows[i]["MaVN"].ToString() + "'";
                    com = new SqlCommand(strUpdateSQL, sqlCon); 
                    com.ExecuteNonQuery();
                }
                sqlCon.Close();
                FillData_sqlHelper();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
