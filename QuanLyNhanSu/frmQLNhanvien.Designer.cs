namespace QuanLyNhanSu
{
    partial class frmQLNhanvien
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
            this.btnThemNV = new System.Windows.Forms.Button();
            this.dateTimePickerNV = new System.Windows.Forms.DateTimePicker();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.btnTKNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTKNV = new System.Windows.Forms.TextBox();
            this.lblTKNV = new System.Windows.Forms.Label();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHuyPB = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMaPB = new System.Windows.Forms.ComboBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(78, 36);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(75, 23);
            this.btnThemNV.TabIndex = 8;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // dateTimePickerNV
            // 
            this.dateTimePickerNV.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNV.Location = new System.Drawing.Point(124, 234);
            this.dateTimePickerNV.Name = "dateTimePickerNV";
            this.dateTimePickerNV.Size = new System.Drawing.Size(179, 20);
            this.dateTimePickerNV.TabIndex = 16;
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(205, 201);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNu.TabIndex = 15;
            this.radioButtonNu.TabStop = true;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Location = new System.Drawing.Point(124, 201);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(47, 17);
            this.radioButtonNam.TabIndex = 14;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(124, 157);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(179, 20);
            this.txtDC.TabIndex = 10;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(124, 116);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(108, 20);
            this.txtMaNV.TabIndex = 9;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(124, 77);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(179, 20);
            this.txtTenNV.TabIndex = 8;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(27, 119);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(72, 13);
            this.lblMaNV.TabIndex = 7;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // btnTKNV
            // 
            this.btnTKNV.Location = new System.Drawing.Point(399, 37);
            this.btnTKNV.Name = "btnTKNV";
            this.btnTKNV.Size = new System.Drawing.Size(75, 23);
            this.btnTKNV.TabIndex = 11;
            this.btnTKNV.Text = "Tìm kiếm";
            this.btnTKNV.UseVisualStyleBackColor = true;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(240, 36);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaNV.TabIndex = 10;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuyPB);
            this.groupBox2.Controls.Add(this.btnHuy);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnXoaNV);
            this.groupBox2.Controls.Add(this.btnSuaNV);
            this.groupBox2.Controls.Add(this.btnThemNV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1127, 159);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(441, 36);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTKNV);
            this.groupBox3.Controls.Add(this.lblTKNV);
            this.groupBox3.Controls.Add(this.btnTKNV);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1121, 87);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // txtTKNV
            // 
            this.txtTKNV.Location = new System.Drawing.Point(121, 37);
            this.txtTKNV.Name = "txtTKNV";
            this.txtTKNV.Size = new System.Drawing.Size(231, 20);
            this.txtTKNV.TabIndex = 18;
            // 
            // lblTKNV
            // 
            this.lblTKNV.AutoSize = true;
            this.lblTKNV.Location = new System.Drawing.Point(9, 40);
            this.lblTKNV.Name = "lblTKNV";
            this.lblTKNV.Size = new System.Drawing.Size(99, 13);
            this.lblTKNV.TabIndex = 18;
            this.lblTKNV.Text = "Tìm kiếm nhân viên";
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(159, 36);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(75, 23);
            this.btnSuaNV.TabIndex = 9;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Location = new System.Drawing.Point(59, 160);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(40, 13);
            this.lblDC.TabIndex = 6;
            this.lblDC.Text = "Địa chỉ";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(52, 201);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(47, 13);
            this.lblGT.TabIndex = 5;
            this.lblGT.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(62, 277);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(37, 13);
            this.lblLuong.TabIndex = 1;
            this.lblLuong.Text = "Lương";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(27, 84);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(76, 13);
            this.lblTenNV.TabIndex = 0;
            this.lblTenNV.Text = "Tên nhân viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLuong);
            this.groupBox1.Controls.Add(this.cbMaPB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DgvNhanVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerNV);
            this.groupBox1.Controls.Add(this.radioButtonNu);
            this.groupBox1.Controls.Add(this.radioButtonNam);
            this.groupBox1.Controls.Add(this.txtDC);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.lblMaNV);
            this.groupBox1.Controls.Add(this.lblDC);
            this.groupBox1.Controls.Add(this.lblGT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblLuong);
            this.groupBox1.Controls.Add(this.lblTenNV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 373);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(118, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Phòng ban";
            // 
            // DgvNhanVien
            // 
            this.DgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Hoten,
            this.MaNV,
            this.Diachi,
            this.GT,
            this.NS,
            this.Luong,
            this.PhongBan});
            this.DgvNhanVien.Location = new System.Drawing.Point(372, 77);
            this.DgvNhanVien.Name = "DgvNhanVien";
            this.DgvNhanVien.Size = new System.Drawing.Size(689, 290);
            this.DgvNhanVien.TabIndex = 20;
            this.DgvNhanVien.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DgvNhanVien_RowPrePaint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(625, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Danh sách nhân viên";
            // 
            // btnHuyPB
            // 
            this.btnHuyPB.Location = new System.Drawing.Point(603, 36);
            this.btnHuyPB.Name = "btnHuyPB";
            this.btnHuyPB.Size = new System.Drawing.Size(75, 23);
            this.btnHuyPB.TabIndex = 15;
            this.btnHuyPB.Text = "Thoát";
            this.btnHuyPB.UseVisualStyleBackColor = true;
            this.btnHuyPB.Click += new System.EventHandler(this.btnHuyPB_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(522, 36);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "HOTEN";
            this.Hoten.HeaderText = "Họ Tên";
            this.Hoten.Name = "Hoten";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MANV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.Name = "Diachi";
            // 
            // GT
            // 
            this.GT.DataPropertyName = "GIOITINH";
            this.GT.HeaderText = "Giới Tính";
            this.GT.Name = "GT";
            // 
            // NS
            // 
            this.NS.DataPropertyName = "NGAYSINH";
            this.NS.HeaderText = "Ngày sinh";
            this.NS.Name = "NS";
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "LUONG";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            // 
            // PhongBan
            // 
            this.PhongBan.DataPropertyName = "TENPB";
            this.PhongBan.HeaderText = "Phòng Ban";
            this.PhongBan.Name = "PhongBan";
            // 
            // cbMaPB
            // 
            this.cbMaPB.FormattingEnabled = true;
            this.cbMaPB.Location = new System.Drawing.Point(124, 321);
            this.cbMaPB.Name = "cbMaPB";
            this.cbMaPB.Size = new System.Drawing.Size(121, 21);
            this.cbMaPB.TabIndex = 22;
            this.cbMaPB.SelectedIndexChanged += new System.EventHandler(this.frmQLNhanvien_Load);
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(122, 277);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(108, 20);
            this.txtLuong.TabIndex = 23;
            // 
            // frmQLNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 532);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLNhanvien";
            this.Load += new System.EventHandler(this.frmQLNhanvien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.DateTimePicker dateTimePickerNV;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Button btnTKNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTKNV;
        private System.Windows.Forms.Label lblTKNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuyPB;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongBan;
        private System.Windows.Forms.ComboBox cbMaPB;
        private System.Windows.Forms.TextBox txtLuong;
    }
}