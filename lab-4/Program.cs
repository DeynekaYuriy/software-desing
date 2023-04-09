using lab_4.Adapter;
using lab_4.Bridge;
using lab_4.Decorator;
using lab_4.Decorator.Hero;
using lab_4.Facade;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("1. Adapter");
var filePath = Path.Combine(Environment.CurrentDirectory, "log.txt");
FileWriter fileWriter = new FileWriter(filePath);
fileWriter.Write("Hi ");
fileWriter.WriteLine("there!");

var logger = new Logger();
logger.Log("Log");
logger.Warn("Warning");
logger.Error("error");
logger = new FileLoggerAdapter(filePath);
logger.Log("Log");
logger.Warn("Warning");
logger.Error("Error");

Console.WriteLine("\n2. Decorator");
IHero warrior = new Warrior();
warrior = new ClothesInventory("Cloak", warrior);
warrior = new WeaponInventory("Sword", warrior);
warrior = new ArtifactInventory("Hammer", warrior);
IHero mage = new Mage();
mage = new ClothesInventory("Cloak", mage);
mage = new WeaponInventory("Magic wand", mage);
IHero paladin = new Paladin();
paladin = new ClothesInventory("Armor", paladin);
paladin = new WeaponInventory("Spear", paladin);
Console.WriteLine(warrior.GetDescription());
Console.WriteLine(mage.GetDescription());
Console.WriteLine(paladin.GetDescription());

Console.WriteLine("\n3. Facade");
var menus = new MenuFacade();
var order = menus.BigMacMenuWithPakaging();
Console.WriteLine(order);

Console.WriteLine("\n4. Bridge");
var triangle = new Triangle(new VectorRender());
var square = new Square(new PixelRender());
var circle = new Circle(new PixelRender());
Console.WriteLine(triangle.Render());
Console.WriteLine(square.Render());
Console.WriteLine(circle.Render());
