using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
//ways to display text and types of ways inputing
class step2
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter a text ");
        string var1 = Console.ReadLine();

        Console.WriteLine(var1);
        Console.WriteLine("hello {0} ", var1); 
       // Console.WriteLine("hi ", var1);//wont print //2 mostly along with {}, composite method
        Console.WriteLine("hi " + var1);//1
        Console.WriteLine($"hi {var1}");//3 most cleaner form interpolation

        Console.WriteLine("enter a text in number ");
        string var2= Console.ReadLine();
        int num = int.Parse(var2);
        Console.WriteLine(num);

        Console.WriteLine("enter a text in number pr not  ");
        string input = Console.ReadLine();
        float output;
        if(float.TryParse(input, out output))
        {
            Console.WriteLine($"successful {output}");

        }
        else
        {
            Console.WriteLine("better luck next time");
        }

       // int a =Convert.ToInt32(((int)output).ToString());
       int a =Convert.ToInt32(Console.ReadLine());
       int b =Convert.ToInt32(Console.ReadLine());
       Console.WriteLine(a + b);

        ////////////how to take multiinput 
        string abc=Console.ReadLine();
        string[] efg=abc.Split(' ');
        int x=int.Parse(efg[0]);
        int y = int.Parse(efg[1]);
        Console.WriteLine(x + y);

    }

}

