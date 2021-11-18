using System;
using System.Collections.Generic;
using System.Text;
namespace  QLnhanvien

{
    class NhanSu
    {
        protected string maso;
        protected string ten;
        protected string gioiTinh;
        protected string ngaySinh;  
    }
    class NhanVien : NhanSu
    {
        private string bangCap;
        public string Ma { get => maso; set => maso = value; }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string BangCap { get => bangCap; set => bangCap = value; }

        public NhanVien(string manv, string hoten, string gioitinh, string ngaysinh, string bangcap)
        {
            maso = manv;
            ten = hoten;
            gioiTinh = gioitinh;
            ngaySinh = ngaysinh;
            bangCap = bangcap;
        }
        public void info()
        {
            Console.WriteLine("\n******Nhan vien {0}******",maso);
            Console.WriteLine(" Ho Ten: " + ten);
            Console.WriteLine(" Gioi tinh: " + gioiTinh);
            Console.WriteLine(" Ngay sinh: " + ngaySinh);
            Console.WriteLine(" Bang cap: " + bangCap);
            Console.WriteLine("****************************\n");
        }
    }
    class KhachHang : NhanSu
    {
        private string loaiKH = "Moi";
        public string Ma { get => maso; set => maso = value; }
        public string Ten { get => ten; set => ten = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string LoaiKH { get => loaiKH; set => loaiKH = value; }
        public KhachHang(string manv, string hoten, string gioitinh, string ngaysinh, string loaikh)
        {
            maso = manv;
            ten = hoten;
            gioiTinh = gioitinh;
            ngaySinh = ngaysinh;
            loaiKH = loaikh;
        }
        public KhachHang(string manv, string hoten, string gioitinh, string ngaysinh)
        {
            maso = manv;
            ten = hoten;
            gioiTinh = gioitinh;
            ngaySinh = ngaysinh;
        }
        public void info()
        {
            Console.WriteLine("\n******Nhan vien {0}******", maso);
            Console.WriteLine(" Ho Ten: " + ten);
            Console.WriteLine(" Gioi tinh: " + gioiTinh);
            Console.WriteLine(" Ngay sinh: " + ngaySinh);
            Console.WriteLine(" Loai khach hang: " + loaiKH);
            Console.WriteLine("****************************\n");
        }
    }
}
