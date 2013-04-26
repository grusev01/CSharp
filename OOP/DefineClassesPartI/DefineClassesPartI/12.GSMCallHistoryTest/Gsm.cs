using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.GSMCallHistoryTest
{
    public class Gsm
    {

        /*Gsm fields*/
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery1;
        private Display display1;

        private List<Call> callHistory = new List<Call>();

        /* static IPhone4S */
        public static readonly object IPhone4S = new Gsm("Iphone4S", "Apple", 899.99m, "Misho", "BT457986543", 60.0, 8.5, 1, "5", "16177000");
        /**/


        /*Gsm constructors*/
        public Gsm(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public Gsm(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer)
        {
            if (price == null || price < 0m)
            {
                price = 0m;
            }
            this.price = price;
            this.owner = owner;

        }
        public Gsm(string model, string manufacturer, decimal price, string owner, string batteryModel, double hoursIdle, double hoursTalk, int type)
            : this(model, manufacturer, price, owner)
        {
            battery1 = new Battery(batteryModel, hoursIdle, hoursTalk, type);
        }
        public Gsm(string model, string manufacturer, decimal price, string owner, string batteryModel, double hoursIdle, double hoursTalk, int type, string displaySize, string displayColors)
            : this(model, manufacturer, price, owner)
        {
            battery1 = new Battery(batteryModel, hoursIdle, hoursTalk, type);
            display1 = new Display(displaySize, displayColors);
        }
        /**/

        private string phoneInfo()
        {
            return string.Format(new System.Globalization.CultureInfo("bg"), "Model: {0}\r\nManufacturer: {1}\r\nPrice: {2:C}\r\nOwner: {3}\r\n", model, manufacturer, price, owner);
        }

        /* override ToString() */
        public override string ToString()
        {
            if (owner == null)
            {
                return string.Format("Model: {0}\r\nManufacturer: {1}\r\n", model, manufacturer);
            }
            else if (battery1 == null)
            {
                return phoneInfo();
            }
            else if (display1 == null)
            {
                return phoneInfo() + battery1.ToString();
            }
            else
            {
                return phoneInfo() + battery1.ToString() + display1.ToString();
            }
        }
        /**/

        /*Call History Methods*/
        public void addCall(long? callDuration, string dailedPhone)
        {
            callHistory.Add(new Call(callDuration, dailedPhone));
        }
        public void removeCall(int index)
        {
            try
            {
                if (index >= 0 && index < this.callHistory.Count())
                    this.callHistory.RemoveAt(index);
                else
                    throw new IndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of boundaries");
            }
        }
        public void ClearCallsHistory()
        {
            this.callHistory.Clear();
        }
        public decimal? TotalPrice(decimal pricePerMin)
        {
            decimal secndsSum = 0;
            foreach (var item in callHistory)
	            {
		            secndsSum += (decimal)item.getCallDuration();
	            }
            return ((secndsSum / 60) * pricePerMin);
        }
        public void GetCallHistory()
        {
            foreach (var i in this.callHistory)
                Console.WriteLine("Date: {0}\nCall duration in seconds: {1}\nCalled number: {2}\n", i.getDate(), i.getCallDuration(), i.getDailedPhone());
        }
        /**/
    }  

}
