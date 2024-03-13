// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace myPrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            string num0 = "";
            int num;
            int tem;
            int boo = 0;

            Console.Write("Please enter a positive integer:");
            num0 = Console.ReadLine();
            num = Int32.Parse(num0);
            tem = num;

            Console.Write("The prime factor of this number is: ");

            for (int i=2; i<=num; i++)
            {
                if (num%i==0)
                {
                    if (i==tem)
                    {
                        boo = 1;    //boo用于判断num是否本身是个素数
                    }
                    Console.Write(i+" ");
                    num = num / i;
                    i = 1;
                }
            }

            if (boo==1)
            {
                Console.Write("is prime");
            }
        }
    }
}
