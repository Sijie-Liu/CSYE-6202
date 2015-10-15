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
            string[] strArr = enteredDOB.Split('/');
            if (strArr.Length != 3)
                return false;
            int month = Int32.Parse(strArr[0]);
            int day = Int32.Parse(strArr[1]);
            int year = Int32.Parse(strArr[2]);
            if (month > 12 || month < 1)
                return false;
            if (year <= 0)
                return false;
            if (day <= 0)
                return false;

            switch(month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        if (day > 31) return false;
                        break;
                    }
                case 2:
                    {
                        if (year % 4 == 0)
                        { if (day > 29) return false; break; }
                        else
                        {
                            if (day > 28) return false; break;
                        }
                    }
                default: {
                        if (day > 30) return false; break;
                    }
            }
            DateTime tmp = new DateTime(year,month,day);
            if (tmp.CompareTo(DateTime.Today) > 0)
                return false;

            patientDOB = new DateTime(year,month,day);
            
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
