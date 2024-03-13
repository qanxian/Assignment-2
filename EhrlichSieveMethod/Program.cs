// See https://aka.ms/new-console-template for more information
namespace myEhrlichSieveMethod
{
    class EhrlichSieveMethod
    {
        static void Main(string[] args)
        {
            int[] arr = new int[99];

            for (int i=2; i<=100; i++)
            {
                arr[i-2] = i;
            }

            for (int i = 0; i < 99; i++)
            {
                if (arr[i]==2 || arr[i] == 3 || arr[i] == 5 || arr[i] == 7)
                {
                    Console.Write(arr[i] + " ");
                }
                if (arr[i]%2!=0 && arr[i]%3!=0 && arr[i]%5!=0 && arr[i]%7!=0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
