using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.TotalPriceOfCalls
{
    public class Display
    {
        /*display fields*/
        private string displaySize;
        private string numberOfColors = null;
        /**/

        /*display constructors*/
        public Display(string displaySize)
        {
            if (displaySize == null)
            {
                displaySize = "Unknown";
            }
            else 
            {
                this.displaySize = displaySize;
            }
            
        }
        public Display(string displaySize, string numberOfColors)
            : this(displaySize)
        {
            if (numberOfColors == null)
            {
                this.numberOfColors = "Unknown";
            }
            this.numberOfColors = numberOfColors;
        }
        /**/
        public override string ToString()
        {
            if (numberOfColors == null)
            {
                return string.Format("Display size : {0}\r\n", displaySize);
            }
            return string.Format("Display size : {0}\r\nDisplay colors: {1}\r\n", displaySize, numberOfColors);
        }
    }
}
