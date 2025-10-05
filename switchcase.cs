using System;
// coffee menu based switch cases
namespace interviewc_
{
     class SwitchCase

    {
        public static void Main(String[] args)
        {
            Start:

            Console.WriteLine("Coffee Menu ");
            Console.WriteLine("1. Small ($2.00)");
            Console.WriteLine("2. Medium ($3.50)");
            Console.WriteLine("3. Large ($5.00)");
            Console.WriteLine("----------------------------");
            Console.Write("Please enter your coffee size (Small, Medium, or Large): ");
            string option=Console.ReadLine().ToLower();
            string finalPrice = "";
            switch (option)
            {
                case ("small"):
                case "s":

                    Console.WriteLine("pay $2");
                    break;
                case "medium":
                case "m":
                    finalPrice = "$3.50";
                    Console.WriteLine($"You ordered a Medium coffee. Total: {finalPrice}");
                   
                    break;

                case "large":
                case "l":
                    finalPrice = "$5.00";
                    Console.WriteLine($"You ordered a Large coffee. Total: {finalPrice}");
                   
                    break;
                default:
                    Console.WriteLine($"invalid selection {option}");
                    goto Start;// go back to label start to stat again from beginning

            }
                
        }


    }
}
