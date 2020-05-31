using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using QuanLyNhanSu2;
using System.Configuration;

namespace QuanLyNhanSu2
{
    public partial class frmHoSoNhanSu : Form
    {
        //private ConnectDBImage conDB;
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public frmHoSoNhanSu()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            InitializeComponent();
        }
        private void FillData_SP()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, "ChiTietHS_Select").Tables[0];
                grvhoso.AutoGenerateColumns = false;
                grvhoso.DataSource = dtData;
                //FillNO();
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
                string strSQL = "SELECT MaNV,HoTen,NgaySinh,GioiTinh,TenPhongBan,TenChucDanh,TenChucVu,TenTrinhDo,LoaiHD,MaBH,QuocTich,DanToc,TonGiao,GhiChu,DangVien,DCThuongTru,DCTamTru,CMTND,Ngaycap,Noicap,SDT,NguyenQuan FROM ChiTietHS";
                DataTable dtData = SqlHelper.ExecuteDataset(strCon, CommandType.Text, strSQL).Tables[0];
                grvhoso.AutoGenerateColumns = false;
                grvhoso.DataSource = dtData;
                //FillNO();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }
        private void FillNO()
        {
            for (int i = 1; i <= grvhoso.Rows.Count; i++)
                grvhoso["STT", i - 1].Value = (i < 10 ? "0" + i : i.ToString());
        }

        private void frmHoSoNhanSu_Load(object sender, EventArgs e)
        {
            LoadHoSo();
            LoadPhongBan();
            LoatChucDanh();
            LoadChucVu();
            LoadTrinhDo();
            LoadHopDong();
            FillData_sqlHelper();
            btnSave.Visible = false;
            lblLuu.Visible = false;
            txtTenNv.Visible = false;
            txtMaBH.Enabled = false;
        }
        private void LoadHoSo()
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
                                  ,[SDT]
                                  ,[NguyenQuan]
                              FROM [ChiTietHS]
                    where HoTen=@HoTen";
                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@HoTen", Ten);
                SqlDataReader read = sqlcm.ExecuteReader();
                if (read.Read())
                {
                    txtmanv.Text = read["MaNV"].ToString();
                    dateTimeNgaysinh.Text = read["Ngaysinh"].ToString();
                    cbbphongban.Text = read["TenPhongBan"].ToString();
                    cbbchucdanh.Text = read["TenChucDanh"].ToString();
                    cbbchucvu.Text = read["TenChucVu"].ToString();
                    cbbtrinhdo.Text = read["TenTrinhDo"].ToString();
                    cbbloaiHD.Text = read["LoaiHD"].ToString();
                    txtMaBH.Text = read["MaBH"].ToString();
                    txtquoctich.Text = read["QuocTich"].ToString();
                    txtdantoc.Text = read["DanToc"].ToString();
                    txttongiao.Text = read["TonGiao"].ToString();
                    rtxtghichuhoso.Text = read["GhiChu"].ToString();
                    cbdangvien.Text = read["DangVien"].ToString();
                    cbgioitinh.Text = read["GioiTinh"].ToString();
                    txtnguyenquan.Text = read["NguyenQuan"].ToString();
                    txtDCthuongtru.Text = read["DCThuongTru"].ToString();
                    txtDCtamtru.Text = read["DCTamTru"].ToString();
                    txtCMTND.Text = read["CMTND"].ToString();
                    dateTimeCMTND.Text = read["Ngaycap"].ToString();
                    txtnoicapCMTND.Text = read["Noicap"].ToString();
                    txtSDT.Text = read["SDT"].ToString();
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
                SqlDataReader reader = SqlHelper.ExecuteReader(strCon, "ChiTietHS_SelectByID", txtmanv.Text.Trim());
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
            if (txtmanv.Text.Trim() == "")
                strError = "Bạn chưa nhập mã nhân viên\n";
            if (CheckExit() == true)
                strError = "Mã này đã tồn tại. Vui lòng nhập mã khác\n";
            if (cbbhoten.Text.Trim() == "")
                strError += "Bạn chưa nhập tên nhân viên";
            if (strError != "")
            {
                MessageBox.Show("Lỗi" + strError, "Thông Báo");
                return false;
            }
            return true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
             
        
        }
        private int rowIndex = 0;

        private void grvhoso_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = grvhoso.Rows[e.RowIndex];
            try
            {
                txtmanv.Text = row.Cells["MaNV"].Value.ToString();
                cbbhoten.Text = row.Cells["HoTen"].Value.ToString();
                dateTimeNgaysinh.Text = row.Cells["NgaySinh"].Value.ToString();
                cbgioitinh.Text = row.Cells["GioiTinh"].Value.ToString();
                cbbphongban.Text = row.Cells["TenPhongBan"].Value.ToString();
                cbbchucdanh.Text = row.Cells["TenChucDanh"].Value.ToString();
                cbbchucvu.Text = row.Cells["TenChucVu"].Value.ToString();
                cbbtrinhdo.Text = row.Cells["TenTrinhDo"].Value.ToString();
                cbbloaiHD.Text = row.Cells["LoaiHD"].Value.ToString();
                txtMaBH.Text = row.Cells["MaBH"].Value.ToString();
                txtquoctich.Text = row.Cells["QuocTich"].Value.ToString();
                txtdantoc.Text = row.Cells["DanToc"].Value.ToString();
                txttongiao.Text = row.Cells["TonGiao"].Value.ToString();
                rtxtghichuhoso.Text = row.Cells["GhiChu"].Value.ToString();
                cbdangvien.Text = row.Cells["DangVien"].Value.ToString();
                txtDCthuongtru.Text = row.Cells["DCThuongTru"].Value.ToString();
                txtDCtamtru.Text = row.Cells["DCTamTru"].Value.ToString();
                txtCMTND.Text = row.Cells["CMTND"].Value.ToString();
                dateTimeCMTND.Text = row.Cells["Ngaycap"].Value.ToString();
                txtnoicapCMTND.Text = row.Cells["Noicap"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtnguyenquan.Text = row.Cells["NguyenQuan"].Value.ToString();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string MaNV = txtmanv.Text.Trim();
            string HoTen = cbbhoten.Text.Trim();
            DateTime NgaySinh = DateTime.Parse(dateTimeNgaysinh.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-AU"));
            string TenPhongBan = cbbphongban.Text.Trim();
            string TenChucDanh = cbbchucdanh.Text.Trim();
            string TenChucVu = cbbchucvu.Text.Trim();
            string TenTrinhDo = cbbtrinhdo.Text.Trim();
            string LoaiHD = cbbloaiHD.Text.Trim();
            string MaBH = txtMaBH.Text.Trim();
            string QuocTich = txtquoctich.Text.Trim();
            string DanToc = txtdantoc.Text.Trim();
            string TonGiao = txttongiao.Text.Trim();
            string GhiChu = rtxtghichuhoso.Text.Trim();
            string DangVien = cbdangvien.Text.Trim();
            string GioiTinh = cbgioitinh.Text.Trim();
            string SDT = txtSDT.Text.Trim();
            string NguyenQuan = txtnguyenquan.Text.Trim();
            string DCThuongTru = txtDCthuongtru.Text.Trim();
            string DCTamTru = txtDCtamtru.Text.Trim();
            string CMTND = txtCMTND.Text.Trim();
            DateTime Ngaycap = DateTime.Parse(dateTimeCMTND.Text.Trim(),System.Globalization.CultureInfo.CreateSpecificCulture("en-AU"));
            string Noicap = txtnoicapCMTND.Text.Trim();
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "ChiTietHS_Update", MaNV, HoTen, NgaySinh, GioiTinh, TenPhongBan, TenChucDanh, TenChucVu, TenTrinhDo, LoaiHD, MaBH, QuocTich, DanToc, TonGiao, GhiChu, DangVien, DCThuongTru, DCTamTru, CMTND, Ngaycap, Noicap, SDT, NguyenQuan);
                //FillData_sqlHelper();
                grvhoso["MaNV", rowIndex].Value = MaNV;
                grvhoso["HoTen", rowIndex].Value = HoTen;
                grvhoso["NgaySinh", rowIndex].Value = NgaySinh;
                grvhoso["GioiTinh", rowIndex].Value = GioiTinh;
                grvhoso["TenPhongBan", rowIndex].Value =TenPhongBan;
                grvhoso["TenChucDanh", rowIndex].Value = TenChucDanh;
                grvhoso["TenChucVu", rowIndex].Value = TenChucVu;
                grvhoso["TenTrinhDo", rowIndex].Value = TenTrinhDo;
                grvhoso["LoaiHD", rowIndex].Value = LoaiHD;
                grvhoso["MaBH", rowIndex].Value = MaBH;
                grvhoso["QuocTich", rowIndex].Value = QuocTich;
                grvhoso["DanToc", rowIndex].Value = DanToc;
                grvhoso["TonGiao", rowIndex].Value = TonGiao;
                grvhoso["GhiChu", rowIndex].Value = GhiChu;
                grvhoso["DangVien", rowIndex].Value = DangVien;
                grvhoso["DCThuongTru", rowIndex].Value = DCThuongTru;
                grvhoso["DCTamTru", rowIndex].Value = DCTamTru;
                grvhoso["CMTND", rowIndex].Value = CMTND;
                grvhoso["Ngaycap", rowIndex].Value = Ngaycap;
                grvhoso["Noicap", rowIndex].Value = Noicap;
                grvhoso["SDT", rowIndex].Value = SDT;
                grvhoso["NguyenQuan", rowIndex].Value = NguyenQuan;
                MessageBox.Show("Sửa thông tin thành công!");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MaNV = txtmanv.Text.Trim();
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

        private void grvhoso_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //FillNO();
        }
        private void LoadPhongBan()
        {
            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(Str);
            try
            {
                sqlCon.Open();
                string strsql = "PhongBan_select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtHS = new DataTable();
                da.Fill(dtHS);
                cbbphongban.DataSource = dtHS;
                cbbphongban.DisplayMember = "TenPhongBan";
                cbbphongban.ValueMember = "TenPhongBan";
                cbbphongban.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbphongban.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbbphongban_SelectedIndexChanged(null, null);

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
        private void cbbphongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbphongban.SelectedValue == null)
                return;
            string str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(str);
            string Phong = cbbphongban.SelectedValue.ToString();
            try
            {
                sqlCn.Open();
                string s = @"SELECT [MaPhongBan]
                                   ,[TenPhongBan]
                               FROM [PhongBan]
                    where TenPhongBan=@TenPhongBan";
                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@TenPhongBan", Phong);
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
        private void LoatChucDanh()
        {
            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(Str);
            try
            {
                sqlCon.Open();
                string strsql = "ChucDanh_select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtHS = new DataTable();
                da.Fill(dtHS);
                //DataRow rw = dtHS.NewRow();
                //rw["TenChucDanh"] = "--Không Có--";
                //rw["MaChucDanh"] = "0";
                //dtHS.Rows.Add(rw);
                cbbchucdanh.DataSource = dtHS;
                cbbchucdanh.DisplayMember = "TenChucDanh";
                cbbchucdanh.ValueMember = "TenChucDanh";
                cbbchucdanh.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbchucdanh.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbbchucdanh_SelectedIndexChanged(null, null);

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

        private void cbbchucdanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbchucdanh.SelectedValue == null)
                return;
            string str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(str);
            string CD = cbbchucdanh.SelectedValue.ToString();
            try
            {
                sqlCn.Open();
                string s = @"SELECT [MaChucDanh]
                                    ,[TenChucDanh]
                                 FROM [ChucDanh]
                    where TenChucDanh=@TenChucDanh";
                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@TenChucDanh", CD);
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
        private void LoadChucVu()
        {
            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(Str);
            try
            {
                sqlCon.Open();
                string strsql = "ChucVu_select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtHS = new DataTable();
                da.Fill(dtHS);
                cbbchucvu.DataSource = dtHS;
                cbbchucvu.DisplayMember = "TenChucVu";
                cbbchucvu.ValueMember = "TenChucVu";
                cbbchucvu.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbchucvu.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbbchucvu_SelectedIndexChanged(null, null);

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
        private void cbbchucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbchucvu.SelectedValue == null)
                return;
            string str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(str);
            string CV = cbbchucvu.SelectedValue.ToString();
            try
            {
                sqlCn.Open();
                string s = @"SELECT [MaChucVu]
                                    ,[TenChucVu]
                                 FROM [ChucVu]
                    where TenChucVu=@TenChucVu";
                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@TenChucVu", CV);
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
        private void LoadTrinhDo()
        {
            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(Str);
            try
            {
                sqlCon.Open();
                string strsql = "TrinhDo_select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtHS = new DataTable();
                da.Fill(dtHS);
                cbbtrinhdo.DataSource = dtHS;
                cbbtrinhdo.DisplayMember = "TenTrinhDo";
                cbbtrinhdo.ValueMember = "TenTrinhDo";
                cbbtrinhdo.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbtrinhdo.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbbtrinhdo_SelectedIndexChanged(null, null);

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
        private void cbbtrinhdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbtrinhdo.SelectedValue == null)
                return;
            string str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(str);
            string TD = cbbtrinhdo.SelectedValue.ToString();
            try
            {
                sqlCn.Open();
                string s = @"SELECT [MaTrinhDo]
                                    ,[TenTrinhDo]
                                 FROM [TrinhDo]
                    where TenTrinhDo=@TenTrinhDo";
                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@TenTrinhDo", TD);
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
        private void LoadHopDong()
        {
            string Str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(Str);
            try
            {
                sqlCon.Open();
                string strsql = "HOPDONG_Select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtHS = new DataTable();
                da.Fill(dtHS);
                cbbloaiHD.DataSource = dtHS;
                cbbloaiHD.DisplayMember = "LoaiHD";
                cbbloaiHD.ValueMember = "LoaiHD";
                cbbloaiHD.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbbloaiHD.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbbloaiHD_SelectedIndexChanged(null, null);

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

        private void cbbloaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbloaiHD.SelectedValue == null)
                return;
            string str = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCn = new SqlConnection(str);
            string HD = cbbloaiHD.SelectedValue.ToString();
            try
            {
                sqlCn.Open();
                string s = @"SELECT [MaHD]
                                    ,[LoaiHD]
                                    ,[GhiChu]
                                 FROM [HOPDONG]
                    where MaHD=@LoaiHD";
                SqlCommand sqlcm = new SqlCommand(s, sqlCn);
                sqlcm.Parameters.AddWithValue("@TenHopDong", HD);
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter="JPG Files(*.JPG)|*.JPG|GIF Files(*.GIF)|*.GIF";
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                //ptAnhNV.Image =Bitmap.FromFile(ofd.FileName); 
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ExcelHSNV HSNV = new ExcelHSNV();
            DataTable dt = new DataTable();
            dt = (DataTable)grvhoso.DataSource;
            HSNV.ExportExcel(dt, "Sheet 1", "BẢNG HỒ SƠ NHÂN SỰ");
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FrmBaoHiem frmBH = new FrmBaoHiem();
            frmBH.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckValid() == false)
                return;
            string MaNV = txtmanv.Text.Trim();
            string HoTen = txtTenNv.Text.Trim();
            DateTime NgaySinh = DateTime.Parse(dateTimeNgaysinh.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-AU"));
            string GioiTinh = cbgioitinh.Text.Trim();
            string TenPhongBan = cbbphongban.Text.Trim();
            string TenChucDanh = cbbchucdanh.Text.Trim();
            string TenChucVu = cbbchucvu.Text.Trim();
            string TenTrinhDo = cbbtrinhdo.Text.Trim();
            string LoaiHD = cbbloaiHD.Text.Trim();
            string MaBH = txtMaBH.Text.Trim();
            string QuocTich = txtquoctich.Text.Trim();
            string DanToc = txtdantoc.Text.Trim();
            string TonGiao = txttongiao.Text.Trim();
            string GhiChu = rtxtghichuhoso.Text.Trim();
            string DangVien = cbdangvien.Text.Trim();
            string DCThuongTru = txtDCthuongtru.Text.Trim();
            string DCTamTru = txtDCtamtru.Text.Trim();
            string CMTND = txtCMTND.Text.Trim();
            DateTime Ngaycap = DateTime.Parse(dateTimeCMTND.Text.Trim(), System.Globalization.CultureInfo.CreateSpecificCulture("en-AU"));
            string Noicap = txtnoicapCMTND.Text.Trim();
            string SDT = txtSDT.Text.Trim();
            string NguyenQuan = txtnguyenquan.Text.Trim();
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "ChiTietHS_InSert", MaNV, HoTen, NgaySinh, GioiTinh, TenPhongBan, TenChucDanh, TenChucVu, TenTrinhDo, LoaiHD, MaBH, QuocTich, DanToc, TonGiao, GhiChu, DangVien, DCThuongTru, DCTamTru, CMTND, Ngaycap, Noicap, SDT, NguyenQuan);
                FillData_sqlHelper();
                btnSave.Visible = false;
                lblLuu.Visible = false;
                btnAdd.Visible = true;
                label25.Visible = true;
                txtTenNv.Visible = false;
                cbbhoten.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            label25.Visible = false;
            btnSave.Visible = true;
            lblLuu.Visible = true;
            txtmanv.Text = "";
            txtTenNv.Visible = true;
            cbbhoten.Visible = false;
            dateTimeNgaysinh.Text = DateTime.Today.ToString();
            txtMaBH.Text = "";
            txtquoctich.Text = "";
            txtdantoc.Text = "";
            txttongiao.Text = "";
            rtxtghichuhoso.Text = "";
            txtSDT.Text = "";
            txtnguyenquan.Text = "";
            txtDCthuongtru.Text = "";
            txtDCtamtru.Text = "";
            txtCMTND.Text = "";
            dateTimeCMTND.Text = DateTime.Today.ToString();
            txtnoicapCMTND.Text = "";
        }
    }
}
