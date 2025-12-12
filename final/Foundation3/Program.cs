using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Antananarivo", "Analamanga", "Madagascar");
        Address address2 = new Address("456 Oak Ave", "Antsirabe", "Vakinakaratra", "Madagascar");
        Address address3 = new Address("789 Pine Rd", "Madison", "WI", "USA");

        Event lecture = new Lecture("The Future of AI", "An in-depth look at the advancements in artificial intelligence.", "12 December 2025", "11:00 AM",
            address1,
            "Dr. Jane Smith",
            150
        );

        Event reception = new Reception("Networking Reception", "An opportunity to network with professionals in your field.", "12 December 2025", "10:00 AM",
            address2, "tiana2512@gmail.com");

        Event outdoorGathering = new OutDoorGathering("Summer Festival", "A fun-filled outdoor festival with music, food, and games.", "12 December 2025", "2:00 PM",
            address3, "Sunny with a chance of showers");

        Event[] events = new Event[] { lecture, reception, outdoorGathering };

            foreach (Event ev in events)
            {
                Console.WriteLine("----- Standard Details -----");
                Console.WriteLine(ev.GetStandardDetails());
                Console.WriteLine();

                Console.WriteLine("----- Full Details -----");
                Console.WriteLine(ev.GetFullDetails());
                Console.WriteLine();

                Console.WriteLine("----- Short Description -----");
                Console.WriteLine(ev.GetShortDescription());
                Console.WriteLine();
            }
    }
}