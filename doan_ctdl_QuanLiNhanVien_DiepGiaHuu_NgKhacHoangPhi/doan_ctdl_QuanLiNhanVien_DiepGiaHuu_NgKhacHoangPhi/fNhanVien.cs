using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace doan_ctdl_QuanLiNhanVien_DiepGiaHuu_NgKhacHoangPhi
{
    public partial class fNhanVien : Form
    {     
        // Khai báo 
        LinkedList myList = new LinkedList();
        List<string> dsChuoi = new List<string>();
        public int sonv;
        private void fNhanVien_Load()
        {
        }
        public fNhanVien()
        {
            InitializeComponent();
        }
        // Các câu lệnh cho các button
        private void bDanhSach_Click(object sender, EventArgs e)
        {
            //myList.Sort();
            Node xuat1 = myList.Head;
            int m = 1;
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("MSNV", typeof(string));
            dt.Columns.Add("Họ và tên đệm", typeof(string));
            dt.Columns.Add("Tên", typeof(string));
            dt.Columns.Add("CMND", typeof(string));
            dt.Columns.Add("Ngày sinh", typeof(string));
            dt.Columns.Add("Công việc", typeof(string));
            dt.Columns.Add("Lương", typeof(string));
            while (xuat1 != null)
            {
                string msnv = xuat1.info.MSNV; 
                string hotendem = xuat1.info.HoTenDem;
                string ten = xuat1.info.Ten;
                string cmnd = xuat1.info.CMND;
                string ngaysinh = xuat1.info.NgaySinh;
                string congviec = xuat1.info.CongViec;
                string luong = xuat1.info.Luong;
                xuat1 = xuat1.Next;
                DataRow row;
                row = dt.NewRow();
                row["STT"] = m;
                m++;
                row["MSNV"] = msnv;
                row["Họ và tên đệm"] = hotendem;
                row["Tên"] = ten;
                row["CMND"] = cmnd;
                row["Ngày sinh"] = ngaysinh;
                row["Công việc"] = congviec;
                row["Lương"] = luong;
                dt.Rows.Add(row);
            }
            dDanhSachNhanVien.DataSource = dt;
            if (myList.Head == null) MessageBox.Show("Danh sách nhân viên đang rỗng. \nHãy LẤY DỮ LIỆU hoặc THÊM", "THÔNG BÁO:");
            else MessageBox.Show("Xuất thành công.", "THÔNG BÁO:");
        }

        private void bThem_Click(object sender, EventArgs e)
        {
            fThem them = new fThem();
            them.ShowDialog();
            Node p = new Node();
            NHANVIEN NVthem = new NHANVIEN();
            NVthem = them.temp;
            p = myList.Head;
            int kt = 0;
            if (them.ktThem==1)
                MessageBox.Show("Thông tin thêm vào không hợp lệ hoặc đang trống.", "THÔNG BÁO:");
            else
            {
                while (p != null)
                {
                    if (them.temp.MSNV == p.info.MSNV)
                    {
                        kt = 1; //Nếu MSNV bị trùng thì thay đổi biến kt để không thêm vào danh sách liên kết.  
                    }
                    p = p.Next;
                }
                if (kt == 0 && them.temp.MSNV != null)
                {
                    myList.addHead(them.temp);
                    myList.Sort();
                    MessageBox.Show("Thêm nhân viên thành công.", "THÔNG BÁO:");
                }
            }
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            fXoa xoa = new fXoa();
            xoa.ShowDialog();
            int kt = 0;
            Node p = new Node();
            p = myList.Head;
            while (p!=null)
            {
                if (xoa.NVxoa == p.info.MSNV)
                {
                    kt = 1;
                }
                p = p.Next;
            }
            if (kt == 1)
            {
                myList.removeKey(myList, xoa.NVxoa);
                MessageBox.Show("Xóa thành công.", "THÔNG BÁO:");
            }
            else MessageBox.Show("Xóa không thành công. \nNhân viên muốn xóa không tồn tại hoặc bạn chưa nhập MSNV cần xóa", "THÔNG BÁO:");
        }

        private void bTimKiem_Click(object sender, EventArgs e)
        {
            string x = null;
            if (tTimKiem.Text != null)
            {
                x = tTimKiem.Text;
            }
            else MessageBox.Show("Ô tìm kiếm đang trống. \n Hãy nhập thông tin cần tìm.", "THÔNG BÁO:");
            myList.SearchNode(myList, x);
            // Tạo dataTable chứa dữ liệu trong list tìm thấy
            DataTable timkiem = new DataTable();
            DataRow row;
            timkiem.Columns.Add("STT", typeof(int));
            timkiem.Columns.Add("MSNV", typeof(string));
            timkiem.Columns.Add("Họ và tên đệm", typeof(string));
            timkiem.Columns.Add("Tên", typeof(string));
            timkiem.Columns.Add("CMND", typeof(string));
            timkiem.Columns.Add("Ngày sinh", typeof(string));
            timkiem.Columns.Add("Công việc", typeof(string));
            timkiem.Columns.Add("Lương", typeof(string));
            int m = 1;
            timkiem.Clear();
            for (int i = 0; i < myList.found.Count; i++)
            {                
                string msnv = myList.found[i].MSNV;
                string hotendem = myList.found[i].HoTenDem;
                string ten = myList.found[i].Ten;
                string cmnd = myList.found[i].CMND;
                string ngaysinh = myList.found[i].NgaySinh;
                string congviec = myList.found[i].CongViec;
                string luong = myList.found[i].Luong;
                row = timkiem.NewRow();
                row["STT"] = m;
                m++;
                row["MSNV"] = msnv;
                row["Họ và tên đệm"] = hotendem;
                row["Tên"] = ten;
                row["CMND"] = cmnd;
                row["Ngày sinh"] = ngaysinh;
                row["Công việc"] = congviec;
                row["Lương"] = luong;
                timkiem.Rows.Add(row);
            }
            dDanhSachNhanVien.DataSource = timkiem;
            if (myList.found.Count == 0) MessageBox.Show("Không có thông tin tương thích.", "THÔNG BÁO:");
            myList.found.Clear();
        }

        private void bSua_Click(object sender, EventArgs e)
        {
            fSua sua = new fSua();
            sua.ShowDialog();
            int kt = 0;
            Node NVthaydoi = new Node();
            NVthaydoi = myList.Head;
            while (NVthaydoi != null)
            {
                if (NVthaydoi.info.MSNV == sua.msnv)
                {
                    NVthaydoi.info = sua.NVtd;
                    kt = 1;
                }
                NVthaydoi = NVthaydoi.Next;
            }
            if (kt == 1) MessageBox.Show("Thay đổi thông tin nhân viên thành công.", "THÔNG BÁO:");
            else MessageBox.Show("Không tồn tại nhân viên cần thay đổi thông tin", "THÔNG BÁO:");
        }

        private void bLuu_Click(object sender, EventArgs e)
        {
            List<string> dsDong = new List<string>();
            FileStream fs = new FileStream("DanhSachNhanVien.txt", FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            sonv = myList.CountNode(myList);
            sWriter.WriteLine(sonv);
            Node temp = new Node();
            temp = myList.Head;
            while(temp != null)
            {
                string dong = "*"+temp.info.MSNV + "+" + temp.info.HoTenDem + "-" + temp.info.Ten + "<" + temp.info.CMND + ">" + temp.info.NgaySinh + "|" + temp.info.CongViec + "/" + temp.info.Luong;
                dsDong.Add(dong);
                temp = temp.Next;
            }
            for(int i = 0; i<dsDong.Count; i++)
            {
                sWriter.WriteLine(dsDong[i]);
            }
            sWriter.Flush();
            fs.Close();
            MessageBox.Show("Lưu thành công.", "THÔNG BÁO:");
        }

        private void bDoc_Click(object sender, EventArgs e)
        {
            myList.clear(myList); //Xóa hết dữ liệu đã tồn tại trong danh sách liên kết
            StreamReader rd = new StreamReader("DanhSachNhanVien.txt", Encoding.UTF8); //Đọc file text
            if (rd == null) MessageBox.Show("Đọc file không thành công.", "THÔNG BÁO:");
            string x = rd.ReadLine();
            sonv = Convert.ToInt32(x);
            for (int i = 0; i < sonv; i++)
            {
                string x1 = rd.ReadLine();
                dsChuoi.Add(x1);
            }
            for (int j = 0; j < sonv; j++)
            {
                NHANVIEN x2 = new NHANVIEN();
                string thongtin = dsChuoi[j];
                string[] msnv = thongtin.Split('*', '+');
                string[] hotendem = thongtin.Split('+', '-');
                string[] ten = thongtin.Split('-', '<');
                string[] cmnd = thongtin.Split('<', '>');
                string[] ngaysinh = thongtin.Split('>', '|');
                string[] congviec = thongtin.Split('|', '/');
                string[] luong = thongtin.Split('/');
                x2.Nhap(Convert.ToString(msnv[1]), Convert.ToString(hotendem[1]), Convert.ToString(ten[1]), Convert.ToString(cmnd[1]), Convert.ToString(ngaysinh[1]), Convert.ToString(congviec[1]), Convert.ToString(luong[1]));
                myList.addHead(x2);
            }
            myList.Sort();
            if (rd != null) MessageBox.Show("Lấy dữ liệu thành công.", "THÔNG BÁO:");
            rd.Close();
        }
    }
}
