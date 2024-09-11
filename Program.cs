using System;
using System.Linq;

class BaiTap
{
    // Bài 1: Tạo mảng số nguyên và tính tổng
    public void Bai1()
    {
        Console.Write("Nhap so luong phan tu cua mang la: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu  {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
            sum += arr[i];
        }

        Console.WriteLine($"Tong cac phan tu trong mang la: {sum}");
    }

    // Bài 2: Đếm số lượng ký tự trong chuỗi
    public void Bai2()
    {
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        int count = 0;

        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                count++;
            }
        }

        Console.WriteLine($"So luong ki tu trong chuoi khong tinh dau cau vaf khoang trong la: {count}");
    }

    // Bài 3: Tìm phần tử lớn nhất trong mảng
    public void Bai3()
    {
        Console.Write("Nhap so luong phan tu trong mang la: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu  {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr.Max();
        Console.WriteLine($"Phan tu lon nhat trong mang la:  {max}");
    }

    // Bài 4: Đảo ngược chuỗi
    public void Bai4()
    {
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        Console.WriteLine($"Chuoi dao nguoc la: {reversed}");
    }

    // Bài 5: Kiểm tra mảng đối xứng
    public void Bai5()
    {
        Console.Write("Nhap so luong phan tu trong mang la: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu  {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        bool isPalindrome = true;
        for (int i = 0; i < n / 2; i++)
        {
            if (arr[i] != arr[n - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Mang la doi xung");
        }
        else
        {
            Console.WriteLine("Mang khong phai doi xung");
        }
    }

    // Bài 6: Đếm số lần xuất hiện của một ký tự trong chuỗi
    public void Bai6()
    {
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        Console.Write("Nhap ki tu can dem: ");
        char ch = Console.ReadLine()[0];
        int count = 0;

        foreach (char c in input)
        {
            if (c == ch)
            {
                count++;
            }
        }

        Console.WriteLine($"So lan xuat hien cua ki tu '{ch}' trong chuoi: {count}");
    }

    // Main
    static void Main(string[] args)
    {
        BaiTap bt = new BaiTap();

        bt.Bai1();
        bt.Bai2();
        bt.Bai3();
        bt.Bai4();
        bt.Bai5();
        bt.Bai6();
    }
}
