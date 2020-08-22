using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab4
{
    class Program
    {
        class Person
        {
            public string firstName;
            public string middleName;
            public string lastName;
            public string Street1;
            public string Street2;
            public string City;
            public string State;
            public string Zip;
            public string Phone;
            

        }
        static void Main(string[] args)
        {
            //Helps not create errors from user
            bool boolResult = false;

            //Allows for temp to be used
            Person temp = new Person();

            //Gathers first name
            Console.Write("\nPlease enter your first name: ");
            temp.firstName = Console.ReadLine();
            temp.firstName += " Poopy";

            //Gathers middle name 
            Console.Write("\nPlease enter your middle name: ");
            temp.middleName = Console.ReadLine();

            //Gathers last name
            Console.Write("\nPlease enter your last name: ");
            temp.lastName = Console.ReadLine();

            //Gathers Street1
            Console.Write("\nPlease enter your primary street address: ");
            temp.Street1 = Console.ReadLine();

            //Gathers Street2
            Console.Write("\nPlease enter any secondary street address (leave blank if there isn't any): ");
            temp.Street2 = Console.ReadLine();

            //Gathers City
            Console.Write("\nPlease enter your city: ");
            temp.City = Console.ReadLine();

            //Gathers State
            Console.Write("Please enter your State (MA,CA,FL,etc): ");
            temp.State = Console.ReadLine();

            //Gathers Zip
            Console.Write("Please enter your zip code: ");
            temp.Zip = Console.ReadLine();

            //Gathers Phone
            Console.Write("Please enter your phone number (with dashes):");
            temp.Phone = Console.ReadLine();
            Console.Clear();
            //PRINTS DATA

            Console.Write("Here is the information we gathered");
            Console.Write("\n-----------------------------------");
            Console.Write($"\nFirst Name: {temp.firstName}");
            Console.Write($"\nMiddle Name: {temp.middleName}");
            Console.Write($"\nLast Name: {temp.lastName}");
            Console.Write($"\nStreet 1: {temp.Street1}");
            Console.Write($"\nStreet 2: {temp.Street2}");
            Console.Write($"\nCity: {temp.City}");
            Console.Write($"\nState: {temp.State}");
            Console.Write($"\nZip: {temp.Zip}");
            Console.Write($"\nPhone: {temp.Phone}");

            Console.Write("\nPress any key to exit: ");
            Console.ReadKey();
        }
    }
}