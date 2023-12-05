namespace PRL
{
    partial class HinhThucThanhToan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtTen = new TextBox();
            txtMota = new RichTextBox();
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnLammoi = new Button();
            txtTimkiem = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 76);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên hình thức";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 126);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Mô tả";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(152, 76);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(287, 27);
            txtTen.TabIndex = 2;
            // 
            // txtMota
            // 
            txtMota.Location = new Point(152, 126);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(287, 97);
            txtMota.TabIndex = 3;
            txtMota.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(124, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(576, 188);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(499, 24);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(105, 44);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(654, 24);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(105, 44);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLammoi
            // 
            btnLammoi.Location = new Point(574, 114);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(105, 44);
            btnLammoi.TabIndex = 8;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(152, 33);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(287, 27);
            txtTimkiem.TabIndex = 10;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 33);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 9;
            label3.Text = "Tìm kiếm";
            // 
            // HinhThucThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTimkiem);
            Controls.Add(label3);
            Controls.Add(btnLammoi);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(txtMota);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HinhThucThanhToan";
            Text = "HinhThucThanhToan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTen;
        private RichTextBox txtMota;
        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnSua;
        private Button btnLammoi;
        private TextBox txtTimkiem;
        private Label label3;
    }
}