using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Product.AirConditioners.cs
{
    public class OneWayAirConditioner : AirConditioner
    {
        public override void Input()
        {
            do
            {
                Console.Write("\t\t\tNhap ma 3-10 ki tu gom so hoac chu (VD: A01): ");
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
                Console.Write("\t\t\t Lua chon inverter(1- Co, 0- Khong): ");
                try
                {
                    inverter = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tVui long chi chon 1 hoac 2");
                }
            } while (inverter <0 || inverter >= 2);
            do
            {
                Console.Write("\t\t\tSo luong ban ra: ");
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
            if (inverter == 0)
                devicePrice = 1000;
            else if (inverter == 1)
                devicePrice = 1500;

            return devicePrice;
        }
        public override void Output()
        {
            if (inverter == 1)
            {
                Console.WriteLine("\t\t\t may lanh: \n\t\t\tma san pham: " + deviceId + "\n\t\t\t may lanh 1 chieu" + "\n\t\t\tco inverter" + "\n\t\t\tTen: " + deviceName + "\n\t\t\t gia: " + devicePrice.ToString() + "\n\t\t\tSo luong " + Amount.ToString());
            }
            else
            {
                Console.WriteLine("\t\t\t may lanh: \n\t\t\tma san pham: " + deviceId + "\n\t\t\t may lanh 1 chieu" + "\n\t\t\tKhong co inverter" + "\n\t\t\tTen: " + deviceName + "\n\t\t\t gia: " + devicePrice.ToString() + "\n\t\t\tSo luong " + Amount.ToString());

            }
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\t\tMay lanh 2 chieu");
            sw.WriteLine("\t\t\tNhap ma: " + deviceId);
            sw.WriteLine("\t\t\tTen sp: " + deviceName);
            sw.WriteLine("\t\t\tNoi sx: " + deviceOriginal);
            if (inverter == 0) sw.WriteLine("\t\t\tCo inverter "); else sw.WriteLine("\t\t\tkhong Co inverter  ");
            sw.WriteLine("\t\t\tDon gia: " + devicePrice);
            sw.WriteLine("\t\t\tSl ban ra: " + Amount);
            sw.Close();
        }
    }
}
