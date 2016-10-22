using System;
using System.Linq;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(String[] args)
        {
            //Animal Object pointing towards the subclass object
            Animals animal = new Animals("Dog", 23.2);
            animal.Print();
            //Animal class object representing the subclass using inheritance
            animal = new Lion();
            //Print the subclass print method using the override property
            animal.Print();
            //Animal class object calling Lion class and instantiating the members of the parent Animal
            animal = new Lion(50,"Lion",330.32);
            animal.Print();

            Lion ls = new Lion();
            ls.Print();
            //ls = new Animals(); // This wont compile as the child can never point to a parent or become necessarily a parent
            
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

        /// <summary>
        /// Print method for the parent class and mentioned as virtual so it can be used by subclasses
        /// </summary>
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
