using Words_of_affirmation;

int timeInterval = 0;

Console.WriteLine("Introduce the time interval");

timeInterval = int.Parse(Console.ReadLine());

TimeElapsed tm = new TimeElapsed(timeInterval);

while(true)
{
    tm.ElapsedTime();
}







