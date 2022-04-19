using System;

namespace _8HoursCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string runAgain;
            do
            {
                try
                {
                    Console.WriteLine("Enter clock in time before lunch: ");
                    string clockInBeforeLunch = Console.ReadLine();

                    Console.WriteLine("Enter clock out time for lunch: ");
                    string clockOutLunch = Console.ReadLine();

                    Console.WriteLine("Enter clock in time after lunch: ");
                    string clockInAfterLunch = Console.ReadLine();


                    DateTime clockInBeforeLunch2 = DateTime.Parse(clockInBeforeLunch);
                    DateTime clockOutLunch2 = DateTime.Parse(clockOutLunch);
                    DateTime clockInAfterLunch2 = DateTime.Parse(clockInAfterLunch);

                    var resultLunch = clockOutLunch2 - clockInBeforeLunch2;

                    var lunchBreak = clockInAfterLunch2 - clockOutLunch2;


                    TimeSpan hoursWorked = new TimeSpan(0, 8, 0, 0);

                    TimeSpan timeLeft2 = hoursWorked.Subtract(resultLunch);

                    var result = clockInAfterLunch2.Add(timeLeft2);

                    Console.WriteLine("Lunch Break: " + lunchBreak);
                    Console.WriteLine("Time Difference: " + timeLeft2);
                    Console.WriteLine("You can leave at: " + result);
                    Console.WriteLine("However, there is a 7 minute rounding rule. (Can't clock out before 4:22pm.");
                    Console.WriteLine("Your clock out time is " + result + ", but was rounded to 4:23pm.");
                    Console.WriteLine("Run again? (Y/N): ");
                    runAgain = Console.ReadLine();
                    if ((runAgain == "N") || (runAgain == "n"))
                        break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("One of the times was entered incorrectly.");
                    Console.WriteLine("The time format must be '00:00 AM' or '00:00 PM'.");
                    Console.WriteLine("Run the program again to try again.");
                    Console.WriteLine("If the problem persists, ask Lukie Dukie");
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                    Console.WriteLine("Error Message: " + e);

                }
            } while (true);


        }
    }

}
