namespace App_Ban_Giay_Test.Frm.Frm_UserControl
{
    partial class Frm_UuDai2
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
            dtgHienthi = new DataGridView();
            txtTimkiem = new TextBox();
            groupBox2 = new GroupBox();
            btnlammoi = new Button();
            btnketthuc = new Button();
            datebatdau = new DateTimePicker();
            dateketthuc = new DateTimePicker();
            label5 = new Label();
            txtphantram = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtTen = new TextBox();
            groupBox3 = new GroupBox();
            txtSoluong = new TextBox();
            btnSua = new Button();
            groupBox4 = new GroupBox();
            btnThem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHienthi).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgHienthi);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 705);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách ưu đãi";
            // 
            // dtgHienthi
            // 
            dtgHienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHienthi.Location = new Point(6, 22);
            dtgHienthi.Name = "dtgHienthi";
            dtgHienthi.RowHeadersWidth = 51;
            dtgHienthi.RowTemplate.Height = 25;
            dtgHienthi.Size = new Size(768, 677);
            dtgHienthi.TabIndex = 0;
            dtgHienthi.CellClick += dtgHienthi_CellClick;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(19, 33);
            txtTimkiem.Multiline = true;
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(272, 32);
            txtTimkiem.TabIndex = 1;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnlammoi);
            groupBox2.Controls.Add(btnketthuc);
            groupBox2.Controls.Add(txtTimkiem);
            groupBox2.Location = new Point(789, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 155);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // btnlammoi
            // 
            btnlammoi.Location = new Point(146, 76);
            btnlammoi.Margin = new Padding(3, 2, 3, 2);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(82, 22);
            btnlammoi.TabIndex = 4;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // btnketthuc
            // 
            btnketthuc.Location = new Point(19, 76);
            btnketthuc.Margin = new Padding(3, 2, 3, 2);
            btnketthuc.Name = "btnketthuc";
            btnketthuc.Size = new Size(82, 22);
            btnketthuc.TabIndex = 2;
            btnketthuc.Text = "Kết thúc";
            btnketthuc.UseVisualStyleBackColor = true;
            btnketthuc.Click += btnketthuc_Click;
            // 
            // datebatdau
            // 
            datebatdau.Location = new Point(19, 170);
            datebatdau.Name = "datebatdau";
            datebatdau.Size = new Size(246, 23);
            datebatdau.TabIndex = 14;
            // 
            // dateketthuc
            // 
            dateketthuc.Location = new Point(19, 228);
            dateketthuc.Name = "dateketthuc";
            dateketthuc.Size = new Size(246, 23);
            dateketthuc.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 268);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 13;
            label5.Text = "Phần trăm giảm giá:";
            // 
            // txtphantram
            // 
            txtphantram.Location = new Point(19, 290);
            txtphantram.Multiline = true;
            txtphantram.Name = "txtphantram";
            txtphantram.Size = new Size(246, 33);
            txtphantram.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 210);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 13;
            label4.Text = "Ngày kết thúc:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 152);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 13;
            label2.Text = "Ngày bắt đầu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 94);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 13;
            label1.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 36);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 13;
            label3.Text = "Tên ưu đãi";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(19, 58);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(246, 33);
            txtTen.TabIndex = 12;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(datebatdau);
            groupBox3.Controls.Add(dateketthuc);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtphantram);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtSoluong);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtTen);
            groupBox3.Location = new Point(789, 164);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(316, 408);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin";
            // 
            // txtSoluong
            // 
            txtSoluong.Location = new Point(19, 116);
            txtSoluong.Multiline = true;
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(246, 33);
            txtSoluong.TabIndex = 12;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Location = new Point(19, 67);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(272, 39);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSua);
            groupBox4.Controls.Add(btnThem);
            groupBox4.Location = new Point(789, 578);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(316, 130);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chức năng";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Location = new Point(19, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(272, 39);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Frm_UuDai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Name = "Frm_UuDai2";
            Size = new Size(1108, 711);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgHienthi).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dtgHienthi;
        private TextBox txtTimkiem;
        private GroupBox groupBox2;
        private Button btnlammoi;
        private Button btnketthuc;
        private DateTimePicker datebatdau;
        private DateTimePicker dateketthuc;
        private Label label5;
        private TextBox txtphantram;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtTen;
        private GroupBox groupBox3;
        private TextBox txtSoluong;
        private Button btnSua;
        private GroupBox groupBox4;
        private Button btnThem;
    }
}
