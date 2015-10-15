using System;

namespace HealthRecordApp
{
	public enum Gender
	{
		Unspecified,
		Male,
		Female
	}

	public class HealthProfile
	{
		private const int UnknownValue = -1;
        private string firstname;
        private string lastname;
        private Gender gender;
        private DateTime dob;
        private int weight;
        private int height;

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public int WeightInPounds
        {
            get { return weight; }
            set { weight = value; }
        }

        public int HeightInInches
        {
            get { return height; }
            set { height = value; }
        }

        


        #region Methods

        public int CalculateAge()
		{
            int thisYear = DateTime.Today.Year;
            int age = thisYear - DOB.Year;
			return age;
		}

		public int CalculateMaxHeartRate()
		{
            
			return 220-CalculateAge();
		}

		public decimal CalculateBMI()
		{
			return decimal.Round(((decimal)weight*703)/ (decimal)(HeightInInches * HeightInInches),2);
		}

		public void DisplayPatientProfile()
		{
            Console.WriteLine("DisPlaying Patient Profile:");
            Console.WriteLine("===========================");
            Console.WriteLine("First Name: "+FirstName);
            Console.WriteLine("Last Name: "+LastName);
            Console.WriteLine("Gender: "+Gender.ToString());
            Console.WriteLine("Date of Birth: "+DOB.ToString());
            Console.WriteLine("Height: "+ HeightInInches + " inches");
            Console.WriteLine("Weight: "+ WeightInPounds + " pounds");
            Console.WriteLine("Age: " + CalculateAge());
            Console.WriteLine("Max Heart Rate: "+CalculateMaxHeartRate());
            Console.WriteLine("BMI: "+CalculateBMI());
        }

		#endregion
	}
}
