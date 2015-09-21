using System;

namespace FindingPrimeNumbers
{
	public class FindingPrimeNumbers
	{
		public long FindSumOfPrimeNumbers(int n)
		{
			long sum = 0;
            if (n == 0)
                return 0;
            if (n == 1)
                return 2;

            sum = 2;
            int count = 1;
            long temp = 0;
            for (int i = 3;count < n ; i++)
            {
                if ((temp = isPrime(i)) != -1)
                {
                    sum += temp;
                    count++;
                }

            }
			// your solution goes in here

			return sum;
		}

        public long isPrime(long num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return -1;
            }
            return num;
        }
	}
}
