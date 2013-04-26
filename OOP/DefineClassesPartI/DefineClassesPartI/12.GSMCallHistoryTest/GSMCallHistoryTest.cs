using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.GSMCallHistoryTest
{
    class GSMCallHistoryTest
    {
        static void Main(string[] args)
        {
            Gsm gsm1 = new Gsm("Nokia 3333", "Nokia Company", 1350.0m, "Misho", "BT6843756", 90.0, 8.0, 2, "4", "16177000");
            
            /*add calss to history*/
            gsm1.addCall(120, "+359456780678");
            gsm1.addCall(20, "+359456345067");
            gsm1.addCall(30, "+359658676875");
            gsm1.addCall(10, "+359876532356");

            /*display info for calls*/
            gsm1.GetCallHistory();

            /*display total price*/
            Console.WriteLine(string.Format(new System.Globalization.CultureInfo("bg"),"{0:C}", gsm1.TotalPrice(0.37m)));
            
            /*remove longest call*/
            gsm1.removeCall(0);

            /*display total price*/
            Console.WriteLine(string.Format(new System.Globalization.CultureInfo("bg"), "{0:C}", gsm1.TotalPrice(0.37m)));
            
            /*clear call history*/
            gsm1.ClearCallsHistory();

            /*display info for calls null*/
            gsm1.GetCallHistory();
        }
    }
}
