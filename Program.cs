using System;

namespace Puzzles
{
    class Program
    {
        public static void RandomArray()
        {
            Random rand = new Random();
            int[] arr = new int[10];
            arr[0] = rand.Next(5,25);
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                arr[i] = rand.Next(5,25);
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                }
                sum += arr[i];
            }
            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Sum: {0}", sum);

        }

        public static string TossCoin()
        {
            Random rand = new Random();
            Console.WriteLine("Tossing a Coin!");
            int coin_toss = rand.Next(2);
            string toss; 
            if(coin_toss == 0)
            {
                toss = "Tails!";
            }
            else
            {
                toss = "Heads!";
            }
            Console.WriteLine(toss);
            return toss;
        }

        public static double TossMultipleCoins(int num)
        {
            double heads = 0;
            for(int i = 1; i <= num; i++)
            {
                string toss = TossCoin();
                if(toss == "Heads!")
                {
                    heads++;
                }
            }
            return heads/num;
        }

        public static string[] Names(string[] arr)
        {
            int counter = 0;
            foreach(string x in arr)
            {
                if(x.Length > 5)
                {
                    counter++;
                }
            }

            string[] myArr = new string[counter];
            counter = 0;
            foreach(string x in arr)
            {
                if(x.Length > 5)
                {
                    myArr[counter] = x;
                    counter++;
                }
            }
            return myArr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RandomArray();
            Console.WriteLine();
            TossCoin();
            Console.WriteLine();
            Console.WriteLine(TossMultipleCoins(5));
            Console.WriteLine();
            string[] names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            foreach(string name in Names(names))
            {
                Console.WriteLine(name);
            }
        }
    }
}
