namespace GymGenZ.PViews
{
    partial class F_SalesManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSpKhac = new System.Windows.Forms.Button();
            this.btnNuocGiaKhat = new System.Windows.Forms.Button();
            this.btnNuocDetox = new System.Windows.Forms.Button();
            this.btnWheyProtein = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnDanhSach = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnDanhSachDaChon = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgvChooseProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnDanhSachDaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChooseProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSpKhac);
            this.panel1.Controls.Add(this.btnNuocGiaKhat);
            this.panel1.Controls.Add(this.btnNuocDetox);
            this.panel1.Controls.Add(this.btnWheyProtein);
            this.panel1.Controls.Add(this.btnTatCa);
            this.panel1.Location = new System.Drawing.Point(-6, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1552, 44);
            this.panel1.TabIndex = 1;
            // 
            // btnSpKhac
            // 
            this.btnSpKhac.Location = new System.Drawing.Point(687, 4);
            this.btnSpKhac.Name = "btnSpKhac";
            this.btnSpKhac.Size = new System.Drawing.Size(105, 33);
            this.btnSpKhac.TabIndex = 5;
            this.btnSpKhac.Text = "Khác";
            this.btnSpKhac.UseVisualStyleBackColor = true;
            this.btnSpKhac.Click += new System.EventHandler(this.btnSpKhac_Click);
            // 
            // btnNuocGiaKhat
            // 
            this.btnNuocGiaKhat.Location = new System.Drawing.Point(500, 4);
            this.btnNuocGiaKhat.Name = "btnNuocGiaKhat";
            this.btnNuocGiaKhat.Size = new System.Drawing.Size(181, 33);
            this.btnNuocGiaKhat.TabIndex = 4;
            this.btnNuocGiaKhat.Text = "Sữa tăng cân";
            this.btnNuocGiaKhat.UseVisualStyleBackColor = true;
            this.btnNuocGiaKhat.Click += new System.EventHandler(this.btnNuocGiaKhat_Click);
            // 
            // btnNuocDetox
            // 
            this.btnNuocDetox.Location = new System.Drawing.Point(345, 4);
            this.btnNuocDetox.Name = "btnNuocDetox";
            this.btnNuocDetox.Size = new System.Drawing.Size(149, 33);
            this.btnNuocDetox.TabIndex = 3;
            this.btnNuocDetox.Text = "Vitamin các loại";
            this.btnNuocDetox.UseVisualStyleBackColor = true;
            this.btnNuocDetox.Click += new System.EventHandler(this.btnNuocDetox_Click);
            // 
            // btnWheyProtein
            // 
            this.btnWheyProtein.Location = new System.Drawing.Point(164, 4);
            this.btnWheyProtein.Name = "btnWheyProtein";
            this.btnWheyProtein.Size = new System.Drawing.Size(175, 33);
            this.btnWheyProtein.TabIndex = 2;
            this.btnWheyProtein.Text = "Whey protein";
            this.btnWheyProtein.UseVisualStyleBackColor = true;
            this.btnWheyProtein.Click += new System.EventHandler(this.btnWheyProtein_Click);
            // 
            // btnTatCa
            // 
            this.btnTatCa.Location = new System.Drawing.Point(9, 4);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(149, 33);
            this.btnTatCa.TabIndex = 1;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // tbFind
            // 
            this.tbFind.BackColor = System.Drawing.Color.White;
            this.tbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbFind.Location = new System.Drawing.Point(1044, 64);
            this.tbFind.Margin = new System.Windows.Forms.Padding(4);
            this.tbFind.Multiline = true;
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(343, 35);
            this.tbFind.TabIndex = 7;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 535);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnDanhSach);
            this.panel2.Location = new System.Drawing.Point(21, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 481);
            this.panel2.TabIndex = 3;
            // 
            // pnDanhSach
            // 
            this.pnDanhSach.AutoScroll = true;
            this.pnDanhSach.Location = new System.Drawing.Point(3, 4);
            this.pnDanhSach.Name = "pnDanhSach";
            this.pnDanhSach.Size = new System.Drawing.Size(660, 474);
            this.pnDanhSach.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPay);
            this.groupBox3.Controls.Add(this.tbTotal);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbSL);
            this.groupBox3.Controls.Add(this.btnGiam);
            this.groupBox3.Controls.Add(this.btnTang);
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(798, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(698, 535);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm đã chọn";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(432, 457);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 43);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnDanhSachDaChon);
            this.panel7.Location = new System.Drawing.Point(15, 34);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(670, 383);
            this.panel7.TabIndex = 6;
            // 
            // pnDanhSachDaChon
            // 
            this.pnDanhSachDaChon.Controls.Add(this.dtgvChooseProduct);
            this.pnDanhSachDaChon.Location = new System.Drawing.Point(18, 15);
            this.pnDanhSachDaChon.Name = "pnDanhSachDaChon";
            this.pnDanhSachDaChon.Size = new System.Drawing.Size(635, 349);
            this.pnDanhSachDaChon.TabIndex = 5;
            // 
            // dtgvChooseProduct
            // 
            this.dtgvChooseProduct.BackgroundColor = System.Drawing.Color.White;
            this.dtgvChooseProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChooseProduct.Location = new System.Drawing.Point(3, 3);
            this.dtgvChooseProduct.Name = "dtgvChooseProduct";
            this.dtgvChooseProduct.RowHeadersWidth = 51;
            this.dtgvChooseProduct.RowTemplate.Height = 24;
            this.dtgvChooseProduct.Size = new System.Drawing.Size(629, 332);
            this.dtgvChooseProduct.TabIndex = 5;
            this.dtgvChooseProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChooseProduct_CellClick);
            this.dtgvChooseProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChooseProduct_CellContentClick);
            this.dtgvChooseProduct.SelectionChanged += new System.EventHandler(this.dtgvChooseProduct_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(19)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(50, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 42);
            this.label1.TabIndex = 35;
            this.label1.Text = "Quản lý Bán hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(309, 457);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(107, 43);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "F5";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(19)))), ((int)(((byte)(99)))));
            this.pictureBox1.Image = global::GymGenZ.Properties.Resources.Vector;
            this.pictureBox1.Location = new System.Drawing.Point(1411, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(39, 457);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(101, 23);
            this.btnTang.TabIndex = 10;
            this.btnTang.Text = "Tăng";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Location = new System.Drawing.Point(146, 457);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(101, 23);
            this.btnGiam.TabIndex = 11;
            this.btnGiam.Text = "Giảm";
            this.btnGiam.UseVisualStyleBackColor = true;
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(143, 427);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(104, 22);
            this.tbSL.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số Lượng";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(515, 424);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(170, 22);
            this.tbTotal.TabIndex = 14;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(564, 457);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(121, 43);
            this.btnPay.TabIndex = 15;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // F_SalesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 687);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_SalesManager";
            this.Text = "F_SalesManager";
            this.Load += new System.EventHandler(this.F_SalesManager_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.pnDanhSachDaChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChooseProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btnSpKhac;
        private System.Windows.Forms.Button btnNuocGiaKhat;
        private System.Windows.Forms.Button btnNuocDetox;
        private System.Windows.Forms.Button btnWheyProtein;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel pnDanhSach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnDanhSachDaChon;
        private System.Windows.Forms.DataGridView dtgvChooseProduct;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnPay;
    }
}