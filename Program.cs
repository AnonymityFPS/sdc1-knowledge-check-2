using System;

namespace SDC1_Knowledge_Check_2
{
    class Program
    {
        private static void Main(string[] args)
        {



            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Apartment>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var apartment = new Apartment();
                Console.WriteLine("Whats the Name of the Property");
                apartment.Name = Console.ReadLine();
                Console.WriteLine("Enter the Address ");
                apartment.Address = Console.ReadLine();
                Console.WriteLine("Enter the Rent of the Property ");
                apartment.Rent = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Number of Apartments in the Building");
                apartment.NumberOfApartments = int.Parse(Console.ReadLine());



                recordList.Add(apartment);

            }
            foreach (var apartment in recordList)
            {
                Console.WriteLine(apartment.ToString());
            }
        }
    }
}


