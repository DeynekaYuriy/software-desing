// See https://aka.ms/new-console-template for more information
using DesignPatterns.Composite;
using lab_5;
using lab_5.Flyweight;
using lab_5.LightHTML;
using lab_5.MarvelHero;
using lab_5.MarvelHero.Logger;
using lab_5.TextReader;
using System.Text.RegularExpressions;

Console.WriteLine("1. Composite. LightHTML");
var ul = new LightElementNode("ul", NodeType.ElementNode, ClosureType.Even, new() { "class1", "class2" });
var li0 = new LightTextNode("li", "li0");

ul.AppendChild(li0);
Console.WriteLine(ul.OuterHTML());

//Console.WriteLine("\n2. Composite. Artefacts");

//var hero = new MarvelHero("IronMan", 100, new ConsoleArtefactLogger());
//var stone1 = new Artefact("InfinityStone", 5, 50);
//var stone2 = new Artefact("InfinityStone", 5, 50);
//var stone3 = new Artefact("InfinityStone", 5, 50);
//var stone4 = new Artefact("InfinityStone", 5, 50);
//var stone5 = new Artefact("InfinityStone", 5, 50);
//var gloves = new CompositeArtefact("GloveOfPower", 0, 0);
//gloves.AddArtefact(stone1);
//gloves.AddArtefact(stone2);
//gloves.AddArtefact(stone3);
//gloves.AddArtefact(stone4);
//gloves.AddArtefact(stone5);
//hero.AddArtefact(gloves);

//hero.CountArtefacts();
//hero.CalculateArtefactsWeight();
//hero.Strike();

//hero.RemoveArtefact(gloves);
//hero.CountArtefacts();
//hero.CalculateArtefactsWeight();
//hero.Strike();

//var artifact1 = new Artefact("1", 5, 1000);
//var artifact2 = new Artefact("2", 5, 1000);

//var container = new ArtefactContainer();
//container.AddArtefact(artifact1);
//container.AddArtefact(artifact2);
//hero.AddArtefact(container);

//hero.CountArtefacts();
//hero.CalculateArtefactsWeight();
//hero.Strike();

//Console.WriteLine("\n3. Proxy. FileReader");
//var path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName).FullName).FullName + "\\text.txt";
//Console.WriteLine(path);
//ITextReader reader = new SmartTextChecker(new ConsoleLogger());
//var content = reader.ReadText(path);

//reader = new SmartTextLocker(new Regex("text.txt"));
//reader.ReadText(path);

//Console.WriteLine("\n4. FlyWeight. ");
//var bookPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).FullName).FullName).FullName + "\\book.txt";
//MemoryMonitor.LogCurrentProccessMemory();
//Line[] lines = FileReader.ReadFile(bookPath);
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(lines[i].Node.GetHashCode());
//}
//MemoryMonitor.LogCurrentProccessMemory();
