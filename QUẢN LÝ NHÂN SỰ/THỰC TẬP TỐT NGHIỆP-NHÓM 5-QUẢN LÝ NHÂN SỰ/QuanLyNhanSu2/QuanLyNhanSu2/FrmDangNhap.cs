using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QuanLyNhanSu2
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {  
            InitializeComponent();
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString); 
        }
        public DataTable checkLog(string user,string pass)
        {
            string sql = "Select * From DangNhap where NguoiDung='"+user+"' and Pass='"+pass+"'";
            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            //xử lý khi nhấn Enter
            this.AcceptButton = btndangnhap;
            try
            {
                //kiểm tra xem Form đã kết nối cơ sở dữ liệu chưa
                SqlConnection con = getConnect();
                this.status.Text = "Kết nối cơ sở dữ liệu thành công";
            }
            catch
            {
                this.status.Text = "Kết nối cơ sở dữ liệu thất bại";
            }
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (this.txtdangnhap.TextLength == 0 || this.txtmatkhau.TextLength == 0)
            {
                this.lbstatus.ForeColor = Color.Red;
                this.lbstatus.Text = "Bạn chưa nhập tài khoản hoặc mật khẩu";
            }
            else
            {
                DataTable dt = new DataTable();
                dt = checkLog(this.txtdangnhap.Text, this.txtmatkhau.Text);
                if (dt.Rows.Count > 0)
                {
                    //đăng nhập thành công, mở FrmGioiThieu, đóng frmDangnhap
                    this.Hide();
                    FrmGioiThieu frm = new FrmGioiThieu();
                    frm.Show();
                }
                else
                {
                    //đăng nhập thất bại->báo lỗi
                    this.lbstatus.ForeColor = Color.Red;
                    this.lbstatus.Text = "Tài khoản không tồn tại";
                    //khi thông báo này xong phải đưa con nháy về ô txtdangnhap
                    this.txtdangnhap.Clear();
                    this.txtmatkhau.Clear();
                    this.txtdangnhap.Focus();
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
