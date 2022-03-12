using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Product.AirConditioners.cs
{
    public class AirConditioner : Device
    {
        protected int typeAirConditioner;
        protected int inverter;
        
        public int TypeAirConditioner { get;set; }
        public override void Input()
        {
            do
            {
                Console.Write("\t\t Chon loai may lanh: 1-may lanh 1 chieu , 2- may lanh 2 chieu):");
                TypeAirConditioner = Convert.ToInt32(Console.ReadLine());
                if (TypeAirConditioner <= 0 || TypeAirConditioner > 2)
                    Console.WriteLine("\t\t Vui long chi nhap 1 hoac 2");
            }
            while (TypeAirConditioner <= 0 || TypeAirConditioner > 2);
        }

    }
}
