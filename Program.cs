using System;

namespace Program
{
    class Application
    {
        static void Main(string[] args)
        {
            
            Delivery personal = new PersonalPickup();
            Delivery mail = new MailDelivery();
            Delivery courier = new CourierService();

           DisplayDelivery("STANDARD DELIVERY", personal);
           DisplayDelivery("MAIL DELIVERY", mail);
           DisplayDelivery("COURIER SERVICE", courier);

            
            // Util.Print(personal);
            // Util.Print(mail);
            // Util.Print(courier);
        }
        static void DisplayDelivery(string deliveryType, Delivery delivery)
        {
            Console.WriteLine($"=====================================");
            Console.WriteLine(deliveryType);
            Console.WriteLine($"-------------------------------------");
            Console.WriteLine($"- Address: {delivery.Address}");
            Console.WriteLine($"- City: {delivery.City}");
            Console.WriteLine($"- Phone: {delivery.Phone}");
            Console.WriteLine($"- DateTime: {delivery.DateTime}");
        }
    }

    // static class Util
    // {
    //     public static void Print(Delivery delivery)
    //     {
    //         Console.WriteLine(delivery.Address);
    //         Console.WriteLine(delivery.City);
    //         Console.WriteLine(delivery.Phone);
    //         Console.WriteLine(delivery.DateTime);
    //     }
    // }

    interface Delivery
    {
        string Address { get; set; }
        string City { get; set; }
        string Phone { get; set; }
        string DateTime { get; set; }
    }

    class PersonalPickup : Delivery
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string DateTime { get; set; }

        public PersonalPickup()
        {
            FirstName = "Clara";
            LastName = "Tyler";
            Address = "Ulica Republike Hrvatske 12";
            City = "Požega";
            Phone = "034-272-199";
            DateTime = "05/09/2023 16:08:24";
        }
    }

    class MailDelivery : Delivery
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string DateTime { get; set; }

         public MailDelivery()
        {
           
            Address = "Cvjetna 15";
            City = "Požega";
            Phone = "034-275-543";
            DateTime = "05/09/2023 17:09:43";
        }
    }

    class CourierService : Delivery
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string DateTime { get; set; }

         public CourierService()
        {
            Address = "Ul. Stjepana Radića 10";
            City = "Požega";
            Phone = "034-274-178";
            DateTime = "05/09/2023 14:02:25";
        }
    }
}


