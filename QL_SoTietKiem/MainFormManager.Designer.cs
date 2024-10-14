namespace WindowsFormsApp1
{
    partial class MainFormManager
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
        /*private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "MainFormManager";
        }

        #endregion*/
        private void InitializeComponent()
        {
            this.panelBar = new System.Windows.Forms.Panel();
            this.pnChinhSach = new System.Windows.Forms.Panel();
            this.btCSNH = new System.Windows.Forms.Button();
            this.btCSLX = new System.Windows.Forms.Button();
            this.iconChinhSach = new FontAwesome.Sharp.IconButton();
            this.panelBCTK = new System.Windows.Forms.Panel();
            this.btnLuongGiaoDich = new System.Windows.Forms.Button();
            this.btnTopKhachHang = new System.Windows.Forms.Button();
            this.btnSoTienGiaoDich = new System.Windows.Forms.Button();
            this.iconBCTK = new FontAwesome.Sharp.IconButton();
            this.panelNhanVien = new System.Windows.Forms.Panel();
            this.btnQuanLyNV = new System.Windows.Forms.Button();
            this.iconNhanVien = new FontAwesome.Sharp.IconButton();
            this.panelThongTinSo = new System.Windows.Forms.Panel();
            this.btnThongTinSo = new System.Windows.Forms.Button();
            this.iconThongTinSo = new FontAwesome.Sharp.IconButton();
            this.panelThongTinKhachHang = new System.Windows.Forms.Panel();
            this.btnThongTinChung = new System.Windows.Forms.Button();
            this.iconKhachHang = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.labelChildForm = new System.Windows.Forms.Label();
            this.iconChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelBar.SuspendLayout();
            this.pnChinhSach.SuspendLayout();
            this.panelBCTK.SuspendLayout();
            this.panelNhanVien.SuspendLayout();
            this.panelThongTinSo.SuspendLayout();
            this.panelThongTinKhachHang.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.AutoScroll = true;
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(88)))));
            this.panelBar.Controls.Add(this.pnChinhSach);
            this.panelBar.Controls.Add(this.iconChinhSach);
            this.panelBar.Controls.Add(this.panelBCTK);
            this.panelBar.Controls.Add(this.iconBCTK);
            this.panelBar.Controls.Add(this.panelNhanVien);
            this.panelBar.Controls.Add(this.iconNhanVien);
            this.panelBar.Controls.Add(this.panelThongTinSo);
            this.panelBar.Controls.Add(this.iconThongTinSo);
            this.panelBar.Controls.Add(this.panelThongTinKhachHang);
            this.panelBar.Controls.Add(this.iconKhachHang);
            this.panelBar.Controls.Add(this.panel2);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(212, 853);
            this.panelBar.TabIndex = 0;
            // 
            // pnChinhSach
            // 
            this.pnChinhSach.Controls.Add(this.btCSNH);
            this.pnChinhSach.Controls.Add(this.btCSLX);
            this.pnChinhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnChinhSach.Location = new System.Drawing.Point(0, 684);
            this.pnChinhSach.Name = "pnChinhSach";
            this.pnChinhSach.Size = new System.Drawing.Size(212, 91);
            this.pnChinhSach.TabIndex = 7;
            // 
            // btCSNH
            // 
            this.btCSNH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(110)))), ((int)(((byte)(95)))));
            this.btCSNH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCSNH.FlatAppearance.BorderSize = 0;
            this.btCSNH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCSNH.Location = new System.Drawing.Point(0, 38);
            this.btCSNH.Name = "btCSNH";
            this.btCSNH.Size = new System.Drawing.Size(212, 38);
            this.btCSNH.TabIndex = 7;
            this.btCSNH.Text = "Chính sách ngân hàng";
            this.btCSNH.UseVisualStyleBackColor = false;
            this.btCSNH.Click += new System.EventHandler(this.btCSNH_Click);
            // 
            // btCSLX
            // 
            this.btCSLX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(110)))), ((int)(((byte)(95)))));
            this.btCSLX.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCSLX.FlatAppearance.BorderSize = 0;
            this.btCSLX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCSLX.Location = new System.Drawing.Point(0, 0);
            this.btCSLX.Name = "btCSLX";
            this.btCSLX.Size = new System.Drawing.Size(212, 38);
            this.btCSLX.TabIndex = 8;
            this.btCSLX.Text = "Chính sách lãi suất";
            this.btCSLX.UseVisualStyleBackColor = false;
            this.btCSLX.Click += new System.EventHandler(this.btCSLX_Click);
            // 
            // iconChinhSach
            // 
            this.iconChinhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconChinhSach.FlatAppearance.BorderSize = 0;
            this.iconChinhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconChinhSach.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconChinhSach.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.iconChinhSach.IconColor = System.Drawing.Color.White;
            this.iconChinhSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChinhSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconChinhSach.Location = new System.Drawing.Point(0, 620);
            this.iconChinhSach.Name = "iconChinhSach";
            this.iconChinhSach.Size = new System.Drawing.Size(212, 64);
            this.iconChinhSach.TabIndex = 0;
            this.iconChinhSach.Text = "Chính  sách ";
            this.iconChinhSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconChinhSach.UseVisualStyleBackColor = true;
            this.iconChinhSach.Click += new System.EventHandler(this.iconChinhSach_Click);
            // 
            // panelBCTK
            // 
            this.panelBCTK.Controls.Add(this.btnLuongGiaoDich);
            this.panelBCTK.Controls.Add(this.btnTopKhachHang);
            this.panelBCTK.Controls.Add(this.btnSoTienGiaoDich);
            this.panelBCTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBCTK.Location = new System.Drawing.Point(0, 492);
            this.panelBCTK.Name = "panelBCTK";
            this.panelBCTK.Size = new System.Drawing.Size(212, 128);
            this.panelBCTK.TabIndex = 0;
            // 
            // btnLuongGiaoDich
            // 
            this.btnLuongGiaoDich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(110)))), ((int)(((byte)(95)))));
            this.btnLuongGiaoDich.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLuongGiaoDich.FlatAppearance.BorderSize = 0;
            this.btnLuongGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuongGiaoDich.Location = new System.Drawing.Point(0, 76);
            this.btnLuongGiaoDich.Name = "btnLuongGiaoDich";
            this.btnLuongGiaoDich.Size = new System.Drawing.Size(212, 38);
            this.btnLuongGiaoDich.TabIndex = 6;
            this.btnLuongGiaoDich.Text = "Lượng giao dịch";
            this.btnLuongGiaoDich.UseVisualStyleBackColor = false;
            this.btnLuongGiaoDich.Click += new System.EventHandler(this.btnLuongGiaoDich_Click);
            // 
            // btnTopKhachHang
            // 
            this.btnTopKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(110)))), ((int)(((byte)(95)))));
            this.btnTopKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTopKhachHang.FlatAppearance.BorderSize = 0;
            this.btnTopKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopKhachHang.Location = new System.Drawing.Point(0, 38);
            this.btnTopKhachHang.Name = "btnTopKhachHang";
            this.btnTopKhachHang.Size = new System.Drawing.Size(212, 38);
            this.btnTopKhachHang.TabIndex = 4;
            this.btnTopKhachHang.Text = "Top khách hàng";
            this.btnTopKhachHang.UseVisualStyleBackColor = false;
            this.btnTopKhachHang.Click += new System.EventHandler(this.btnTopKhachHang_Click);
            // 
            // btnSoTienGiaoDich
            // 
            this.btnSoTienGiaoDich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(110)))), ((int)(((byte)(95)))));
            this.btnSoTienGiaoDich.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoTienGiaoDich.FlatAppearance.BorderSize = 0;
            this.btnSoTienGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoTienGiaoDich.Location = new System.Drawing.Point(0, 0);
            this.btnSoTienGiaoDich.Name = "btnSoTienGiaoDich";
            this.btnSoTienGiaoDich.Size = new System.Drawing.Size(212, 38);
            this.btnSoTienGiaoDich.TabIndex = 5;
            this.btnSoTienGiaoDich.Text = "Số tiền giao dịch";
            this.btnSoTienGiaoDich.UseVisualStyleBackColor = false;
            this.btnSoTienGiaoDich.Click += new System.EventHandler(this.btnSoTienGiaoDich_Click);
            // 
            // iconBCTK
            // 
            this.iconBCTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBCTK.FlatAppearance.BorderSize = 0;
            this.iconBCTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBCTK.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBCTK.ForeColor = System.Drawing.Color.White;
            this.iconBCTK.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconBCTK.IconColor = System.Drawing.Color.White;
            this.iconBCTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBCTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBCTK.Location = new System.Drawing.Point(0, 432);
            this.iconBCTK.Name = "iconBCTK";
            this.iconBCTK.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.iconBCTK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconBCTK.Size = new System.Drawing.Size(212, 60);
            this.iconBCTK.TabIndex = 4;
            this.iconBCTK.Text = "Báo cáo-Thống kê";
            this.iconBCTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBCTK.UseVisualStyleBackColor = true;
            this.iconBCTK.Click += new System.EventHandler(this.iconBCTK_Click);
            // 
            // panelNhanVien
            // 
            this.panelNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(110)))), ((int)(((byte)(95)))));
            this.panelNhanVien.Controls.Add(this.btnQuanLyNV);
            this.panelNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNhanVien.Location = new System.Drawing.Point(0, 392);
            this.panelNhanVien.Name = "panelNhanVien";
            this.panelNhanVien.Size = new System.Drawing.Size(212, 40);
            this.panelNhanVien.TabIndex = 6;
            // 
            // btnQuanLyNV
            // 
            this.btnQuanLyNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyNV.FlatAppearance.BorderSize = 0;
            this.btnQuanLyNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNV.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLyNV.Name = "btnQuanLyNV";
            this.btnQuanLyNV.Size = new System.Drawing.Size(212, 30);
            this.btnQuanLyNV.TabIndex = 0;
            this.btnQuanLyNV.Text = "Thông tin nhân viên";
            this.btnQuanLyNV.UseVisualStyleBackColor = true;
            this.btnQuanLyNV.Click += new System.EventHandler(this.btnQuanLyNV_Click);
            // 
            // iconNhanVien
            // 
            this.iconNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconNhanVien.FlatAppearance.BorderSize = 0;
            this.iconNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconNhanVien.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconNhanVien.ForeColor = System.Drawing.Color.White;
            this.iconNhanVien.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.iconNhanVien.IconColor = System.Drawing.Color.White;
            this.iconNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconNhanVien.Location = new System.Drawing.Point(0, 332);
            this.iconNhanVien.Name = "iconNhanVien";
            this.iconNhanVien.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.iconNhanVien.Size = new System.Drawing.Size(212, 60);
            this.iconNhanVien.TabIndex = 6;
            this.iconNhanVien.Text = "Nhân viên";
            this.iconNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconNhanVien.UseVisualStyleBackColor = true;
            this.iconNhanVien.Click += new System.EventHandler(this.iconNhanVien_Click);
            // 
            // panelThongTinSo
            // 
            this.panelThongTinSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(110)))), ((int)(((byte)(95)))));
            this.panelThongTinSo.Controls.Add(this.btnThongTinSo);
            this.panelThongTinSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTinSo.Location = new System.Drawing.Point(0, 291);
            this.panelThongTinSo.Name = "panelThongTinSo";
            this.panelThongTinSo.Size = new System.Drawing.Size(212, 41);
            this.panelThongTinSo.TabIndex = 3;
            // 
            // btnThongTinSo
            // 
            this.btnThongTinSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongTinSo.FlatAppearance.BorderSize = 0;
            this.btnThongTinSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinSo.Location = new System.Drawing.Point(0, 0);
            this.btnThongTinSo.Name = "btnThongTinSo";
            this.btnThongTinSo.Size = new System.Drawing.Size(212, 35);
            this.btnThongTinSo.TabIndex = 0;
            this.btnThongTinSo.Text = "Thông tin sổ";
            this.btnThongTinSo.UseVisualStyleBackColor = true;
            this.btnThongTinSo.Click += new System.EventHandler(this.btnThongTinSo_Click);
            // 
            // iconThongTinSo
            // 
            this.iconThongTinSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconThongTinSo.FlatAppearance.BorderSize = 0;
            this.iconThongTinSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconThongTinSo.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconThongTinSo.ForeColor = System.Drawing.Color.White;
            this.iconThongTinSo.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconThongTinSo.IconColor = System.Drawing.Color.White;
            this.iconThongTinSo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconThongTinSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconThongTinSo.Location = new System.Drawing.Point(0, 231);
            this.iconThongTinSo.Name = "iconThongTinSo";
            this.iconThongTinSo.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.iconThongTinSo.Size = new System.Drawing.Size(212, 60);
            this.iconThongTinSo.TabIndex = 2;
            this.iconThongTinSo.Text = "Sổ tiết kiệm";
            this.iconThongTinSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconThongTinSo.UseVisualStyleBackColor = true;
            this.iconThongTinSo.Click += new System.EventHandler(this.iconThongTinSo_Click);
            // 
            // panelThongTinKhachHang
            // 
            this.panelThongTinKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(110)))), ((int)(((byte)(95)))));
            this.panelThongTinKhachHang.Controls.Add(this.btnThongTinChung);
            this.panelThongTinKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTinKhachHang.Location = new System.Drawing.Point(0, 185);
            this.panelThongTinKhachHang.Name = "panelThongTinKhachHang";
            this.panelThongTinKhachHang.Size = new System.Drawing.Size(212, 46);
            this.panelThongTinKhachHang.TabIndex = 2;
            // 
            // btnThongTinChung
            // 
            this.btnThongTinChung.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongTinChung.FlatAppearance.BorderSize = 0;
            this.btnThongTinChung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinChung.Location = new System.Drawing.Point(0, 0);
            this.btnThongTinChung.Name = "btnThongTinChung";
            this.btnThongTinChung.Size = new System.Drawing.Size(212, 40);
            this.btnThongTinChung.TabIndex = 0;
            this.btnThongTinChung.Text = "Thông tin khách hàng";
            this.btnThongTinChung.UseVisualStyleBackColor = true;
            this.btnThongTinChung.Click += new System.EventHandler(this.btnThongTinChung_Click);
            // 
            // iconKhachHang
            // 
            this.iconKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconKhachHang.FlatAppearance.BorderSize = 0;
            this.iconKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconKhachHang.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconKhachHang.ForeColor = System.Drawing.Color.White;
            this.iconKhachHang.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconKhachHang.IconColor = System.Drawing.Color.White;
            this.iconKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconKhachHang.Location = new System.Drawing.Point(0, 125);
            this.iconKhachHang.Name = "iconKhachHang";
            this.iconKhachHang.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.iconKhachHang.Size = new System.Drawing.Size(212, 60);
            this.iconKhachHang.TabIndex = 1;
            this.iconKhachHang.Text = "Khách hàng ";
            this.iconKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconKhachHang.UseVisualStyleBackColor = true;
            this.iconKhachHang.Click += new System.EventHandler(this.iconKhachHang_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 125);
            this.panel2.TabIndex = 0;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureLogo.Image = global::WindowsFormsApp1.Properties.Resources._7e0c8d2e412f4676b52e692542423cd8;
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(212, 120);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(88)))));
            this.panelTitleBar.Controls.Add(this.iconUser);
            this.panelTitleBar.Controls.Add(this.labelChildForm);
            this.panelTitleBar.Controls.Add(this.iconChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(212, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(927, 74);
            this.panelTitleBar.TabIndex = 1;
            // 
            // iconUser
            // 
            this.iconUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(88)))));
            this.iconUser.ForeColor = System.Drawing.Color.Yellow;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconUser.IconColor = System.Drawing.Color.Yellow;
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 41;
            this.iconUser.Location = new System.Drawing.Point(863, 12);
            this.iconUser.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(41, 47);
            this.iconUser.TabIndex = 2;
            this.iconUser.TabStop = false;
            this.iconUser.Click += new System.EventHandler(this.iconUser_Click);
            // 
            // labelChildForm
            // 
            this.labelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelChildForm.AutoSize = true;
            this.labelChildForm.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChildForm.Location = new System.Drawing.Point(53, 22);
            this.labelChildForm.Name = "labelChildForm";
            this.labelChildForm.Size = new System.Drawing.Size(61, 21);
            this.labelChildForm.TabIndex = 1;
            this.labelChildForm.Text = "Home";
            // 
            // iconChildForm
            // 
            this.iconChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.iconChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(88)))));
            this.iconChildForm.ForeColor = System.Drawing.Color.Yellow;
            this.iconChildForm.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            this.iconChildForm.IconColor = System.Drawing.Color.Yellow;
            this.iconChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChildForm.IconSize = 41;
            this.iconChildForm.Location = new System.Drawing.Point(6, 12);
            this.iconChildForm.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.iconChildForm.Name = "iconChildForm";
            this.iconChildForm.Size = new System.Drawing.Size(41, 47);
            this.iconChildForm.TabIndex = 0;
            this.iconChildForm.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(88)))));
            this.panelChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelChildForm.ForeColor = System.Drawing.Color.Black;
            this.panelChildForm.Location = new System.Drawing.Point(212, 71);
            this.panelChildForm.MinimumSize = new System.Drawing.Size(875, 500);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(935, 777);
            this.panelChildForm.TabIndex = 2;
            // 
            // MainFormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 853);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelBar);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(1157, 900);
            this.Name = "MainFormManager";
            this.Text = "Form1";
            this.panelBar.ResumeLayout(false);
            this.pnChinhSach.ResumeLayout(false);
            this.panelBCTK.ResumeLayout(false);
            this.panelNhanVien.ResumeLayout(false);
            this.panelThongTinSo.ResumeLayout(false);
            this.panelThongTinKhachHang.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconKhachHang;
        private FontAwesome.Sharp.IconButton iconBCTK;
        private FontAwesome.Sharp.IconButton iconThongTinSo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnThongTinChung;
        private System.Windows.Forms.Panel panelThongTinSo;
        private System.Windows.Forms.Button btnThongTinSo;
        private System.Windows.Forms.Button btnQuanLyNV;
        private FontAwesome.Sharp.IconButton iconNhanVien;
        private System.Windows.Forms.Panel panelNhanVien;
        private System.Windows.Forms.Panel panelThongTinKhachHang;
        private System.Windows.Forms.Panel panelBCTK;
        private System.Windows.Forms.Button btnSoTienGiaoDich;
        private System.Windows.Forms.Button btnTopKhachHang;
        private System.Windows.Forms.Button btnLuongGiaoDich;
        private FontAwesome.Sharp.IconButton iconChinhSach;
        private System.Windows.Forms.Button btCSNH;
        private System.Windows.Forms.Button btCSLX;
        private System.Windows.Forms.Panel pnChinhSach;
        private System.Windows.Forms.Label labelChildForm;
        private FontAwesome.Sharp.IconPictureBox iconChildForm;
        private FontAwesome.Sharp.IconPictureBox iconUser;
    }
}