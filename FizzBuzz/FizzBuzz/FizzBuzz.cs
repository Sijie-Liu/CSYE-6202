namespace FizzBuzz
{
	public class FizzBuzz
	{
		public string RunFizzBuzz(int number)
		{
			string result = number.ToString();

            // your solution/implementation should go in here
            
            string fb = "FizzBuzz";
            bool flag3 = false;
            bool flag5 = false;
            if (number == 0)
                return "0";

            if (number % 5 == 0)
                flag5 = true;
            if (number % 3 == 0)
                flag3 = true;

            if (flag3 && flag5)
                return fb;
            else if (flag3 && !flag5)
                return "Fizz";
            else if (flag5 && !flag3)
                return "Buzz";
            else
			    return result;
		}
	}
}
