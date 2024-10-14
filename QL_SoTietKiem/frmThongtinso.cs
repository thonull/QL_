using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Thong_Tin_Khach_hang;

namespace WindowsFormsApp1
{
    public partial class frmThongtinso : Form
    {
        public frmThongtinso()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MainFormManager.Instance.openChildForm(new frmthongTinKhachHang());
        }
    }
}
