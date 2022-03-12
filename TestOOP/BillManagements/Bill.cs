using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOOP.Customers;
namespace TestOOP.BillManagements
{
    public class Bill : RegexCheck
    {
        private string _billId;
        private Customer customer;
        private List<DetailBill> _bills = new List<DetailBill>();
        private double[] _totalDetailBills;
        private string _date;
        private double _totalBill;
        public int numberOfDetailBills = 0;
        public void Input()
        {

            do
            {
                Console.Write("Ma hoa don gom 3 ki tu tro len (VD : M01):  ");
                _billId = Console.ReadLine();
            }
            while (!checkID(_billId));

            do
            {
                Console.Write("Ngay lap hoa don(dd/mm/yyyy): ");
                _date = Console.ReadLine();
            }
            while (!validate_date(_date));

            Console.Write("Nhap thong tin khach hang : ");
            customer = new Customer();
            customer.Input();

            Console.WriteLine("Nhap danh sach cac chi tiet hoa don ");
            do
            {
                Console.Write("So luong chi tiet trong danh sach cac chi tiet hoa don : ");
                try
                {
                    numberOfDetailBills = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Nhap so nguyen duong");
                }

            }
            while (numberOfDetailBills < 0);

            for (int i = 0; i < numberOfDetailBills; i++)
            {
                Console.WriteLine("Nhap Hoa don thu " + (i + 1));
                DetailBill bill = new DetailBill();
                _totalDetailBills = new double[numberOfDetailBills];
                bill.Input();
                _bills.Add(bill);
                _totalDetailBills[i] = bill.Price();
                _totalBill += bill.Price();
            }
        }
        public void Output()
        {
            Console.WriteLine("Hoa don:\n\t\t\tma hoa don: " + _billId + "\n\t\t\tngay nhap hoa don: " + _date + "\n\t\t\tGia: " + _totalBill);
            customer.Output();
            Console.WriteLine("Danh sach chi tiet cac hoa don: ");
            for (int i = 0; i < numberOfDetailBills; i++)
            {
                _bills[i].Output();
            }
        }
        public void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
            sw.WriteLine("\t\t\tMa HD: " + _billId);
            sw.WriteLine("\t\t\tNggay: " + _date);
            sw.WriteLine("\t\t\tTong gia don: " + _totalBill);
            sw.WriteLine("Thong tin khach hang: ");
            sw.Close();
            customer.OutToText();
            sw = File.AppendText(Environment.CurrentDirectory + @"\danh_sach_hoa_don.txt");
            sw.WriteLine("Danh sach chi tiet cac hoa don");
            sw.Close();
            for (int i = 0; i < numberOfDetailBills; i++)
            {
                _bills[i].OutToText();
            }
        }
    }
}
