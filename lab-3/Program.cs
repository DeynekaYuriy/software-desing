using lab_3.AbstractFactory.Factories;
using lab_3.AbstractFactory.Interfaces;
using lab_3.Builder;
using lab_3.FabricMethod;
using lab_3.Prototype;
using lab_3.Singleton;
using System.Text;
using static lab_3.AbstractFactory.Enums.Sizes;
using static lab_3.Prototype.VirusTypes;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\nFactory Method:");
        var premiumCreator = new PremiumSubscriptionCreator();
        var educationalCreator = new EducationalSubscriptionCreator();
        var domesticCreator = new DomesticSubscriptionCreator();
        var website = new WebSite();
        var mobileApp = new MobileApp();
        var managerCall = new ManagerCall();
        Console.WriteLine("Premium created with website:");
        Console.WriteLine($"Price: {website.Subscribe(premiumCreator).MonthlyFee}");
        Console.WriteLine("Educational created with manager call:");
        Console.WriteLine($"Price: {managerCall.Subscribe(educationalCreator).MonthlyFee}");
        Console.WriteLine("Domestic created with mobile app:");
        Console.WriteLine($"Price: {mobileApp.Subscribe(domesticCreator).MonthlyFee}");

        Console.WriteLine("\nAbstract Factory:");
        List<IClothes> clothesList = new();
        IClothesFactory[] factories = new IClothesFactory[] { new BabyClothesFactory(), new MaleClothesFactory(), new FemaleClothesFactory() };
        foreach (IClothesFactory factory in factories)
        {
            clothesList.AddRange(CreateClothes(factory, ClothesSize.M, ClothesSize.Size40));
        }
        foreach (IClothes clothes in clothesList)
        {
            Console.WriteLine(clothes.Name);
        }

        /*Console.WriteLine("\nSingleton: ");
        for (var i = 0; i < 10; i++)
        {
            new Thread(() =>
            {
                Console.WriteLine("Attempt to initialize");
                var repository = DatabaseRepository.GetInstance();
            }).Start();
        }
        var orders = DatabaseRepository.GetInstance().GetOrders();
        Console.WriteLine("Orders: ");
        foreach (var order in orders)
        {
            Console.WriteLine(order);
        }*/


        Console.WriteLine("\nPrototype: ");
        Virus mainVirus = new Virus("Main Virus", VirusType.Unknwn, 10, 23);
        var virusB = mainVirus.Clone("Virus B");
        var virusB1 = virusB.Clone("Virus B1");
        var virusB2 = virusB.Clone("Virus B2");
        var virusB22 = virusB2.Clone("Virus B2-2");
        var virusB23 = virusB2.Clone("Virus B2-3");
        var virusB22_2022 = virusB23.Clone("Virus B2-2 2022");
        var virusB22_2023 = virusB23.Clone("Virus B2-2 2023");
        var virusC = mainVirus.Clone("Virus C");
        var virusC1 = virusC.Clone("Virus C1");
        Console.WriteLine("Main Virus hierarchy:");
        Console.WriteLine(mainVirus.GetVirusChilds());

        Console.WriteLine("\nBuilder:");
        var director = new CharacterDirector(new HeroBuilder());
        var hero = director.MakeNationalist();
        director.SetBuilder(new EnemyBuilder());
        var enemy = director.MakeCommunist();
        Console.WriteLine("\nHero:");
        Console.WriteLine(hero.ToString());
        Console.WriteLine("Enemy:");
        Console.WriteLine(enemy.ToString());

    }

    public static List<IClothes> CreateClothes(IClothesFactory factory, ClothesSize clothesSize, ClothesSize shoeSize)
    {
        var clothes = new List<IClothes>
        {
            factory.CreateSocks(shoeSize),
            factory.CreateCap(clothesSize),
            factory.CreateTShirt(clothesSize),
            factory.CreateShoes(shoeSize)
        };
        return clothes;
    }
}