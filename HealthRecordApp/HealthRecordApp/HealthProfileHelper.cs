using System;

namespace HealthRecordApp
{
	public class HealthProfileHelper
	{
		public static bool ValidateFirstName(string firstName)
		{
            if (firstName == null)
                return false;
            string str = firstName.Trim();
            if (str.Equals(""))
                return false;
			return true;
		}

		public static bool ValidateLastName(string lastName)
		{
            if (lastName == null)
                return false;
            string str = lastName.Trim();
            if (str.Equals(""))
                return false;
            return true;
        }

		public static bool ValidateGender(string enteredGender, ref Gender patientGender)
		{
            if (enteredGender.Equals("Male"))
            {
                patientGender = Gender.Male;
                return true;
            }
      
            if(enteredGender.Equals("Female"))
            {
                patientGender = Gender.Female;
                return true;
            }

            if (enteredGender.Equals("Unspecified"))
            {
                patientGender = Gender.Unspecified;
                return true;
            }

            return false;
		}

		public static bool ValidateDateOfBirth(string enteredDOB, ref DateTime patientDOB)
		{
            DateTime tmp;
            try {
                tmp = DateTime.Parse(enteredDOB);
            }
            catch (Exception e)
            {
                return false;
            }

            if (tmp.CompareTo(DateTime.Today) > 0)
                return false;

            patientDOB = tmp;
			return true;
		}

		public static bool ValidateHeight(string heightInString, ref int patientHeight)
		{
            for (int i=0;i< heightInString.ToCharArray().Length;i++)
            {
                if (heightInString.ToCharArray()[i] > '9' || heightInString.ToCharArray()[i] < '0')
                {
                    return false;
                }
            }
            int height = Int32.Parse(heightInString);
            if (height <= 0)
                return false;
            patientHeight = height;
			return true;
		}

		public static bool ValidateWeight(string weightInString, ref int patientWeight)
		{
            for (int i = 0; i < weightInString.ToCharArray().Length; i++)
            {
                if (weightInString.ToCharArray()[i] > '9' || weightInString.ToCharArray()[i] < '0')
                {
                    return false;
                }
            }
            int weight = Int32.Parse(weightInString);
            if (weight <= 0)
                return false;
            patientWeight = weight;
			return true;
		}
	}
}
