using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOOP.Product;
using TestOOP.Product.AirConditioners.cs;
using TestOOP.Product.Fans;

namespace TestOOP.BillManagements
{
    public class DetailBill
    {
        private Device _product;
        private int _amount;

        public void Input()
        {
            _product = new Device();
            _product.Input();
            if (_product.TypeProduct == 2) // may lanh
            {
                AirConditioner aircon = new AirConditioner();
                aircon.Input();
                if (aircon.TypeAirConditioner == 1) //may lanh 1 chieu
                {
                    OneWayAirConditioner oneway = new OneWayAirConditioner();
                    oneway.Input(); //nhap thong tin ve may lanh 1 chieu
                    _product = oneway;
                    _amount = oneway.Amount;
                }
                else //may lanh 2 chieu
                {
                    TwoWayAirConditioner twoway = new TwoWayAirConditioner();
                    twoway.Input();
                    _product = twoway;
                    _amount = twoway.Amount;
                }
            }
            else if (_product.TypeProduct == 1)//may quat
            {
                Fan fan = new Fan();
                fan.Input();
                if (fan.typeFan == 1) //quat dung
                {
                    StandFan standFan = new StandFan();
                    standFan.Input();
                    _product = standFan;
                    _amount = standFan.Amount;
                }
                else if (fan.typeFan == 2) //quat hoi nuoc
                {
                    ElectricFan electricFan = new ElectricFan();
                    electricFan.Input();
                    _product = electricFan;
                    _amount = electricFan.Amount;
                }
                else //quat dien
                {
                    SteamFan steamFan = new SteamFan();
                    steamFan.Input();
                    _product = steamFan;
                    _amount = steamFan.Amount;
                }
            }

        }
        public void Output()
        {
            if (_product != null)
                _product.Output();
        }
        public double Price()
        {
            return _product.Price() * _amount;
        }
        public void OutToText()
        {
            StreamWriter sw = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\danh_sach_hoa_don.txt");
            sw.Close();
            _product.OutToText();

        }
    }
}
