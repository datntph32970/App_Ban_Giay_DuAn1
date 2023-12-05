namespace App_Ban_Giay_Test.Frm.Frm_UserControl
{
    partial class Frm_BanHang2
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dtgSanpham = new DataGridView();
            cboxDungDiemKH = new CheckBox();
            groupBox3 = new GroupBox();
            ptbLamMoiIdHoaDonChiTiet = new PictureBox();
            txtIDHoaDonChiTiet_Checked = new TextBox();
            dtgGiohang = new DataGridView();
            btnChonTatCa = new Button();
            btnXoa = new Button();
            btnThanhToan = new Button();
            cbbHinhThucThanhToan = new ComboBox();
            txtGhiChu = new TextBox();
            txtDiemKH = new TextBox();
            txtSoTienNhan = new TextBox();
            txtGiaGiam = new TextBox();
            label12 = new Label();
            label11 = new Label();
            txtSoTienThieu = new Label();
            txtSoTienThua = new Label();
            txtTongTien = new Label();
            txtTongTienSP = new Label();
            txtMaNhanVien = new Label();
            txtTimKiemSP = new TextBox();
            txtMaHoaDon = new Label();
            groupBox1 = new GroupBox();
            ptbThemHoaDon = new PictureBox();
            btnXoaHoaDon = new Button();
            btnTimKiemHoaDon = new Button();
            dtgHoadon = new DataGridView();
            cbbTimKiemHoaDon = new ComboBox();
            txtTimKiemHoaDon = new TextBox();
            label3 = new Label();
            label33 = new Label();
            label2 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            groupBox4 = new GroupBox();
            ptbLamMoiSP = new PictureBox();
            btnTimKiemSP = new Button();
            comboBox3 = new ComboBox();
            label6 = new Label();
            ptbChonKhachHang = new PictureBox();
            txtMaKhachHang = new Label();
            txtTenKhachHang = new Label();
            label1 = new Label();
            groupBox5 = new GroupBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtgSanpham).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLamMoiIdHoaDonChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgGiohang).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbThemHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgHoadon).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLamMoiSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbChonKhachHang).BeginInit();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgSanpham
            // 
            dtgSanpham.AllowUserToAddRows = false;
            dtgSanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSanpham.Location = new Point(6, 56);
            dtgSanpham.Name = "dtgSanpham";
            dtgSanpham.RowHeadersWidth = 51;
            dtgSanpham.RowTemplate.Height = 25;
            dtgSanpham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgSanpham.Size = new Size(816, 197);
            dtgSanpham.TabIndex = 13;
            dtgSanpham.CellClick += dtgSanpham_CellClick;
            // 
            // cboxDungDiemKH
            // 
            cboxDungDiemKH.AutoSize = true;
            cboxDungDiemKH.Enabled = false;
            cboxDungDiemKH.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cboxDungDiemKH.Location = new Point(25, 274);
            cboxDungDiemKH.Name = "cboxDungDiemKH";
            cboxDungDiemKH.Size = new Size(63, 21);
            cboxDungDiemKH.TabIndex = 5;
            cboxDungDiemKH.Text = "Dùng:";
            cboxDungDiemKH.UseVisualStyleBackColor = true;
            cboxDungDiemKH.Click += cboxDungDiemKH_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ptbLamMoiIdHoaDonChiTiet);
            groupBox3.Controls.Add(txtIDHoaDonChiTiet_Checked);
            groupBox3.Controls.Add(dtgGiohang);
            groupBox3.Controls.Add(btnChonTatCa);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Location = new Point(5, 235);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(828, 207);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Giỏ hàng";
            // 
            // ptbLamMoiIdHoaDonChiTiet
            // 
            ptbLamMoiIdHoaDonChiTiet.Image = Properties.Resources.broom;
            ptbLamMoiIdHoaDonChiTiet.Location = new Point(446, 14);
            ptbLamMoiIdHoaDonChiTiet.Name = "ptbLamMoiIdHoaDonChiTiet";
            ptbLamMoiIdHoaDonChiTiet.Size = new Size(25, 24);
            ptbLamMoiIdHoaDonChiTiet.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLamMoiIdHoaDonChiTiet.TabIndex = 10;
            ptbLamMoiIdHoaDonChiTiet.TabStop = false;
            ptbLamMoiIdHoaDonChiTiet.Click += ptbLamMoiIdHoaDonChiTiet_Click;
            // 
            // txtIDHoaDonChiTiet_Checked
            // 
            txtIDHoaDonChiTiet_Checked.BorderStyle = BorderStyle.None;
            txtIDHoaDonChiTiet_Checked.Enabled = false;
            txtIDHoaDonChiTiet_Checked.Location = new Point(477, 15);
            txtIDHoaDonChiTiet_Checked.Name = "txtIDHoaDonChiTiet_Checked";
            txtIDHoaDonChiTiet_Checked.Size = new Size(100, 16);
            txtIDHoaDonChiTiet_Checked.TabIndex = 9;
            // 
            // dtgGiohang
            // 
            dtgGiohang.AllowUserToAddRows = false;
            dtgGiohang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGiohang.Location = new Point(6, 47);
            dtgGiohang.Name = "dtgGiohang";
            dtgGiohang.RowHeadersWidth = 51;
            dtgGiohang.RowTemplate.Height = 25;
            dtgGiohang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgGiohang.Size = new Size(816, 154);
            dtgGiohang.TabIndex = 8;
            dtgGiohang.CellClick += dtgGiohang_CellContentClick;
            // 
            // btnChonTatCa
            // 
            btnChonTatCa.FlatAppearance.BorderSize = 0;
            btnChonTatCa.FlatStyle = FlatStyle.System;
            btnChonTatCa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnChonTatCa.Location = new Point(692, 11);
            btnChonTatCa.Name = "btnChonTatCa";
            btnChonTatCa.Size = new Size(103, 30);
            btnChonTatCa.TabIndex = 7;
            btnChonTatCa.Text = "Chọn tất cả";
            btnChonTatCa.UseVisualStyleBackColor = true;
            btnChonTatCa.Click += btnChonTatCa_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.System;
            btnXoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Location = new Point(583, 11);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(103, 30);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatStyle = FlatStyle.System;
            btnThanhToan.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.Location = new Point(33, 647);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(209, 39);
            btnThanhToan.TabIndex = 4;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // cbbHinhThucThanhToan
            // 
            cbbHinhThucThanhToan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHinhThucThanhToan.FormattingEnabled = true;
            cbbHinhThucThanhToan.Location = new Point(102, 233);
            cbbHinhThucThanhToan.Name = "cbbHinhThucThanhToan";
            cbbHinhThucThanhToan.Size = new Size(140, 23);
            cbbHinhThucThanhToan.TabIndex = 3;
            // 
            // txtGhiChu
            // 
            txtGhiChu.BorderStyle = BorderStyle.None;
            txtGhiChu.Location = new Point(24, 517);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(228, 115);
            txtGhiChu.TabIndex = 2;
            // 
            // txtDiemKH
            // 
            txtDiemKH.BorderStyle = BorderStyle.None;
            txtDiemKH.Enabled = false;
            txtDiemKH.Location = new Point(86, 272);
            txtDiemKH.Name = "txtDiemKH";
            txtDiemKH.Size = new Size(156, 16);
            txtDiemKH.TabIndex = 2;
            txtDiemKH.TextChanged += txtDiemKH_TextChanged;
            // 
            // txtSoTienNhan
            // 
            txtSoTienNhan.BorderStyle = BorderStyle.None;
            txtSoTienNhan.Location = new Point(115, 311);
            txtSoTienNhan.Name = "txtSoTienNhan";
            txtSoTienNhan.Size = new Size(127, 16);
            txtSoTienNhan.TabIndex = 2;
            txtSoTienNhan.TextChanged += txtSoTienNhan_TextChanged;
            // 
            // txtGiaGiam
            // 
            txtGiaGiam.BorderStyle = BorderStyle.None;
            txtGiaGiam.Enabled = false;
            txtGiaGiam.Location = new Point(95, 195);
            txtGiaGiam.Name = "txtGiaGiam";
            txtGiaGiam.Size = new Size(147, 16);
            txtGiaGiam.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(25, 428);
            label12.Name = "label12";
            label12.Size = new Size(88, 17);
            label12.TabIndex = 1;
            label12.Text = "Số tiền thiếu:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(25, 390);
            label11.Name = "label11";
            label11.Size = new Size(85, 17);
            label11.TabIndex = 1;
            label11.Text = "Số tiền thừa:";
            // 
            // txtSoTienThieu
            // 
            txtSoTienThieu.AutoSize = true;
            txtSoTienThieu.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoTienThieu.Location = new Point(124, 428);
            txtSoTienThieu.Name = "txtSoTienThieu";
            txtSoTienThieu.Size = new Size(17, 17);
            txtSoTienThieu.TabIndex = 1;
            txtSoTienThieu.Text = "...";
            // 
            // txtSoTienThua
            // 
            txtSoTienThua.AutoSize = true;
            txtSoTienThua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoTienThua.Location = new Point(114, 390);
            txtSoTienThua.Name = "txtSoTienThua";
            txtSoTienThua.Size = new Size(17, 17);
            txtSoTienThua.TabIndex = 1;
            txtSoTienThua.Text = "...";
            // 
            // txtTongTien
            // 
            txtTongTien.AutoSize = true;
            txtTongTien.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongTien.Location = new Point(104, 462);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(17, 17);
            txtTongTien.TabIndex = 1;
            txtTongTien.Text = "...";
            // 
            // txtTongTienSP
            // 
            txtTongTienSP.AutoSize = true;
            txtTongTienSP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongTienSP.Location = new Point(164, 352);
            txtTongTienSP.Name = "txtTongTienSP";
            txtTongTienSP.Size = new Size(17, 17);
            txtTongTienSP.TabIndex = 1;
            txtTongTienSP.Text = "...";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.AutoSize = true;
            txtMaNhanVien.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaNhanVien.Location = new Point(124, 122);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(17, 17);
            txtMaNhanVien.TabIndex = 1;
            txtMaNhanVien.Text = "...";
            // 
            // txtTimKiemSP
            // 
            txtTimKiemSP.BorderStyle = BorderStyle.None;
            txtTimKiemSP.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiemSP.Location = new Point(6, 20);
            txtTimKiemSP.Multiline = true;
            txtTimKiemSP.Name = "txtTimKiemSP";
            txtTimKiemSP.Size = new Size(380, 30);
            txtTimKiemSP.TabIndex = 9;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.AutoSize = true;
            txtMaHoaDon.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaHoaDon.Location = new Point(114, 160);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(17, 17);
            txtMaHoaDon.TabIndex = 1;
            txtMaHoaDon.Text = "...";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(ptbThemHoaDon);
            groupBox1.Controls.Add(btnXoaHoaDon);
            groupBox1.Controls.Add(btnTimKiemHoaDon);
            groupBox1.Controls.Add(dtgHoadon);
            groupBox1.Controls.Add(cbbTimKiemHoaDon);
            groupBox1.Controls.Add(txtTimKiemHoaDon);
            groupBox1.Location = new Point(5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(828, 225);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hóa đơn";
            // 
            // ptbThemHoaDon
            // 
            ptbThemHoaDon.Image = Properties.Resources.add;
            ptbThemHoaDon.Location = new Point(768, 22);
            ptbThemHoaDon.Name = "ptbThemHoaDon";
            ptbThemHoaDon.Size = new Size(37, 30);
            ptbThemHoaDon.SizeMode = PictureBoxSizeMode.Zoom;
            ptbThemHoaDon.TabIndex = 4;
            ptbThemHoaDon.TabStop = false;
            ptbThemHoaDon.Click += ptbThemHoaDon_Click;
            // 
            // btnXoaHoaDon
            // 
            btnXoaHoaDon.FlatAppearance.BorderSize = 0;
            btnXoaHoaDon.FlatStyle = FlatStyle.System;
            btnXoaHoaDon.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaHoaDon.Location = new Point(659, 22);
            btnXoaHoaDon.Name = "btnXoaHoaDon";
            btnXoaHoaDon.Size = new Size(101, 30);
            btnXoaHoaDon.TabIndex = 3;
            btnXoaHoaDon.Text = "Xóa";
            btnXoaHoaDon.UseVisualStyleBackColor = true;
            btnXoaHoaDon.Click += btnXoaHoaDon_Click;
            // 
            // btnTimKiemHoaDon
            // 
            btnTimKiemHoaDon.FlatAppearance.BorderSize = 0;
            btnTimKiemHoaDon.FlatStyle = FlatStyle.System;
            btnTimKiemHoaDon.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiemHoaDon.Location = new Point(550, 22);
            btnTimKiemHoaDon.Name = "btnTimKiemHoaDon";
            btnTimKiemHoaDon.Size = new Size(103, 30);
            btnTimKiemHoaDon.TabIndex = 2;
            btnTimKiemHoaDon.Text = "Tìm kiếm";
            btnTimKiemHoaDon.UseVisualStyleBackColor = true;
            btnTimKiemHoaDon.Click += btnTimKiemHoaDon_Click;
            // 
            // dtgHoadon
            // 
            dtgHoadon.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgHoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgHoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHoadon.GridColor = SystemColors.InactiveCaption;
            dtgHoadon.Location = new Point(6, 58);
            dtgHoadon.Name = "dtgHoadon";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgHoadon.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgHoadon.RowHeadersWidth = 51;
            dtgHoadon.RowTemplate.Height = 25;
            dtgHoadon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgHoadon.Size = new Size(816, 157);
            dtgHoadon.TabIndex = 4;
            dtgHoadon.CellClick += dtgHoadon_CellClick;
            // 
            // cbbTimKiemHoaDon
            // 
            cbbTimKiemHoaDon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTimKiemHoaDon.FormattingEnabled = true;
            cbbTimKiemHoaDon.Location = new Point(392, 24);
            cbbTimKiemHoaDon.Name = "cbbTimKiemHoaDon";
            cbbTimKiemHoaDon.Size = new Size(150, 23);
            cbbTimKiemHoaDon.TabIndex = 1;
            // 
            // txtTimKiemHoaDon
            // 
            txtTimKiemHoaDon.BorderStyle = BorderStyle.None;
            txtTimKiemHoaDon.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiemHoaDon.Location = new Point(6, 22);
            txtTimKiemHoaDon.Multiline = true;
            txtTimKiemHoaDon.Name = "txtTimKiemHoaDon";
            txtTimKiemHoaDon.Size = new Size(380, 30);
            txtTimKiemHoaDon.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 462);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 1;
            label3.Text = "Tổng tiền:";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label33.Location = new Point(25, 352);
            label33.Name = "label33";
            label33.Size = new Size(133, 17);
            label33.TabIndex = 1;
            label33.Text = "Tổng tiền sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 497);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 1;
            label2.Text = "Ghi chú:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(25, 314);
            label9.Name = "label9";
            label9.Size = new Size(88, 17);
            label9.TabIndex = 1;
            label9.Text = "Số tiền nhận:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(25, 236);
            label8.Name = "label8";
            label8.Size = new Size(71, 17);
            label8.TabIndex = 1;
            label8.Text = "Hình thức:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 198);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 1;
            label4.Text = "Giảm giá:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(25, 160);
            label7.Name = "label7";
            label7.Size = new Size(85, 17);
            label7.TabIndex = 1;
            label7.Text = "Mã hóa đơn:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(ptbLamMoiSP);
            groupBox4.Controls.Add(dtgSanpham);
            groupBox4.Controls.Add(btnTimKiemSP);
            groupBox4.Controls.Add(comboBox3);
            groupBox4.Controls.Add(txtTimKiemSP);
            groupBox4.Location = new Point(5, 448);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(828, 259);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sản phẩm";
            // 
            // ptbLamMoiSP
            // 
            ptbLamMoiSP.Image = Properties.Resources.reload;
            ptbLamMoiSP.Location = new Point(787, 22);
            ptbLamMoiSP.Name = "ptbLamMoiSP";
            ptbLamMoiSP.Size = new Size(35, 28);
            ptbLamMoiSP.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLamMoiSP.TabIndex = 4;
            ptbLamMoiSP.TabStop = false;
            ptbLamMoiSP.Click += ptbLamMoiIdHoaDonChiTiet_Click;
            // 
            // btnTimKiemSP
            // 
            btnTimKiemSP.FlatAppearance.BorderSize = 0;
            btnTimKiemSP.FlatStyle = FlatStyle.System;
            btnTimKiemSP.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiemSP.Location = new Point(550, 20);
            btnTimKiemSP.Name = "btnTimKiemSP";
            btnTimKiemSP.Size = new Size(103, 30);
            btnTimKiemSP.TabIndex = 11;
            btnTimKiemSP.Text = "Tìm kiếm";
            btnTimKiemSP.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(392, 22);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(150, 23);
            comboBox3.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(24, 122);
            label6.Name = "label6";
            label6.Size = new Size(94, 17);
            label6.TabIndex = 1;
            label6.Text = "Mã nhân viên:";
            // 
            // ptbChonKhachHang
            // 
            ptbChonKhachHang.Image = Properties.Resources.add_user;
            ptbChonKhachHang.Location = new Point(199, 25);
            ptbChonKhachHang.Name = "ptbChonKhachHang";
            ptbChonKhachHang.Size = new Size(36, 36);
            ptbChonKhachHang.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbChonKhachHang.TabIndex = 2;
            ptbChonKhachHang.TabStop = false;
            ptbChonKhachHang.Click += ptbChonKhachHang_Click;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.AutoSize = true;
            txtMaKhachHang.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaKhachHang.Location = new Point(113, 19);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(17, 17);
            txtMaKhachHang.TabIndex = 1;
            txtMaKhachHang.Text = "...";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.AutoSize = true;
            txtTenKhachHang.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTenKhachHang.Location = new Point(113, 45);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(17, 17);
            txtTenKhachHang.TabIndex = 1;
            txtTenKhachHang.Text = "...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 45);
            label1.Name = "label1";
            label1.Size = new Size(107, 17);
            label1.TabIndex = 1;
            label1.Text = "Tên khách hàng:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(ptbChonKhachHang);
            groupBox5.Controls.Add(txtMaKhachHang);
            groupBox5.Controls.Add(txtTenKhachHang);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(label5);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.Location = new Point(18, 22);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(241, 79);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 19);
            label5.Name = "label5";
            label5.Size = new Size(105, 17);
            label5.TabIndex = 1;
            label5.Text = "Mã khách hàng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cboxDungDiemKH);
            groupBox2.Controls.Add(btnThanhToan);
            groupBox2.Controls.Add(cbbHinhThucThanhToan);
            groupBox2.Controls.Add(txtGhiChu);
            groupBox2.Controls.Add(txtDiemKH);
            groupBox2.Controls.Add(txtSoTienNhan);
            groupBox2.Controls.Add(txtGiaGiam);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtSoTienThieu);
            groupBox2.Controls.Add(txtSoTienThua);
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(txtTongTienSP);
            groupBox2.Controls.Add(txtMaHoaDon);
            groupBox2.Controls.Add(txtMaNhanVien);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label33);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Location = new Point(839, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 703);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thanh toán";
            // 
            // Frm_BanHang2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Name = "Frm_BanHang2";
            Size = new Size(1108, 711);
            Load += Frm_BanHang_Load;
            ((System.ComponentModel.ISupportInitialize)dtgSanpham).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLamMoiIdHoaDonChiTiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgGiohang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbThemHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgHoadon).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLamMoiSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbChonKhachHang).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgSanpham;
        private CheckBox cboxDungDiemKH;
        private GroupBox groupBox3;
        private PictureBox ptbLamMoiIdHoaDonChiTiet;
        private TextBox txtIDHoaDonChiTiet_Checked;
        private DataGridView dtgGiohang;
        private Button btnChonTatCa;
        private Button btnXoa;
        private Button btnThanhToan;
        private ComboBox cbbHinhThucThanhToan;
        private TextBox txtGhiChu;
        private TextBox txtDiemKH;
        private TextBox txtSoTienNhan;
        private TextBox txtGiaGiam;
        private Label label12;
        private Label label11;
        private Label txtSoTienThieu;
        private Label txtSoTienThua;
        private Label txtTongTien;
        private Label txtTongTienSP;
        private Label txtMaNhanVien;
        private TextBox txtTimKiemSP;
        private Label txtMaHoaDon;
        private GroupBox groupBox1;
        private PictureBox ptbThemHoaDon;
        private Button btnXoaHoaDon;
        private Button btnTimKiemHoaDon;
        private DataGridView dtgHoadon;
        private ComboBox cbbTimKiemHoaDon;
        private TextBox txtTimKiemHoaDon;
        private Label label3;
        private Label label33;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label4;
        private Label label7;
        private GroupBox groupBox4;
        private PictureBox ptbLamMoiSP;
        private Button btnTimKiemSP;
        private ComboBox comboBox3;
        private Label label6;
        private PictureBox ptbChonKhachHang;
        private Label txtMaKhachHang;
        private Label txtTenKhachHang;
        private Label label1;
        private GroupBox groupBox5;
        private Label label5;
        private GroupBox groupBox2;
    }
}
