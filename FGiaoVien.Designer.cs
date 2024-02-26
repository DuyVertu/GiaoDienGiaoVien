namespace GiaoDienGiaoVien
{
    partial class FGiaoVien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.lbTenNguoiLogin = new System.Windows.Forms.Label();
            this.lbChinhSua = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.lbTenDOAN = new System.Windows.Forms.Label();
            this.tbTenDOAN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIDDoan = new System.Windows.Forms.TextBox();
            this.lbIDNhom = new System.Windows.Forms.Label();
            this.tbIDNhom = new System.Windows.Forms.TextBox();
            this.lbDeadline = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.cbDiem = new System.Windows.Forms.ComboBox();
            this.lbIDGv = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Column1,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.GridColor = System.Drawing.Color.Cyan;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(935, 302);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Location = new System.Drawing.Point(12, 9);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(72, 16);
            this.lbTenDangNhap.TabIndex = 1;
            this.lbTenDangNhap.Text = "GiaoVien : ";
            this.lbTenDangNhap.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTenNguoiLogin
            // 
            this.lbTenNguoiLogin.AutoSize = true;
            this.lbTenNguoiLogin.Location = new System.Drawing.Point(90, 9);
            this.lbTenNguoiLogin.Name = "lbTenNguoiLogin";
            this.lbTenNguoiLogin.Size = new System.Drawing.Size(241, 16);
            this.lbTenNguoiLogin.TabIndex = 2;
            this.lbTenNguoiLogin.Text = "Ten Cua Giao Vien Khi Dang Nhap Vao";
            // 
            // lbChinhSua
            // 
            this.lbChinhSua.AutoSize = true;
            this.lbChinhSua.Location = new System.Drawing.Point(39, 214);
            this.lbChinhSua.Name = "lbChinhSua";
            this.lbChinhSua.Size = new System.Drawing.Size(0, 16);
            this.lbChinhSua.TabIndex = 3;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btThem.Location = new System.Drawing.Point(760, 34);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(96, 44);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Them";
            this.btThem.UseVisualStyleBackColor = false;
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btXoa.Location = new System.Drawing.Point(760, 103);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(96, 42);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xoa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btSua.Location = new System.Drawing.Point(760, 170);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(96, 42);
            this.btSua.TabIndex = 6;
            this.btSua.Text = "Sua";
            this.btSua.UseVisualStyleBackColor = false;
            // 
            // btTimkiem
            // 
            this.btTimkiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btTimkiem.Location = new System.Drawing.Point(760, 235);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(96, 44);
            this.btTimkiem.TabIndex = 7;
            this.btTimkiem.Text = "Tim Kiem";
            this.btTimkiem.UseVisualStyleBackColor = false;
            // 
            // lbTenDOAN
            // 
            this.lbTenDOAN.AutoSize = true;
            this.lbTenDOAN.Location = new System.Drawing.Point(39, 196);
            this.lbTenDOAN.Name = "lbTenDOAN";
            this.lbTenDOAN.Size = new System.Drawing.Size(74, 16);
            this.lbTenDOAN.TabIndex = 8;
            this.lbTenDOAN.Text = "Ten Do An ";
            this.lbTenDOAN.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tbTenDOAN
            // 
            this.tbTenDOAN.Location = new System.Drawing.Point(151, 196);
            this.tbTenDOAN.Name = "tbTenDOAN";
            this.tbTenDOAN.Size = new System.Drawing.Size(131, 22);
            this.tbTenDOAN.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Do An";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // tbIDDoan
            // 
            this.tbIDDoan.Location = new System.Drawing.Point(151, 126);
            this.tbIDDoan.Name = "tbIDDoan";
            this.tbIDDoan.Size = new System.Drawing.Size(131, 22);
            this.tbIDDoan.TabIndex = 11;
            // 
            // lbIDNhom
            // 
            this.lbIDNhom.AutoSize = true;
            this.lbIDNhom.Location = new System.Drawing.Point(39, 258);
            this.lbIDNhom.Name = "lbIDNhom";
            this.lbIDNhom.Size = new System.Drawing.Size(59, 16);
            this.lbIDNhom.TabIndex = 12;
            this.lbIDNhom.Text = "ID Nhom";
            // 
            // tbIDNhom
            // 
            this.tbIDNhom.Location = new System.Drawing.Point(151, 258);
            this.tbIDNhom.Name = "tbIDNhom";
            this.tbIDNhom.Size = new System.Drawing.Size(131, 22);
            this.tbIDNhom.TabIndex = 13;
            // 
            // lbDeadline
            // 
            this.lbDeadline.AutoSize = true;
            this.lbDeadline.Location = new System.Drawing.Point(377, 170);
            this.lbDeadline.Name = "lbDeadline";
            this.lbDeadline.Size = new System.Drawing.Size(66, 16);
            this.lbDeadline.TabIndex = 14;
            this.lbDeadline.Text = "DeadLine";
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Location = new System.Drawing.Point(377, 235);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(39, 16);
            this.lbDiem.TabIndex = 15;
            this.lbDiem.Text = "Diem";
            // 
            // cbDiem
            // 
            this.cbDiem.FormattingEnabled = true;
            this.cbDiem.Location = new System.Drawing.Point(477, 235);
            this.cbDiem.Name = "cbDiem";
            this.cbDiem.Size = new System.Drawing.Size(131, 24);
            this.cbDiem.TabIndex = 17;
            // 
            // lbIDGv
            // 
            this.lbIDGv.AutoSize = true;
            this.lbIDGv.Location = new System.Drawing.Point(333, 9);
            this.lbIDGv.Name = "lbIDGv";
            this.lbIDGv.Size = new System.Drawing.Size(110, 16);
            this.lbIDGv.TabIndex = 18;
            this.lbIDGv.Text = "[Id cua GiaoVien]";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(477, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Do An";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ten Do An";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TomTatNoiDung";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID Nhom";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID GiaoVien PhuTrach";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "DeadLine";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Diem";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // FGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(940, 614);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbIDGv);
            this.Controls.Add(this.cbDiem);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.lbDeadline);
            this.Controls.Add(this.tbIDNhom);
            this.Controls.Add(this.lbIDNhom);
            this.Controls.Add(this.tbIDDoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTenDOAN);
            this.Controls.Add(this.lbTenDOAN);
            this.Controls.Add(this.btTimkiem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.lbChinhSua);
            this.Controls.Add(this.lbTenNguoiLogin);
            this.Controls.Add(this.lbTenDangNhap);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FGiaoVien";
            this.Text = "FGiaoVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbTenDangNhap;
        private System.Windows.Forms.Label lbTenNguoiLogin;
        private System.Windows.Forms.Label lbChinhSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Label lbTenDOAN;
        private System.Windows.Forms.TextBox tbTenDOAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIDDoan;
        private System.Windows.Forms.Label lbIDNhom;
        private System.Windows.Forms.TextBox tbIDNhom;
        private System.Windows.Forms.Label lbDeadline;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.ComboBox cbDiem;
        private System.Windows.Forms.Label lbIDGv;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

