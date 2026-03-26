using System;

class Program
{
    static void Main(string[] args)
    {
        ///////////////////////////////PRODUCTS///////////////////////////////////////////
        int toysId = 1;
        string toys = "Toys";
        double toysP = 34.5;

        int planetsId = 2;
        string planets = "Planets";
        double planetsP = 2.69;

        int tiresId = 3;
        string tires = "Tires";
        double tiresP = 60.64;

        int catsId = 4;
        string cats = "Cats";
        double catsP = 399.24;

        ///////////////////////////////PERSONAL INFO///////////////////////////////////////////
        /// 
        string c1Name = "John Helldiver";

        string c1Street1 = "14 Pain 33rd";
        string c1City1 = "CyberStan";
        string c1State1 = "New York";
        string c1Country1 = "US";
        int c1ZipCode1 = 43503;

        string c1Street2 = "100 Glory 1st";
        string c1City2 = "SuperEarth";
        string c1State2 = "Washington";
        string c1Country2 = "US";
        int c1ZipCode2 = 00001;

        ///////////////////////////////LOGIC///////////////////////////////////////////



        Address c1Address1 = new Address(c1Street1, c1City1, c1State1, c1Country1, c1ZipCode1);
        Address c1Address2 = new Address(c1Street2, c1City2, c1State2, c1Country2, c1ZipCode2);
        Customer c1 = new Customer(c1Name, c1Address1);

        Product c1Or1P1 = new Product(toys, toysP, toysId, 6);
        Product c1Or1P2 = new Product(planets, planetsP, planetsId, 2);

        List<Product> c1AllProducts1 = new List<Product>();
        c1AllProducts1.Add(c1Or1P1);
        c1AllProducts1.Add(c1Or1P2);

        Order c1Order1 = new Order(c1AllProducts1, c1);



        Product c1Or2P1 = new Product(tires, tiresP, tiresId, 4);
        Product c1Or2P2 = new Product(cats, catsP, catsId, 5);

        List<Product> c1AllProducts2 = new List<Product>();
        c1AllProducts2.Add(c1Or2P1);
        c1AllProducts2.Add(c1Or2P2);

        Order c1Order2 = new Order(c1AllProducts2, c1);




        ///////////////////////////////DISPLAY///////////////////////////////////////////
        Console.WriteLine("Online Order!\n");
        Console.WriteLine($"Dear {c1.DisplayName()}");
        Console.WriteLine($"Here're your Orders\n\nOrder#1\n{c1Order1.GetPackingLabel()}");
        Console.WriteLine($"Price: {c1Order1.ComputeTotal()}$ including shipping");
        Console.WriteLine("");
        Console.WriteLine($"Order #2\n{c1Order2.GetPackingLabel()}");
        Console.WriteLine($"Price: {c1Order2.ComputeTotal()}$ including shipping");
        Console.WriteLine("");
        Console.WriteLine($"We share your shipping label: {c1Order1.GetShippingLabel()}");
    }
}