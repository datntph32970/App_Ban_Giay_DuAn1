namespace App_Ban_Giay_Test.Frm.Frm_UserControl
{
    partial class Frm_HoaDon2
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnExcel = new Button();
            cmbTimkiem = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cmbloaitt = new ComboBox();
            txtTimkiem = new TextBox();
            groupBox3 = new GroupBox();
            dtgHoadonchitiet = new DataGridView();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHoadonchitiet).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1063, 252);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dtgHoadon_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(cmbTimkiem);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbloaitt);
            groupBox1.Controls.Add(txtTimkiem);
            groupBox1.Location = new Point(2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1105, 138);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(501, 89);
            btnExcel.Margin = new Padding(3, 2, 3, 2);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(82, 22);
            btnExcel.TabIndex = 10;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // cmbTimkiem
            // 
            cmbTimkiem.FormattingEnabled = true;
            cmbTimkiem.Location = new Point(501, 23);
            cmbTimkiem.Margin = new Padding(3, 2, 3, 2);
            cmbTimkiem.Name = "cmbTimkiem";
            cmbTimkiem.Size = new Size(133, 23);
            cmbTimkiem.TabIndex = 9;
            cmbTimkiem.SelectedIndexChanged += cmbTimkiem_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 81);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 7;
            label2.Text = "Loại thanh toán:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 7;
            label1.Text = "Tìm kiếm:";
            // 
            // cmbloaitt
            // 
            cmbloaitt.FormattingEnabled = true;
            cmbloaitt.Location = new Point(142, 80);
            cmbloaitt.Name = "cmbloaitt";
            cmbloaitt.Size = new Size(150, 23);
            cmbloaitt.TabIndex = 5;
            cmbloaitt.SelectedIndexChanged += cmbloaitt_SelectedIndexChanged;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimkiem.Location = new Point(108, 22);
            txtTimkiem.Multiline = true;
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(380, 30);
            txtTimkiem.TabIndex = 4;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgHoadonchitiet);
            groupBox3.Location = new Point(5, 433);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1102, 275);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa đơn chi tiết";
            // 
            // dtgHoadonchitiet
            // 
            dtgHoadonchitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHoadonchitiet.Location = new Point(15, 22);
            dtgHoadonchitiet.Name = "dtgHoadonchitiet";
            dtgHoadonchitiet.RowHeadersWidth = 51;
            dtgHoadonchitiet.RowTemplate.Height = 25;
            dtgHoadonchitiet.Size = new Size(1067, 247);
            dtgHoadonchitiet.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(2, 147);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1102, 280);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn";
            // 
            // Frm_HoaDon2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Name = "Frm_HoaDon2";
            Size = new Size(1108, 711);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgHoadonchitiet).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnExcel;
        private ComboBox cmbTimkiem;
        private Label label2;
        private Label label1;
        private ComboBox cmbloaitt;
        private TextBox txtTimkiem;
        private GroupBox groupBox3;
        private DataGridView dtgHoadonchitiet;
        private GroupBox groupBox2;
    }
}
