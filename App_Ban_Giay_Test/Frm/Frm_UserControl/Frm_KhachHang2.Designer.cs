namespace App_Ban_Giay_Test.Frm.Frm_UserControl
{
    partial class Frm_KhachHang2
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
            groupBox1 = new GroupBox();
            dtgKhachHang = new DataGridView();
            txtTimkiem = new TextBox();
            label1 = new Label();
            btnExcel = new Button();
            txtDiem = new TextBox();
            label8 = new Label();
            btnKhoaMoKhoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTen = new TextBox();
            txtSDT = new TextBox();
            groupBox2 = new GroupBox();
            dtgHoaDon = new DataGridView();
            txtMa = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgKhachHang).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHoaDon).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgKhachHang);
            groupBox1.Controls.Add(txtTimkiem);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 231);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1078, 244);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Khách hàng";
            // 
            // dtgKhachHang
            // 
            dtgKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgKhachHang.Location = new Point(24, 75);
            dtgKhachHang.Margin = new Padding(2);
            dtgKhachHang.Name = "dtgKhachHang";
            dtgKhachHang.RowHeadersWidth = 62;
            dtgKhachHang.RowTemplate.Height = 33;
            dtgKhachHang.Size = new Size(1025, 146);
            dtgKhachHang.TabIndex = 2;
            dtgKhachHang.CellClick += dtgKhachHang_CellClick;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(106, 24);
            txtTimkiem.Margin = new Padding(2);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(266, 23);
            txtTimkiem.TabIndex = 1;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm";
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(438, 119);
            btnExcel.Margin = new Padding(2);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(79, 20);
            btnExcel.TabIndex = 15;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // txtDiem
            // 
            txtDiem.Enabled = false;
            txtDiem.Location = new Point(268, 67);
            txtDiem.Margin = new Padding(2);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(120, 23);
            txtDiem.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(181, 67);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 13;
            label8.Text = "Điểm KH";
            // 
            // btnKhoaMoKhoa
            // 
            btnKhoaMoKhoa.Location = new Point(307, 119);
            btnKhoaMoKhoa.Margin = new Padding(2);
            btnKhoaMoKhoa.Name = "btnKhoaMoKhoa";
            btnKhoaMoKhoa.Size = new Size(107, 20);
            btnKhoaMoKhoa.TabIndex = 11;
            btnKhoaMoKhoa.Text = "Khóa/Mở khoá";
            btnKhoaMoKhoa.UseVisualStyleBackColor = true;
            btnKhoaMoKhoa.Click += btnKhoaMoKhoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(183, 119);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(79, 20);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(64, 119);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(79, 20);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(64, 67);
            txtTen.Margin = new Padding(2);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(98, 23);
            txtTen.TabIndex = 5;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(268, 27);
            txtSDT.Margin = new Padding(2);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(120, 23);
            txtSDT.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtgHoaDon);
            groupBox2.Location = new Point(15, 487);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1078, 211);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn đã mua";
            // 
            // dtgHoaDon
            // 
            dtgHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHoaDon.Location = new Point(24, 39);
            dtgHoaDon.Margin = new Padding(2);
            dtgHoaDon.Name = "dtgHoaDon";
            dtgHoaDon.RowHeadersWidth = 62;
            dtgHoaDon.RowTemplate.Height = 33;
            dtgHoaDon.Size = new Size(1025, 169);
            dtgHoaDon.TabIndex = 0;
            // 
            // txtMa
            // 
            txtMa.Enabled = false;
            txtMa.Location = new Point(64, 27);
            txtMa.Margin = new Padding(2);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(98, 23);
            txtMa.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 29);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 2;
            label6.Text = "Số điện thoại";
            label6.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 65);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 1;
            label5.Text = "Họ tên";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExcel);
            groupBox3.Controls.Add(txtDiem);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(btnKhoaMoKhoa);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(txtTen);
            groupBox3.Controls.Add(txtSDT);
            groupBox3.Controls.Add(txtMa);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(15, 13);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(1078, 198);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thêm khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 29);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 0;
            label4.Text = "Mã";
            // 
            // Frm_KhachHang2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "Frm_KhachHang2";
            Size = new Size(1108, 711);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgKhachHang).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgHoaDon).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtgKhachHang;
        private TextBox txtTimkiem;
        private Label label1;
        private Button btnExcel;
        private TextBox txtDiem;
        private Label label8;
        private Button btnKhoaMoKhoa;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTen;
        private TextBox txtSDT;
        private GroupBox groupBox2;
        private DataGridView dtgHoaDon;
        private TextBox txtMa;
        private Label label6;
        private Label label5;
        private GroupBox groupBox3;
        private Label label4;
    }
}
