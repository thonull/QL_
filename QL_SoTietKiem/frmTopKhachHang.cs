using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media;
using WindowsFormsApp1.ConnectDB;

namespace WindowsFormsApp1
{
    public partial class frmTopKhachHang : Form
    {
        string month = "";
        string year = "";
        public frmTopKhachHang()
        {
            InitializeComponent();        
            month = dtpmonthReport.Value.Month.ToString();
            year = dtpmonthReport.Value.Year.ToString();
            FillChart();
            LoadAccountList();


        }
        private void ReportTopDeposit_Load(object sender, EventArgs e)
        {
            txtTgBaoCao.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

           
        private void FillChart()
        {
            DataProvider provider = new DataProvider();
            string query = $"SELECT TOP 5 KH.MaKH, SUM(PGT.SoTienGoi) as TongTienGui From KHACHHANG KH, SOTIETKIEM STK, PHIEUGOITIEN PGT WHERE KH.MaKH=STK.MaKH AND STK.MaSoTK= PGT.MaSoTK AND YEAR(PGT.NgayGoi)={year} AND MONTH(PGT.NgayGoi)={month} GROUP BY KH.MaKH, KH.TenKH ORDER BY SUM(PGT.SoTienGoi) DESC"; 
            chart1.DataSource = provider.ExcuteQuery(query);

            chart1.Series["Số tiền gửi"].XValueMember = "MaKH";
            chart1.Series["Số tiền gửi"].YValueMembers = "TongTienGui";
            chart1.Titles.Add("");
        }

        void LoadAccountList()
        {
            string query = $"SELECT TOP 5 KH.MaKH, KH.TenKH, KH.NgaySinh,KH.SDT,KH.DiaChi,SUM(PGT.SoTienGoi) as'Tổng tiền gửi' From KHACHHANG KH, SOTIETKIEM STK, PHIEUGOITIEN PGT WHERE KH.MaKH=STK.MaKH AND STK.MaSoTK= PGT.MaSoTK AND YEAR(PGT.NgayGoi)={year} AND MONTH(PGT.NgayGoi)={month} GROUP BY KH.MaKH, KH.TenKH, KH.NgaySinh,KH.SDT,KH.DiaChi ORDER BY SUM(PGT.SoTienGoi) DESC"; ;
            DataProvider provider = new DataProvider();
            dataGridView_Top5.DataSource = provider.ExcuteQuery(query);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            month = dtpmonthReport.Value.Month.ToString();
            year = dtpmonthReport.Value.Year.ToString();
            FillChart();
            LoadAccountList();

        }

        private void rjbtnXuatFile_Click(object sender, EventArgs e)
        {
          //Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            //Tọa mới một excel WorkBook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = true;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = "Tổng tiền gửi";
            //Tạo tiêu đề 
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "D1");
            head.MergeCells = true;
            head.Value2 = "Thống kê top 5 khách hàng ";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

          
            Microsoft.Office.Interop.Excel.Range r1 = oSheet.get_Range("A2", "D2");
            r1.MergeCells = true;
            r1.Value2 = "Ngày:" + " " + DateTime.Now.ToString("dd/MM/yyyy");
            r1.ColumnWidth = 13.5;
            r1.Font.Italic = true;
            //Tạo tiêu đề cột
            r1.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
          
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã khách hàng";
            cl1.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên khách hàng";
            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Ngày sinh";
            cl3.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "SDT";
            cl4.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Điạ chỉ";
            cl5.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Tổng tiền gửi";
            cl6.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");
            rowHead.Font.Bold = true;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //Tạo mảng Datatable
            object[,] arr = new object[dataGridView_Top5.Rows.Count, dataGridView_Top5.Columns.Count];
            //Chuyển dữ liệu từ Datatable vào mảng đối tượng 
            for (int r = 0; r < dataGridView_Top5.Rows.Count; r++)
            {
                DataGridViewRow dt = dataGridView_Top5.Rows[r];

                for (int c = 0; c < dataGridView_Top5.Columns.Count; c++)
                {
                    arr[r, c] = dt.Cells[c].Value;
                }
            }
            //Thiết lập vùng điền dữ liệu 
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dataGridView_Top5.Rows.Count - 1;
            int columnEnd = dataGridView_Top5.Columns.Count;
            Microsoft.Office.Interop.Excel.Range bd = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[4, 3];
            Microsoft.Office.Interop.Excel.Range kt = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[4 + dataGridView_Top5.Rows.Count - 1, 3];
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(bd, kt);
            range.NumberFormat = "dd/MM/yyyy";

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range1 = oSheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range1.Value2 = arr;
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
        }

        private void dtpmonthReport_ValueChanged(object sender, EventArgs e)
        {
            month = dtpmonthReport.Value.Month.ToString();
            year = dtpmonthReport.Value.Year.ToString();
            FillChart();
            LoadAccountList();
        }
    }
}
