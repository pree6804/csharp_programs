using System;
// coffee menu based switch cases using do while
namespace interviewc_
{
    class do_while
    { 
        public static void Main(string[] args)
        {
            string choice = "true";
            do
            {

                Console.WriteLine("Coffee Menu ");
                Console.WriteLine("1. Small ($2.00)");
                Console.WriteLine("2. Medium ($3.50)");
                Console.WriteLine("3. Large ($5.00)");
                Console.WriteLine("----------------------------");
                Console.Write("Please enter your coffee size (Small, Medium, or Large): ");
                string option = Console.ReadLine().ToLower();
                string finalPrice = "";

                switch (option)
                {
                    case ("small"):
                    case "1":
                    case "s":

                        Console.WriteLine("pay $2");
                        break;
                    case "medium":
                    case "m":
                    case "2":
                        finalPrice = "$3.50";
                        Console.WriteLine($"You ordered a Medium coffee. Total: {finalPrice}");

                        break;

                    case "large":
                    case "l":
                    case "3":
                        finalPrice = "$5.00";
                        Console.WriteLine($"You ordered a Large coffee. Total: {finalPrice}");

                        break;
                    default:
                        Console.WriteLine($"invalid selection {option}");
                        break;

                }

                Console.WriteLine("want to continue ordering?");

                choice = Console.ReadLine();
            }
            while (choice.ToLower() != "no");

        }

       
      
    }
}
