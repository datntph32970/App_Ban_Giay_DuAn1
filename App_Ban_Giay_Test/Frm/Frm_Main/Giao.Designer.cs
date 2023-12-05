namespace PRL
{
    partial class Giao
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
            label3 = new Label();
            txtTenca = new TextBox();
            datebatdau = new DateTimePicker();
            dateketthuc = new DateTimePicker();
            btnthem = new Button();
            txtTimkiem = new TextBox();
            label4 = new Label();
            btnsua = new Button();
            btnlammoi = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 60);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên ca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 114);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Bắt đầu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 157);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Kết thúc";
            // 
            // txtTenca
            // 
            txtTenca.Location = new Point(122, 63);
            txtTenca.Name = "txtTenca";
            txtTenca.Size = new Size(250, 27);
            txtTenca.TabIndex = 3;
            // 
            // datebatdau
            // 
            datebatdau.Location = new Point(122, 107);
            datebatdau.Name = "datebatdau";
            datebatdau.Size = new Size(250, 27);
            datebatdau.TabIndex = 4;
            // 
            // dateketthuc
            // 
            dateketthuc.Location = new Point(122, 157);
            dateketthuc.Name = "dateketthuc";
            dateketthuc.Size = new Size(250, 27);
            dateketthuc.TabIndex = 5;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(454, 59);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 6;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(122, 12);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(250, 27);
            txtTimkiem.TabIndex = 8;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 9);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "Tìm kiếm";
            // 
            // btnsua
            // 
            btnsua.Location = new Point(521, 153);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 9;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnlammoi
            // 
            btnlammoi.Location = new Point(623, 60);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(94, 29);
            btnlammoi.TabIndex = 10;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = true;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(113, 235);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(565, 188);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Giaoca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnlammoi);
            Controls.Add(btnsua);
            Controls.Add(txtTimkiem);
            Controls.Add(label4);
            Controls.Add(btnthem);
            Controls.Add(dateketthuc);
            Controls.Add(datebatdau);
            Controls.Add(txtTenca);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Giaoca";
            Text = "Giaoca";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTenca;
        private DateTimePicker datebatdau;
        private DateTimePicker dateketthuc;
        private Button btnthem;
        private TextBox txtTimkiem;
        private Label label4;
        private Button btnsua;
        private Button btnlammoi;
        private DataGridView dataGridView1;
    }
}