using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Customers
{
    public class Customer : RegexCheck
    {
        private string _idCustomer;
        private string _nameCustomer;
        private string _phoneNumber;
        private string _address;
        public Customer()
        {

        }
        public void Input()
        {
            do
            {
                Console.Write("\n\t\t Nhap ma cua khach hang (VD : KH01): ");
                _idCustomer = Console.ReadLine();
            }
            while (!checkID(_idCustomer));
            do
            {
                Console.Write("\t\t Nhap ten cua khach: ");
                _nameCustomer = Console.ReadLine();
            }
            while (!checkText(_nameCustomer));

           
            do
            {
                Console.Write("\t\t Nhap sdt cua khach: ");
                try
                {
                _phoneNumber = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Vui long nhap so");
                }
            }
            while (_phoneNumber.Length<9 || _phoneNumber.Length>11);
            do
            {
                Console.Write("\t\t Nhap dia chi cua khach: ");
                _address = Console.ReadLine();
            }
            while (!onlyNumberAndLetters(_address));

        }
        public void Output()
        {
            Console.WriteLine("Thong tin khach hang: \n\t\t\tMa khach hang:" + _idCustomer + "\n\t\t\tten khach hang:" + _nameCustomer + "\n\t\t\tDia chi:" + _address + "\n\t\t\tSDT:" + _phoneNumber);

        }
        public void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\t\tMa KH: " + _idCustomer);
            sw.WriteLine("\t\t\tTen KH: " + _nameCustomer);
            sw.WriteLine("\t\t\tDia chi: " + _address);
            sw.WriteLine("\t\t\tSDT: " + _phoneNumber);
            sw.Close();
        }
    }
}
