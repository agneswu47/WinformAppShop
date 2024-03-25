
namespace LTUD
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            this.trasua = new System.Windows.Forms.Button();
            this.doanvat = new System.Windows.Forms.Button();
            this.hoadon = new System.Windows.Forms.Button();
            this.thongtinnhanvien = new System.Windows.Forms.Button();
            this.thongke = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_xc = new System.Windows.Forms.Label();
            this.label_hello = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trasua
            // 
            this.trasua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trasua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trasua.ForeColor = System.Drawing.Color.White;
            this.trasua.Location = new System.Drawing.Point(-6, 205);
            this.trasua.Name = "trasua";
            this.trasua.Size = new System.Drawing.Size(243, 68);
            this.trasua.TabIndex = 4;
            this.trasua.Text = "Trà sữa";
            this.trasua.UseVisualStyleBackColor = false;
            this.trasua.Click += new System.EventHandler(this.trasua_Click);
            // 
            // doanvat
            // 
            this.doanvat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.doanvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doanvat.ForeColor = System.Drawing.Color.White;
            this.doanvat.Location = new System.Drawing.Point(-3, 279);
            this.doanvat.Name = "doanvat";
            this.doanvat.Size = new System.Drawing.Size(240, 68);
            this.doanvat.TabIndex = 5;
            this.doanvat.Text = "Đồ ăn vặt";
            this.doanvat.UseVisualStyleBackColor = false;
            this.doanvat.Click += new System.EventHandler(this.doanvat_Click);
            // 
            // hoadon
            // 
            this.hoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoadon.ForeColor = System.Drawing.Color.White;
            this.hoadon.Location = new System.Drawing.Point(-3, 353);
            this.hoadon.Name = "hoadon";
            this.hoadon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.hoadon.Size = new System.Drawing.Size(240, 68);
            this.hoadon.TabIndex = 7;
            this.hoadon.Text = "Hóa đơn";
            this.hoadon.UseVisualStyleBackColor = false;
            this.hoadon.Click += new System.EventHandler(this.hoadon_Click);
            // 
            // thongtinnhanvien
            // 
            this.thongtinnhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thongtinnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongtinnhanvien.ForeColor = System.Drawing.Color.White;
            this.thongtinnhanvien.Location = new System.Drawing.Point(-6, 427);
            this.thongtinnhanvien.Name = "thongtinnhanvien";
            this.thongtinnhanvien.Size = new System.Drawing.Size(243, 68);
            this.thongtinnhanvien.TabIndex = 8;
            this.thongtinnhanvien.Text = "Nhân viên";
            this.thongtinnhanvien.UseVisualStyleBackColor = false;
            this.thongtinnhanvien.Click += new System.EventHandler(this.thongtinnhanvien_Click);
            // 
            // thongke
            // 
            this.thongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongke.ForeColor = System.Drawing.Color.White;
            this.thongke.Location = new System.Drawing.Point(-3, 501);
            this.thongke.Name = "thongke";
            this.thongke.Size = new System.Drawing.Size(243, 68);
            this.thongke.TabIndex = 9;
            this.thongke.Text = "Thống kê";
            this.thongke.UseVisualStyleBackColor = false;
            this.thongke.Click += new System.EventHandler(this.thongke_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.thongke);
            this.panel2.Controls.Add(this.trasua);
            this.panel2.Controls.Add(this.thongtinnhanvien);
            this.panel2.Controls.Add(this.doanvat);
            this.panel2.Controls.Add(this.hoadon);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 823);
            this.panel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 199);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label_xc
            // 
            this.label_xc.AutoSize = true;
            this.label_xc.BackColor = System.Drawing.Color.Transparent;
            this.label_xc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_xc.ForeColor = System.Drawing.Color.Maroon;
            this.label_xc.Location = new System.Drawing.Point(707, 49);
            this.label_xc.Name = "label_xc";
            this.label_xc.Size = new System.Drawing.Size(122, 29);
            this.label_xc.TabIndex = 1;
            this.label_xc.Text = "Xin chào,";
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.BackColor = System.Drawing.Color.Transparent;
            this.label_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hello.ForeColor = System.Drawing.Color.Maroon;
            this.label_hello.Location = new System.Drawing.Point(835, 49);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(0, 29);
            this.label_hello.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trang chủ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label_xc);
            this.panel1.Controls.Add(this.label_hello);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(237, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 100);
            this.panel1.TabIndex = 12;
            // 
            // mainpanel
            // 
            this.mainpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainpanel.BackgroundImage")));
            this.mainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(237, 100);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1260, 723);
            this.mainpanel.TabIndex = 13;
            //this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1497, 823);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "TrangChu";
            this.Text = " ";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button trasua;
        private System.Windows.Forms.Button doanvat;
        private System.Windows.Forms.Button hoadon;
        private System.Windows.Forms.Button thongtinnhanvien;
        private System.Windows.Forms.Button thongke;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label_xc;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainpanel;
    }
}

