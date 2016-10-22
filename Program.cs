using System;
using System.Linq;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(String[] args)
        {
            Animals animal = new Animals("Dog", 23.2);
            animal.Print();
            animal = new Lion();
            animal.Print();
            animal = new Lion(50,"Lion",330.32);
            animal.Print();

            Console.ReadLine();

        }
        
    }

    class Animals
    {
        private static int counter = 0;
        public Animals()
        {
            AnimalID = counter++;
            AnimalName = "Anything";
            power = 0;
        }

        public Animals(string AnimalName,double power)
        {

            this.AnimalID = counter++;
            this.AnimalName = AnimalName;
            this.power = power;
        }
        public int AnimalID { get; set; }
        public string AnimalName { get; set; }
        public double power { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Animal Name: "+AnimalName+  " And its Power: "+power);
        }

    }

    class Lion:Animals
    {
        public int beardLength { get; set; }
        public Lion():base()
        {
            beardLength = 10;
        }

        public Lion(int beardLength, string AnimalName, double power) :base(AnimalName,power)
        {
            this.beardLength = beardLength;
        }


        public override void Print()
        {
            Console.WriteLine("Animal Name: " + AnimalName + " And its Power: " + power+ " Well since I am a Lion I have a beard of Length "+beardLength);
        }
    }


    
}
