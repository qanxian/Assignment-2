// See https://aka.ms/new-console-template for more information
namespace myArray
{
    class Array
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the array: ");

            string value = Console.ReadLine();
            string[] vals = value.Split(',');

            int[] num = new int[vals.Length];
            for (int i=0; i<vals.Length; i++)
            {
                num[i] = int.Parse(vals[i]);
            }

            int max = num[0];
            int min = num[0];
            double ave;
            int sum = 0;

            for (int i = 0; i < vals.Length; i++)
            {
                if (num[i]>max)
                {
                    max = num[i];
                }
                if (num[i]<min)
                {
                    min = num[i];
                }
                sum = sum + num[i];
            }
            ave = sum / vals.Length;

            Console.WriteLine("The maximum value of the array is: " + max);
            Console.WriteLine("The minimum value of the array is: " + min);
            Console.WriteLine("The average of the arrays is:" + ave);
            Console.WriteLine("The sum of the arrays is:" + sum);
        }
    }
}
