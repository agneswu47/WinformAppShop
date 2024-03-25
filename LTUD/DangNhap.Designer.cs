
namespace LTUD
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.hienpass = new System.Windows.Forms.GroupBox();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.passdn = new System.Windows.Forms.TextBox();
            this.manv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dn = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.hienpass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(805, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // hienpass
            // 
            this.hienpass.BackColor = System.Drawing.Color.Maroon;
            this.hienpass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hienpass.BackgroundImage")));
            this.hienpass.Controls.Add(this.showpass);
            this.hienpass.Controls.Add(this.passdn);
            this.hienpass.Controls.Add(this.manv);
            this.hienpass.Controls.Add(this.label3);
            this.hienpass.Controls.Add(this.label2);
            this.hienpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hienpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hienpass.Location = new System.Drawing.Point(503, 271);
            this.hienpass.Name = "hienpass";
            this.hienpass.Size = new System.Drawing.Size(956, 249);
            this.hienpass.TabIndex = 1;
            this.hienpass.TabStop = false;
            this.hienpass.Text = "Thông tin đăng nhập";
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.ForeColor = System.Drawing.Color.White;
            this.showpass.Location = new System.Drawing.Point(757, 136);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(100, 36);
            this.showpass.TabIndex = 4;
            this.showpass.Text = "Hiện";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // passdn
            // 
            this.passdn.Location = new System.Drawing.Point(442, 133);
            this.passdn.Name = "passdn";
            this.passdn.Size = new System.Drawing.Size(275, 39);
            this.passdn.TabIndex = 3;
            this.passdn.UseSystemPasswordChar = true;
            this.passdn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passdn_KeyDown);
            // 
            // manv
            // 
            this.manv.Location = new System.Drawing.Point(442, 69);
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(280, 39);
            this.manv.TabIndex = 2;
            this.manv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manv_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(89, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(89, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mã nhân viên";
            // 
            // dn
            // 
            this.dn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn.ForeColor = System.Drawing.Color.White;
            this.dn.Location = new System.Drawing.Point(653, 588);
            this.dn.Name = "dn";
            this.dn.Size = new System.Drawing.Size(225, 93);
            this.dn.TabIndex = 2;
            this.dn.Text = "Đăng nhập";
            this.dn.UseVisualStyleBackColor = false;
            this.dn.Click += new System.EventHandler(this.dn_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.ForeColor = System.Drawing.Color.White;
            this.thoat.Location = new System.Drawing.Point(1006, 589);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(219, 92);
            this.thoat.TabIndex = 3;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1682, 731);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.dn);
            this.Controls.Add(this.hienpass);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.hienpass.ResumeLayout(false);
            this.hienpass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox hienpass;
        private System.Windows.Forms.TextBox passdn;
        private System.Windows.Forms.TextBox manv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dn;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.CheckBox showpass;
    }
}