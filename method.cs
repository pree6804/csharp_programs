using System;

namespace interviewc_
{
    class Method
    {
        //nonstatic method
        public void EvenNumber()
        {
            int n = 20;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void oddNumber()
        {
            int n = 21;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

        }

        public static void Program1()
        {
            Method m = new Method();
            m.EvenNumber();//non static method so instancew to be created then used to call
            Method.oddNumber();//static method so class name 
        }

        //---------------------------------------------------
        public static void Main()
        {
            Program(30);

        }
        /// <summary>
        /// we cant changes the places of static as its rules and synatx 
        /// </summary>
        /// <param name="target"></param>
        public static void  Program(int target)
        {
            for (int i= 0 ;i <target;i++)
            {
                Console.WriteLine(i);
            }

        }

    }
}

