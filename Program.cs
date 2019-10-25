using System;


namespace Bubbles
{
    class BubbleSorter
    {
        public static void BubbleSorterAscending(int[] bubbles)
        {
            bool swapped = true;

            for (int i = 0; swapped; i++)
            {
                swapped = false;
                for (int j = 0; j < bubbles.Length - (i + 1); j++)
                {
                    if (bubbles[j] > bubbles[j + 1])
                    {
                        Swap(j, j + 1, bubbles);
                        swapped = true;

                    }
                
                               
                }
            
            
            }
        
        
        }
        public static void Swap(int first, int second, int[] arr)
        {
            int temp;
            temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
              
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            
            }
        
        }
       
        static void Main(string[] args)
        {
            /*
            int[] testScores = {300,90,50,120,100,10,290,85,90,120};

            BubbleSorterAscending(testScores);
            Console.WriteLine("The test score sorted in ascending order:\n");
            PrintArray(testScores);
            Console.ReadLine();
              */
            int[] testScores = new int[10000];
            DateTime sortStart;
            DateTime sortEnd;

            for (int i = 0; i < testScores.Length; i++)
            {
                testScores[i] = testScores.Length - i;
            
            }

            Console.WriteLine("Now timing the bubble sort method please wait...");
            sortStart = DateTime.Now;
            BubbleSorterAscending(testScores);
            sortEnd = DateTime.Now;
            Console.WriteLine("Senconds elapsed bubble sorting an arry of length {0}: {1}",testScores.Length,((sortEnd-sortStart).Ticks/10000000));
            for (int i = 0; i < testScores.Length; i++)
            {
                testScores[i] = testScores.Length - i;

            }

            Console.WriteLine("\nNow timing the built in sort method of System.Array. Please wait...");
            sortStart = DateTime.Now;
            Array.Sort(testScores);
            sortEnd = DateTime.Now;
            Console.WriteLine("Second elapsed .NET sorting an array of length {0}: {1}",testScores.Length,((sortEnd-sortStart).Ticks/10000000));
            Console.ReadLine();
        }
    }
}
