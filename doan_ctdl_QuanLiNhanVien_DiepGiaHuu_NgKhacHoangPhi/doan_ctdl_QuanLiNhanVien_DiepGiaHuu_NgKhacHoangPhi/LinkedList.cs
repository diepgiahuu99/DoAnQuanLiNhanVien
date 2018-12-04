using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace doan_ctdl_QuanLiNhanVien_DiepGiaHuu_NgKhacHoangPhi
{

    //khai bóa nút
    public class Node
    {
        public NHANVIEN info;
        public Node Next;
        // Hàm khởi tạo
        public Node()
        {
        }
        public Node(NHANVIEN x, Node next)
        {
            this.info = x;
            this.Next = next;
        }
        // Tạo Node chứa dữ liệu
        public Node CreateNode(NHANVIEN x)
        {
            Node p = new Node();
            p.info = new NHANVIEN();
            p.info.MSNV = x.MSNV;
            p.info.HoTenDem = x.HoTenDem;
            p.info.Ten = x.Ten;
            p.info.CMND = x.CMND;
            p.info.NgaySinh = x.NgaySinh;
            p.info.CongViec = x.CongViec;
            p.info.Luong = x.Luong;
            p.Next = null;
            if (p.info == null)
            {
               return null;
            }
            return p;
        }
    }
    public class NHANVIEN
    {
        public string MSNV;
        public string HoTenDem;
        public string Ten;
        public string CMND;
        public string NgaySinh;
        public string CongViec;
        public string Luong;
        // Hàm khởi tạo
        public NHANVIEN()
        {
        }
        // Hàm nhập 
        public void Nhap(string msnv, string hotendem, string ten, string cmnd, string ngaysinh, string congviec, string luong)
        {
            this.MSNV = msnv;
            this.HoTenDem = hotendem;
            this.Ten = ten;
            this.CMND = cmnd;
            this.NgaySinh = ngaysinh;
            this.CongViec = congviec;
            this.Luong = luong;
        }
    }
    public class LinkedList
    {
        // Khai báo
        public Node Head;
        public Node Tail;
        public List<NHANVIEN> found = new List<NHANVIEN>(); //Danh sách kiểu NHANVIEN để chứa những nhân viên thỏa điều kiện tìm
        // Hàm khởi tạo
        public LinkedList()
        {
            Head = Tail = null;
        }
        // Hàm kiểm tra danh sách liên kết có rỗng hay không
        public int IsEmptyList()
        {
            if (this.Head == null)
                return 1;               // Danh sách rỗng
            return 0;                   // Danh sách không rỗng
        }
        // Thêm vào cuối danh sách
        public void addTail(NHANVIEN x)
        {
            Node p = new Node(x, null);
            if (this.Head == null)
                this.Head = this.Tail = p;
            else
            {
                this.Tail.Next = p;
                this.Tail = p;
            }
        }
        //Thêm vào đầu danh sách      
        public void addHead(NHANVIEN x)
        {
            Node p = new Node(x, Head);
            Head = p;
            if (Tail == null)
                Tail = Head;
        }
        // Tìm kiếm và đưa những nhân viên thỏa thông tin tìm vào danh sách found
        public void SearchNode(LinkedList myList, string x)
        {
            Node p = myList.Head;
            while (p!=null)
            {
                NHANVIEN temp = new NHANVIEN(); //Biến nhớ kiểu sinh viên để đưa vào list
                if ((x == p.info.MSNV)|| (x == p.info.HoTenDem) || (x == p.info.Ten) || (x == p.info.CMND) || (x == p.info.NgaySinh) || (x == p.info.CongViec) || (x == p.info.Luong))
                {
                    temp.Nhap(p.info.MSNV, p.info.HoTenDem, p.info.Ten, p.info.CMND, p.info.NgaySinh, p.info.CongViec, p.info.Luong);
                    found.Add(temp);
                }
                p = p.Next;
            }
        }
        // Xóa phần tử đầu
        public void removeHead(LinkedList myList)
        {
            if (myList.Head == null)
            {
            }
            else if (myList.Head == myList.Tail)
            {
                myList.Head = null;
                myList.Head = myList.Tail = null;
            }
            else
            {
                Node temp = new Node();
                temp = myList.Head;
                myList.Head = myList.Head.Next;
                temp = null;
            }
        }
        // Xóa nút phía sau
        public void removeAfter(LinkedList myList, Node node)
        {
            if (myList.Head == null)
            { }
            else
            {
                Node temp = new Node();
                temp = node.Next;
                if (temp != null)
                {
                    node.Next = temp.Next;
                    temp = null;
                }
            }
        }
        // Xóa nút có giá trị cần xóa
        public void removeKey(LinkedList myList, string x)
        {
            if (myList.Head == null)
            { }
            else
            {
                Node result = new Node();
                result = myList.Head;
                Node before = new Node();
                before = null;
                while (result.info.MSNV != x)
                {
                    before = result;
                    result = result.Next;
                }
                if (result != null)
                {
                    if (result == myList.Head)
                        removeHead(myList);
                    else
                        removeAfter(myList, before);
                }
            }
        }
        // Đếm node
        public int CountNode(LinkedList myList)
        {
            int dem = 0;
            Node p = new Node();
            p = myList.Head;
            while (p!=null)
            {
                dem++;
                p = p.Next;
            }
            return dem;
        }
        // Hàm hủy danh sách liên kết
        public void clear(LinkedList myList)
        {
            Node temp = new Node();
            temp = myList.Head;
            while (temp != null)
            {
                myList.removeHead(myList);
                temp = temp.Next;
            }
        }
        //Sắp xếp theo MSNV
        public void Sort()
        {
            LinkedList lnv1 = new LinkedList();
            LinkedList lnv2 = new LinkedList();
            Node pivot, p;
            if (Head == Tail)
                return;
            pivot = Head;
            p = Head.Next;
            string[] msnvPivot = pivot.info.MSNV.Split('V');
            while (p != null)
            {
                Node q = p;
                p = p.Next;
                q.Next = null;
                string[] msnvQ = q.info.MSNV.Split('V');
                if (Convert.ToInt32(msnvQ[1]) < Convert.ToInt32(msnvPivot[1]))
                    lnv1.addTail(q.info);
                else
                    lnv2.addTail(q.info);
            };
            lnv1.Sort();
            lnv2.Sort();
            if (lnv1.IsEmptyList() == 0)
            {
                this.Head = lnv1.Head;
                lnv1.Tail.Next = pivot;
            }
            else
                this.Head = pivot;
            pivot.Next = lnv2.Head;
            if (lnv2.IsEmptyList() == 0)
                this.Tail = lnv2.Tail;
            else
                this.Tail = pivot;
        }
    }
}

