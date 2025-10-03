using System;


namespace interviewc_
{
    class step3
    {
        public static bool IsValid(string value)
        {
            return value.GetType() == typeof(string);

        }
        public static void Main(string[] args)
        {
           // Console.WriteLine("min value of int ={0}",int.MinValue);
            //Console.WriteLine("max value of int ={0}", int.MaxValue);
            //developing a C# application for an inventory system that needs to store the following two values:
            //Product ID: An identification number that will never be negative,.
            //Net Profit: A dollar amount that can be negative (a loss) or positive, with a total value
            ushort profit;
            int productID;
            //Scenario:
            // You have written a function that validates user input for a form field.The function must return a value indicating whether the input is valid or invalid.
            Console.WriteLine("enter Value ");
            string value =Console.ReadLine();
            if (IsValid(value))
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("string ");
            }


        }

    }
}
