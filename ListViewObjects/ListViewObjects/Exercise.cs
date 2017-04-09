using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListViewObjects
{
    public class Exercise
    {
        public string type = "Not Set";
        public DateTime datetimeValue = DateTime.Now;
        public int distance = 0;

        public override string ToString()
        {
            string returnValue = type.PadRight(7) + "\t\t";
            returnValue += datetimeValue.ToString("yyyy/MM/dd HH:mm:ss") + "\t";
            returnValue += distance.ToString();

            return returnValue;
        }
    }
}
