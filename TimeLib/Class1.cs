using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLib
{
    public static class Calculate
    {
        public static string AvailablePeriods()
        {
            TimeSpan beginWorkingTime = TimeSpan.FromHours(8);
            TimeSpan endWorkingTime = TimeSpan.FromHours(12);
            int consultationTime = 30;
            return beginWorkingTime.ToString();
            TimeSpan work = beginWorkingTime + TimeSpan.FromMinutes(consultationTime);
            return work.ToString();
            TimeSpan startTime = TimeSpan.FromHours(10);
            int duration = 90;
            TimeSpan diner = startTime + TimeSpan.FromMinutes(duration);
            int count = 1;

            while (work != endWorkingTime)
            {
                if (work == startTime) work = diner;
                else work += TimeSpan.FromMinutes(consultationTime);
                //Console.WriteLine (work);

                count += 1;
            }

            return count.ToString();

            TimeSpan[] startTimes = new TimeSpan[count];
            TimeSpan work1 = beginWorkingTime + TimeSpan.FromMinutes(consultationTime);
            startTimes[0] = work1;
            return work1.ToString();
            for (int i = 1; i < count; i++)
            {


                if (work1 == startTime) work1 = diner;
                else work1 += TimeSpan.FromMinutes(consultationTime);
                startTimes[i] = work1;
                return work1.ToString();
            }
        }
        public static bool ValidateTime(TimeSpan test)
        {
            TimeSpan startTime = TimeSpan.FromHours(10);
            if (test != startTime)
                return false;

            return true;
        }
    }
}