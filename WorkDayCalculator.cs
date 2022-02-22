using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDayCalculator 
{
    public class WorkDayCalculator : IWorkDayCalculator
    {

        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            int weekendsCount = 0; //количество выходных
            for (int i = 0; i < weekEnds.Length; i++) //количество введённых дат начала и дат конца выходных
            {
                if (startDate < weekEnds[i].StartDate & startDate <= weekEnds[i].EndDate)
                {
                    if((startDate + new TimeSpan(weekendsCount + dayCount - 1, 0, 0, 0)) <= weekEnds[i].StartDate)
                        weekendsCount += 0;
                    else if((startDate + new TimeSpan(weekendsCount + dayCount - 1, 0, 0, 0)) > weekEnds[i].StartDate)
                        weekendsCount += (weekEnds[i].EndDate - weekEnds[i].StartDate).Days + 1;
                }
                else if (startDate >= weekEnds[i].StartDate & startDate <= weekEnds[i].EndDate)
                    weekendsCount += (weekEnds[i].EndDate - startDate).Days + 1;
                else if (startDate > weekEnds[i].StartDate & startDate > weekEnds[i].EndDate)
                {
                    if((startDate + new TimeSpan(weekendsCount + dayCount - 1, 0, 0, 0)) > weekEnds[i].StartDate)
                        weekendsCount += 0;
                    if((startDate + new TimeSpan(weekendsCount + dayCount - 1, 0, 0, 0)) <= weekEnds[i].StartDate)
                        weekendsCount += (weekEnds[i].EndDate - startDate).Days + 1;
                }
                else weekendsCount += 0;
            }
            return (startDate + new TimeSpan(weekendsCount + dayCount - 1, 0, 0, 0));
        }
    }
}
