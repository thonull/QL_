using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thong_Tin_Khach_hang
{
    public partial class frmthongKeGiaoDich : Form
    {
        public frmthongKeGiaoDich()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmthongKeGiaoDich_Load(object sender, EventArgs e)
        {
            setCustomFormat();
        }
        public void setCustomFormat()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";
        }
  

    }
}
