using System;
using System.Collections.Generic;

class SinhVien
{
    public string HoTen { get; set; }
    public string MSSV { get; set; }
    public double DiemTrungBinh { get; set; }

    public void NhapThongTin()
    {
        Console.Write("Nhap ho va ten: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap ma so sinh vien: ");
        MSSV = Console.ReadLine();
        Console.Write("Nhap diem trung binh: ");
        DiemTrungBinh = double.Parse(Console.ReadLine());
    }

    public void HienThiThongTin()
    {
        // Hiển thị điểm với 2 chữ số thập phân
        Console.WriteLine($"Ho ten: {HoTen}, MSSV: {MSSV}, Diem TB: {DiemTrungBinh:F2}");
    }
}

class DanhSachSinhVien
{
    private List<SinhVien> sinhVienList = new List<SinhVien>();

    public void ThemSinhVien(SinhVien sv)
    {
        sinhVienList.Add(sv);
    }

    public void HienThiDanhSach()
    {
        foreach (var sv in sinhVienList)
        {
            sv.HienThiThongTin();
        }
    }

    public SinhVien TimSinhVienTheoMSSV(string mssv)
    {
        return sinhVienList.Find(sv => sv.MSSV.Equals(mssv, StringComparison.OrdinalIgnoreCase));
    }

    public SinhVien TinhDiemTrungBinhCaoNhat()
    {
        SinhVien svMax = null;
        foreach (var sv in sinhVienList)
        {
            if (svMax == null || sv.DiemTrungBinh > svMax.DiemTrungBinh)
            {
                svMax = sv;
            }
        }
        return svMax;
    }
}

class Program
{
    static void Main(string[] args)
    {
        DanhSachSinhVien danhSach = new DanhSachSinhVien();
        int soLuong = 0;

        while (soLuong < 3)
        {
            Console.Write("Nhap so luong sinh vien (toi thieu 3): ");
            soLuong = Convert.ToInt32(Console.ReadLine());

            if (soLuong < 3)
            {
                Console.WriteLine("So luong sinh vien phai lon hon hoac bang 3. Vui long nhap lai.");
            }
        }

        for (int i = 0; i < soLuong; i++)
        {
            Console.WriteLine($"\nNhap thong tin cho sinh vien thu {i + 1}:");
            SinhVien sv = new SinhVien();
            sv.NhapThongTin();
            danhSach.ThemSinhVien(sv);
        }

        Console.WriteLine("\nDanh sach sinh vien da nhap:");
        danhSach.HienThiDanhSach();

        SinhVien svCaoNhat = danhSach.TinhDiemTrungBinhCaoNhat();
        if (svCaoNhat != null)
        {
            Console.WriteLine("\nSinh vien co diem trung binh cao nhat:");
            svCaoNhat.HienThiThongTin();
        }

        Console.Write("\nNhap MSSV de tim kiem: ");
        string mssvTimKiem = Console.ReadLine();
        SinhVien svTimKiem = danhSach.TimSinhVienTheoMSSV(mssvTimKiem);
        if (svTimKiem != null)
        {
            Console.WriteLine("Thong tin sinh vien tim thay:");
            svTimKiem.HienThiThongTin();
        }
        else
        {
            Console.WriteLine("Khong tim thay sinh vien voi MSSV: " + mssvTimKiem);
        }
    }
}