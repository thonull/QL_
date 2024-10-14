namespace WindowsFormsApp1
{
    partial class frmLuongGiaoDich
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.rdRut = new System.Windows.Forms.RadioButton();
            this.rdGui = new System.Windows.Forms.RadioButton();
            this.txtTgBaoCao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpmonthReport = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.paneldata = new System.Windows.Forms.Panel();
            this.lbDanhSach = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.rjButton2 = new WindowsFormsApp1.RJControls.RjButton();
            this.btnReport = new WindowsFormsApp1.RJControls.RjButton();
            this.panelHeader.SuspendLayout();
            this.paneldata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.btnReport);
            this.panelHeader.Controls.Add(this.rdRut);
            this.panelHeader.Controls.Add(this.rdGui);
            this.panelHeader.Controls.Add(this.txtTgBaoCao);
            this.panelHeader.Controls.Add(this.label3);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.dtpmonthReport);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1156, 251);
            this.panelHeader.TabIndex = 0;
            // 
            // rdRut
            // 
            this.rdRut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdRut.AutoSize = true;
            this.rdRut.Location = new System.Drawing.Point(408, 186);
            this.rdRut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdRut.Name = "rdRut";
            this.rdRut.Size = new System.Drawing.Size(76, 24);
            this.rdRut.TabIndex = 11;
            this.rdRut.TabStop = true;
            this.rdRut.Text = "Rút ra";
            this.rdRut.UseVisualStyleBackColor = true;
            // 
            // rdGui
            // 
            this.rdGui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdGui.AutoSize = true;
            this.rdGui.Location = new System.Drawing.Point(186, 186);
            this.rdGui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdGui.Name = "rdGui";
            this.rdGui.Size = new System.Drawing.Size(87, 24);
            this.rdGui.TabIndex = 10;
            this.rdGui.TabStop = true;
            this.rdGui.Text = "Gửi vào";
            this.rdGui.UseVisualStyleBackColor = true;
            // 
            // txtTgBaoCao
            // 
            this.txtTgBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTgBaoCao.Location = new System.Drawing.Point(779, 106);
            this.txtTgBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTgBaoCao.Name = "txtTgBaoCao";
            this.txtTgBaoCao.ReadOnly = true;
            this.txtTgBaoCao.Size = new System.Drawing.Size(189, 26);
            this.txtTgBaoCao.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(582, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thời gian báo cáo:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(65, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tháng báo cáo:";
            // 
            // dtpmonthReport
            // 
            this.dtpmonthReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpmonthReport.CustomFormat = "MM/yyyy";
            this.dtpmonthReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpmonthReport.Location = new System.Drawing.Point(225, 106);
            this.dtpmonthReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpmonthReport.Name = "dtpmonthReport";
            this.dtpmonthReport.Size = new System.Drawing.Size(209, 26);
            this.dtpmonthReport.TabIndex = 5;
            this.dtpmonthReport.ValueChanged += new System.EventHandler(this.dtpmonthReport_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(349, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ LƯỢNG GIAO DỊCH GỬI, RÚT ";
            // 
            // paneldata
            // 
            this.paneldata.Controls.Add(this.rjButton2);
            this.paneldata.Controls.Add(this.lbDanhSach);
            this.paneldata.Controls.Add(this.dataGridView);
            this.paneldata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldata.Location = new System.Drawing.Point(0, 251);
            this.paneldata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paneldata.Name = "paneldata";
            this.paneldata.Size = new System.Drawing.Size(1156, 441);
            this.paneldata.TabIndex = 1;
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDanhSach.AutoSize = true;
            this.lbDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDanhSach.Location = new System.Drawing.Point(314, 51);
            this.lbDanhSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(0, 18);
            this.lbDanhSach.TabIndex = 13;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 120);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1152, 326);
            this.dataGridView.TabIndex = 0;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 29;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(996, 51);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(129, 36);
            this.rjButton2.TabIndex = 13;
            this.rjButton2.Text = "Xuất file ";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReport.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReport.BorderRadius = 19;
            this.btnReport.BorderSize = 0;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(830, 166);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(160, 45);
            this.btnReport.TabIndex = 12;
            this.btnReport.Text = "Thống kê";
            this.btnReport.TextColor = System.Drawing.Color.White;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmLuongGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 692);
            this.Controls.Add(this.paneldata);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLuongGiaoDich";
            this.Text = "frmLuongGiaoDich";
            this.Load += new System.EventHandler(this.frmLuongGiaoDich_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.paneldata.ResumeLayout(false);
            this.paneldata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel paneldata;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private RJControls.RjButton btnReport;
        private System.Windows.Forms.RadioButton rdRut;
        private System.Windows.Forms.RadioButton rdGui;
        private System.Windows.Forms.TextBox txtTgBaoCao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpmonthReport;
        private System.Windows.Forms.Label lbDanhSach;
        private RJControls.RjButton rjButton2;
    }
}