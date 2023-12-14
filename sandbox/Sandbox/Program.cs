using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("\nWelcome to the 'YouTube VIDEO' Program\n");

        // // Create Video 1 and comments
        // Video video1 = new Video("Legend Of The Seeker","Mike Williams",44.8);
        // Comment vid1Comment1 = new Comment("Mike Johnson","Wow! what a great movie");
        // Comment vid1Comment2 = new Comment("Prince Nwachukwu","I am not a fan of this type of Film but it's great");
        // Comment vid1Comment3 = new Comment("Sussan Cowel","I don't like this movie");
        // video1.UpdateComment(vid1Comment1);
        // video1.UpdateComment(vid1Comment2);
        // video1.UpdateComment(vid1Comment3);
        // video1.DisplayVideoDetails();

        // // Create Video 2 and comments
        // Video video2 = new Video("Spider-Man","Disney",60.3);
        // Comment vid2Comment1 = new Comment("Ikechukwu","No comments");
        // Comment vid2Comment2 = new Comment("Alma","Is it on sale already?");
        // Comment vid2Comment3 = new Comment("Marry Allison","The production of this movie is poor");
        // video2.UpdateComment(vid2Comment1);
        // video2.UpdateComment(vid2Comment2);
        // video2.UpdateComment(vid2Comment3);
        // video2.DisplayVideoDetails();

        // // Create Video 3 and comments
        // Video video3 = new Video("Captain America","Marvels",56);
        // Comment vid3Comment1 = new Comment("Matthew","Nice job by this team");
        // Comment vid3Comment2 = new Comment("Eddie","I Love the ending");
        // Comment vid3Comment3 = new Comment("Johnathan","Fantactis.\n Please when is the prt 2 comming out");
        // Comment vid3Comment4 = new Comment("Rosline Efe","I wish i had super powers");
        // video3.UpdateComment(vid3Comment1);
        // video3.UpdateComment(vid3Comment2);
        // video3.UpdateComment(vid3Comment3);
        // video3.UpdateComment(vid3Comment4);
        // video3.DisplayVideoDetails();




        // Console.WriteLine("\n\nWelcome to the 'ONLINE ORDERING' Program");
        // // Create Customer one and address
        // Address address1 = new Address("Yakubu-Habibu","Sagamu","Ogun State","Nigeria");
        // Customer customer1 = new Customer("Prince Nwachukwu",address1);
        // Order order1 = new Order(customer1);

        // // Create products for customer one and Add products to list
        // Product product1 = new Product("Soft-Drink","1245AG",190,3);
        // order1.ProductList(product1);
        // Product product2 = new Product("Bicycle","2496BI",1000,2);
        // order1.ProductList(product2);
        // Product product3 = new Product("Rice","3838JDH",50,8);  
        // order1.ProductList(product3);

        // // Diplay Orders of customer one
        // order1.ShippingLabel();
        // order1.PackingLabel();
        // order1.TotalCostOfOrder();

        // // Create Customer two and address
        // Address address2 = new Address("32, BYU street","BYU","Idaho","USA");
        // Customer customer2 = new Customer("Mr. Kenedy",address2);
        // Order order2 = new Order(customer2);

        // // Create products for customer two and Add products to list
        // Product product21 = new Product("Gucci Bag","1245AG",950,1);
        // order2.ProductList(product21);
        // Product product22 = new Product("Soap","2496BI",120,5);
        // order2.ProductList(product22);
        // Product product23 = new Product("Candy","3838JDH",22.8,10);  
        // order2.ProductList(product23);

        // // Diplay Orders of customer two
        // order2.ShippingLabel();
        // order2.PackingLabel();
        // order2.TotalCostOfOrder();




        // Console.WriteLine("\n\nWelcome to the 'EVENT PLANNING' Program\n");
        // Lectures lecturesPlan = new Lectures("Winning in Life","Prince Nwachukwu",4820,"Teaching you how to use samll businesses to become self-reliant","30/Nov/2023","4:00pm",new Address("Agura Palace","Sagamu","Lagos State","Nigeria"));
        // Console.WriteLine(lecturesPlan.StandardDetails());

        // Receptions receptions = new Receptions("Wedding Anniversery","Mr & Mrs. Johnathan invites you to their Third(3rd) wedding anniversery","12/08/2024","5:00pm - 7:00pm",new Address("2nd Victoria Avenue","Ikoyi","F.C.T Abuja","Nigeria"),"vera@gmail.com");
        // Console.WriteLine(receptions.FullDetails());

        // OutdoorGathering outdoorGathering = new OutdoorGathering("LDS Youngs Single Adult Picnic","Outdoor games event and Recreational activity","02/02/2023","2:00pm",new Address("LDS Church","Saint Park","New-York","USA"),"Sunny with a temprature of 25^degree");
        // Console.WriteLine(outdoorGathering.ShortDiscripton());




        Console.WriteLine("\n\nWelcome to the 'EXERCISE TRACKING' Program \n");
        Running running = new Running("12/10/2023", 30, 4.8);
        Swimming swimming = new Swimming("06/12/2023", 30, 10);
        StationaryBike stationaryBike = new StationaryBike("24/11/2023", 30, 9.7);


        List<Activitys> activitys = new List<Activitys>();
        activitys.Add(running);
        activitys.Add(swimming);
        activitys.Add(stationaryBike);

        foreach (Activitys active in activitys)
        {
            active.GetSummary();
        }
        // running.GetSummary();
        // swimming.GetSummary();
        // stationaryBike.GetSummary();
    }
}