using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            //  Writes message to terminal
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.");

            Console.WriteLine("What is your name?");
            //  Saves input to variable
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            //  Converts string to int
            int page = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string str_help = Console.ReadLine();
            // Converts string 'true' or 'false' to boolean
            bool help = Convert.ToBoolean(str_help);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string string_hours = Console.ReadLine();
            int hours = Convert.ToInt32(string_hours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.\nHave a gready day!");
            //  Leaves console running until a key is press to exit
            Console.ReadLine();
            

        }
    }
}
