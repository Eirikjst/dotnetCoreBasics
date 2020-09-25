using System;
using System.Threading;

namespace SocketAndThreadsTesting
{
    public class PrimeNumbersThreading
    {
        public static void ThreadWork(Object obj) {

            int counter = 0;
            int[] arr;
            string res = "";
            try
            {
                arr = (int[]) obj;
                var th = Thread.CurrentThread;

                //Console.WriteLine("\nThread {0}: [{1}]", th.ManagedThreadId, string.Join(", ", arr));

                for (int i = 0; i < arr.Length; i++)
                {
                    if (!isPrime(arr[i]))
                    {
                        arr[i] = 0;
                    }
                }

                foreach(var item in arr)
                {
                    if (item != 0)
                    {
                        res += item.ToString()+", ";
                        counter++;
                        if (counter == 15)
                        {
                            res += "\n";
                            counter = 0;
                        }
                    }
                }

                //Console.WriteLine("Thread {0}: [{1}]", th.ManagedThreadId, string.Join(", ", arr));
                Console.WriteLine("Thread {0}:\n {1}", th.ManagedThreadId, res);
            }
            catch(InvalidCastException)
            {
                Console.WriteLine("Failed to assign workload to thread....");
            }
        }

        public static bool isPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int lowerBound = 1;
            int upperBound = 10000;
            int numberOfThreads = 10;

            //if upperbound-lowerbound % numberOfThreads != 0
            //increment upperbound untill condition is true
            if ((upperBound - lowerBound) % numberOfThreads != 0)
            {
                while ((upperBound - lowerBound) % numberOfThreads != 0)
                {
                    upperBound++;
                }
            }

            Console.WriteLine(
                "Checking prime numbers between {0}-{1}\n" +
                "Workload shared between {2} number of threads",
                lowerBound, upperBound, numberOfThreads
                );

            for (int i = 0; i < numberOfThreads; i++)
            {
                int[] temp = new int[(upperBound-lowerBound)/numberOfThreads];
                
                for (int j = 0; j < temp.Length; j++)
                {
                    temp[j] = lowerBound + i + (j*numberOfThreads);
                }

                //Console.WriteLine("[{0}]", string.Join(", ",temp));
                var th = new Thread(ThreadWork);
                th.Start(temp);
            }
        }
    }
}
