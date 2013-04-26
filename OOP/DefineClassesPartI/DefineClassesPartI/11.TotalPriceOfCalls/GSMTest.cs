using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.TotalPriceOfCalls
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            /*Create Gsm-s */
            Gsm gsm1 = new Gsm("Samsung S5830", "Samsung Co");
            Gsm gsm2 = new Gsm("Nokia 555", "Nokia Company", 450.0m, "Pesho");
            Gsm gsm3 = new Gsm("Nokia 999", "Nokia Company", 950.0m, "Ivan", "BT684327", 82.0, 6.0, 1);
            Gsm gsm4 = new Gsm("Nokia 3333", "Nokia Company", 1350.0m, "Misho", "BT6843756", 90.0, 8.0, 2, "4", "16177000");

            Gsm[] gsms = { gsm1, gsm2, gsm3, gsm4 };

            /*Prints Gsm-s info*/
            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm.ToString());
            }

            /*Prints static IPhone4S info*/
            Console.WriteLine(Gsm.IPhone4S.ToString());
        }
    }
}
