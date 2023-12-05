using BUS.Services;
using DAL.Models.DomainClass;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Ban_Giay_Test.Frm.Frm_UserControl
{
    public partial class Frm_KhachHang2 : UserControl
    {
        public Frm_KhachHang2()
        {
            InitializeComponent(); LoadGird(null);
        }
        private KhachHangService _service = new KhachHangService();
        int _idWhenClick;
        public void LoadGird(string search)
        {
            int stt = 1;
            dtgKhachHang.ColumnCount = 6;
            dtgKhachHang.Columns[0].Name = "STT";
            dtgKhachHang.Columns[1].Name = "Mã";
            dtgKhachHang.Columns[2].Name = "Tên";
            dtgKhachHang.Columns[3].Name = "SDT";
            dtgKhachHang.Columns[4].Name = "Điểm";
            dtgKhachHang.Columns[5].Name = "Trạng Thái";
            dtgKhachHang.Rows.Clear();

            foreach (var x in _service.GetAllKhachhang(search))
            {
                dtgKhachHang.Rows.Add(stt++, x.Makhachhang, x.Tenkhachhang, x.Sdt, x.Diemkhachhang, x.Trangthai == false ? "Không hoạt động" : "Hoạt đông");
            }
        }
        public void Loadhodon()
        {

            int stt = 1;
            dtgHoaDon.ColumnCount = 5;
            dtgHoaDon.Columns[0].Name = "STT";
            dtgHoaDon.Columns[1].Name = "Mã Hoá Đơn";
            dtgHoaDon.Columns[2].Name = "Ngày tạo";
            dtgHoaDon.Columns[3].Name = "Loại thanh toán";
            dtgHoaDon.Columns[4].Name = "Tổng tiền";

            dtgHoaDon.Rows.Clear();
            foreach (var e in _service.GetAllHoadon())
            {
                var idtt = _service.GetHinhthucthanhtoans().FirstOrDefault(x => x.Mahinhthucthanhtoan == e.Mahinhthucthanhtoan);
                dtgHoaDon.Rows.Add(stt++, e.Mahoadon, e.Ngaytao, idtt.Tenhinhthuc, e.Tongtien);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!checksdt(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkdulieu(txtSDT.Text))
            {

                Khachhang khachhang = new Khachhang();
                khachhang.Tenkhachhang = txtTen.Text;
                khachhang.Sdt = txtSDT.Text;
                khachhang.Diemkhachhang = 0;
                khachhang.Trangthai = true;

                var relust = MessageBox.Show("Xác nhận muốm thêm", "Xác nhận", MessageBoxButtons.YesNo);
                if (relust == DialogResult.Yes)
                {
                    MessageBox.Show(_service.AddKhachHang(khachhang));
                }
                LoadGird(null);
            }
        }

        private void dtgKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0)
            {
                _idWhenClick = int.Parse(dtgKhachHang.Rows[index].Cells[1].Value.ToString());
                var khach = _service.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == _idWhenClick);
                txtMa.Text = khach.Makhachhang.ToString();
                txtTen.Text = khach.Tenkhachhang;
                txtSDT.Text = khach.Sdt;
                txtDiem.Text = khach.Diemkhachhang.ToString();
                Loadhodon();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkdulieu(txtSDT.Text))
            {
                Khachhang khachhang = new Khachhang();
                khachhang.Makhachhang = _idWhenClick;
                khachhang.Tenkhachhang = txtTen.Text;
                khachhang.Sdt = txtSDT.Text;
                var relust = MessageBox.Show("Xác nhận muốm sửa", "Xác nhận", MessageBoxButtons.YesNo);
                if (relust == DialogResult.Yes)
                {
                    MessageBox.Show(_service.UpdateKhachHang(khachhang));
                }
                LoadGird(null);
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            LoadGird(txtTimkiem.Text);
        }

        private void btnKhoaMoKhoa_Click(object sender, EventArgs e)
        {
            Khachhang khachhang = new Khachhang();
            khachhang.Makhachhang = _idWhenClick;
            var relust = MessageBox.Show("Xác nhận muốm Khoá/Mở khoá", "Xác nhận", MessageBoxButtons.YesNo);
            if (relust == DialogResult.Yes)
            {
                MessageBox.Show(_service.Khoa_MoKhoa(khachhang));
            }
            LoadGird(null);
        }

        public bool checkdulieu(string sodienthoai)
        {
            if (string.IsNullOrEmpty(txtSDT.Text)
            || string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (sodienthoai.Length != 10 && sodienthoai[0] != '0' && !sodienthoai.All(char.IsDigit) || !int.TryParse(sodienthoai, out _))
            {
                MessageBox.Show("Số điện thoại 0 hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool checksdt(string sodienthoai)
        {
            int dem = 0;
            foreach (Khachhang khachhang in _service.GetAllKhachhang(null))
            {
                if (khachhang.Sdt == sodienthoai)
                {
                    dem++;
                }
            }
            if (dem == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < dtgKhachHang.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dtgKhachHang.Columns[i].HeaderText;
                }

                for (int i = 0; i < dtgKhachHang.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgKhachHang.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dtgKhachHang.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(fileInfo);
                }
            }
            MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
