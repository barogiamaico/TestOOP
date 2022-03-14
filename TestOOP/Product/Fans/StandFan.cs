﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Product.Fans
{
    public class StandFan : Fan
    {
        public override void Input()
        {
            do
            {
                Console.Write("\t\t\tNhap ma 3-10 ki tu gom so hoac chu (VD: D01): ");
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
            devicePrice = 500;
            return devicePrice;
        }
        public override void Output()
        {
            Console.WriteLine("\t\t\t may quat dung \n\t\t\tma san pham: " + deviceId + "\n\t\t\t quat dung" + "\n\t\t\t" + "\n\t\t\tTen: " + deviceName + "\n\t\t\t gia: " + devicePrice.ToString() + "\n\t\tSo luong " + Amount.ToString());
        }
        public override void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\t\tQuat dung");
            sw.WriteLine("\t\t\tNhap ma: " + deviceId);
            sw.WriteLine("\t\t\tTen sp: " + deviceName);
            sw.WriteLine("\t\t\tNoi sx: " + deviceOriginal);
            sw.WriteLine("\t\t\tDon gia: " + devicePrice);
            sw.WriteLine("\t\tSl ban ra: " + Amount);
            sw.Close();
        }
    }
}
