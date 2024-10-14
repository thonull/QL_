using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAccount : Form
    {
        bool display = true;
        public frmAccount()
        {
            InitializeComponent();
        }

        private void iconUser_Click(object sender, EventArgs e)
        {
            if (display)
            {
                iconMK.IconChar = FontAwesome.Sharp.IconChar.Eye;
                tbMK.UseSystemPasswordChar = false;
                display = false;
            }
            else
            {
                iconMK.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                tbMK.UseSystemPasswordChar = true;
                display = true;
            }
        }
    }
}
