using System.Runtime.CompilerServices;
using System.Timers;

int timeInterval = 0;

Console.WriteLine("Introduce the time interval");

timeInterval = int.Parse(Console.ReadLine());
int myTime = timeInterval * 1000;

System.Timers.Timer myTimer = new System.Timers.Timer();
myTimer.Interval = myTime;
myTimer.Elapsed += new ElapsedEventHandler(GetPhrase);
myTimer.Enabled = true;

Console.WriteLine("Press \'q\' to quit the sample.");
while (Console.Read() != 'q');

static void GetPhrase(object source, ElapsedEventArgs e)
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
    Console.WriteLine((phrases[ran]));
}





