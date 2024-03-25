
namespace LTUD
{
    partial class TraSua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraSua));
            this.dataGVTS = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sizeTS = new System.Windows.Forms.ComboBox();
            this.tpTS = new System.Windows.Forms.TextBox();
            this.tenTS = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.huyTS = new System.Windows.Forms.Button();
            this.timTS = new System.Windows.Forms.Button();
            this.searchTS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maTS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hinhTS = new System.Windows.Forms.PictureBox();
            this.loadhinh = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhTS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVTS
            // 
            this.dataGVTS.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGVTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVTS.Location = new System.Drawing.Point(16, 341);
            this.dataGVTS.Name = "dataGVTS";
            this.dataGVTS.RowHeadersWidth = 62;
            this.dataGVTS.RowTemplate.Height = 28;
            this.dataGVTS.Size = new System.Drawing.Size(1566, 291);
            this.dataGVTS.TabIndex = 18;
            this.dataGVTS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTTraSua_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(12, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Danh sách trà sữa";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.sizeTS);
            this.groupBox1.Controls.Add(this.tpTS);
            this.groupBox1.Controls.Add(this.tenTS);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.maTS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(439, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1129, 239);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // sizeTS
            // 
            this.sizeTS.FormattingEnabled = true;
            this.sizeTS.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.sizeTS.Location = new System.Drawing.Point(202, 130);
            this.sizeTS.Name = "sizeTS";
            this.sizeTS.Size = new System.Drawing.Size(224, 33);
            this.sizeTS.TabIndex = 89;
            // 
            // tpTS
            // 
            this.tpTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpTS.ForeColor = System.Drawing.Color.Maroon;
            this.tpTS.Location = new System.Drawing.Point(202, 183);
            this.tpTS.Name = "tpTS";
            this.tpTS.Size = new System.Drawing.Size(224, 30);
            this.tpTS.TabIndex = 88;
            // 
            // tenTS
            // 
            this.tenTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenTS.ForeColor = System.Drawing.Color.Maroon;
            this.tenTS.Location = new System.Drawing.Point(202, 81);
            this.tenTS.Name = "tenTS";
            this.tenTS.Size = new System.Drawing.Size(224, 30);
            this.tenTS.TabIndex = 87;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.huyTS);
            this.groupBox2.Controls.Add(this.timTS);
            this.groupBox2.Controls.Add(this.searchTS);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(614, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 220);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // huyTS
            // 
            this.huyTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.huyTS.ForeColor = System.Drawing.Color.White;
            this.huyTS.Location = new System.Drawing.Point(348, 124);
            this.huyTS.Name = "huyTS";
            this.huyTS.Size = new System.Drawing.Size(105, 44);
            this.huyTS.TabIndex = 31;
            this.huyTS.Text = "Hủy";
            this.huyTS.UseVisualStyleBackColor = false;
            this.huyTS.Click += new System.EventHandler(this.huyTS_Click);
            // 
            // timTS
            // 
            this.timTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timTS.ForeColor = System.Drawing.Color.White;
            this.timTS.Location = new System.Drawing.Point(160, 124);
            this.timTS.Name = "timTS";
            this.timTS.Size = new System.Drawing.Size(111, 44);
            this.timTS.TabIndex = 32;
            this.timTS.Text = "Tìm";
            this.timTS.UseVisualStyleBackColor = false;
            this.timTS.Click += new System.EventHandler(this.timTS_Click);
            // 
            // searchTS
            // 
            this.searchTS.Location = new System.Drawing.Point(220, 60);
            this.searchTS.Name = "searchTS";
            this.searchTS.Size = new System.Drawing.Size(224, 30);
            this.searchTS.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(45, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "Tìm tên trà sữa";
            // 
            // maTS
            // 
            this.maTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maTS.ForeColor = System.Drawing.Color.Maroon;
            this.maTS.Location = new System.Drawing.Point(202, 27);
            this.maTS.Name = "maTS";
            this.maTS.Size = new System.Drawing.Size(224, 30);
            this.maTS.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(18, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 75;
            this.label7.Text = "Topping";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(18, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 25);
            this.label8.TabIndex = 74;
            this.label8.Text = "Size";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(18, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 73;
            this.label9.Text = "Tên trà sữa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(18, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 72;
            this.label10.Text = "Mã trà sữa";
            // 
            // hinhTS
            // 
            this.hinhTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hinhTS.Location = new System.Drawing.Point(69, -2);
            this.hinhTS.Name = "hinhTS";
            this.hinhTS.Size = new System.Drawing.Size(278, 227);
            this.hinhTS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhTS.TabIndex = 30;
            this.hinhTS.TabStop = false;
            // 
            // loadhinh
            // 
            this.loadhinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadhinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadhinh.ForeColor = System.Drawing.Color.White;
            this.loadhinh.Location = new System.Drawing.Point(146, 255);
            this.loadhinh.Name = "loadhinh";
            this.loadhinh.Size = new System.Drawing.Size(120, 55);
            this.loadhinh.TabIndex = 31;
            this.loadhinh.Text = "Load";
            this.loadhinh.UseVisualStyleBackColor = false;
            this.loadhinh.Click += new System.EventHandler(this.loadhinh_Click);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(12, 231);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(0, 20);
            this.link.TabIndex = 32;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(1247, 658);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(111, 58);
            this.btn_thoat.TabIndex = 58;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click_1);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.Location = new System.Drawing.Point(979, 658);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(111, 58);
            this.btn_luu.TabIndex = 57;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(764, 658);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(111, 58);
            this.btn_xoa.TabIndex = 56;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(530, 658);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(111, 58);
            this.btn_sua.TabIndex = 55;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(283, 658);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(111, 58);
            this.btn_them.TabIndex = 54;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // TraSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1678, 743);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.link);
            this.Controls.Add(this.loadhinh);
            this.Controls.Add(this.hinhTS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGVTS);
            this.Name = "TraSua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraSua";
            this.Load += new System.EventHandler(this.TraSua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGVTS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maTS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox hinhTS;
        private System.Windows.Forms.Button timTS;
        private System.Windows.Forms.TextBox searchTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button huyTS;
        private System.Windows.Forms.TextBox tenTS;
        private System.Windows.Forms.TextBox tpTS;
        private System.Windows.Forms.Button loadhinh;
        private System.Windows.Forms.ComboBox sizeTS;
        private System.Windows.Forms.Label link;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
    }
}