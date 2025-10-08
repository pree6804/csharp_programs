using System;

namespace interviewc_
{
    class namespace1
    {
        ////////////////////
        /*
         * namespace Data.Utilities
{
    public class Addition
    {
        public static string Concat(string[] items)
        {
            return string.Join(" | ", items);
            
        }
    }
}
        //////////////////////////
        namespace Data.Processors
{
    public class Addition
   {
    public static int Add(int[] num)
    {
        int sum = 0;
        foreach (int i in num)
        {
            sum += i ;
        }

        return sum;
    }
        
   }
}
        /////////////////////////////////
        
//both place class name same 
using System;
using  SumAdd=Data.Processors.Addition;
using Data.Utilities;
class BasicCalculator
{
     public static void Main(string[] args)
    {
        int[] arr = [1, 2, 3];
        string[] str = { "a", "x" };
        int resultadd = SumAdd.Add(arr);
        string resultstr = Data.Utilities.Addition.Concat(str);
        Console.WriteLine(resultadd);
        Console.WriteLine(resultstr);
        Console.WriteLine();
    }
}



         */
    }
}
