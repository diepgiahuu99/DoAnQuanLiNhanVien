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
        public fThem()
        {
            InitializeComponent();
        }
        private void bXacNhan_Click(object sender, EventArgs e)
        {
            if ((tMSNV.Text == null) || (tHoTenDem.Text == null) || (tTen.Text == null) || (tCMND.Text == null) || (tNgaySinh.Text == null) || (tCongViec.Text == null))
                MessageBox.Show("Thêm thất bại. \n Dữ liệu không được để trống.", "THÔNG BÁO:");
            else
            {
                temp.Nhap(tMSNV.Text, tHoTenDem.Text, tTen.Text, tCMND.Text, tNgaySinh.Text, tCongViec.Text, tLuong.Text);
                MessageBox.Show("Thêm thành công.", "THÔNG BÁO:");
            }
        }
    }
}
