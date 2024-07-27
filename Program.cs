/*Create a C# program that implements an IVehiculo interface with two methods, one for Drive of type void and another for Refuel of type bool that has a parameter of type integer with the amount of gasoline to refuel. Then create a Car class with a builder that receives a parameter with the car's starting gasoline amount and implements the Drive and Refuel methods of the car.

The Drive method will print on the screen that the car is Driving, if the gasoline is greater than 0. The Refuel method will increase the gasoline of the car and return true.


To carry out the tests, create an object of type Car with 0 of gasoline in the Main of the program and ask the user for an amount of gasoline to refuel, finally execute the Drive method of the car.

Input
50
Output
Driving*/
public interface Ivehiculo
{
    void Drive();
    bool refuel(int amount);
}
 class car : Ivehiculo
{
    public int gasoline;
    public car(int initialgasoline)
    {
        gasoline = initialgasoline;
    }
    public void drive()
    {
        if (gasoline>0)
        { Console.WriteLine("Driving");
        }

        else
        {
            Console.WriteLine("Not Enough gasoline to drive");
        }
  
    
    }
    public bool refuel(int amount)
    {if(amount>0)
        {
            gasoline += amount;
            return true;

        }
        return false;
    }
}
namespace Problem_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car mycar = new car(0);
            Console.WriteLine("Enter the amount of gasoline to refuel");
            if(int.TryParse(Console.ReadLine(),out int amount))
            {
                bool refueled = mycar.refuel(amount);
                if(refueled)
                { mycar.drive(); }
                else 
                { Console.WriteLine("Failed to refuel");
                
                }

            }
            else
            {
                Console.WriteLine("Invalid Entry! Please enter a neumaric value");
            }
        }
    }
}