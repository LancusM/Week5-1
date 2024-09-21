using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_1
{
    internal class Program
    {
        class Vehicle
        {
            //makes the variables/fields, whatever, of Make, Model, Year, and MaxSpeed. (I don't fully know if the get, set is necessary, but it is here if so.
            public string Make {  get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public int MaxSpeed { get; set; }
            /* I originally made it with each of the new objects calling the Make, then the Model, etc, in separate lines.
             * Then I remembered there was a better way, which was the constructors! So I added that in to make things a lot cleaner and easier. */
            public Vehicle(string theMake, string theModel, int theYear, int theMaxSpeed)
            {
                Make = theMake;
                Model = theModel;
                Year = theYear;
                MaxSpeed = theMaxSpeed;
            }
            //Displays each in it's own space, but the classes later override it and ass their respective properties.
            public virtual void DisplayInfo()
            {
                Console.WriteLine("Make: " + Make);
                Console.WriteLine("Model: " + Model);
                Console.WriteLine("Year: " + Year);
                Console.WriteLine("MaxSpeed: " + MaxSpeed);
                Console.WriteLine();
            }
            public class Car : Vehicle
            {
                public int NumberOfDoors { get; set; }
                /* Easy, simply grab each of the fields and input them through, and add NumberOfDoors
                 * I didn't know this before, but you need the base:(theMake, etc) part because the sode basically needs to understand that the temp variables are from the bsae constructor
                 * So they can then be used in the new class. */
                public Car(string theMake, string theModel, int theYear, int theMaxSpeed, int theNumberOfDoors) : base(theMake, theModel, theYear, theMaxSpeed)
                {
                    NumberOfDoors = theNumberOfDoors;
                }
                public override void DisplayInfo()
                {
                    //I'm pretty sure you can't use polymorphism/override, and still get the original lines, so I simply put them all again here, plus the 'title' and NumberOfDoors
                    Console.WriteLine("YOUR CAR:");
                    Console.WriteLine("Make: " + Make);
                    Console.WriteLine("Model: " + Model);
                    Console.WriteLine("Year: " + Year);
                    Console.WriteLine("MaxSpeed: " + MaxSpeed);
                    Console.WriteLine("Number of Doors: " + NumberOfDoors);
                    Console.WriteLine();
                }
                //Near everything is identical in meaning and undersatnding for Motorcycle!
                public class Motorcycle : Vehicle
                {
                    public bool HasSidecar { get; set; }
                    public Motorcycle(string theMake, string theModel, int theYear, int theMaxSpeed, bool ifHasSidecar) : base(theMake, theModel, theYear, theMaxSpeed)
                    {
                        HasSidecar = ifHasSidecar;
                    }
                    public override void DisplayInfo()
                    {
                        Console.WriteLine("YOUR MOTORCYCLE:");
                        Console.WriteLine("Make: " + Make);
                        Console.WriteLine("Model: " + Model);
                        Console.WriteLine("Year: " + Year);
                        Console.WriteLine("MaxSpeed: " + MaxSpeed);
                        Console.WriteLine("Has Sidecar: " + HasSidecar);
                        Console.WriteLine();
                    }
                    static void Main(string[] args)
                    {
                        //This is where I realized the constructor change, because it was originally far too long.
                        Car newCar = new Car("Honda", "SUV", 2006, 150, 4);
                        //I also did too much research necessary because I don't know Car or Motorcycle brands or models and that stuff. So it's probably right, but that's not the important stuff.
                        Motorcycle newMotorcycle = new Motorcycle("Harley Davidson", "Cruiser", 1995, 200, false);
                        //Then they each call on DisplayInfo, and they override the original to add their respective properties.
                        newCar.DisplayInfo();
                        newMotorcycle.DisplayInfo();
                        Console.Read();
                        /* I hope the amount of comments I am putting is acceptable, because the more I comment about, it usually means I am saying more for my sake, especially if I don't know a lot.
                         * The less I comment, or the more simple and straightforward it is (with some but not 100% explanation), the more confident that I do know. */
                    }
                }
            }
        }
    }
}
