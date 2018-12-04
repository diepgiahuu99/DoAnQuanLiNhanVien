using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan_ctdl_QuanLiNhanVien_DiepGiaHuu_NgKhacHoangPhi
{
    public partial class fThem : Form
    {
        public NHANVIEN temp = new NHANVIEN();
        public int ktThem = 0;
        public fThem()
        {
            InitializeComponent();
        }
        private void bXacNhan_Click(object sender, EventArgs e)
        {
            if (tMSNV.Text.CompareTo("") == 0) ktThem = 1;
            else
                temp.Nhap(tMSNV.Text, tHoTenDem.Text, tTen.Text, tCMND.Text, tNgaySinh.Text, tCongViec.Text, tLuong.Text);
            this.Close();
        }
    }
}
