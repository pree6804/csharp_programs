using System;
using System.Xml.Schema;

namespace interviewc_
{
    class methodParameters
    {
        /// <summary>
        /// ///////////////////////////output parameter
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            int t_prod = 0, t_sum = 0;
            Calculate(10,20,out t_sum, out t_prod);
            Console.WriteLine("sum  is {0} and product is {1}");
        }
        public static void Calculate(int FN,int SN,out int  sum ,out int  product )
        {
            sum  = FN +SN ;
            product = FN * SN;
        }
        /// <summary>
        /// /////////////////////////////////////array parameter
        /// </summary>
        /// <param name="args"></param>

        public static void Main(string[] args)
        {
            int[] number = new int[5];
            //ParamMethod();
            //ParamMethod(number);
            ParamMethod(1,2,3,4,5,6,7);


        }
        //public static void ParamMethod(int x ,params int[] Numbers)
        public static void ParamMethod(params int[] Numbers)
        {
            Console.WriteLine(" the length of array is {0}",Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
           
        }
        ////////////////////////////////////////reference parameter
        public static void Main(string[] args)
        {
            int i = 10;
            RefMethod(ref i);
            Console.WriteLine(i);
        }
        public static void RefMethod(ref int j)
        {
            j = 101;
        }
        ///////////////////////////////////////call by parameteer
        public static void Main(string[] args)
        {
        int i = 10;
        CallMethod(ref i);
        Console.WriteLine(i);//101
        }
        public static void CallMethod( ref int k)
        {
            k = 101;
        }
        ///////////////////////////////////////call by value
        public static void Main(string[] args)
        {
            int i = 10;
            CallMethod( i);
            Console.WriteLine(i);//10
        }
        public static void CallMethod( int k)
        {
            k = 101;
        }
    }
}
