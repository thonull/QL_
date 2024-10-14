﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;
using Thong_Tin_Khach_hang;

namespace Lần_1
{
    public partial class Form1 : Form
    {
       DataTable dt=new DataTable();
        DataTable dt1 = new DataTable(); 
        bool Search=false;
        public Form1()
        {
            InitializeComponent();
        }
        void LoadData()
        {

            string st = "SELECT MaNV, CCCD, TenNV ,NgaySinh ,GioiTinh,NV.DiaChi,SDT,Email,CN.TenCN,ChucVu,TaiKhoan FROM NHANVIEN NV, CHINHANH CN WHERE NV.ChiNhanhLV=CN.MaCN ";
            dgvNhanVien.DataSource = dataProvider.Instance.ExecuteQuery(st);
            rbNam.Checked = false;
            rbNu.Checked = false;
        }
        void LoadChiNhanh()
        {
            
            string st = "SELECT MaCN,TenCN FROM CHINHANH";
            
            cbChiNhanh.DisplayMember = "TenCN";
            cbChiNhanh.ValueMember = "MaCN";
            dt1=dataProvider.Instance.ExecuteQuery(st);
            cbChiNhanh.DataSource = dt1;
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
           
            LoadData();
            LoadChiNhanh();
            //connection.Close();
            cbChucVu.Text = "Nhân viên quầy";
        }

        private void checkBox1_Click_1(object sender, EventArgs e)
        {
            if (!Search)
            {
                if (cbTK.Checked)
                {
                    cbTK.Checked = false;
                }
                else
                {
                    cbTK.Checked = true;
                }
            }
            else
            {
                if (cbTK.Checked) {
                    (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = "TaiKhoan=True";
                    
                }
                else
                {
                    (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = "TaiKhoan=False";
                }
            }
        }

       bool CheckMa( string st)
        {
            DataTable dtb = new DataTable();
            dt = dataProvider.Instance.ExecuteQuery(st);
            if (dt.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }
        int Random()
        {
            Random rd = new Random();
            return rd.Next(100000, 999999);
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            Check();
            string maNV = Random().ToString();
            string st = "SELECT * FROM NHANVIEN WHERE MaNV='" + maNV + "' ";
            while (!CheckMa(st))
            {
                maNV = Random().ToString();
            }
            tbMNV.Text = maNV;
            st = "SELECT * FROM NHANVIEN WHERE  CCCD='" + tbCCCD.Text + "'";
            if (!CheckMa(st))
            {
                MessageBox.Show("CMND/CCCD đã tồn tại, mời nhập lại!", "Thông báo!", MessageBoxButtons.OK);
                tbCCCD.Focus();
                return;
            }
            string gioitinh="";
            if (rbNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            
             st= "INSERT INTO NHANVIEN VALUES ('" + tbMNV.Text + "','" + tbCCCD.Text + "',N'"+tbTen.Text+"','"+dtNgaySinh.Text+"',N'"+tbDiaChi.Text+"','"+tbSDT.Text+"','"+tbGmail.Text+"',N'"+ (string)cbChiNhanh.SelectedValue + "',N'"+cbChucVu.Text+ "','NULL',N'"+gioitinh+"','False')";
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn thêm Nhân viên trên?", "Important Question", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dataProvider.Instance.ExecuteNonQuery(st) == 0)
                {
                    MessageBox.Show("Thêm không thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công!");
                    KhoiTao();
                }
            }
            
        }
        
        private void btXoa_Click(object sender, EventArgs e)
        {
            Check();
            
            string st = "DELETE FROM NHANVIEN WHERE MaNV='"+ tbMNV.Text+ "'";
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn xóa Nhân viên trên?","Important Question",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dataProvider.Instance.ExecuteNonQuery(st) == 0)
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thành công!");
                    KhoiTao();
                }
            }
            
        }

        private void btKhoiTao_Click(object sender, EventArgs e)
        {
            KhoiTao();
        }
        void KhoiTao() {
            tbMNV.ReadOnly = false;
            tbMNV.Text = "";
            tbTen.Text = "";
            tbDiaChi.Text = "";
            tbCCCD.Text = "";
            dtNgaySinh.Text = "12/31/2002";
            tbSDT.Text = "";
            cbChiNhanh.SelectedIndex = 1;
            tbGmail.Text = "";
            cbChucVu.Text = "Nhân viên quầy";
            rbNam.Checked = false;
            rbNu.Checked = false;
            cbTK.Checked = false;
            LoadData();
            string rowFilter = string.Format("{0} like '{1}'", "GioiTinh", "*" + "N" + "*");
            (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            Check();
            string st = "SELECT * FROM NHANVIEN WHERE MaNV='" + tbMNV.Text + "' OR CCCD='" + tbCCCD.Text + "'";
            if (!CheckMa(st))
            {
                MessageBox.Show("Mã Nhân viên hoặc CMND đã tồn tại, mời nhập lại!", "Thông báo!", MessageBoxButtons.OK);
                tbMNV.Focus();
            }
            string gioitinh = "";
            if (rbNam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
           
            st = "UPDATE NHANVIEN SET MaNV='"+tbMNV.Text+"',CCCD='"+tbCCCD.Text+"',TenNV='"+tbTen.Text+"',NgaySinh='"+dtNgaySinh.Text+"',GioiTinh='"+gioitinh+"',DiaChi='"+tbDiaChi.Text+"',SDT='"+tbSDT.Text+"',Email='"+tbGmail.Text+"',ChiNhanhLV='"+ (string)cbChiNhanh.SelectedValue + "',ChucVu='"+cbChucVu.Text+ "' WHERE = MaNV'" + tbMNV.Text+"'";
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn sửa thông tin Nhân viên trên?", "Important Question", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dataProvider.Instance.ExecuteNonQuery(st) == 0)
                {
                    MessageBox.Show("Sửa không thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa thành công!");
                    KhoiTao();
                }
            }
           
        }
        void Check()
        {
            if(tbMNV.Text=="" || tbTen.Text=="" || tbDiaChi.Text=="" || tbCCCD.Text=="" || tbSDT.Text=="" || dtNgaySinh.Text=="" || cbChiNhanh.Text=="" || cbChucVu.Text=="" || tbGmail.Text == "")
            {
                MessageBox.Show("Mời nhập đầy đủ các thông tin!", "Thông báo lỗi!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            if((rbNam.Checked==true && rbNu.Checked==true) || (rbNam.Checked == false && rbNu.Checked == false))
            {
                MessageBox.Show("Mời chọn giới tính!", "Thông báo lỗi!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            KhoiTao();
            if (Search)
            {
                Search = false;
                KhoiTao();
                btTimKiem.Text = "Tìm kiếm";
                tbMNV.ReadOnly = true;
            }
            else
            {
                Search=true;
                btTimKiem.Text = "Bỏ tìm kiếm";
                btKhoiTao.Enabled = true;
                tbMNV.ReadOnly = false;
            }
            
        }

        private void tbMNV_TextChanged(object sender, EventArgs e)
        {
            if (Search)
            {
                string rowFilter = string.Format("{0} like '{1}'", "MaNV", "*" + tbMNV.Text + "*");
                (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

            }
        }
        private void tbTen_TextChanged(object sender, EventArgs e)
        {
            if (Search)
            {
                string rowFilter = string.Format("{0} like '{1}'", "TenNV", "*" + tbTen.Text + "*");
                (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;

            }
        }
        private void tbDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (Search)
            {
                string rowFilter = string.Format("{0} like '{1}'", "DiaChi", "*" + tbDiaChi.Text + "*");
                (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }
        private void tbCCCD_TextChanged(object sender, EventArgs e)
        {
            if (Search)
            {
                string rowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "CCCD", tbCCCD.Text);
                (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }
        

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (Search)
            {
                if (rbNu.Checked)
                {
                    string rowFilter = string.Format("{0} like '{1}'", "GioiTinh", "*" + "Nữ" + "*");
                    (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                }
            }
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (Search)
            {
                if (rbNam.Checked)
                {
                    string rowFilter = string.Format("{0} like '{1}'", "GioiTinh", "*" + "Nam" + "*");
                    (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
                }
            }
        }

        private void dtNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if (Search)
            {
                string rowFilter = string.Format("{0} = '{1}'", "NgaySinh", dtNgaySinh.Value);
                (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }

        private void tbSDT_TextChanged(object sender, EventArgs e)
        {
            if (Search)
            {
                string rowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "SDT", tbSDT.Text);
                //MessageBox.Show(rowFilter);
                (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }

        private void btTaoTK_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Bạn có muốn tạo tài khoản cho nhân viên " + tbTen.Text + " không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                MessageBox.Show("Thông tin tài khoản đã được gởi tới email " + tbGmail.Text + ", hãy kiểm tra và đăng nhập vào hệ thống!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                KhoiTao();
            }
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Search)
            {
                string rowFilter = string.Format("{0} like '{1}'", "TenCN", "*" + cbChiNhanh.Text + "*");
                (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMNV.ReadOnly = true;
            int i;
            i = e.RowIndex;
            if(i== -1)
            {
                return;
            }
            //MessageBox.Show(  dgvNhanVien.Rows[i].Cells[8].Value.ToString());

            tbMNV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            tbTen.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            tbDiaChi.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            tbCCCD.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            dtNgaySinh.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            tbSDT.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            tbGmail.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
            cbChucVu.Text = dgvNhanVien.Rows[i].Cells[9].Value.ToString();
            cbChiNhanh.Text = dgvNhanVien.Rows[i].Cells[8].Value.ToString();
            
            if (dgvNhanVien.Rows[i].Cells[4].Value.ToString() == "Nam")
            {
                rbNam.Checked = true;
                rbNu.Checked = false;
            }
            else
            {
                rbNam.Checked = false;
                rbNu.Checked = true;
            }


            if (dgvNhanVien.Rows[i].Cells[10].Value.ToString() == "False")
            {
                cbTK.Checked = false;
            }
            else
            {
                cbTK.Checked = true;
            }
        }

        private void tbGmail_TextChanged(object sender, EventArgs e)
        {
            if (Search)
            {
                string rowFilter = string.Format("{0} like '{1}'", "Email", "*" + tbGmail.Text + "*");
                (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Search)
            {
                string rowFilter = string.Format("{0} like '{1}'", "ChucVu", "*" + cbChucVu.Text + "*");
                (dgvNhanVien.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
        }
    }
}
