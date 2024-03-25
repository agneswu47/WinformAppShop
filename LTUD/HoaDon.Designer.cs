
namespace LTUD
{
    partial class HoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_themmathang = new System.Windows.Forms.Button();
            this.tenDAV = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tenTS = new System.Windows.Forms.ComboBox();
            this.dongia = new System.Windows.Forms.TextBox();
            this.soluong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.maNV = new System.Windows.Forms.TextBox();
            this.hotenNV = new System.Windows.Forms.TextBox();
            this.hotenKH = new System.Windows.Forms.TextBox();
            this.maHD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ngaylap = new System.Windows.Forms.DateTimePicker();
            this.maKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGVHD = new System.Windows.Forms.DataGridView();
            this.btn_xuat = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thongtinHD = new System.Windows.Forms.GroupBox();
            this.thongtinKH = new System.Windows.Forms.GroupBox();
            this.thongtinNV = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.diachiKH = new System.Windows.Forms.TextBox();
            this.sdtKH = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.thongtinHD.SuspendLayout();
            this.thongtinKH.SuspendLayout();
            this.thongtinNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.btn_themmathang);
            this.groupBox1.Controls.Add(this.tenDAV);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tenTS);
            this.groupBox1.Controls.Add(this.dongia);
            this.groupBox1.Controls.Add(this.soluong);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(1078, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 272);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mặt hàng";
            // 
            // btn_themmathang
            // 
            this.btn_themmathang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_themmathang.ForeColor = System.Drawing.Color.White;
            this.btn_themmathang.Location = new System.Drawing.Point(301, 206);
            this.btn_themmathang.Name = "btn_themmathang";
            this.btn_themmathang.Size = new System.Drawing.Size(185, 56);
            this.btn_themmathang.TabIndex = 58;
            this.btn_themmathang.Text = "Thêm mặt hàng";
            this.btn_themmathang.UseVisualStyleBackColor = false;
            this.btn_themmathang.Click += new System.EventHandler(this.btn_themmathang_Click);
            // 
            // tenDAV
            // 
            this.tenDAV.FormattingEnabled = true;
            this.tenDAV.Items.AddRange(new object[] {
            "Bánh tráng trộn",
            "Bánh tráng cuốn",
            "Thập cẩm chiên",
            "Cơm cuộn",
            "Cơm cháy chà bông",
            "Xiên que"});
            this.tenDAV.Location = new System.Drawing.Point(226, 77);
            this.tenDAV.Name = "tenDAV";
            this.tenDAV.Size = new System.Drawing.Size(353, 33);
            this.tenDAV.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Tên đồ ăn vặt";
            // 
            // tenTS
            // 
            this.tenTS.FormattingEnabled = true;
            this.tenTS.Items.AddRange(new object[] {
            "Trà sữa Matcha",
            "Trà sữa Khoai Môn",
            "Trà sữa Socola",
            "Trà sữa Việt Quất",
            "Hồng trà Matchiato",
            "Trà sữa Truyền Thống"});
            this.tenTS.Location = new System.Drawing.Point(226, 29);
            this.tenTS.Name = "tenTS";
            this.tenTS.Size = new System.Drawing.Size(353, 33);
            this.tenTS.TabIndex = 34;
            // 
            // dongia
            // 
            this.dongia.Location = new System.Drawing.Point(226, 160);
            this.dongia.Name = "dongia";
            this.dongia.Size = new System.Drawing.Size(353, 30);
            this.dongia.TabIndex = 33;
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(226, 120);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(353, 30);
            this.soluong.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tên trà sữa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Đơn giá";
            // 
            // maNV
            // 
            this.maNV.Location = new System.Drawing.Point(226, 49);
            this.maNV.Name = "maNV";
            this.maNV.Size = new System.Drawing.Size(353, 30);
            this.maNV.TabIndex = 32;
            // 
            // hotenNV
            // 
            this.hotenNV.Location = new System.Drawing.Point(226, 107);
            this.hotenNV.Name = "hotenNV";
            this.hotenNV.Size = new System.Drawing.Size(353, 30);
            this.hotenNV.TabIndex = 30;
            // 
            // hotenKH
            // 
            this.hotenKH.Location = new System.Drawing.Point(226, 85);
            this.hotenKH.Name = "hotenKH";
            this.hotenKH.Size = new System.Drawing.Size(353, 30);
            this.hotenKH.TabIndex = 29;
            // 
            // maHD
            // 
            this.maHD.Location = new System.Drawing.Point(242, 42);
            this.maHD.Name = "maHD";
            this.maHD.Size = new System.Drawing.Size(353, 30);
            this.maHD.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(21, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Họ Tên nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(21, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Họ Tên khách hàng";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ngaylap
            // 
            this.ngaylap.Location = new System.Drawing.Point(242, 92);
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.Size = new System.Drawing.Size(353, 30);
            this.ngaylap.TabIndex = 10;
            // 
            // maKH
            // 
            this.maKH.Location = new System.Drawing.Point(226, 38);
            this.maKH.Name = "maKH";
            this.maKH.Size = new System.Drawing.Size(353, 30);
            this.maKH.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(64, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày lập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(21, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(21, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(64, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // dataGVHD
            // 
            this.dataGVHD.BackgroundColor = System.Drawing.Color.White;
            this.dataGVHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVHD.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGVHD.Location = new System.Drawing.Point(0, 29);
            this.dataGVHD.Name = "dataGVHD";
            this.dataGVHD.RowHeadersWidth = 62;
            this.dataGVHD.RowTemplate.Height = 28;
            this.dataGVHD.Size = new System.Drawing.Size(1063, 458);
            this.dataGVHD.TabIndex = 0;
            this.dataGVHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVHD_CellContentClick);
            // 
            // btn_xuat
            // 
            this.btn_xuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuat.ForeColor = System.Drawing.Color.White;
            this.btn_xuat.Location = new System.Drawing.Point(1131, 688);
            this.btn_xuat.Name = "btn_xuat";
            this.btn_xuat.Size = new System.Drawing.Size(111, 58);
            this.btn_xuat.TabIndex = 53;
            this.btn_xuat.Text = "Xuất";
            this.btn_xuat.UseVisualStyleBackColor = false;
            this.btn_xuat.Click += new System.EventHandler(this.btn_xuat_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(1392, 688);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(111, 58);
            this.btn_thoat.TabIndex = 52;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(911, 688);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(111, 58);
            this.btn_luu.TabIndex = 51;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(696, 688);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(111, 58);
            this.btn_xoa.TabIndex = 50;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(462, 688);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(111, 58);
            this.btn_sua.TabIndex = 49;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(215, 688);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(111, 58);
            this.btn_them.TabIndex = 48;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.dataGVHD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(3, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1069, 493);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // thongtinHD
            // 
            this.thongtinHD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thongtinHD.BackgroundImage")));
            this.thongtinHD.Controls.Add(this.label2);
            this.thongtinHD.Controls.Add(this.maHD);
            this.thongtinHD.Controls.Add(this.label5);
            this.thongtinHD.Controls.Add(this.ngaylap);
            this.thongtinHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtinHD.ForeColor = System.Drawing.Color.Maroon;
            this.thongtinHD.Location = new System.Drawing.Point(3, 7);
            this.thongtinHD.Name = "thongtinHD";
            this.thongtinHD.Size = new System.Drawing.Size(1069, 150);
            this.thongtinHD.TabIndex = 55;
            this.thongtinHD.TabStop = false;
            this.thongtinHD.Text = "Thông tin hóa đơn";
            // 
            // thongtinKH
            // 
            this.thongtinKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thongtinKH.BackgroundImage")));
            this.thongtinKH.Controls.Add(this.sdtKH);
            this.thongtinKH.Controls.Add(this.diachiKH);
            this.thongtinKH.Controls.Add(this.label7);
            this.thongtinKH.Controls.Add(this.label1);
            this.thongtinKH.Controls.Add(this.label3);
            this.thongtinKH.Controls.Add(this.maKH);
            this.thongtinKH.Controls.Add(this.label9);
            this.thongtinKH.Controls.Add(this.hotenKH);
            this.thongtinKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtinKH.ForeColor = System.Drawing.Color.Maroon;
            this.thongtinKH.Location = new System.Drawing.Point(1078, 290);
            this.thongtinKH.Name = "thongtinKH";
            this.thongtinKH.Size = new System.Drawing.Size(604, 209);
            this.thongtinKH.TabIndex = 56;
            this.thongtinKH.TabStop = false;
            this.thongtinKH.Text = "Thông tin khách hàng";
            // 
            // thongtinNV
            // 
            this.thongtinNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thongtinNV.BackgroundImage")));
            this.thongtinNV.Controls.Add(this.label4);
            this.thongtinNV.Controls.Add(this.maNV);
            this.thongtinNV.Controls.Add(this.hotenNV);
            this.thongtinNV.Controls.Add(this.label10);
            this.thongtinNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtinNV.ForeColor = System.Drawing.Color.Maroon;
            this.thongtinNV.Location = new System.Drawing.Point(1078, 505);
            this.thongtinNV.Name = "thongtinNV";
            this.thongtinNV.Size = new System.Drawing.Size(604, 161);
            this.thongtinNV.TabIndex = 57;
            this.thongtinNV.TabStop = false;
            this.thongtinNV.Text = "Thông tin nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(26, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "SĐT";
            // 
            // diachiKH
            // 
            this.diachiKH.Location = new System.Drawing.Point(226, 123);
            this.diachiKH.Name = "diachiKH";
            this.diachiKH.Size = new System.Drawing.Size(353, 30);
            this.diachiKH.TabIndex = 32;
            // 
            // sdtKH
            // 
            this.sdtKH.Location = new System.Drawing.Point(226, 162);
            this.sdtKH.Name = "sdtKH";
            this.sdtKH.Size = new System.Drawing.Size(353, 30);
            this.sdtKH.TabIndex = 33;
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1682, 775);
            this.Controls.Add(this.thongtinNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.thongtinKH);
            this.Controls.Add(this.thongtinHD);
            this.Controls.Add(this.btn_xuat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVHD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.thongtinHD.ResumeLayout(false);
            this.thongtinHD.PerformLayout();
            this.thongtinKH.ResumeLayout(false);
            this.thongtinKH.PerformLayout();
            this.thongtinNV.ResumeLayout(false);
            this.thongtinNV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ngaylap;
        private System.Windows.Forms.TextBox maKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGVHD;
        private System.Windows.Forms.TextBox dongia;
        private System.Windows.Forms.TextBox maNV;
        private System.Windows.Forms.TextBox hotenNV;
        private System.Windows.Forms.TextBox hotenKH;
        private System.Windows.Forms.TextBox maHD;
        private System.Windows.Forms.ComboBox tenTS;
        private System.Windows.Forms.ComboBox tenDAV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox soluong;
        private System.Windows.Forms.Button btn_xuat;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox thongtinHD;
        private System.Windows.Forms.GroupBox thongtinKH;
        private System.Windows.Forms.GroupBox thongtinNV;
        private System.Windows.Forms.Button btn_themmathang;
        private System.Windows.Forms.TextBox sdtKH;
        private System.Windows.Forms.TextBox diachiKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}