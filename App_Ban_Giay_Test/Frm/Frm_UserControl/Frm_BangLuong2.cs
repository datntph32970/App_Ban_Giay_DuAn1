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
    public partial class Frm_BangLuong2 : UserControl
    {
        public Frm_BangLuong2()
        {
           
            InitializeComponent();
            LoadGrid(null);
        }
        LuongService _service = new LuongService();
        int _idWhenclick;
        public void LoadGrid(string search)
        {
            int stt = 1;
            dtgHienthi.ColumnCount = 9;
            dtgHienthi.Columns[0].Name = "STT";
            dtgHienthi.Columns[1].Name = "Mã";
            dtgHienthi.Columns[2].Name = "Mã nhân viên";
            dtgHienthi.Columns[3].Name = "Tên nhân viên";
            dtgHienthi.Columns[4].Name = "Tháng làm";
            dtgHienthi.Columns[5].Name = "Lương cơ bản";
            dtgHienthi.Columns[6].Name = "Thưởng";
            dtgHienthi.Columns[7].Name = "Khấu trừ";
            dtgHienthi.Columns[8].Name = "Tổng lương";

            dtgHienthi.Rows.Clear();
            foreach (var x in _service.bangluongs(search))
            {
                var tentk = _service.taikhoans().FirstOrDefault(e => e.Mataikhoan == x.Mataikhoan);
                dtgHienthi.Rows.Add(stt++, x.Maluong, x.Mataikhoan, tentk.Hovaten, x.Thanglam, x.Luongcoban, x.Tienthuong, x.Tienkhautru, x.Tongthunhap);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Bangluong bangluong = new Bangluong();

            if (int.TryParse(txtManv.Text, out int maTaiKhoan) &&
                int.TryParse(txtThanglam.Text, out int thangLam) &&
                float.TryParse(txtLCB.Text, out float luongcoban) &&
                float.TryParse(txtTienthuong.Text, out float tienThuong) &&
                float.TryParse(txtTienkhautru.Text, out float tienKhauTru))
            {
                var nhanVien = _service.taikhoans().FirstOrDefault(nv => nv.Mataikhoan == maTaiKhoan);
                if (nhanVien != null && nhanVien.Trangthai == false)
                {
                    MessageBox.Show("Không thể thêm bảng lương vì nhân viên nghỉ làm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bangluong.Mataikhoan = maTaiKhoan;
                bangluong.Thanglam = thangLam;
                bangluong.Luongcoban = luongcoban;
                bangluong.Tienthuong = tienThuong;
                bangluong.Tienkhautru = tienKhauTru;
                txtManv.Text = string.Empty;
                txtTennv.Text = string.Empty;
                bangluong.Tongthunhap = int.Parse(txtTongthunhap.Text);
                var relust = MessageBox.Show("Xác nhận muốm thêm", "Xác nhận", MessageBoxButtons.YesNo);
                if (relust == DialogResult.Yes)
                {
                    MessageBox.Show(_service.AddLuong(bangluong));
                }
                else
                {
                    return;
                }
                LoadGrid(null);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu.");
            }
        }
        private void dtgHienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            _idWhenclick = int.Parse(dtgHienthi.Rows[rowindex].Cells[1].Value.ToString());
            var obj = _service.bangluongs(null).FirstOrDefault(x => x.Maluong == _idWhenclick);
            txtManv.Text = obj.Mataikhoan.ToString();
            txtThanglam.Text = obj.Thanglam.ToString();
            txtLCB.Text = obj.Luongcoban.ToString();
            txtTienkhautru.Text = obj.Tienkhautru.ToString();
            txtTienthuong.Text = obj.Tienthuong.ToString();
            txtTongthunhap.Text = obj.Tongthunhap.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Bangluong bangluong = new Bangluong();

            if (int.TryParse(txtManv.Text, out int maTaiKhoan) &&
                int.TryParse(txtThanglam.Text, out int thangLam) &&
                float.TryParse(txtLCB.Text, out float luongcoban) &&
                float.TryParse(txtTienthuong.Text, out float tienThuong) &&
                float.TryParse(txtTienkhautru.Text, out float tienKhauTru))
            {
                var nhanVien = _service.taikhoans().FirstOrDefault(nv => nv.Mataikhoan == maTaiKhoan);
                if (nhanVien != null && nhanVien.Trangthai == false)
                {
                    MessageBox.Show("Không thể sửa bảng lương vì nhân viên nghỉ làm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bangluong.Maluong = _idWhenclick;
                bangluong.Mataikhoan = maTaiKhoan;
                bangluong.Thanglam = thangLam;
                bangluong.Luongcoban = luongcoban;
                bangluong.Tienthuong = tienThuong;
                bangluong.Tienkhautru = tienKhauTru;
                txtManv.Text = string.Empty;
                txtTennv.Text = string.Empty;
                bangluong.Tongthunhap = int.Parse(txtTongthunhap.Text);
                var relust = MessageBox.Show("Xác nhận muốm sửa", "Xác nhận", MessageBoxButtons.YesNo);
                if (relust == DialogResult.Yes)
                {
                    MessageBox.Show(_service.UdateLuong(bangluong));
                }
                else
                {
                    return;
                }
                LoadGrid(null);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu.");
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtManv.Text = "";
            txtTennv.Text = "";
            txtThanglam.Text = "";
            txtLCB.Text = "";
            txtTienthuong.Text = "";
            txtTienkhautru.Text = "";
            txtTongthunhap.Text = "";
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(txtTimkiem.Text);
        }

        private void txtLCB_TextChanged(object sender, EventArgs e)
        {
            UpdateTongThuNhap();
        }

        private void txtTienthuong_TextChanged(object sender, EventArgs e)
        {
            UpdateTongThuNhap();
        }

        private void txtTienkhautru_TextChanged(object sender, EventArgs e)
        {
            UpdateTongThuNhap();
        }
        private void UpdateTongThuNhap()
        {
            if (float.TryParse(txtLCB.Text, out float luongcoban) &&
                float.TryParse(txtTienthuong.Text, out float tienthuong) &&
                float.TryParse(txtTienkhautru.Text, out float tienkhautru))
            {
                float tongthunhap = luongcoban + tienthuong - tienkhautru;
                txtTongthunhap.Text = tongthunhap.ToString();
            }
            else
            {
                txtTongthunhap.Text = "0";
            }
        }

        private void txtManv_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(txtManv.Text, out int maTaiKhoan))
            {
                var taiKhoan = _service.taikhoans().FirstOrDefault(tk => tk.Mataikhoan == maTaiKhoan);
                if (taiKhoan != null)
                {
                    txtTennv.Text = taiKhoan.Hovaten;
                }
                else
                {
                    txtTennv.Text = string.Empty;
                }
            }
            else
            {
                txtTennv.Text = string.Empty;
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < dtgHienthi.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dtgHienthi.Columns[i].HeaderText;
                }

                for (int i = 0; i < dtgHienthi.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgHienthi.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dtgHienthi.Rows[i].Cells[j].Value?.ToString();
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
