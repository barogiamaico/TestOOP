using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Product.Fans
{
    public class SteamFan : Fan
    {
        private double _liter;

        public override void Input()
        {
            do
            {
                Console.Write("\t\t\tNhap ma 3-10 ki tu gom so hoac chu (VD: E01): ");
                deviceId = Console.ReadLine();
            }
            while (!checkID(deviceId));

            do
            {
                Console.Write("\t\t\t Ten san Pham: ");
                deviceName = Console.ReadLine();
            } while (!checkText(deviceName));
            do
            {
                Console.Write("\t\t\t Noi san xuat: ");
                deviceOriginal = Console.ReadLine();
            } while (!onlyNumberAndLetters(deviceOriginal));

            do
            {
                Console.Write("\t\t\t Nhap lit nuoc: ");
                _liter = double.Parse(Console.ReadLine());
            } while (_liter <= 0);
            do
            {
                Console.Write("\t\t\t So luong ban ra: ");
                try
                {
                    Amount = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Nhap so nguyen duong");
                }
            } while (Amount <= 0);
        }
        public override double Price()
        {
            devicePrice = _liter * 400;
            return devicePrice;
        }
        public override void Output()
        {
            Console.WriteLine("\t\t\t may quat co \n\t\t\tma san pham: " + deviceId + "\n\t\t\t quat hoi nuoc" 
                + "\n\t\t\t" + "\n\t\t\tTen: " + deviceName + "\n\t\t\t gia: " + devicePrice.ToString() + "\n\t\t\tSo luong " + Amount.ToString());
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\t\tQuat hoi nuoc");
            sw.WriteLine("\t\t\tNhap ma: " + deviceId);
            sw.WriteLine("\t\t\tTen sp: " + deviceName);
            sw.WriteLine("\t\t\tNoi sx: " + deviceOriginal);
            sw.WriteLine("\t\t\tDung tich nuoc: " + _liter);
            sw.WriteLine("\t\t\tDon gia: " + devicePrice);
            sw.WriteLine("\t\t\tSl ban ra: " + Amount);
            sw.Close();
        }
    }
}
