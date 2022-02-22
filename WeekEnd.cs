using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDayCalculator
{
    public class WeekEnd
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public WeekEnd(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
        public string Show(WeekEnd[] weekEnds)
        {
            string str = "\n";
            for (int i = 0; i < weekEnds.Length; i++)
                str += (weekEnds[i].StartDate.ToShortDateString() + " - " + weekEnds[i].EndDate.ToShortDateString() + "\n");
            return str;
        }
    }
}
