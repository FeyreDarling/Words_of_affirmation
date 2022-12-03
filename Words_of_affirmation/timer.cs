using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Words_of_affirmation
{
    internal class TimeElapsed
    {
        int interval;
        double startTime;


        public TimeElapsed(int interval)
        {
            this.interval = interval;
            StartTimer();
        }

        public void StartTimer()
        {
            this.startTime = DateTime.Now.TimeOfDay.TotalMilliseconds;
        }

        public void ElapsedTime()
        {
            double timeElapsed = DateTime.Now.TimeOfDay.TotalMilliseconds - this.startTime;
            if (timeElapsed > (interval * 1000))
            {
                Console.WriteLine(GetPhrase());
                StartTimer();
            }
        }

        public String GetPhrase()
        {
            Random randomNumber = new Random();
            int ran = randomNumber.Next(0, 4);
            List<String> phrases = new List<string>()
            {
                "Go off, do something!",
                "You can do it...I think",
                "You can have a nap after this!",
                "A llorar a la llorería",
            };
            return (phrases[ran]);

        }


    }
}
