using System;

namespace BoxingWeights
{
	public class BoxingWeightClassifier
	{
		public string ClassifyBoxingWeight(int weightInPounds)
		{
			string result = weightInPounds.ToString();

            // your solution/implementation should go in here
            int i = weightInPounds;
            if (i >= 0 && i <= 105)
                result = "Strawweight and Heavyweight";
            if (i >= 106 && i <= 108)
                result = "JuniorFlyweight and Heavyweight";
            if (i >= 109 && i <= 112)
                result = "Flyweight and Heavyweight";
            if (i >= 113 && i <= 115)
                result = "JuniorBantamweight and Heavyweight";
            if (i >= 116 && i <= 118)
                result = "Bantamweight and Heavyweight";
            if (i >= 119 && i <= 122)
                result = "JuniorFeatherweight and Heavyweight";
            if (i >= 123 && i <= 126)
                result = "Featherweight and Heavyweight";
            if (i >= 127 && i <= 130)
                result = "JuniorLightweight and Heavyweight";
            if (i >= 131 && i <= 135)
                result = "Lightweight and Heavyweight";
            if (i >= 136 && i <= 140)
                result = "JuniorWelterweight and Heavyweight";
            if (i >= 141 && i <= 147)
                result = "Welterweight and Heavyweight";
            if (i >= 148 && i <= 154)
                result = "JuniorMiddleweight and Heavyweight";
            if (i >= 155 && i <= 160)
                result = "Middleweight and Heavyweight";
            if (i >= 161 && i <= 168)
                result = "SuperMiddleweight and Heavyweight";
            if (i >= 169 && i <= 175)
                result = "LightHeavyweight and Heavyweight";
            if (i >= 176 && i <= 200)
                result = "Cruiserweight and Heavyweight";
            if (i >= 201)
                result = "Heavyweight";
            Console.WriteLine(result);
            return result;

        }
	}
}
