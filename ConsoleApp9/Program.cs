using System;

namespace ConsoleApp9
{
    class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public string Index { get; set; }

    }
    class Program
    {
        static void Main()
        {
            Address address = new Address();

            address.Country = "Ukraine";
            address.City = "Kiev";
            address.Street = "Lobachevskogo Street";
            address.House = "23";
            address.Apartment = "601";
            address.Index = "11111";

            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);
            Console.WriteLine(address.Index);

            Console.ReadKey();
        }
    }
}
