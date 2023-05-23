﻿// See https://aka.ms/new-console-template for more information
using DesignPatterns.Composite;
using lab_5;
using lab_5.Flyweight;
using lab_5.LightHTML;
using lab_5.LightHTML.Strategy;
using lab_5.MarvelHero;
using lab_5.MarvelHero.Logger;
using lab_5.TextReader;
using System.Text.RegularExpressions;

//Console.WriteLine("1. Composite. LightHTML");
var ul = new LightElementNode("ul", NodeType.ElementNode, ClosureType.Even, new() { "class1", "class2" });
var li0 = new LightElementNode("li", NodeType.ElementNode, ClosureType.Even, new() { "class1" });
var span1 = new LightTextNode("span", "Text");
var span2 = new LightTextNode("span", "Text");
var p = new LightTextNode("p", "Paragraph");
var li1 = new LightElementNode("li", NodeType.ElementNode, ClosureType.Even, new() { "class1" });
var li2 = new LightElementNode("li", NodeType.ElementNode, ClosureType.Even, new() { "class1" });
li0.AppendChild(span1);
li0.AppendChild(span2);
ul.AppendChild(li1);
ul.AppendChild(li2);
li1.AppendChild(p);
ul.InsertBefore(li1, li0);
Console.WriteLine(ul.OuterHTML());
Console.WriteLine("Surface iterator:");
ul.Children.Strategy = new SurfaceStrategy();
printDOM();
Console.WriteLine("Depth iterator:");
ul.Children.Strategy = new DepthFirstStrategy();
printDOM();
Console.WriteLine("Breadth iterator:");
ul.Children.Strategy = new BreadthFirstStrategy();
printDOM();
void printDOM()
{
    foreach (var child in ul.Children)
    {
        Console.WriteLine($"{child.Tag}");
    }

}
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
