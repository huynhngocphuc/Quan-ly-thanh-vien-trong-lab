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
    public partial class FrmTimKiem : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public FrmTimKiem()
        {
            
            InitializeComponent();
        }
        private void TimTruongPhong()
        {
            using (var da = new SqlDataAdapter("Select * from ChiTietHS Where TenChucDanh=N'" + cbbchucdanh.SelectedValue + "' and TenPhongBan=N'" + cbbphongban.SelectedValue + "'and TenChucVu=N'" + cbbchucvu.SelectedValue + "'and TenTrinhDo=N'" + cbbtrinhdo.SelectedValue + "'", strCon))
            {
                DataTable dtcd = new DataTable();
                da.Fill(dtcd);
                grvtimkiem.DataSource = dtcd;
            }
        }

        private void FrmTimKiem_Load(object sender, EventArgs e)
        {
            LoadChucDanh();
            LoadChucVu();
            LoadPhongBan();
            LoadTrinhDo();
            
            setAllDisable();
        }
        private void LoadPhongBan()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                sqlCon.Open();
                string strsql = "PhongBan_select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtPB = new DataTable();
                da.Fill(dtPB);
                //DataRow rw = dtPB.NewRow();
                //rw["TenPhongBan"] = "--Không Chọn--";
                //rw["MaPhongBan"] = "0";
                //dtPB.Rows.Add(rw);
                cbbphongban.DataSource = dtPB;
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
        private void LoadChucDanh()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                sqlCon.Open();
                string strsql = "ChucDanh_select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtCD = new DataTable();
                da.Fill(dtCD);
                //DataRow rw = dtCD.NewRow();
                //rw["TenChucDanh"] = "--Không Chọn--";
                //rw["MaChucDanh"] = "0";
                //dtCD.Rows.Add(rw);
                cbbchucdanh.DataSource = dtCD;
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
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                sqlCon.Open();
                string strsql = "ChucVu_select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtCV = new DataTable();
                da.Fill(dtCV);
                //DataRow rw = dtCV.NewRow();
                //rw["TenChucVu"] = "--Không Chọn--";
                //rw["MaChucVu"] = "0";
                //dtCV.Rows.Add(rw);
                cbbchucvu.DataSource = dtCV;
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
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlCon = new SqlConnection(strCon);
            try
            {
                sqlCon.Open();
                string strsql = "TrinhDo_select";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlCon);
                DataTable dtTD = new DataTable();
                da.Fill(dtTD);
               //DataRow rw = dtTD.NewRow();
                //rw["TenTrinhDo"] = "--Không Chọn--";
                //rw["MaTrinhDo"] = "0";
                //dtTD.Rows.Add(rw);
                cbbtrinhdo.DataSource = dtTD;
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
            TimTruongPhong();
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
        void setAllDisable()
        {
            cbbphongban.Enabled = false;
            cbbchucdanh.Enabled = false;
            cbbchucvu.Enabled = false;
            cbbtrinhdo.Enabled = false;
        }

        void setAllEnable()
        {
            cbbphongban.Enabled = true;
            cbbchucdanh.Enabled = true;
            cbbchucvu.Enabled = true;
            cbbtrinhdo.Enabled = true;
        }
        private void cbbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSearchBy.SelectedIndex == 0)
            {
                setAllDisable();
                cbbphongban.Enabled = true;
            }
            if (cbbSearchBy.SelectedIndex == 1)
            {
                setAllDisable();
                cbbchucdanh.Enabled = true;

            }
            if (cbbSearchBy.SelectedIndex == 2)
            {
                setAllDisable();
                cbbchucvu.Enabled = true;
            }
            if (cbbSearchBy.SelectedIndex == 3)
            {
                setAllDisable();
                cbbtrinhdo.Enabled = true;
            }
            if (cbbSearchBy.SelectedIndex == 4)
            {
                setAllEnable();
            }

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            /*
            Phong ban
            Chuc danh
            Chuc vu
            Trinh do
            Tong hop
            */
            if (cbbSearchBy.SelectedIndex == 0) //phongban
            {
                SearchByPhongBan(cbbphongban.SelectedValue.ToString());
            }
            if (cbbSearchBy.SelectedIndex == 1) //ChucDanh
            {
                searchByChucDanh(cbbchucdanh.SelectedValue.ToString());

            }
            if (cbbSearchBy.SelectedIndex == 2)//ChucVU
            {
                searchByChucVu(cbbchucvu.SelectedValue.ToString());
            }
            if (cbbSearchBy.SelectedIndex == 3)//TrinhDo
            {
                searchByTrinhDo(cbbtrinhdo.SelectedValue.ToString());
            }
            if (cbbSearchBy.SelectedIndex == 4)//TongHop
            {
                string TenPhong = cbbphongban.SelectedValue.ToString();
                string TenChucDanh = cbbchucdanh.SelectedValue.ToString();
                string TenChucVu = cbbchucvu.SelectedValue.ToString();
                string TenTrinhDo = cbbtrinhdo.SelectedValue.ToString();
                advancedSearch(TenPhong, TenChucDanh, TenChucVu, TenTrinhDo);
            }
        }
        void searchByChucVu(string TenChucVu)
        {
            using (var da = new SqlDataAdapter("Select * from ChiTietHS Where TenChucVu =N'" + TenChucVu + "'", strCon))
            {
                DataTable dtcd = new DataTable();
                da.Fill(dtcd);
                grvtimkiem.DataSource = dtcd;
            }
        }
        void searchByChucDanh(string TenChucDanh)
        {
            using (var da = new SqlDataAdapter("Select * from ChiTietHS Where TenChucDanh=N'" + TenChucDanh + "'", strCon))
            {
                DataTable dtcd = new DataTable();
                da.Fill(dtcd);
                grvtimkiem.DataSource = dtcd;
            }
        }
        void SearchByPhongBan(string TenPhong)
        {
            using (var da = new SqlDataAdapter("Select * from ChiTietHS Where TenPhongBan=N'" + TenPhong + "'", strCon))
            {
                DataTable dtcd = new DataTable();
                da.Fill(dtcd);
                grvtimkiem.DataSource = dtcd;
            }
        }

        void searchByTrinhDo(string TenTrinhDo)
        {
            using (var da = new SqlDataAdapter("Select * from ChiTietHS Where TenTrinhDo=N'" + TenTrinhDo + "'", strCon))
            {
                DataTable dtcd = new DataTable();
                da.Fill(dtcd);
                grvtimkiem.DataSource = dtcd;
            }
        }


        void advancedSearch(string TenPhong, string TenChucDanh, string TenChucVu, string TenTrinhDo)
        {
            string cnnString = "Select * from ChiTietHS Where ";// MaPhongBan ='" + MaPhong + "' and MaChucDanh='" + MaChucDanh + "' and MaChucVu='" + MaChucVu + "' and MaTrinhDo='" + MaTrinhDo + "'";
            //string cnnString = "Select * from NhanVien Where MaPhongBan ='" + MaPhong + "' and MaChucDanh='" + MaChucDanh + "' and MaChucVu='" + MaChucVu + "' and MaTrinhDo='" + MaTrinhDo + "'";
            if (TenPhong != "0")
            {
                cnnString += "TenPhongBan=N'" + TenPhong + "'";
            }
            if (TenChucDanh != "0")
            {
                if (cnnString != "Select * from ChiTietHS Where ")
                    cnnString += "and TenChucDanh=N'" + TenChucDanh + "'";
                else
                    cnnString += "TenChucDanh=N'" + TenChucDanh + "'";
            }
            if (TenChucVu != "0")
            {
                if (cnnString != "Select * from ChiTietHS Where ")
                    cnnString += "and TenChucVu=N'" + TenChucVu + "'";
                else
                    cnnString += "TenChucVu=N'" + TenChucVu + "'";
            }
            if (TenTrinhDo != "0")
            {
                if (cnnString != "Select * from ChiTietHS Where")
                    cnnString += "and TenTrinhDo=N'" + TenTrinhDo + "'";
                else
                    cnnString += "TenTrinhDo=N'" + TenTrinhDo + "'";
            }
            if (cnnString == "Select * from ChiTietHS Where ")
                cnnString = "Select * from ChiTietHS";
            using (var da = new SqlDataAdapter(cnnString, strCon))
            {
                DataTable dtcd = new DataTable();
                da.Fill(dtcd);
                grvtimkiem.DataSource = dtcd;
            }
        }


        private void cbbphongban_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (var da = new SqlDataAdapter("Select * from ChiTietHS Where TenPhongBan=N'" + cbbphongban.SelectedValue + "'", strCon))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                grvtimkiem.DataSource = dt;
            }
        }

        private void cbbchucdanh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (var da = new SqlDataAdapter("Select * from  ChiTietHS Where TenChucDanh=N'" + cbbchucdanh.SelectedValue + "'", strCon))
            {
                DataTable dtcd = new DataTable();
                da.Fill(dtcd);
                grvtimkiem.DataSource = dtcd;
            }
        }

        private void cbbchucvu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (var da = new SqlDataAdapter("Select * from ChiTietHS Where TenChucVu=N'" + cbbchucvu.SelectedValue + "'", strCon))
            {
                DataTable dtcv = new DataTable();
                da.Fill(dtcv);
                grvtimkiem.DataSource = dtcv;
            }
        }

        private void cbbtrinhdo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (var da = new SqlDataAdapter("Select * from ChiTietHS Where TenTrinhDo=N'" + cbbtrinhdo.SelectedValue + "'", strCon))
            {
                DataTable dttd = new DataTable();
                da.Fill(dttd);
                grvtimkiem.DataSource = dttd;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
