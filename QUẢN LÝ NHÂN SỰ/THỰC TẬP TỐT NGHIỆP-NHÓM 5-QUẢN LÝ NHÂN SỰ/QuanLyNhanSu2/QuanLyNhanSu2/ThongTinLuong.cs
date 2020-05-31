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
    public partial class ThongTinLuong : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public ThongTinLuong()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "ThongTinLuong_Select").Tables[0];
                dgvthongtinluong.AutoGenerateColumns = false;
                dgvthongtinluong.DataSource = dtData;
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
                string strSQL = "Select MaNV,HoTen,HSL,Thangtangcuoicung,BHXH,BHYT,BHTN From ThongTinLuong";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                dgvthongtinluong.AutoGenerateColumns = false;
                dgvthongtinluong.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgvthongtinluong.Rows.Count; i++)
                dgvthongtinluong["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }

        private void ThongTinLuong_Load(object sender, EventArgs e)
        {
            LoadHoTen();
            FillData_sqlHelper();
            btnSave.Visible = false;
            lblSave.Visible = false;
        }
        private void LoadHoTen()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                sqlCon.Open();
                string strsql = "ChiTietHS_Select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtHS = new DataTable();
                da.Fill(dtHS);
                cbbhoten.DataSource = dtHS;
                cbbhoten.DisplayMember = "HoTen";
                cbbhoten.ValueMember = "HoTen";
                cbbhoten.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbhoten.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbbhoten_SelectedIndexChanged(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void cbbhoten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbhoten.SelectedValue == null)
                return;
            string str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(str);
            string Ten = cbbhoten.SelectedValue.ToString();
            try
            {
                sqlCn.Open();
                string s = @"SELECT [MaNV]
                                  ,[HoTen]
                                  
                              FROM [ChiTietHS]
                    where HoTen=@HoTen";
                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@HoTen", Ten);
                SqlDataReader read = sqlcm.ExecuteReader();
                if (read.Read())
                {
                    txtMaNV.Text = read["MaNV"].ToString();
                    
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
            finally
            {
                sqlCn.Close();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
        private bool CheckExit()
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "ThongTinLuong_SelectByID", txtMaNV.Text.Trim());
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
            if (txthesoluong.Text.Trim() == "")
                strError = "Bạn chưa nhập hệ số lương\n";
            if (CheckExit() == true)
                strError = "Mã này đã tồn tại. Vui lòng nhập mã khác\n";
            if (cbbhoten.Text.Trim() == "")
                strError += "Bạn chưa nhập tên nhân viên";
            if (txtBHXH.Text.Trim() == "")
                strError = "Bạn chưa nhập khấu trừ BHXH";
            if (txtBHYT.Text.Trim() == "")
                strError = "Bạn chưa nhập khấu trừ BHYT";
            if (txtBHTN.Text.Trim() == "")
                strError = "Bạn chưa nhập khấu trừ BHTN";
            if (strError != "")
            {
                MessageBox.Show("Lỗi" + strError, "Thông Báo");
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            lblSave.Visible = true;
            txtMaNV.Text = "";
            cbbhoten.Text = "Chọn nhân viên";
            txthesoluong.Text = "";
            txtBHXH.Text = "";
            txtBHTN.Text = "";
            txtBHYT.Text = "";
            
        }
        private int rowIndex = 0;

        private void dgvthongtinluong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = dgvthongtinluong.Rows[e.RowIndex];
            try
            {
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                cbbhoten.Text = row.Cells["HoTen"].Value.ToString();
                txthesoluong.Text = row.Cells["HSL"].Value.ToString();
                dtthangtangcuoicung.Text = row.Cells["Thangtangcuoicung"].Value.ToString();
                txtBHXH.Text = row.Cells["BHXH"].Value.ToString();
                txtBHYT.Text = row.Cells["BHYT"].Value.ToString();
                txtBHTN.Text = row.Cells["BHTN"].Value.ToString();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text.Trim();
            string HoTen = cbbhoten.Text.Trim();
            string HSL = txthesoluong.Text.Trim();
            DateTime Thangtangcuoicung = DateTime.Parse(dtthangtangcuoicung.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-AU"));
            string BHXH = txtBHXH.Text.Trim();
            string BHYT = txtBHYT.Text.Trim();
            string BHTN = txtBHTN.Text.Trim();
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "ThongTinLuong_Update", MaNV, HoTen, HSL, Thangtangcuoicung, BHXH, BHYT, BHTN);
                //FillData_sqlHelper();
                dgvthongtinluong["MaNV", rowIndex].Value = MaNV;
                dgvthongtinluong["HoTen", rowIndex].Value = HoTen;
                dgvthongtinluong["HSL", rowIndex].Value = HSL;
                dgvthongtinluong["Thangtangcuoicung", rowIndex].Value = Thangtangcuoicung;
                dgvthongtinluong["BHXH", rowIndex].Value = BHXH;
                dgvthongtinluong["BHYT", rowIndex].Value = BHYT;
                dgvthongtinluong["BHTN", rowIndex].Value = BHTN;
              
                MessageBox.Show("Sửa thông tin thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNV.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa:" + MaNV, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "ChiTietHS_Delete", MaNV);
                FillData_SP();
                cbbhoten.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString());
            }
        }

        private void dgvthongtinluong_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillNO();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckValid() == false)
                return;
            string MaNV = txtMaNV.Text.Trim();
            string HoTen = cbbhoten.Text.Trim();
            string HSL = txthesoluong.Text.Trim();
            DateTime Thangtangcuoicung = DateTime.Parse(dtthangtangcuoicung.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-AU"));
            string BHXH = txtBHXH.Text.Trim();
            string BHYT = txtBHYT.Text.Trim();
            string BHTN = txtBHTN.Text.Trim();

            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "ThongTinLuong_Insert", MaNV, HoTen, HSL, Thangtangcuoicung, BHXH, BHYT, BHTN);
                FillData_sqlHelper();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
    }
}
