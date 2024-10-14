using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Drawing.Printing;

namespace Thong_Tin_Khach_hang
{
    public partial class frmthongTinKhachHang : Form
    {
        DataTable dt = new DataTable();
        editPerson edit = new editPerson();
        public string maSoTK = "";
        public string maPhieuGui = "";
        public frmthongTinKhachHang()
        {
            InitializeComponent();
            ShowData();
            danhSachKyHan();
            danhSachChiNhanh();
        }
        //Danh sách khách hàng
        void ShowData()
        {
            string query = "SELECT MaKH 'Mã Khách Hàng', kh.CCCD 'CCCD', tenKH 'Tên Khách Hàng', kh.NgaySinh 'Ngày Sinh',kh.GioiTinh 'Giới Tính', kh.DiaChi 'Địa Chỉ', kh.SDT 'Số Điện Thoại', kh.Email 'Email', cn.TenCN 'Chi Nhánh', nv.TenNV 'Nhân Viên', NgayThamGia 'Ngày Tham Gia' FROM KHACHHANG kh, CHINHANH cn, NHANVIEN nv WHERE kh.ChiNhanhNhapTT=MaCN and nv.MaNV=kh.NhanVienNhapTT ";
            dataGridView1.DataSource = dataProvider.Instance.ExecuteQuery(query);
            iconbtninSo.Hide();
            iconbtnphieuGuiTien.Hide();
        }
        //danh sách chi nhánh
        void danhSachChiNhanh()
        {
            string query = "SELECT TenCN from CHINHANH";
            dt = dataProvider.Instance.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboChiNhanh.Items.Add(dt.Rows[i]["TenCN"].ToString());
                cbochiNhanh1.Items.Add(dt.Rows[i]["TenCN"].ToString());
            }
        }
        //danh sách nhân viên
        void danhSachNhanVien(string text)
        {
            string query = "SELECT TenNV FROM NHANVIEN where ChiNhanhLV='" + maCN(text) + "'";
            dt = dataProvider.Instance.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbonhanVien.Items.Add(dt.Rows[i]["TenNV"].ToString());
                cbonhanVien1.Items.Add(dt.Rows[i]["TenNV"].ToString());
            }
        }
        //danh sách kỳ hạn
        void danhSachKyHan()
        {
            string query = "SELECT TenLoaiTK from LOAITIETKIEM";
            dt = dataProvider.Instance.ExecuteQuery(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboloaiTietKiem.Items.Add(dt.Rows[i]["TenLoaiTK"].ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtmNgayThamGia.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dtmNgaySinh.Format = DateTimePickerFormat.Custom;
            dtmNgayThamGia.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dtmNgaySinh.CustomFormat = "dd-MM-yyyy";
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            dtmNgayThamGia.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dtmNgaySinh.Value = new DateTime(2002, 01, 13);
            rdbYes.Checked = true;
            rdbten.Checked = true;
            dateTimePicker2.Enabled = false;

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            if (txtmaKH.Text != "" && txtmaKH != null)
            {
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                tabPage2.Text = "Mở sổ";
                txtten1.Text = txthoTen.Text;
                txtmaKH1.Text = txtmaKH.Text;
                txtdiaChi1.Text = txtdiaChi.Text;
                txtcccd1.Text = txtcccd.Text;
            }
            else
            {
                MessageBox.Show("Mời bạn chọn khách hàng cần mở sổ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
        private bool checkTienGuiVao()
        {
            string query = "select SoTienGoiToithieuBD from THAMSO";
            dt = dataProvider.Instance.ExecuteQuery(query);
            decimal soTien;
            decimal soTienGuiVao;
            Decimal.TryParse(dt.Rows[0]["SoTienGoiToithieuBD"].ToString(), out soTien);
            Decimal.TryParse(txtsoTien.Text, out soTienGuiVao);
            if (soTien > soTienGuiVao)
            {
                MessageBox.Show("số tiền gửi tiết kiệm tối thiểu là: " + soTien, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        // mở sổ tiết kiệm 
        private void iconbtnAdd_Click(object sender, EventArgs e)
        {
            if (cbochiNhanh1.Text == "" || cboloaiTietKiem.Text == "" || txtsoTien.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "SELECT MaLoaiTK from LOAITIETKIEM where TenLoaiTK=N'" + cboloaiTietKiem.Text + "'";
                dt = dataProvider.Instance.ExecuteQuery(query);
                string MaLoaiTK = dt.Rows[0]["MaLoaiTK"].ToString();
                string maSo = Random().ToString();
                string st = "SELECT * FROM  SOTIETKIEM WHERE MaSoTK ='" + maSo.ToString() + "' ";
                while (CheckMa(st))
                {
                    Passbook pb = new Passbook();
                    pb.maSoTK = maSo;
                    pb.maKH = txtmaKH1.Text;
                    pb.maLoaiTK = MaLoaiTK;
                    pb.maNV = maNV(cbonhanVien1.Text);
                    pb.maChiNhanh = maCN(cbochiNhanh1.Text);
                    pb.ngayMoSo = dateTimePicker2.Value;
                    pb.soDuSo = decimal.Parse(txtsoTien.Text);
                    pb.tuDongGiaHan = rdbYes.Checked;
                    maSoTK = pb.maSoTK;


                    phieuGuiTien pg = new phieuGuiTien();
                    pg.maPhieu = Random().ToString();
                    pg.maNV = maNV(cbonhanVien1.Text);
                    pg.maSoTK = maSoTK;
                    pg.ngayGui = dateTimePicker2.Value;
                    pg.soTienGui = decimal.Parse(txtsoTien.Text);
                    maPhieuGui = pg.maPhieu;
                    if (edit.InsertPassBook(pb) && edit.InsertphieuGuiTien(pg) && checkTienGuiVao())
                    {
                        MessageBox.Show("Mở sổ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        iconbtnAdd.Hide();
                        iconbtnphieuGuiTien.Show();
                        iconbtninSo.Show();
                        cbochiNhanh1.Enabled = false;
                        cbonhanVien1.Enabled = false;
                        txtsoTien.Enabled = false;
                        cboloaiTietKiem.Enabled = false;
                        dateTimePicker2.Enabled = false;
                        rdbYes.Enabled = false;
                        rdbNo.Enabled = false;
                        iconButton7.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void iconButton5_Click(object sender, EventArgs e)
        {
            cbochiNhanh1.Enabled = true;
            cbonhanVien1.Enabled = true;
            txtsoTien.Enabled = true;
            cboloaiTietKiem.Enabled = true;
            dateTimePicker2.Enabled = true;
            rdbYes.Enabled = true;
            rdbNo.Enabled = true;
            rdbYes.Checked = true;
            reload1();
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Add(tabPage1);
            tabPage1.Text = "Thông tin khách hàng";
            iconbtnAdd.Show();
            iconbtninSo.Hide();
            iconbtnphieuGuiTien.Hide();
            iconButton7.Enabled = true;
        }

        private void iconbtnphieuGuiTien_Click(object sender, EventArgs e)
        {
            iconbtninSo.Show();
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Add(tabPage3);
            inPhieuGui();

        }

        private void iconButton7_Click_1(object sender, EventArgs e)
        {
            cbochiNhanh1.Text = "";
            cboloaiTietKiem.Text = "";
            cbonhanVien1.Text = "";
            txtsoTien.Text = "";
            txtLaiSuat.Text = "";
            rdbNo.Checked = false;
            rdbYes.Checked = true;
        }
        bool CheckMa(string st)
        {
            DataTable dtb = new DataTable();
            dtb = dataProvider.Instance.ExecuteQuery(st);
            if (dtb.Rows.Count == 0)
            {
                return true;
            }
            return false;
        }


        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txthoTen.Text))
            {
                MessageBox.Show("bạn chưa nhập tên Khách hàng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthoTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtcccd.Text))
            {
                MessageBox.Show("bạn chưa nhập số CCCD", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcccd.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtdiaChi.Text))
            {
                MessageBox.Show("bạn chưa nhập địa chỉ khách hàng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiaChi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtgmail.Text))
            {
                MessageBox.Show("bạn chưa nhập Gmail khách hàng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgmail.Focus();
                return false;
            }
            else
            {
                string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                Regex regex = new Regex(strRegex);
                if (regex.IsMatch(txtgmail.Text) == false)
                {
                    MessageBox.Show("email không hợp lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtsdt.Text))
            {
                MessageBox.Show("bạn chưa nhập số điện thoại khách hàng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsdt.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboChiNhanh.Text))
            {
                MessageBox.Show("bạn chưa nhập chi nhánh ngân hàng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboChiNhanh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbonhanVien.Text))
            {
                MessageBox.Show("bạn chưa nhập nhân viên giao dich", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbonhanVien.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboGioiTinh.Text))
            {
                MessageBox.Show("bạn chưa nhập Giới tính", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboGioiTinh.Focus();
                return false;
            }
            return true;
        }
        int Random()
        {
            Random rd = new Random();
            return rd.Next(100000, 999999);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                dataGridView1.Rows[index].Selected = true;
                txtmaKH.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                txtcccd.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                txthoTen.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                dtmNgaySinh.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
                cboGioiTinh.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
                txtdiaChi.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
                txtsdt.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
                txtgmail.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
                cboChiNhanh.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();
                cbonhanVien.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();
                dtmNgayThamGia.Text = dataGridView1.Rows[index].Cells[10].Value.ToString();
            }
        }

        private string maNV(string text)
        {
            string query = "SELECT MaNV from NHANVIEN where TenNV=N'" + text + "'";
            dt = dataProvider.Instance.ExecuteQuery(query);
            string maNV = dt.Rows[0]["MaNV"].ToString();
            return maNV;
        }
        private string maCN(string text)
        {
            string query = "SELECT MaCN from CHINHANH where TenCN=N'" + text + "'";
            dt = dataProvider.Instance.ExecuteQuery(query);
            string macn = dt.Rows[0]["MaCN"].ToString();
            return macn;
        }
        // Thêm xóa sửa khách hàng
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                string maKH = Random().ToString();
                string st = "SELECT * FROM KHACHHANG WHERE MaKH='" + maKH.ToString() + "' OR CCCD='" + txtcccd.Text + "'";
                while (CheckMa(st))
                {
                    Person per = new Person();
                    per.maKH = maKH;
                    per.cccd = txtcccd.Text;
                    per.tenKH = txthoTen.Text;
                    per.ngaySinh = dtmNgaySinh.Value;
                    per.gioiTinh = cboGioiTinh.Text;
                    per.diaChi = txtdiaChi.Text;
                    per.sdt = txtsdt.Text;
                    per.email = txtgmail.Text;
                    per.chiNhanh = maCN(cboChiNhanh.Text);
                    per.nhanVien = maNV(cbonhanVien.Text);
                    per.tenKH = txthoTen.Text;
                    per.ngayThamGia = dtmNgayThamGia.Value;
                    if (edit.Insert(per))
                    {
                        reload();
                        ShowData();
                        MessageBox.Show("Thêm mới khách hàng thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không thêm được, vui lòng thử lại sau!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {

                Person per = new Person();
                per.maKH = txtmaKH.Text;
                per.cccd = txtcccd.Text;
                per.tenKH = txthoTen.Text;
                per.ngaySinh = dtmNgaySinh.Value;
                per.gioiTinh = cboGioiTinh.Text;
                per.diaChi = txtdiaChi.Text;
                per.sdt = txtsdt.Text;
                per.email = txtgmail.Text;
                per.chiNhanh = maCN(cboChiNhanh.Text);
                per.nhanVien = maNV(cbonhanVien.Text);
                per.tenKH = txthoTen.Text;
                per.ngayThamGia = dtmNgayThamGia.Value;
                if (edit.Update(per))
                {
                    ShowData();
                    MessageBox.Show("Thông tin đã được thay đổi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi không sửa được, vui lòng thử lại sau!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Person per = new Person();
            per.maKH = txtmaKH.Text;
            if (txtmaKH.Text != "" && txtmaKH != null)
            {
                DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng " + txtmaKH.Text + "khỏi danh sách không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    if (edit.Delete(per))
                    {

                        ShowData();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không xóa được, vui lòng thử lại sau!! Có thể khách hàng này đã mở sổ tiết kiệm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Mời bạn chọn khách hàng cần xóa!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //ràng buộc nhập số cho cccd
        private void txtcccd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //ràng buộc nhập số cho sdt
        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txthoTen_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        //nhập lại sổ tiết kiệm
        void reload()
        {
            txtmaKH.Text = "";
            txtcccd.Text = "";
            txtsdt.Text = "";
            cboGioiTinh.Text = "";
            txtdiaChi.Text = "";
            txtgmail.Text = "";
            txthoTen.Text = "";
            txtsdt.Text = "";
            cboChiNhanh.Text = "";
            cbonhanVien.Text = "";
            dtmNgaySinh.Value = new DateTime(2002, 01, 13);
            dtmNgayThamGia.Value = DateTime.Now;

        }

        void reload1()
        {
            cbochiNhanh1.Text = "";
            cbonhanVien1.Text = "";
            txtsoTien.Text = "";
            cboloaiTietKiem.Text = "";
            txtLaiSuat.Text = "";
            rdbYes.Checked = false;
            rdbNo.Checked = false;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void txtmaKH_TextChanged(object sender, EventArgs e)
        {
            if (txtmaKH.Text == "" || txtmaKH == null)
            {
                btnAdd.Enabled = true;
                btnSua.Enabled = false;
                btnopenPassBook.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = false;
                btnSua.Enabled = true;
                btnopenPassBook.Enabled = true;
            }
        }

        private void cboloaiTietKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT LaiXuat from LOAITIETKIEM where TenLoaiTK=N'" + cboloaiTietKiem.Text + "'";
            dt = dataProvider.Instance.ExecuteQuery(query);
            txtLaiSuat.Text = dt.Rows[0]["LaiXuat"].ToString();
        }

        private void iconbtninSo_Click(object sender, EventArgs e)
        {
            lblmaso.Text = maSoTK;
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Add(tabPage4);
            lblmakh2.Text = txtmaKH1.Text;
            lblchinhanh2.Text = cbochiNhanh1.Text;
            lblkyhan2.Text = cboloaiTietKiem.Text;
            lbltenkh.Text = txtten1.Text;
            lblcccd2.Text = txtcccd1.Text;
            lbldiachi2.Text = txtdiaChi1.Text;
            lblngayphathanh.Text = dateTimePicker2.Value.ToString();
        }
        //In sổ
        private void btnInSo_Click(object sender, EventArgs e)
        {
            Print(this.pnlPrint);
        }

        private void Print(Panel pnl)
        {
            PrinterSettings printer = new PrinterSettings();
            pnlPrint = pnl;
            getPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printPreviewDialog1.ShowDialog();

        }
        private Bitmap memoryimg;
        private void getPrintArea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.pnlPrint.Width / 2), this.pnlPrint.Location.Y);
        }

        private void txtsoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Print(this.pnlPrint);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Add(tabPage2);
        }

        public void inPhieuGui()
        {
            dataGridView2.Columns.Clear();
            string query = "SELECT NgayGoi 'Ngày gửi', SoTienGoi 'Số Tiền Gửi', SoDuSo 'Số Dư Sổ' FROM PHIEUGOITIEN,SOTIETKIEM WHERE PHIEUGOITIEN.MaSoTK=SOTIETKIEM.MaSoTK and MaPhieu='" + maPhieuGui + "'";
            dataGridView2.DataSource = dataProvider.Instance.ExecuteQuery(query);
            dataGridView2.Columns.Add("Column", "Nhân Viên");
            dataGridView2.Columns.Add("Column", "Khách Hàng");
            DataGridViewRow row = dataGridView2.Rows[0];
            row.Height = 100;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Add(tabPage2);
        }

        private void btninPhieu_Click(object sender, EventArgs e)
        {
            Print(this.panel5);
        }
        private void checkedrdb()
        {
            try
            {
                if (!string.IsNullOrEmpty(txttimKiem.Text))
                {
                    string query;
                    if (rdbsdt.Checked)
                    {
                        query = "SELECT MaKH 'Mã Khách Hàng', kh.CCCD 'CCCD', tenKH 'Tên Khách Hàng', kh.NgaySinh 'Ngày Sinh', kh.GioiTinh 'Giới Tính', kh.DiaChi 'Địa Chỉ', kh.SDT 'Số Điện Thoại', kh.Email 'Email', cn.TenCN 'Chi Nhánh', nv.TenNV 'Nhân Viên', NgayThamGia 'Ngày Tham Gia' FROM KHACHHANG kh, CHINHANH cn, NHANVIEN nv WHERE kh.ChiNhanhNhapTT=MaCN and nv.MaNV=kh.NhanVienNhapTT and kh.SDT like '%" + txttimKiem.Text + "%'";
                    }
                    else if (rdbcccd.Checked)
                    {
                        query = "SELECT MaKH 'Mã Khách Hàng', kh.CCCD 'CCCD', tenKH 'Tên Khách Hàng', kh.NgaySinh 'Ngày Sinh', kh.GioiTinh 'Giới Tính', kh.DiaChi 'Địa Chỉ', kh.SDT 'Số Điện Thoại', kh.Email 'Email', cn.TenCN 'Chi Nhánh', nv.TenNV 'Nhân Viên', NgayThamGia 'Ngày Tham Gia' FROM KHACHHANG kh, CHINHANH cn, NHANVIEN nv WHERE kh.ChiNhanhNhapTT=MaCN and nv.MaNV=kh.NhanVienNhapTT and kh.CCCD like'%" + txttimKiem.Text + "%'";
                    }
                    else if (rdbten.Checked)
                    {
                        query = "SELECT MaKH 'Mã Khách Hàng', kh.CCCD 'CCCD', tenKH 'Tên Khách Hàng', kh.NgaySinh 'Ngày Sinh', kh.GioiTinh 'Giới Tính', kh.DiaChi 'Địa Chỉ', kh.SDT 'Số Điện Thoại', kh.Email 'Email', cn.TenCN 'Chi Nhánh', nv.TenNV 'Nhân Viên', NgayThamGia 'Ngày Tham Gia' FROM KHACHHANG kh, CHINHANH cn, NHANVIEN nv WHERE kh.ChiNhanhNhapTT=MaCN and nv.MaNV=kh.NhanVienNhapTT and TenKH like N'%" + txttimKiem.Text + "%'";
                    }
                    else
                    {
                        query = "SELECT MaKH 'Mã Khách Hàng', kh.CCCD 'CCCD', tenKH 'Tên Khách Hàng', kh.NgaySinh 'Ngày Sinh', kh.GioiTinh 'Giới Tính', kh.DiaChi 'Địa Chỉ', kh.SDT 'Số Điện Thoại', kh.Email 'Email', cn.TenCN 'Chi Nhánh', nv.TenNV 'Nhân Viên', NgayThamGia 'Ngày Tham Gia' FROM KHACHHANG kh, CHINHANH cn, NHANVIEN nv WHERE kh.ChiNhanhNhapTT=MaCN and nv.MaNV=kh.NhanVienNhapTT and MaKH like N'%" + txttimKiem.Text + "%'";
                    }
                    dataGridView1.DataSource = dataProvider.Instance.ExecuteQuery(query);
                }
                else
                {
                    ShowData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void txttimKiem_TextChanged(object sender, EventArgs e)
        {
            checkedrdb();
        }

        private void cboChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbonhanVien.Items.Clear();
            cbonhanVien.Text = "";
            danhSachNhanVien(cboChiNhanh.Text);
        }

        private void cbochiNhanh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbonhanVien1.Items.Clear();
            cbonhanVien1.Text = "";
            danhSachNhanVien(cbochiNhanh1.Text);
        }
       
    }
}
