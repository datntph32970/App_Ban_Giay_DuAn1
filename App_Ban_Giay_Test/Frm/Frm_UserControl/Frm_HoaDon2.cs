using BUS.Services;
using DAL.Models.ModelRefer;
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
    public partial class Frm_HoaDon2 : UserControl
    {
        public Frm_HoaDon2()
        {
            InitializeComponent(); LoadGridHD(null, null);
            Loadcombobox();


        }
        HoaDonService _service = new HoaDonService();
        int _idWhenclick;


        public void Loadcombobox()
        {
            List<string> hinhThucThanhToans = _service.GetHinhthucthanhtoans().Select(p => p.Tenhinhthuc).ToList();
            cmbloaitt.Items.Add("Tất cả");
            cmbloaitt.Items.AddRange(hinhThucThanhToans.ToArray());
            cmbloaitt.SelectedIndex = 0;
            cmbloaitt.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbTimkiem.Items.Add(SearchType.tatca);
            cmbTimkiem.Items.Add(SearchType.tenkhach);
            cmbTimkiem.Items.Add(SearchType.SDTkhach);
            cmbTimkiem.Items.Add(SearchType.TenTaikhoan);
            cmbTimkiem.SelectedIndex = 0;
            cmbTimkiem.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public void LoadGridHD(string search, string searchType)
        {
            int stt = 1;
            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Mã hoá đơn";
            dataGridView1.Columns[2].Name = "Tên khách";
            dataGridView1.Columns[3].Name = "SĐT khách";
            dataGridView1.Columns[4].Name = "Mã NV";
            dataGridView1.Columns[5].Name = "Tên NV";
            dataGridView1.Columns[6].Name = "Ngày tạo";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[7].Name = "Loại thanh toán";
            dataGridView1.Columns[8].Name = "Tổng tiền";
            dataGridView1.Columns[9].Name = "Ghi chú";
            dataGridView1.Columns[10].Name = "Trạng thái";

            dataGridView1.Rows.Clear();

            foreach (var x in _service.hoaDonNhes(search, searchType))
            {
                dataGridView1.Rows.Add(stt++, x.Hoadone.Mahoadon, x.tenkhachhang, x.sdtkhach, x.Hoadone.Mataikhoan, x.hovatentaikhoan, x.Hoadone.Ngaytao, x.tenhinhthuc, x.Hoadone.Tongtien, x.Hoadone.Ghichu, x.Hoadone.Trangthai == false ? "Chưa thanh toán" : "Đã thanh toán");
            }
        }

        public void loadgridHoadonchitiet()
        {
            int stt = 1;
            dtgHoadonchitiet.ColumnCount = 5;
            dtgHoadonchitiet.Columns[0].Name = "STT";
            dtgHoadonchitiet.Columns[1].Name = "Mã hoá đơn";
            dtgHoadonchitiet.Columns[2].Name = "Tên sản phẩm";
            dtgHoadonchitiet.Columns[3].Name = "Số lượng";
            dtgHoadonchitiet.Columns[4].Name = "Giá bán";

            dtgHoadonchitiet.Rows.Clear();
            foreach (var e in _service.GetHoadonchitiets())
            {
                var idspct = _service.GetGiaychitiets().FirstOrDefault(i => i.Magiaychitiet == e.Magiaychitiet);
                var idsp = _service.GetGiays().FirstOrDefault(s => s.Magiay == idspct.Magiay);
                dtgHoadonchitiet.Rows.Add(stt++, e.Mahoadon, idsp.Tengiay, e.Soluongmua, e.Gia);
            }
        }
        private void dtgHoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            _idWhenclick = int.Parse(dataGridView1.Rows[index].Cells[1].Value.ToString());
            loadgridHoadonchitiet();
        }


        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            LoadGridHD(txtTimkiem.Text, cmbTimkiem.Text);
        }

        private void cmbloaitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hinhThucThanhToanDuocChon = cmbloaitt.SelectedItem.ToString();
            string loaiThanhToan = (hinhThucThanhToanDuocChon == "Tất cả") ? null : hinhThucThanhToanDuocChon;
            LoadGridHD(null, loaiThanhToan);
        }

        private void cmbTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGridHD(txtTimkiem.Text, cmbTimkiem.Text);
        }

        private void datetao_ValueChanged(object sender, EventArgs e)
        {
            LoadGridHD(txtTimkiem.Text, cmbTimkiem.Text);
        }
        private void dateden_ValueChanged(object sender, EventArgs e)
        {
            LoadGridHD(txtTimkiem.Text, cmbTimkiem.Text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
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
