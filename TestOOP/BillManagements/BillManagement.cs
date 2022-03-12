using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.BillManagements
{
    public class BillManagement
    {
        private int _amountOfBills;
        private List<Bill> _billsList = new List<Bill>();
        public void Input()
        {
            do
            {
                try
                {
                    Console.Write("So luong hoa don muon nhap: ");
                    _amountOfBills = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Nhap so nguyen duong");
                }

            }
            while (_amountOfBills <= 0);

            for (int i = 0; i < _amountOfBills; i++)
            {
                Bill bill = new Bill();
                bill.Input();
                _billsList.Add(bill);
            }
        }
        public void Output()
        {
            for (int i = 0; i < _billsList.Count; i++)
                _billsList[i].Output();
        }
        public void OutToText()
        {
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt", "");

            for (int i = 0; i < _amountOfBills; i++)
            {
                StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
                sw.WriteLine("Hóa đơn " + (i + 1) + ": ");
                sw.Close();
                _billsList[i].OutToText();
            }
        }
    }
}
