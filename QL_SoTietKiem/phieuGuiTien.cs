using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thong_Tin_Khach_hang
{
    internal class phieuGuiTien
    {

        public string maPhieu { get; set; }
        public string maSoTK { get; set; }

        public string maNV { get; set; }
        public DateTime ngayGui { get; set; }
        public Decimal soTienGui { get; set; }
        public phieuGuiTien() { }
        public phieuGuiTien(string maPhieu, string maSoTK, string maNV, DateTime ngayGui, decimal soTienGui)
        {
            this.maPhieu = maPhieu;
            this.maSoTK = maSoTK;
            this.maNV = maNV;
            this.ngayGui = ngayGui;
            this.soTienGui = soTienGui;
        }



    }
}
