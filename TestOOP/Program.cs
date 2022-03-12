using System;
using TestOOP.Product;
using TestOOP.Product.AirConditioners.cs;
using TestOOP.BillManagements;

namespace TestOOP
{
    public class Program
    {
        public static void Menu()
        {
            Console.WriteLine("1. Nhap thong tin hoa don.                    ");
            Console.WriteLine("2. Xuat thong tin hoa don.                    ");
            Console.WriteLine("3. Luu thong tin hoa don thanh file text o Dekstop.     ");
            Console.WriteLine("4. Thoat.                                     ");
        }
        static void Main(string[] args)
        {
            Menu();
            BillManagement bills = new BillManagement();
            int option=0;
            int count = 0;
            bool[] options = new bool[3];
            while (true)
            {
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("vui long nhap so tu 1-4");
                }
                switch(option)
                {
                    case 1:
                        options[0] = true;
                        bills.Input();
                        Console.WriteLine("chon tiep");
                        count++;
                            break;
                    case 2:
                        options[1] = true;
                        if (options[0])
                            bills.Output();
                        else Console.WriteLine("Chua nhap du lieu");
                        Console.WriteLine("chon tiep");
                        count++;
                        break;
                    case 3:
                        if (options[0] && options[1])
                        {
                            bills.OutToText();
                            Console.WriteLine("Da ghi xuong desktop");
                        }
                        else Console.WriteLine("Chua nhap du lieu");
                        Console.WriteLine("chon tiep");
                        count++;
                        break;
                    case 4:
                        return;

                    default:
                        return;
                }
                if (count == 3)
                {
                    Console.Clear();
                    Menu();
                    count = 0;
                }

            }
              
        }
    }
}
