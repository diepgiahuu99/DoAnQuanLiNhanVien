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
    public partial class fXoa : Form
    {
        public string NVxoa;
        public fXoa()
        {
            InitializeComponent();
        }

        private void bXacNhan_Click(object sender, EventArgs e)
        {
            NVxoa = tMSNV.Text;
            //MessageBox.Show("Hoàn tất.", "THÔNG BÁO:");
            this.Close();
        }
    }
}
