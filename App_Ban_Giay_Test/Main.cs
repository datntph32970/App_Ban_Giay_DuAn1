using App_Ban_Giay_Test.Frm;
using App_Ban_Giay_Test.Frm.Frm_UserControl;
using PRL.Frm_Main;

namespace App_Ban_Giay_Test
{
    public partial class Main : Form
    {
        Frm_BanHang2 form_BanHang = new Frm_BanHang2();
        DangNhap_Frm form_DangNhap = new DangNhap_Frm();
        int idTaiKhoan;
        int maChucVu;
        string hoVaTen;

        public Main()
        {
            InitializeComponent();
        }

        private void LBBanHang_Click(object sender, EventArgs e)
        {
            frm_BanHang21.BringToFront();
        }

        private void LBSanPham_Click(object sender, EventArgs e)
        {
            frm_SanPham21.BringToFront();

        }

        private void LBHoaDon_Click(object sender, EventArgs e)
        {
            frm_HoaDon21.BringToFront();

        }

        private void LBKhuyenMai_Click(object sender, EventArgs e)
        {
            if (maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng quản lý ưu đãi!");
            }
            else
            {
                frm_UuDai21.BringToFront();

            }

        }

        private void LBNhanVien_Click(object sender, EventArgs e)
        {
            if (maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng quản lý nhân viên!");
            }
            else
            {

            frm_NhanVien21.BringToFront();
            }


        }

        private void LBKhachHang_Click(object sender, EventArgs e)
        {
            frm_KhachHang21.BringToFront();

        }

        private void LBThongKe_Click(object sender, EventArgs e)
        {
            if (maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng quản lý ưu đãi!");
            }
            else
            {
                frm_ThongKe21.BringToFront();

            }


        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Hide();
            OpenLoginForm();
            if (form_DangNhap.maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhân viên");
                LBGiaoCa.Enabled = true;
                LBNhanVien.Enabled = true;
                LBKhuyenMai.Enabled = true;
                LBLuong.Enabled = true;
                LBThongKe.Enabled = true;
            }
            else if (form_DangNhap.maChucVu == 2)
            {
                MessageBox.Show("Bạn là quản lý");
            }
            else
            {
                MessageBox.Show("Không nhận dạng được chức vụ");
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_BanHang.XoaHoaDon_ChuaThanhToan();
        }

        private void LBLuong_Click(object sender, EventArgs e)
        {
            if (maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng quản lý ưu đãi!");
            }
            else
            {
                frm_BangLuong21.BringToFront();

            }


        }

        private void LBGiaoCa_Click(object sender, EventArgs e)
        {
            if(maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng giao ca!");
            }
            else
            {

            frm_GiaoCa21.BringToFront();
            }

        }
        private void OpenLoginForm()
        {
            form_DangNhap.ShowDialog();

             idTaiKhoan = form_DangNhap.idTaiKhoan;
             maChucVu = form_DangNhap.maChucVu;
             hoVaTen = form_DangNhap.hoVaTen;

            if(idTaiKhoan != 0 || maChucVu != 0)
            {
                this.Show();
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }

    }
}