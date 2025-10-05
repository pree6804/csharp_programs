using System;


namespace interviewc_
{
    class step4
    {
        public static void Main(string[] args)
        {
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
            catch (Exception e)
            {
                Console.WriteLine($"invalid format number  {invalid}");
            }




        }
    }
}
