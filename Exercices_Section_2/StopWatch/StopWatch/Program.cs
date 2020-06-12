using System;

namespace StopWatch
{

    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            string userInput;

            while (true)
            {
                Console.Write("Inserte instruccion:");
                userInput = Console.ReadLine();
                StopWatchInterface(userInput, stopWatch);
            }
        }

        public static void StopWatchInterface(string userInput, StopWatch stopWatch)
        {
            switch (userInput.ToUpper())
            {   case "START" :
                    stopWatch.Start();
                    break;
                case "STOP":
                    stopWatch.Stop();
                    break;
                default:
                    break;
            }
        }
    }
}
