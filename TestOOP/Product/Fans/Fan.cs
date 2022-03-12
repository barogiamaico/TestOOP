using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Product.Fans
{
    public class Fan : Device
    {
        public int typeFan;
        
        public override void Input()
        {
            while (typeFan<=0 || typeFan > 3)
            {
                Console.Write("\t\t\tChon loai quay (1- quat dung, 2- quat hoi nc , 3- quat dien):");
                try
                {
                    typeFan = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\t\t\tVui long chi nhap 1,2 va 3");
                }
            }
        }

    }
}
