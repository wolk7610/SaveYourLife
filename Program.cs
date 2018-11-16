using System;

namespace SaveYourLife
{
    class Program
    {
        static void Main(string[] args)
        {
            int old;
            string isSmoke;

            Console.WriteLine("Save Your Life com.");
            Console.WriteLine("Программа для подсчета продолжительности жизни.. ");
            Console.WriteLine("Сколько вам лет?");
            old = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы курите?");
            isSmoke = Console.ReadLine();
            if (isSmoke == "Да" || isSmoke == "да")
            {
                Console.WriteLine("Сколько лет вы курите?");
                double smokeYear = Convert.ToDouble(Console.ReadLine());
                double result = SmokeTime(smokeYear);
                Console.WriteLine($"Вы израсходовали {result.ToString("F" + 2)} лет");
            } 

        }

        static double SmokeTime(double year)
        {
            //one day subtract 2 hours
            double hoursSubtract = 2;
            double daysOfSmoke = year * 365;
            double lifeSubtract = ((daysOfSmoke * hoursSubtract) / 24) / 365; // year 
            return lifeSubtract;
        }
    }
}
