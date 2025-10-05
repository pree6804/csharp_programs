using System;


namespace interviewc_
{
    class step4
    {
        public static void Main(string[] args)
        {
            /*
            string valid = "7896";
            string invalid = "mahina";

            try
            {
                double n = int.Parse(valid);
                Console.WriteLine($"parsed value {valid + 2} ");

            }
            catch (Exception e) {
                Console.WriteLine("wrong format ");
            }
            try
            {
                double n = int.Parse(invalid);
            }
            catch (FormatException)
            {
                Console.WriteLine($"invalid format number  {invalid}");
            }
            */

            string validDate = "2025-10-05";
            string invalidDate = "NotADate";
            DateTime parseDate;
            bool success = DateTime.TryParse(validDate, out parseDate);
            if (success) {
                Console.WriteLine($"date is {parseDate}");
                    }
            else
            {
                Console.WriteLine("TryParse Failed.");
            }

            bool fail = DateTime.TryParse(invalidDate, out parseDate);
            if (fail) {
               
            }
            else
            {
                Console.WriteLine($"TryParse Failed. The string '{invalidDate}' could not be converted.");
            }





        }
    }
}
