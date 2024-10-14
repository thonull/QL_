namespace WindowsFormsApp1
{
    partial class fInPhieuGiaoDichRut
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
            this.pXemTruocIn = new System.Windows.Forms.Panel();
            this.ibtnInPhieu = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // pXemTruocIn
            // 
            this.pXemTruocIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pXemTruocIn.Location = new System.Drawing.Point(0, 0);
            this.pXemTruocIn.Name = "pXemTruocIn";
            this.pXemTruocIn.Size = new System.Drawing.Size(1100, 521);
            this.pXemTruocIn.TabIndex = 0;
            // 
            // ibtnInPhieu
            // 
            this.ibtnInPhieu.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.ibtnInPhieu.IconColor = System.Drawing.Color.Black;
            this.ibtnInPhieu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnInPhieu.IconSize = 30;
            this.ibtnInPhieu.Location = new System.Drawing.Point(503, 545);
            this.ibtnInPhieu.Name = "ibtnInPhieu";
            this.ibtnInPhieu.Size = new System.Drawing.Size(100, 40);
            this.ibtnInPhieu.TabIndex = 1;
            this.ibtnInPhieu.Text = "In Phiếu";
            this.ibtnInPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnInPhieu.UseVisualStyleBackColor = true;
            // 
            // fInPhieuGiaoDichRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 625);
            this.Controls.Add(this.ibtnInPhieu);
            this.Controls.Add(this.pXemTruocIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fInPhieuGiaoDichRut";
            this.Text = "fInPhieuGiaoDichRut";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pXemTruocIn;
        private FontAwesome.Sharp.IconButton ibtnInPhieu;
    }
}