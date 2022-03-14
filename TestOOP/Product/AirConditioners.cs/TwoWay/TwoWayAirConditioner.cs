using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Product.AirConditioners.cs
{
    public class TwoWayAirConditioner : AirConditioner
    {
        private int _antiSmell;
        private int _antiMicro;

        public override void Input()
        {
            do
            {
                Console.Write("\t\t\tNhap ma 3-10 ki tu gom so hoac chu (VD: B01): ");
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
                    Console.WriteLine("\t\t\tVui long chi chon 1 hoac 0");
                }
            } while (inverter <0 || inverter >= 2);
            while (_antiSmell < 0 || _antiSmell >= 2)
            {
                Console.Write("\t\t\tCông nghệ khử mùi(1- Có, 0- Không):");
                try
                {
                    _antiSmell = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tChỉ nhập 1 hoặc 0");
                }
            }
            while (_antiMicro < 0 || _antiMicro >= 2)
            {
                Console.Write("\t\t\tCong nghe khang khuan(1- Có, 0- Không):");
                try
                {
                    _antiMicro = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tChỉ nhập 1 hoặc 0");
                }
            }
            do
            {
                Console.Write("\t\t So luong ban ra: ");
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
                devicePrice = 2000;
            else if (inverter == 1)
                devicePrice = 2500;

            if (_antiMicro == 1)
                devicePrice += 500;
            if (_antiSmell ==1)
                devicePrice += 500;

            return devicePrice;
        }
        public override void Output()
        {
            if (inverter == 1) { 
                if (_antiSmell == 1 && _antiMicro == 1)
                    Console.WriteLine("\t\t\tmay lanh: \n\t\t\tma san pham: " + deviceId + "\n\t\t\t may lanh 2 chieu" + "\n\t\t\tco inverter, co khu mui va co khang khuan" + "\n\t\t\tTen: " + deviceName + "\n\t\t\t gia: " + devicePrice.ToString() + "\n\t\tSo luong " + Amount.ToString());
                else if (_antiSmell == 1 && _antiMicro == 0)
                    Console.WriteLine("\t\t\tmay lanh: \n\t\t\tma san pham: " + deviceId + "\n\t\t\t may lanh 2 chieu" + "\n\t\t\tco inverter, co khu mui va khong co khang khuan" + "\n\t\t\tTen: " + deviceName + "\n\t\t\t gia: " + devicePrice.ToString() + "\n\t\tSo luong " + Amount.ToString());
                else if (_antiSmell == 0 && _antiMicro == 1)
                    Console.WriteLine("\t\t\tmay lanh: \n\t\t\tma san pham: " + deviceId + "\n\t\t\t may lanh 2 chieu" + "\n\t\t\tco inverter,khong co khu mui va co khang khuan" + "\n\t\t\tTen: " + deviceName + "\n\t\t\t gia: " + devicePrice.ToString() + "\n\t\tSo luong " + Amount.ToString());
                else Console.WriteLine("\t\t\tmay lanh: \n\t\t\tma san pham: " + deviceId + "\n\t\t\t may lanh 2 chieu" + "\n\t\t\tco inverter,khong co khu mui va khong co khang khuan" + "\n\t\t\tTen: " + deviceName + "\n\t\t\t gia: " + devicePrice.ToString() + "\n\t\tSo luong " + Amount.ToString());
            }
            else
            {
                if (_antiSmell == 1 && _antiMicro == 1)
                    Console.WriteLine("\t\t may lanh: \n\t\t\tma san pham: " + deviceId + "\n\t\t\t may lanh 2 chieu" + "\n\t\t\tkhong co inverter, co khu mui va co khang khuan" + "\n\t\t\tTen: " + deviceName + "\n\t\t\t gia: " + devicePrice.ToString() + "\n\t\tSo luong " + Amount.ToString());
                else if (_antiSmell == 1 && _antiMicro == 0)
                    Console.WriteLine("\t\t may lanh: \n\t\t\tma san pham: " + deviceId + "\n\t\t\t may lanh 2 chieu" + "\n\t\t\tkhong co inverter, co khu mui va khong co khang khuan" + "\n\t\t\tTen: " + deviceName + "\n\t\t\t gia: " + devicePrice.ToString() + "\n\t\tSo luong " + Amount.ToString());
                else if (_antiSmell == 0 && _antiMicro == 1)
                    Console.WriteLine("\t\t may lanh: \n\t\t\tma san pham: " + deviceId + "\n\t\t\t may lanh 2 chieu" + "\n\t\t\tkhong co inverter,khong co khu mui va co khang khuan" + "\n\t\t\tTen: " + deviceName + "\n\t\t\t gia: " + devicePrice.ToString() + "\n\t\tSo luong " + Amount.ToString());
                else Console.WriteLine("\t\t may lanh: \n\t\t\tma san pham: " + deviceId + "\n\t\t\t may lanh 2 chieu" + "\n\t\t\tkhong co inverter,khong co khu mui va khong co khang khuan" + "\n\t\t\tTen: " + deviceName + "\n\t\t\t gia: " + devicePrice.ToString() + "\n\t\tSo luong " + Amount.ToString());
            }

            
            
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\tMay lanh 2 chieu");
            sw.WriteLine("\t\t\tNhap ma: " + deviceId);
            sw.WriteLine("\t\t\tTen sp: " + deviceName);
            sw.WriteLine("\t\t\tNoi sx: " + deviceOriginal);
            if (_antiSmell == 1) sw.WriteLine("\t\t\tChong mui "); else sw.WriteLine("\t\t\tkhong Chong mui ");
            if (_antiMicro == 1) sw.WriteLine("\t\t\tChong khuan "); else sw.WriteLine("\t\t\tkhong Chong khuan ");
            if (inverter == 1) sw.WriteLine("\t\t\tCo inverter "); else sw.WriteLine("\t\t\tkhong Co inverter  ");

            sw.WriteLine("\t\t\tDon gia: " + devicePrice);
            sw.WriteLine("\t\tSl ban ra: " + Amount);
            sw.Close();
        }

    }
}
