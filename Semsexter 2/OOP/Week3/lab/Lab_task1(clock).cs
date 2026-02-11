using System;

namespace Classapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClockType clock1 = new ClockType();
            Console.WriteLine("Clock 1 (default): " + clock1.PrintTime());

            ClockType clock2 = new ClockType(10, 25, 30);
            Console.WriteLine("Clock 2 (initialized): " + clock2.PrintTime());

            clock2.IncreamentSecondsByOne();
            clock2.IncreamentMinutesByOne();
            clock2.IncreamentHoursByOne();
            Console.WriteLine("Clock 2 after increments: " + clock2.PrintTime());

            Console.WriteLine("Clock1 equal to Clock2? " + clock1.equalTime(clock2));

            Console.WriteLine("Clock2 elapsed time in seconds: " + clock2.ElapsedTimeInSeconds());

            Console.WriteLine("Clock2 remaining time in seconds: " + clock2.RemainingTimeInSeconds());

            Console.WriteLine("Difference between Clock1 and Clock2: " + clock1.DifferenceInTime(clock2) + " seconds");
        }
    }

    class ClockType
    {
        public int hours;
        public int minutes;
        public int seconds;

        public ClockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }

        public ClockType(int hr, int min, int sec)
        {
            hours = (hr >= 0 && hr < 24) ? hr : 0;
            minutes = (min >= 0 && min < 60) ? min : 0;
            seconds = (sec >= 0 && sec < 60) ? sec : 0;
        }

        public string PrintTime()
        {
            return hours + " : " + minutes + " : " + seconds;
        }

        public void IncreamentSecondsByOne()
        {
            seconds += 1;
        }

        public void IncreamentMinutesByOne()
        {
            minutes += 1;
        }

        public void IncreamentHoursByOne()
        {
            hours += 1;
        }

        public bool equalTime(ClockType clock)
        {
            if (hours == clock.hours && minutes == clock.minutes && seconds == clock.seconds)
            {
                return true;
            }
            return false;
        }

        public int ElapsedTimeInSeconds()
        {
            return hours * 3600 + minutes * 60 + seconds;
        }

        public int RemainingTimeInSeconds()
        {
            int totalSeconds = 24 * 3600;
            return totalSeconds - ElapsedTimeInSeconds();
        }

        public int DifferenceInTime(ClockType clock)
        {
            int Difference = ElapsedTimeInSeconds() - clock.ElapsedTimeInSeconds();
            return (Difference < 0) ? Difference * -1 : Difference;
        }
    }
}