using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Lần_1;
using Thong_Tin_Khach_hang;

namespace WindowsFormsApp1
{
    public partial class MainFormManager : Form
    {
        private Form curentChildForm;
        public static MainFormManager Instance;
        bool formShow = false;

        public MainFormManager()
        {
            InitializeComponent();
            customizeDesign();
            Instance = this;
        }

        private void customizeDesign()
        {
            panelThongTinKhachHang.Visible = false;
            panelThongTinSo.Visible = false;
            panelNhanVien.Visible = false;
            panelBCTK.Visible = false;
            pnChinhSach.Visible = false;
        }

        private void hidenSubMenu()
        {
            if (panelThongTinKhachHang.Visible == true)
            {
                panelThongTinKhachHang.Visible = false;
            }
            if (panelThongTinSo.Visible == true)
            {
                panelThongTinSo.Visible = false;
            }
            if (panelNhanVien.Visible == true)
            {
                panelNhanVien.Visible = false;
            }
            if (panelBCTK.Visible == true)
            {
                panelBCTK.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hidenSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void iconKhachHang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongTinKhachHang);
        }

        private void iconThongTinSo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongTinSo);
        }

        private void iconNhanVien_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNhanVien);
        }

        private void iconBCTK_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBCTK);
        }

        void SetDFColor()
        {
            btnThongTinChung.BackColor = btnThongTinSo.BackColor = btnQuanLyNV.BackColor = btnSoTienGiaoDich.BackColor = btnTopKhachHang.BackColor = btnLuongGiaoDich.BackColor = btCSLX.BackColor = btCSNH.BackColor = Color.FromArgb(63, 110, 95);
            formShow = true;
        }

        private void btnThongTinChung_Click(object sender, EventArgs e)
        {
            openChildForm(new frmthongTinKhachHang());
            SetDFColor();
            btnThongTinChung.BackColor = Color.FromArgb(93, 166, 143);
        }

        public void openChildForm(Form childForm)
        {
            if (curentChildForm != null)
            {
                curentChildForm.Close();
            }
            curentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(curentChildForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //private void btnThemSo_Click(object sender, EventArgs e)
        //{
        //    hidenSubMenu();
        //    openChildForm(new frmThongtinso());
        //    SetDFColor();
        //    btnThemSo.BackColor = Color.FromArgb(93, 166, 143);
        //}

        private void btnQuanLyNV_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
            SetDFColor();
            btnQuanLyNV.BackColor = Color.FromArgb(93, 166, 143);
        }

        private void btnSoTienGiaoDich_Click(object sender, EventArgs e)
        {
            SetDFColor();
            btnSoTienGiaoDich.BackColor = Color.FromArgb(93, 166, 143);
        }

        private void btnTopKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTopKhachHang());
            SetDFColor();
            btnTopKhachHang.BackColor = Color.FromArgb(93, 166, 143);
        }

        private void btnLuongGiaoDich_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLuongGiaoDich());
            SetDFColor();
            btnLuongGiaoDich.BackColor = Color.FromArgb(93, 166, 143);
        }

        private void iconChinhSach_Click(object sender, EventArgs e)
        {
            showSubMenu(pnChinhSach);
        }

        private void btCSLX_Click(object sender, EventArgs e)
        {
            openChildForm(new ChinhSuaLoaiTK());
            SetDFColor();
            btCSLX.BackColor = Color.FromArgb(93, 166, 143);
        }

        private void btCSNH_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongTinChinhSach());
            SetDFColor();
            btCSNH.BackColor = Color.FromArgb(93, 166, 143);
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
            if (formShow && curentChildForm != null)
            {
                curentChildForm.Close();
                formShow = false;
            }
        }

        private void iconUser_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAccount());
        }

        private void btnThongTinSo_Click(object sender, EventArgs e)
        {
            SetDFColor();
            btnThongTinSo.BackColor = Color.FromArgb(93, 166, 143);
        }
    }
}
