using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.TotalPriceOfCalls
{
    public class Battery
    {


        /*battery fields*/
        private string batteryModel;
        private double? hoursIdle = null;
        private double? hoursTalk = null;
        private BatteryType? batType = null;
        /**/

        /*Battery constructors*/
        public Battery(string batteryModel)
        {
            this.batteryModel = batteryModel;
        }
        public Battery(string batteryModel, double? hoursIdle, double? hoursTalk, int type)
            : this(batteryModel)
        {
            if (hoursIdle == null || hoursIdle < 0.0)
            {
                this.hoursIdle = 0.0;
            }
            else 
            {
                this.hoursIdle = hoursIdle;
            }


            if (hoursTalk == null || hoursTalk < 0.0)
            {
                this.hoursTalk = 0.0;
            }
            else
            {
                this.hoursTalk = hoursTalk;
            }

            if (type < 0 || type > 3)
            {
                this.batType = BatteryType.Unknown;
            }
            else
            {
                this.batType = (BatteryType)type;
            }
            
        }
        /**/

        public override string ToString()
        {
            if (batType == null)
            {
                return string.Format("Battery Model : {0}\r\n", batteryModel);
            }
            return string.Format("Battery Model : {0}\r\nBattery hours on idle: {1}\r\nBattery hours talk: {2}\r\nBattery type: {3}\r\n", batteryModel, hoursIdle, hoursTalk, batType);
        }

    }
    /*Battery Type enum */
    public enum BatteryType
    {
        Unknown = 0, LiIon = 1, NiMH = 2, NiCd = 3
    }
    /**/
}
