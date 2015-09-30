using System;

namespace GasPump
{
	public class Program
	{
		public enum GasType
		{
			None,
			RegularGas,
			MidgradeGas,
			PremiumGas,
			DieselFuel				
		}

		static void Main(string[] args)
		{
			// your implementation here
		}

		// use this method to check and see if sentinel value is entered
		public static bool UserEnteredSentinelValue(string userInput)
		{
			var result = false;

            // your implementation here
            if (userInput == null)
                return false;
            if (userInput.Equals("r") || userInput.Equals("m") || userInput.Equals("p") || userInput.Equals("d")|| userInput.Equals("q")|| userInput.Equals("Q"))
                result = true;
            return result;
		}

		// use this method to parse and check the characters entered
		// this does not conform 
		public static bool UserEnteredValidGasType(string userInput)
		{
			var result = false;

            if (userInput == null)
                return false;
            // your implementation here
            string req = userInput.ToLower();
            if(req.Equals("r")|| req.Equals("m")|| req.Equals("p")|| req.Equals("d"))
                result = true;
			
			return result;
		}

		// use this method to parse and check the double type entered
		// please use Double.TryParse() method 
		public static bool UserEnteredValidAmount(string userInput)
		{
			var result = false;

            if (userInput == null)
                return false;

            // your implementation here
            char[] arr = userInput.ToCharArray();
            for (int i=0;i<arr.Length;i++)
            {
                if ((arr[i] <= '9' && arr[i] >= '0') || arr[i] == '.')
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }

			return result;
		}

		// use this method to map a valid char entry to its enum representation
		// e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
		// this mapping "must" be used within CalculateTotalCost() method later on
		public static GasType GasTypeMapper(char c)
		{
			GasType gasType = GasType.None;

            // your implementation here
            switch (c)
            {
                case 'r':
                    gasType = GasType.RegularGas;
                    break;
                case 'R':
                    gasType = GasType.RegularGas;
                    break;
                case 'p':
                    gasType = GasType.PremiumGas;
                    break;
                case 'P':
                    gasType = GasType.PremiumGas;
                    break;
                case 'd':
                    gasType = GasType.DieselFuel;
                    break;
                case 'D':
                    gasType = GasType.DieselFuel;
                    break;
                case 'm':
                    gasType = GasType.MidgradeGas;
                    break;
                case 'M':
                    gasType = GasType.MidgradeGas;
                    break;
            }

			return gasType;
		}

		public static double GasPriceMapper(GasType gasType)
		{
			var result = 0.0;
            switch (gasType)
            {
                case GasType.RegularGas:
                    result = 1.94;
                    break;
                case GasType.MidgradeGas:
                    result = 2.0;
                    break;
                case GasType.PremiumGas:
                    result = 2.24;
                    break;
                case GasType.DieselFuel:
                    result = 2.17;
                    break;
            }
			// your implementation here

			return result;
	}

		public static void CalculateTotalCost(GasType gasType, int gasAmount, ref double totalCost)
		{
            // your implementation here
            totalCost = GasPriceMapper(gasType) * gasAmount;
		}
	}
}
