using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestOOP.Product
{
    public  class Device : RegexCheck
    {
        protected string deviceId;
        protected string deviceName;
        protected string deviceOriginal;
        protected double devicePrice;
        protected int amount;
        protected int typeProduct;
        public int TypeProduct { get;set; }
        public int Amount { get;set; }  
        public Device()
        {
            deviceId = "";
            deviceName = "";
            deviceOriginal = "";
        }

        public virtual void Input()
        {
            do
            {
                Console.Write("\t\t Chon loai thiet bi dien: 1-may quat , 2- may lanh):");
                TypeProduct = Convert.ToInt32(Console.ReadLine());
                if (TypeProduct <= 0 || TypeProduct > 2)
                    Console.WriteLine("\t\t Vui long chi nhap 1 hoac 2");
            }
            while (TypeProduct <= 0 || TypeProduct > 2);
        }
        public virtual double Price()
        {
            return 0;
        }
        public virtual void Output()
        {

        }
        public virtual void OutToText()
        {

        }
        
        
    }
}
