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
    public partial class FrmBaoHiem : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public FrmBaoHiem()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
        }

        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "BaoHiem_Select").Tables[0];
                dgvBaoHiem.AutoGenerateColumns = false;
                dgvBaoHiem.DataSource = dtData;
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
                string strSQL = "SELECT MaNV,HoTen,MaBH,LoaiBH,NgaycapBH,NoicapBH FROM BaoHiem";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                dgvBaoHiem.AutoGenerateColumns = false;
                dgvBaoHiem.DataSource = dtData;
                FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= dgvBaoHiem.Rows.Count; i++)
                dgvBaoHiem["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }

        private void FrmBaoHiem_Load(object sender, EventArgs e)
        {
            LoadHoTen();
            LoadBaoHiem();
            FillData_sqlHelper();
            btnSave.Visible = false;
            lblSave.Visible = false;
            txtMaNS.Enabled = false;


        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void dgvBaoHiem_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillNO();
        }
        private bool CheckExit()
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "BaoHiem_selectByID", txtMaNS.Text.Trim(), txtMaBH.Text.Trim());
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
            if (txtMaNS.Text.Trim() == "")
                strError = "Bạn chưa nhập mã nhân viên";

            if (CheckExit() == true)
                strError = "Mã nhân viên học mã sổ này đã tồn tại. Vui lòng nhập mã khác";
            if (txtMaBH.Text.Trim() == "")
                strError += "Bạn chưa nhập mã sổ bảo hiểm";
            if (strError != "")
            {
                MessageBox.Show("Lỗi" + strError, "Thông Báo");
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnthem.Visible = false;
            btnSave.Visible = true;
            lblThem.Visible = false;
            lblSave.Visible = true;
            txtMaBH.Enabled = true;
            txtMaBH.Text = "";
            txtnoicapBH.Text = "";
            datetimeBH.Text = DateTime.Today.ToString();
        }
        private int rowIndex = 0;

        private void dgvBaoHiem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = dgvBaoHiem.Rows[e.RowIndex];
            try
            {
                txtMaNS.Text = row.Cells["MaNV"].Value.ToString();
                cbbhoten.Text = row.Cells["HoTen"].Value.ToString();
                txtMaBH.Text = row.Cells["MaBH"].Value.ToString();
                cbbLoaiBH.Text = row.Cells["LoaiBH"].Value.ToString();
                datetimeBH.Text = row.Cells["NgaycapBH"].Value.ToString();
                txtnoicapBH.Text = row.Cells["NoicapBH"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaNS.Text.Trim();
            string HoTen = cbbhoten.Text.Trim();
            string MaSoBH = txtMaBH.Text.Trim();
            string LoaiBH = cbbLoaiBH.Text.Trim();
            DateTime NgaycapBH = DateTime.Parse(datetimeBH.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-AU"));
            string NoicapBH = txtnoicapBH.Text.Trim();
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "BaoHiem_update", MaSoBH, LoaiBH, MaNV, HoTen, NgaycapBH, NoicapBH);
                //FillData_sqlHelper();
                dgvBaoHiem["MaNV", rowIndex].Value = MaNV;
                dgvBaoHiem["HoTen", rowIndex].Value = HoTen;
                dgvBaoHiem["MaBH", rowIndex].Value = MaSoBH;
                dgvBaoHiem["LoaiBH", rowIndex].Value = LoaiBH;
                dgvBaoHiem["NgaycapBH", rowIndex].Value = NgaycapBH;
                dgvBaoHiem["NoicapBH", rowIndex].Value = NoicapBH;
                MessageBox.Show("Sửa thông tin thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message, "Thông Báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MaBH = txtMaBH.Text.Trim();
            string MaNS = txtMaNS.Text.Trim();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa sổ bảo hiểm của nhân viên mã " + MaNS, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "BaoHiem_delete", MaBH);
                FillData_SP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
        private void LoadHoTen()
        {
            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(Str);
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
                                  ,[NgaySinh]
                                  ,[GioiTinh]
                                  ,[TenPhongBan]
                                  ,[TenChucDanh]
                                  ,[TenChucVu]
                                  ,[TenTrinhDo]
                                  ,[LoaiHD]
                                  ,[MaBH]
                                  ,[QuocTich]
                                  ,[DanToc]
                                  ,[TonGiao]
                                  ,[GhiChu]
                                  ,[DangVien]
                                  ,[DCThuongTru]
                                  ,[DCTamTru]
                                  ,[CMTND]
                                  ,[Ngaycap]
                                  ,[Noicap]
                              FROM [ChiTietHS]
                    where HoTen=@HoTen";
                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@HoTen", Ten);
                SqlDataReader read = sqlcm.ExecuteReader();
                if (read.Read())
                {
                    txtMaNS.Text = read["MaNV"].ToString();
                    txtMaBH.Text = read["MaBH"].ToString();
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
        private void LoadBaoHiem()
        {
            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(Str);
            try
            {
                sqlCon.Open();
                string strsql = "CNBaoHiem_Select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtHS = new DataTable();
                da.Fill(dtHS);
                cbbLoaiBH.DataSource = dtHS;
                cbbLoaiBH.DisplayMember = "LoaiBH";
                cbbLoaiBH.ValueMember = "LoaiBH";
                cbbLoaiBH.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbLoaiBH.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbbLoaiBH_SelectedIndexChanged(null, null);
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
        private void cbbLoaiBH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLoaiBH.SelectedValue == null)
                return;
            string str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(str);
            string TenBH = cbbLoaiBH.SelectedValue.ToString();
            try
            {
                sqlCn.Open();
                string s = @"SELECT MaLoaiBH
                                  ,LoaiBH
                              FROM 
                    where LoaiBH=@LoaiBH";
                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@TenBH", TenBH);
                //SqlDataReader read = sqlcm.ExecuteReader();
                //if (read.Read())
                //{
                //    txtmaloaibaohiem.Text = read["MaBH"].ToString();
                //}
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

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel();
            DataTable dt = new DataTable();
            //DataSet ds = new DataSet();
            dt = (DataTable)dgvBaoHiem.DataSource;
            excel.KetXuat(dt,"Danh sach", "Chi Tiết Bảo Hiểm");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckValid() == false)
                return;
            string MaNV = txtMaNS.Text.Trim();
            string HoTen = cbbhoten.Text.Trim();
            string MaSoBH = txtMaBH.Text.Trim();
            string LoaiBH = cbbLoaiBH.Text.Trim();
            DateTime NgaycapBH = DateTime.Parse(datetimeBH.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-AU"));
            string NoicapBH = txtnoicapBH.Text.Trim();

            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "BaoHiem_insert", MaSoBH, LoaiBH, MaNV, HoTen, NgaycapBH, NoicapBH);
                FillData_sqlHelper();
                txtMaBH.Enabled = false;
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