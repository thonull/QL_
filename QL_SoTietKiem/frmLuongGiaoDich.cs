using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ConnectDB;

namespace WindowsFormsApp1
{
    public partial class frmLuongGiaoDich : Form
    {
        string month = "";
        string year = "";
        public frmLuongGiaoDich()
        {
            InitializeComponent();
        }

        private void frmLuongGiaoDich_Load(object sender, EventArgs e)
        {
           txtTgBaoCao.Text= DateTime.Now.ToString("dd/MM/yyyy");
            month = DateTime.Now.Month.ToString();
            year = DateTime.Now.Year.ToString();
            rdGui.Checked = true;
            LoadAccountDealSend();

        }

        void LoadAccountDealSend()
        {
            lbDanhSach.Text = "Danh sách khách hàng gửi tiền";
            string query = $"SELECT KH.MaKH, KH.TenKH, KH.NgaySinh,KH.SDT,KH.DiaChi,count(PGT.MaPhieu) as'Số lần gửi' From KHACHHANG KH, SOTIETKIEM STK, PHIEUGOITIEN PGT WHERE KH.MaKH=STK.MaKH AND STK.MaSoTK= PGT.MaSoTK AND YEAR(PGT.NgayGoi)={year} AND MONTH(PGT.NgayGoi)={month} GROUP BY KH.MaKH, KH.TenKH, KH.NgaySinh,KH.SDT,KH.DiaChi ORDER BY count(PGT.MaPhieu) DESC"; ;
            DataProvider provider = new DataProvider();
            dataGridView.DataSource = provider.ExcuteQuery(query);
        }
        void LoadAccountDealWithdraw()
        {
            lbDanhSach.Text = "Danh sách khách hàng rút tiền";
            string query = $"SELECT KH.MaKH, KH.TenKH, KH.NgaySinh,KH.SDT,KH.DiaChi,count(PRT.MaPhieu) as'Số lần rút' From KHACHHANG KH, SOTIETKIEM STK, PHIEURUTTIEN PRT WHERE KH.MaKH=STK.MaKH AND STK.MaSoTK= PRT.MaSoTK AND YEAR(PRT.NgayRut)={year} AND MONTH(PRT.NgayRut)={month} GROUP BY KH.MaKH, KH.TenKH, KH.NgaySinh,KH.SDT,KH.DiaChi ORDER BY count(PRT.MaPhieu) DESC"; ;
            DataProvider provider = new DataProvider();
            dataGridView.DataSource = provider.ExcuteQuery(query);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            month = dtpmonthReport.Value.Month.ToString();
            year = dtpmonthReport.Value.Year.ToString();
            if (rdGui.Checked)
            {             
                LoadAccountDealSend();
            }
            if(rdRut.Checked)
            {
                LoadAccountDealWithdraw();
            }
            
        }

        private void dtpmonthReport_ValueChanged(object sender, EventArgs e)
        {
            month = dtpmonthReport.Value.Month.ToString();
            year = dtpmonthReport.Value.Year.ToString();
            if (rdGui.Checked)
            {
                LoadAccountDealSend();
            }
            if (rdRut.Checked)
            {
                LoadAccountDealWithdraw();
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
