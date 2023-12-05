using App_Ban_Giay_Test.Frm;
using App_Ban_Giay_Test.Frm.Frm_UserControl;
using DAL.Models.ModelRefer;
using PRL.Frm_Main;

namespace App_Ban_Giay_Test
{
    public partial class Main : Form
    {
        Frm_BanHang2 form_BanHang = new Frm_BanHang2();
        DangNhap_Frm form_DangNhap = new DangNhap_Frm();
        public int idTaiKhoan;
        public int maChucVu;
        string hoVaTen;

        public Main()
        {
            InitializeComponent();
            Frm_BanHang2 US_BanHang = new Frm_BanHang2();
            Load_Usercontrol(US_BanHang);

        }
        private void LBBanHang_Click(object sender, EventArgs e)
        {
            Frm_BanHang2 US_BanHang = new Frm_BanHang2();
            Load_Usercontrol(US_BanHang);
        }
        private void LBSanPham_Click(object sender, EventArgs e)
        {
            Frm_SanPham2 US_SanPham = new Frm_SanPham2();
            Load_Usercontrol(US_SanPham);
        }
        private void LBHoaDon_Click(object sender, EventArgs e)
        {
            Frm_HoaDon2 US_HoaDon = new Frm_HoaDon2();
            Load_Usercontrol(US_HoaDon);
        }
        private void LBKhuyenMai_Click(object sender, EventArgs e)
        {
            if (maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng quản lý 'ưu đãi'!");
            }
            else
            {
                Frm_UuDai2 US_UuDai = new Frm_UuDai2();
                Load_Usercontrol(US_UuDai);

            }

        }
        private void LBNhanVien_Click(object sender, EventArgs e)
        {
            if (maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng quản lý 'nhân viên'!");
            }
            else
            {
                Frm_NhanVien2 US_NhanVien = new Frm_NhanVien2();
                Load_Usercontrol(US_NhanVien);
            }


        }
        private void LBKhachHang_Click(object sender, EventArgs e)
        {
            Frm_KhachHang2 US_Khachhang = new Frm_KhachHang2();
            Load_Usercontrol(US_Khachhang);
        }
        private void LBThongKe_Click(object sender, EventArgs e)
        {
            if (maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng quản lý 'thông kê'!");
            }
            else
            {
                Frm_ThongKe2 US_ThongKe = new Frm_ThongKe2();
                Load_Usercontrol(US_ThongKe);
            }


        }
        private void Main_Load(object sender, EventArgs e)
        {
            this.Hide();
            OpenLoginForm();
            if (LoginManager.Instance.MaChucVu == 1)
            {
                MessageBox.Show("Bạn là nhân viên");
            }
            else if (LoginManager.Instance.MaChucVu == 2)
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
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng quản lý 'lương'!");
            }
            else
            {
                Frm_BangLuong2 US_Luong = new Frm_BangLuong2();
                Load_Usercontrol(US_Luong);
            }
        }
        private void LBGiaoCa_Click(object sender, EventArgs e)
        {
            if (maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng 'giao ca'!");
            }
            else
            {
                Frm_GiaoCa2 US_GiaoCa = new Frm_GiaoCa2();
                Load_Usercontrol(US_GiaoCa);
            }

        }
        private void OpenLoginForm()
        {
            form_DangNhap.ShowDialog();

            idTaiKhoan = LoginManager.Instance.IdTaiKhoan;
            maChucVu = LoginManager.Instance.MaChucVu;
            hoVaTen = LoginManager.Instance.HoVaTen;

            if (idTaiKhoan != 0 || maChucVu != 0)
            {
                this.Show();
            }
            else
            {
                MessageBox.Show("Lỗi!");
                this.Close();
            }
        }
        private void Load_Usercontrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void LBBanHang_MouseHover(object sender, EventArgs e)
        {

        }
        private void LoadMouse_Vao()
        {
            Cursor = Cursors.Hand;
        }
        private void LoadMouse_Ra()
        {
            Cursor = Cursors.Default;
        }
        private void LBBanHang_MouseEnter(object sender, EventArgs e)
        {
            LoadMouse_Vao();
        }
        private void LBSanPham_MouseEnter(object sender, EventArgs e)
        {
            LoadMouse_Vao();

        }
        private void LBHoaDon_MouseEnter(object sender, EventArgs e)
        {
            LoadMouse_Vao();

        }
        private void LBKhuyenMai_MouseEnter(object sender, EventArgs e)
        {
            LoadMouse_Vao();

        }
        private void LBNhanVien_MouseEnter(object sender, EventArgs e)
        {
            LoadMouse_Vao();

        }
        private void LBKhachHang_MouseEnter(object sender, EventArgs e)
        {
            LoadMouse_Vao();
        }
        private void LBThongKe_MouseEnter(object sender, EventArgs e)
        {
            LoadMouse_Vao();
        }
        private void LBLuong_MouseEnter(object sender, EventArgs e)
        {
            LoadMouse_Vao();
        }
        private void LBGiaoCa_MouseEnter(object sender, EventArgs e)
        {
            LoadMouse_Vao();
        }
        private void LBBanHang_MouseLeave(object sender, EventArgs e)
        {
            LoadMouse_Ra();
        }
        private void LBSanPham_MouseLeave(object sender, EventArgs e)
        {
            LoadMouse_Ra();

        }
        private void LBHoaDon_MouseLeave(object sender, EventArgs e)
        {
            LoadMouse_Ra();

        }
        private void LBKhuyenMai_MouseLeave(object sender, EventArgs e)
        {
            LoadMouse_Ra();

        }
        private void LBNhanVien_MouseLeave(object sender, EventArgs e)
        {
            LoadMouse_Ra();

        }
        private void LBKhachHang_MouseLeave(object sender, EventArgs e)
        {
            LoadMouse_Ra();

        }
        private void LBThongKe_MouseLeave(object sender, EventArgs e)
        {
            LoadMouse_Ra();

        }
        private void LBLuong_MouseLeave(object sender, EventArgs e)
        {
            LoadMouse_Ra();

        }
        private void LBGiaoCa_MouseLeave(object sender, EventArgs e)
        {
            LoadMouse_Ra();

        }
         
        private void LBDangXuat_Click(object sender, EventArgs e)
        {
            LoginManager.Instance.Logout();
            this.Hide();

            DangNhap_Frm loginForm = new DangNhap_Frm();
            loginForm.ShowDialog();
            this.Show();

            int idTaiKhoan = LoginManager.Instance.IdTaiKhoan;
            int maChucVu = LoginManager.Instance.MaChucVu;
            string hoVaTen = LoginManager.Instance.HoVaTen;
        }
    }
}