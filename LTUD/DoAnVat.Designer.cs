
namespace LTUD
{
    partial class DoAnVat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoAnVat));
            this.hinhDAV = new System.Windows.Forms.PictureBox();
            this.huyDAV = new System.Windows.Forms.Button();
            this.timDAV = new System.Windows.Forms.Button();
            this.searchDAV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpDAV = new System.Windows.Forms.TextBox();
            this.tenDAV = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sizeDAV = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maDAV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGVDAV = new System.Windows.Forms.DataGridView();
            this.loadhinh = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hinhDAV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDAV)).BeginInit();
            this.SuspendLayout();
            // 
            // hinhDAV
            // 
            this.hinhDAV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hinhDAV.Location = new System.Drawing.Point(91, 3);
            this.hinhDAV.Name = "hinhDAV";
            this.hinhDAV.Size = new System.Drawing.Size(241, 227);
            this.hinhDAV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhDAV.TabIndex = 40;
            this.hinhDAV.TabStop = false;
            // 
            // huyDAV
            // 
            this.huyDAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.huyDAV.ForeColor = System.Drawing.Color.White;
            this.huyDAV.Location = new System.Drawing.Point(406, 125);
            this.huyDAV.Name = "huyDAV";
            this.huyDAV.Size = new System.Drawing.Size(105, 44);
            this.huyDAV.TabIndex = 31;
            this.huyDAV.Text = "Hủy";
            this.huyDAV.UseVisualStyleBackColor = false;
            this.huyDAV.Click += new System.EventHandler(this.huyDAV_Click);
            // 
            // timDAV
            // 
            this.timDAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timDAV.ForeColor = System.Drawing.Color.White;
            this.timDAV.Location = new System.Drawing.Point(183, 125);
            this.timDAV.Name = "timDAV";
            this.timDAV.Size = new System.Drawing.Size(111, 44);
            this.timDAV.TabIndex = 32;
            this.timDAV.Text = "Tìm";
            this.timDAV.UseVisualStyleBackColor = false;
            // 
            // searchDAV
            // 
            this.searchDAV.Location = new System.Drawing.Point(243, 61);
            this.searchDAV.Name = "searchDAV";
            this.searchDAV.Size = new System.Drawing.Size(224, 30);
            this.searchDAV.TabIndex = 87;
            this.searchDAV.TextChanged += new System.EventHandler(this.searchDAV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(58, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 87;
            this.label2.Text = "Tìm tên đồ ăn vặt";
            // 
            // tpDAV
            // 
            this.tpDAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDAV.ForeColor = System.Drawing.Color.Maroon;
            this.tpDAV.Location = new System.Drawing.Point(234, 188);
            this.tpDAV.Name = "tpDAV";
            this.tpDAV.Size = new System.Drawing.Size(224, 30);
            this.tpDAV.TabIndex = 88;
            // 
            // tenDAV
            // 
            this.tenDAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenDAV.ForeColor = System.Drawing.Color.Maroon;
            this.tenDAV.Location = new System.Drawing.Point(234, 86);
            this.tenDAV.Name = "tenDAV";
            this.tenDAV.Size = new System.Drawing.Size(224, 30);
            this.tenDAV.TabIndex = 87;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.sizeDAV);
            this.groupBox1.Controls.Add(this.tpDAV);
            this.groupBox1.Controls.Add(this.tenDAV);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.maDAV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(464, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 238);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // sizeDAV
            // 
            this.sizeDAV.FormattingEnabled = true;
            this.sizeDAV.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
            this.sizeDAV.Location = new System.Drawing.Point(234, 133);
            this.sizeDAV.Name = "sizeDAV";
            this.sizeDAV.Size = new System.Drawing.Size(224, 33);
            this.sizeDAV.TabIndex = 90;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.huyDAV);
            this.groupBox2.Controls.Add(this.timDAV);
            this.groupBox2.Controls.Add(this.searchDAV);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(551, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 238);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // maDAV
            // 
            this.maDAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maDAV.ForeColor = System.Drawing.Color.Maroon;
            this.maDAV.Location = new System.Drawing.Point(234, 32);
            this.maDAV.Name = "maDAV";
            this.maDAV.Size = new System.Drawing.Size(224, 30);
            this.maDAV.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(17, 181);
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
            this.label8.Location = new System.Drawing.Point(17, 128);
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
            this.label9.Location = new System.Drawing.Point(17, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 73;
            this.label9.Text = "Tên đồ ăn vặt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(17, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 72;
            this.label10.Text = "Mã đồ ăn vặt";
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
            this.label6.TabIndex = 37;
            this.label6.Text = "Danh sách trà sữa";
            // 
            // dataGVDAV
            // 
            this.dataGVDAV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGVDAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDAV.Location = new System.Drawing.Point(12, 341);
            this.dataGVDAV.Name = "dataGVDAV";
            this.dataGVDAV.RowHeadersWidth = 62;
            this.dataGVDAV.RowTemplate.Height = 28;
            this.dataGVDAV.Size = new System.Drawing.Size(1566, 289);
            this.dataGVDAV.TabIndex = 31;
            this.dataGVDAV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVDAV_CellContentClick);
            // 
            // loadhinh
            // 
            this.loadhinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadhinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadhinh.ForeColor = System.Drawing.Color.White;
            this.loadhinh.Location = new System.Drawing.Point(149, 255);
            this.loadhinh.Name = "loadhinh";
            this.loadhinh.Size = new System.Drawing.Size(120, 55);
            this.loadhinh.TabIndex = 41;
            this.loadhinh.Text = "Load";
            this.loadhinh.UseVisualStyleBackColor = false;
            this.loadhinh.Click += new System.EventHandler(this.loadhinh_Click);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(1, 240);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(0, 20);
            this.link.TabIndex = 47;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(1258, 661);
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
            this.btn_luu.Location = new System.Drawing.Point(989, 661);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(111, 58);
            this.btn_luu.TabIndex = 57;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(745, 661);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(111, 58);
            this.btn_xoa.TabIndex = 56;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(511, 661);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(111, 58);
            this.btn_sua.TabIndex = 55;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(264, 661);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(111, 58);
            this.btn_them.TabIndex = 54;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // DoAnVat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1678, 744);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.link);
            this.Controls.Add(this.loadhinh);
            this.Controls.Add(this.hinhDAV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGVDAV);
            this.Name = "DoAnVat";
            this.Text = "DoAnVat";
            this.Load += new System.EventHandler(this.DoAnVat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hinhDAV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDAV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hinhDAV;
        private System.Windows.Forms.Button huyDAV;
        private System.Windows.Forms.Button timDAV;
        private System.Windows.Forms.TextBox searchDAV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tpDAV;
        private System.Windows.Forms.TextBox tenDAV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox maDAV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGVDAV;
        private System.Windows.Forms.Button loadhinh;
        private System.Windows.Forms.ComboBox sizeDAV;
        private System.Windows.Forms.Label link;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
    }
}