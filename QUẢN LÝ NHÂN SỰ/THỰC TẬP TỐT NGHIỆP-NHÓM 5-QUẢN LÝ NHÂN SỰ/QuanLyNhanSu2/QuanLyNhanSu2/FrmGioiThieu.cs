using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanSu2
{
    public partial class FrmGioiThieu : Form
    {
        public FrmGioiThieu()
        {
            InitializeComponent();
        }

        private void mnthongtinbanquyen_Click(object sender, EventArgs e)
        {
            FrmThongtinbanquyen frmTTBanQuyen= new FrmThongtinbanquyen();
            frmTTBanQuyen.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoSoNhanSu frmHoSo = new frmHoSoNhanSu();
            frmHoSo.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhongBancs frmPhongBan = new FrmPhongBancs();
            frmPhongBan.Show();
        }

        private void chứcDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChucDanh frmChucDanh = new FrmChucDanh();
            frmChucDanh.ShowDialog();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChucVu frmChucvu = new FrmChucVu();
            frmChucvu.Show();
        }

        private void trìnhĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTrinhDo FrmTD = new FrmTrinhDo();
            FrmTD.Show();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHopDong frmHD = new FrmHopDong();
            frmHD.Show();
        }

        private void bảoHiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCapnhatBH frmCNBH = new FrmCapnhatBH();
            frmCNBH.ShowDialog();
        }

        private void bảngChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

       

        private void btnphongban_Click(object sender, EventArgs e)
        {
            FrmPhongBancs frmPhongBan = new FrmPhongBancs();
            frmPhongBan.Show();
        }

        private void btnchucdanh_Click(object sender, EventArgs e)
        {
            FrmChucDanh frmChucdanh = new FrmChucDanh();
            frmChucdanh.Show();
        }

        private void btnchucvu_Click(object sender, EventArgs e)
        {
            FrmChucVu frmchucvu = new FrmChucVu();
            frmchucvu.Show();
        }

        private void btntrinhdo_Click(object sender, EventArgs e)
        {
            FrmTrinhDo frmtrinhdo = new FrmTrinhDo();
            frmtrinhdo.Show();
        }

        private void btnbaohiem_Click(object sender, EventArgs e)
        {
            FrmCapnhatBH frmCNBH = new FrmCapnhatBH();
            frmCNBH.Show();
        }

        private void btnhopdong_Click(object sender, EventArgs e)
        {
            FrmHopDong frmHopdong = new FrmHopDong();
            frmHopdong.Show();
        }

        

        

        private void btnhoso_Click(object sender, EventArgs e)
        {
            frmHoSoNhanSu frmHSNS = new frmHoSoNhanSu();
            frmHSNS.Show();
        }

        /*private void btnchamcong_Click(object sender, EventArgs e)
        {
            FrmChamcong frmchamcong = new FrmChamcong();
            frmchamcong.ShowDialog();
        }*/

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void thôngTinBảnQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongtinbanquyen frmTTBQ = new FrmThongtinbanquyen();
            frmTTBQ.Show();
        }

        private void traCứuTìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiem frmTimKiem = new FrmTimKiem();
            frmTimKiem.Show();
        }

        private void traCứuTìmKiếm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimKiem2 frmTimkiem2 = new FormTimKiem2();
            frmTimkiem2.Show();
        }                     

        private void ngạchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinLuong frmTTluong = new ThongTinLuong();
            frmTTluong.Show();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            LuongNV frmLuong = new LuongNV();
            frmLuong.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPhucap frmphucap = new FrmPhucap();
            frmphucap.Show();
        }
    }
}
