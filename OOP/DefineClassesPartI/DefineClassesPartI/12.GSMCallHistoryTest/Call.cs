using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.GSMCallHistoryTest
{
    class Call
    {
        /*Call fields*/
        private DateTime data;
        private long? callDuration;
        private string dailedPhone;

        public DateTime getDate()
        {
            return data;
        }
        public double? getCallDuration()
        {
            return callDuration;
        }
        public string getDailedPhone()
        {
            return dailedPhone;
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
