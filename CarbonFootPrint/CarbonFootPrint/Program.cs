using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Instances ins = new Instances();
            ins.printAll();
            Console.Read();
        }
    }

    abstract class Super
    {
        private double carbon;
        public double Carbon
        { set { carbon = value; } get { return carbon; } }

        abstract public void calculate();
    }

    class Bicycle:Super
    {
        override public void calculate()
        {
            Carbon = 0;
        }

        override public string ToString()
        {
            return "Hi I am a bicycle, and I have no carbon footprint.";
        }
    }

    class Car : Super
    {
        private double gallon;
        public double Gallon
        {
            set { gallon = value; }
            get { return gallon; }
        }
        public override void calculate()
        {
            Carbon = 20 * Gallon;
        }
        public override string ToString()
        {
            return "Hi I am a car, and my carbon footprint is "+Carbon+" pounds.";
        }
    }
    class Building : Super
    {
        private double square;
        public double Square
        { set { square = value; } get { return square; } }
        public override void calculate()
        {
            Carbon = 50 * Square;
        }
        public override string ToString()
        {
            return "Hi I am a building, and my carbon footprint is "+Carbon+" pounds.";
        }
    }

    class Instances
    {
        public List<Super> instanceList = new List<Super>();
        public Instances()
        {
            Bicycle bicycle = new Bicycle();
            bicycle.calculate();

            Car car = new Car();
            car.Gallon = 10;
            car.calculate();

            Building building = new Building();
            building.Square = 170;
            building.calculate();
            
            instanceList.Add(bicycle);
            instanceList.Add(car);
            instanceList.Add(building);
        }

        public void printAll()
        {
            for (int i =0;i< instanceList.Count;i++)
            {
                Console.WriteLine(instanceList[i]);
            }
        }

    }
}
