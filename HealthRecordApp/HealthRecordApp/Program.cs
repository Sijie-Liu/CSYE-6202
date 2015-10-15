using System;

namespace HealthRecordApp
{
	class Program
	{
        static HealthProfile hp = new HealthProfile();
        

		static void Main(string[] args)
		{
            //ask to input firstname
            Console.Write("Please enter patient's first name:");
            string firstname = Console.ReadLine();
            while (!HealthProfileHelper.ValidateFirstName(firstname))
            {
                Console.Write("Please enter patient's first name:");
                firstname = Console.ReadLine();
            }

            //ask to input last name
            Console.Write("Please enter patient's last name:");
            string lastname = Console.ReadLine();
            while (!HealthProfileHelper.ValidateLastName(lastname))
            {
                Console.Write("Please enter patient's last name:");
                lastname = Console.ReadLine();
            }

            //ask to input gender
            Gender patientGender = Gender.Unspecified;
            Console.Write("Please enter patient's gender (Unspecified/Male/Female):");
            string gender = Console.ReadLine();
            while (!HealthProfileHelper.ValidateGender(gender,ref patientGender))
            {
                Console.Write("Please enter patient's gender (Unspecified/Male/Female):");
                gender = Console.ReadLine();
            }

            //ask to input dob
            DateTime patientDOB = DateTime.Today;
            Console.Write("Please enter patient's date of birth:");
            string dob = Console.ReadLine();
            while (!HealthProfileHelper.ValidateDateOfBirth(dob, ref patientDOB))
            {
                Console.Write("Please enter patient's date of birth:");
                dob = Console.ReadLine();
            }

            //ask to input height
            Console.Write("Please enter patient's height:");
            string height = Console.ReadLine();
            int patientHeight = 0;
            while (!HealthProfileHelper.ValidateHeight(height,ref patientHeight))
            {
                Console.Write("Please enter patient's height:");
                height = Console.ReadLine();
            }

            //ask to input weight
            Console.Write("Please enter patient's weight:");
            string weight = Console.ReadLine();
            int patientWeight = 0;
            while (!HealthProfileHelper.ValidateWeight(weight, ref patientWeight))
            {
                Console.Write("Please enter patient's weight:");
                weight = Console.ReadLine();
            }

            //store info into hp;
            hp.FirstName = firstname;
            hp.LastName = lastname;
            hp.Gender = patientGender;
            hp.DOB = patientDOB;
            hp.HeightInInches = patientHeight;
            hp.WeightInPounds = patientWeight;

            //display
            Console.WriteLine();
            Console.WriteLine();
            hp.DisplayPatientProfile();

            Console.ReadLine();
        }
	}
}
