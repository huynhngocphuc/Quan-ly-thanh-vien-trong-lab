using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ultilities;
using System.IO;
using QuanLyNhanSu2;
using System.Configuration;

namespace QuanLyNhanSu2
{
    public partial class LuongNV : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        private SQLUltilities ulti;
        public LuongNV()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            ulti = new SQLUltilities();
            InitializeComponent();
            loadData();
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "LuongNV_Select").Tables[0];
                dgvluongnhanvien.AutoGenerateColumns = false;
                dgvluongnhanvien.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgvluongnhanvien.Rows.Count; i++)
                dgvluongnhanvien["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }
        private void FillData_sqlHelper()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                string strSQL = "Select MaNV,HoTen,HSL,Thangtangcuoicung,BHXH,BHYT,BHTN,TongPC,LuongThucLanh from ThongTinLuong";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                dgvluongnhanvien.AutoGenerateColumns = false;
                dgvluongnhanvien.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }

        private void loadData()
        {

            //binding combobox
            String sql = "select distinct thang from PhuCap";
            DataTable tb1 = ulti.ExecuteQuery(new SqlCommand(sql, ulti.connection));
            if (tb1 == null) return;
            cbMonth.Items.Clear();
            foreach (DataRow row in tb1.Rows)
            {
                cbMonth.Items.Add(row[0].ToString());
            }
          //  if (cbMonth.Items.Count > 0) cbMonth.SelectedIndex = 0;

        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            /// return;
            // MessageBox.Show(cbMonth.Text);
            if (cbMonth.Text != null && cbMonth.Text.Length != 0)
            {

                String sql = "Select SUM (Phucap)  from PhuCap where Thang=@thang group by Thang ";
                SqlCommand cmd = new SqlCommand(sql, ulti.connection);
                SqlParameter param = new SqlParameter("@thang", cbMonth.Text);
                cmd.Parameters.Add(param);
                DataTable tb1 = ulti.ExecuteQuery(cmd);
                if (tb1 == null) return;
                txtAmount.Text = tb1.Rows[0][0].ToString();
            }
        }

        private void LuongNV_Load(object sender, EventArgs e)
        {
            FillData_sqlHelper();
            btnTinh.Enabled = false;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                string strSQL = "Select MaNV,HoTen,HSL,Thangtangcuoicung,BHXH,BHYT,BHTN,TongPC,LuongThucLanh from ThongTinLuong";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                Double LuongThucLanh = 0;
                int n = dtData.Rows.Count;
                SqlCommand com;
                sqlCon.Open();
                int LuongCB = 1150;
                for (int i = 0; i <= n - 1; i++)
                {

                    Double HSL = Convert.ToDouble(dtData.Rows[i]["HSL"].ToString());
                    Double BHXH = Convert.ToDouble(dtData.Rows[i]["BHXH"].ToString());
                    Double BHYT = Convert.ToDouble(dtData.Rows[i]["BHYT"].ToString());
                    Double BHTN = Convert.ToDouble(dtData.Rows[i]["BHTN"].ToString());
                    Double TongPC = Convert.ToDouble(dtData.Rows[i]["TongPC"].ToString());

                    LuongThucLanh = HSL * Convert.ToInt32(LuongCB) - (BHXH + BHYT + BHTN) * HSL + TongPC;
                    string UpdateSQL = "UPDATE ThongTinLuong SET LuongThucLanh = N'" + LuongThucLanh + "' WHERE MaNV=N'" + dtData.Rows[i]["MaNV"].ToString() + "'";
                    com = new SqlCommand(UpdateSQL, sqlCon);
                    com.ExecuteNonQuery();

                }
                sqlCon.Close();
                FillData_sqlHelper();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                string strSQL = "Select MaNV,HoTen,HSL,Thangtangcuoicung,BHXH,BHYT,BHTN,TongPC,LuongThucLanh from ThongTinLuong";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                int n = dtData.Rows.Count;

                SqlCommand com;
                sqlCon.Open();
                for (int i = 0; i <= n - 1; i++)
                {
                    string date = dtData.Rows[i]["Thangtangcuoicung"].ToString();
                    DateTime startdate = DateTime.Parse(date);
                    DateTime now = DateTime.Now;
                    TimeSpan tinhhieu = now.Subtract(startdate);
                    double daysago = tinhhieu.TotalDays;
                    if (daysago / 365 >= 3)
                    {
                        string dateNow = DateTime.Now.ToString("dd/MM/yyyy");
                        string strUpdateSQL2 = "Update ThongTinLuong Set HSL=HSL+0.33 , Thangtangcuoicung=Convert(date,'" + dateNow + "',105) WHERE MaNV=N'" + dtData.Rows[i]["MaNV"].ToString() + "'";
                        com = new SqlCommand(strUpdateSQL2, sqlCon);
                        com.ExecuteNonQuery();
                        //FillData_sqlHelper();
                    }

                    float TongPC = float.Parse(txtAmount.Text.Trim());
                    string strUpdateSQL = "UPDATE ThongTinLuong SET TongPC = N'" + TongPC + "' WHERE MaNV=N'" + dtData.Rows[i]["MaNV"].ToString() + "'";
                    com = new SqlCommand(strUpdateSQL, sqlCon);
                    com.ExecuteNonQuery();
                    btnTinh.Enabled = true;


                }
                sqlCon.Close();
                FillData_sqlHelper();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btnExel_Click(object sender, EventArgs e)
        {
            ExportLuongNhanVien luong = new ExportLuongNhanVien();
            DataTable dt = new DataTable();
            dt = (DataTable)dgvluongnhanvien.DataSource;
            luong.KetXuatLuongNV(dt, "Sheet", "Bảng lương nhân viên tháng "+cbMonth.Text+" năm"+dtNam.Text);
        }
    }
}
