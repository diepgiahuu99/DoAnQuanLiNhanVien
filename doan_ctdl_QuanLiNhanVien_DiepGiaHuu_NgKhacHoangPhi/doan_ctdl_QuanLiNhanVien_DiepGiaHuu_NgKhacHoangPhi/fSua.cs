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
    public partial class fSua : Form
    {
        public string msnv, hotendem, ten, cmnd, ngaysinh, congviec, luong;
        public NHANVIEN NVtd = new NHANVIEN();
        public fSua()
        {
            InitializeComponent();
        }

        private void bXacNhan_Click(object sender, EventArgs e)
        {
            msnv = tMSNV.Text;
            hotendem = tHoTenDem.Text;
            ten = tTen.Text;
            cmnd = tCMND.Text;
            ngaysinh = tNgaySinh.Text;
            congviec = tCongViec.Text;
            luong = tLuong.Text;
            NVtd.Nhap(msnv, hotendem, ten, cmnd, ngaysinh, congviec, luong);
            this.Close();
        }
    }
}
