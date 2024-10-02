using System;

namespace ProductManagement
{
    // Lop tru tuong Product
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public abstract void DisplayProductInfo();
        public abstract void ApplyDiscount(decimal percentage);
    }

    // Giao dien ISellable
    public interface ISellable
    {
        void Sell(int quantity);
        bool IsInStock();
    }

    // Lop MobilePhone ke thua tu Product va trien khai ISellable
    public class MobilePhone : Product, ISellable
    {
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Ten san pham: {Name}, Gia: {Price:C}, Ton kho: {Stock}");
        }

        public override void ApplyDiscount(decimal percentage)
        {
            Price -= Price * percentage / 100;
        }

        public void Sell(int quantity)
        {
            if (IsInStock() && quantity <= Stock)
            {
                Stock -= quantity;
                Console.WriteLine($"Da ban {quantity} dien thoai {Name}.");
            }
            else
            {
                Console.WriteLine("Khong du hang trong kho.");
            }
        }

        public bool IsInStock()
        {
            return Stock > 0;
        }
    }

    // Lop Laptop ke thua tu Product va trien khai ISellable
    public class Laptop : Product, ISellable
    {
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Ten san pham: {Name}, Gia: {Price:C}, Ton kho: {Stock}");
        }

        public override void ApplyDiscount(decimal percentage)
        {
            Price -= Price * percentage / 100;
        }

        public void Sell(int quantity)
        {
            if (IsInStock() && quantity <= Stock)
            {
                Stock -= quantity;
                Console.WriteLine($"Da ban {quantity} laptop {Name}.");
            }
            else
            {
                Console.WriteLine("Khong du hang trong kho.");
            }
        }

        public bool IsInStock()
        {
            return Stock > 0;
        }
    }

    // Lop Accessory ke thua tu Product va trien khai ISellable
    public class Accessory : Product, ISellable
    {
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Ten san pham: {Name}, Gia: {Price:C}, Ton kho: {Stock}");
        }

        public override void ApplyDiscount(decimal percentage)
        {
            Price -= Price * percentage / 100;
        }

        public void Sell(int quantity)
        {
            if (IsInStock() && quantity <= Stock)
            {
                Stock -= quantity;
                Console.WriteLine($"Da ban {quantity} phu kien {Name}.");
            }
            else
            {
                Console.WriteLine("Khong du hang trong kho.");
            }
        }

        public bool IsInStock()
        {
            return Stock > 0;
        }
    }

    // Chuong trinh chinh
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone phone = new MobilePhone { Name = "iPhone 14", Price = 999.99m, Stock = 10 };
            Laptop laptop = new Laptop { Name = "Dell XPS 13", Price = 1299.99m, Stock = 5 };
            Accessory accessory = new Accessory { Name = "Tai nghe Bluetooth", Price = 199.99m, Stock = 20 };

            // Hien thi thong tin san pham
            phone.DisplayProductInfo();
            laptop.DisplayProductInfo();
            accessory.DisplayProductInfo();

            // Thuc hien ban hang
            phone.Sell(2);
            laptop.Sell(1);
            accessory.Sell(5);

            // Kiem tra ton kho
            Console.WriteLine($"Ton kho dien thoai: {phone.Stock}");
            Console.WriteLine($"Ton kho laptop: {laptop.Stock}");
            Console.WriteLine($"Ton kho phu kien: {accessory.Stock}");

            // Ap dung giam gia
            phone.ApplyDiscount(10);
            laptop.ApplyDiscount(15);
            accessory.ApplyDiscount(5);

            // Hien thi thong tin sau khi giam gia
            phone.DisplayProductInfo();
            laptop.DisplayProductInfo();
            accessory.DisplayProductInfo();
        }
    }
}
