using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.TotalPriceOfCalls
{
    class Call
    {
        /*Call fields*/
        private DateTime data;
        private long? callDuration;
        private string dailedPhone;

        public double? getCallDuration()
        {
            return callDuration;
        }

        /*Call constructor*/
        public Call(long? callDuration, string dailedPhone)
        {
            this.callDuration = callDuration;
            this.dailedPhone = dailedPhone;
            this.data = DateTime.Now;
        }

        
    }
}
