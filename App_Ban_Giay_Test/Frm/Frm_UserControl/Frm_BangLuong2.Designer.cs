namespace App_Ban_Giay_Test.Frm.Frm_UserControl
{
    partial class Frm_BangLuong2
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
            txtTimkiem = new TextBox();
            txtThanglam = new TextBox();
            btnLammoi = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label8 = new Label();
            txtTongthunhap = new TextBox();
            label7 = new Label();
            txtTienkhautru = new TextBox();
            label6 = new Label();
            txtTienthuong = new TextBox();
            btnexcel = new Button();
            dtgHienthi = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label5 = new Label();
            txtLCB = new TextBox();
            txtTennv = new TextBox();
            label3 = new Label();
            txtManv = new TextBox();
            label2 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtgHienthi).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(108, 26);
            txtTimkiem.Margin = new Padding(2);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(187, 23);
            txtTimkiem.TabIndex = 0;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // txtThanglam
            // 
            txtThanglam.Location = new Point(116, 90);
            txtThanglam.Margin = new Padding(3, 2, 3, 2);
            txtThanglam.Name = "txtThanglam";
            txtThanglam.Size = new Size(194, 23);
            txtThanglam.TabIndex = 15;
            // 
            // btnLammoi
            // 
            btnLammoi.Location = new Point(247, 271);
            btnLammoi.Margin = new Padding(2);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.RightToLeft = RightToLeft.No;
            btnLammoi.Size = new Size(79, 20);
            btnLammoi.TabIndex = 14;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(146, 271);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(79, 20);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(35, 271);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(79, 20);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 218);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 13;
            label8.Text = "Tổng lương";
            // 
            // txtTongthunhap
            // 
            txtTongthunhap.Enabled = false;
            txtTongthunhap.Location = new Point(116, 218);
            txtTongthunhap.Margin = new Padding(3, 2, 3, 2);
            txtTongthunhap.Name = "txtTongthunhap";
            txtTongthunhap.Size = new Size(194, 23);
            txtTongthunhap.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 186);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 11;
            label7.Text = "Tiền khấu trừ";
            // 
            // txtTienkhautru
            // 
            txtTienkhautru.Location = new Point(116, 186);
            txtTienkhautru.Margin = new Padding(3, 2, 3, 2);
            txtTienkhautru.Name = "txtTienkhautru";
            txtTienkhautru.Size = new Size(194, 23);
            txtTienkhautru.TabIndex = 10;
            txtTienkhautru.TextChanged += txtTienkhautru_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 155);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 9;
            label6.Text = "Tiền thưởng";
            // 
            // txtTienthuong
            // 
            txtTienthuong.Location = new Point(116, 154);
            txtTienthuong.Margin = new Padding(3, 2, 3, 2);
            txtTienthuong.Name = "txtTienthuong";
            txtTienthuong.Size = new Size(194, 23);
            txtTienthuong.TabIndex = 8;
            txtTienthuong.TextChanged += txtTienthuong_TextChanged;
            // 
            // btnexcel
            // 
            btnexcel.Location = new Point(420, 34);
            btnexcel.Margin = new Padding(3, 2, 3, 2);
            btnexcel.Name = "btnexcel";
            btnexcel.Size = new Size(82, 22);
            btnexcel.TabIndex = 4;
            btnexcel.Text = "Excel";
            btnexcel.UseVisualStyleBackColor = true;
            btnexcel.Click += btnexcel_Click;
            // 
            // dtgHienthi
            // 
            dtgHienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHienthi.Location = new Point(16, 69);
            dtgHienthi.Margin = new Padding(2);
            dtgHienthi.Name = "dtgHienthi";
            dtgHienthi.RowHeadersWidth = 62;
            dtgHienthi.RowTemplate.Height = 33;
            dtgHienthi.Size = new Size(625, 217);
            dtgHienthi.TabIndex = 3;
            dtgHienthi.CellClick += dtgHienthi_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnexcel);
            groupBox1.Controls.Add(dtgHienthi);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTimkiem);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(703, 539);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bảng lương";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 122);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 7;
            label5.Text = "Lương cơ bản";
            // 
            // txtLCB
            // 
            txtLCB.Location = new Point(116, 122);
            txtLCB.Margin = new Padding(3, 2, 3, 2);
            txtLCB.Name = "txtLCB";
            txtLCB.Size = new Size(194, 23);
            txtLCB.TabIndex = 6;
            txtLCB.TextChanged += txtLCB_TextChanged;
            // 
            // txtTennv
            // 
            txtTennv.Enabled = false;
            txtTennv.Location = new Point(116, 61);
            txtTennv.Margin = new Padding(3, 2, 3, 2);
            txtTennv.Name = "txtTennv";
            txtTennv.Size = new Size(194, 23);
            txtTennv.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 31);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 3;
            label3.Text = "Mã nhân viên";
            // 
            // txtManv
            // 
            txtManv.Location = new Point(116, 31);
            txtManv.Margin = new Padding(3, 2, 3, 2);
            txtManv.Name = "txtManv";
            txtManv.Size = new Size(194, 23);
            txtManv.TabIndex = 2;
            txtManv.TextChanged += txtManv_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 88);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Tháng làm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 61);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 4;
            label4.Text = "Tên nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtThanglam);
            groupBox2.Controls.Add(btnLammoi);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtTongthunhap);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTienkhautru);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtTienthuong);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtLCB);
            groupBox2.Controls.Add(txtTennv);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtManv);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(709, 10);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(347, 531);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tính lương";
            // 
            // Frm_BangLuong2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Frm_BangLuong2";
            Size = new Size(1108, 711);
            ((System.ComponentModel.ISupportInitialize)dtgHienthi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTimkiem;
        private TextBox txtThanglam;
        private Button btnLammoi;
        private Button btnSua;
        private Button btnThem;
        private Label label8;
        private TextBox txtTongthunhap;
        private Label label7;
        private TextBox txtTienkhautru;
        private Label label6;
        private TextBox txtTienthuong;
        private Button btnexcel;
        private DataGridView dtgHienthi;
        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private TextBox txtLCB;
        private TextBox txtTennv;
        private Label label3;
        private TextBox txtManv;
        private Label label2;
        private Label label4;
        private GroupBox groupBox2;
    }
}
