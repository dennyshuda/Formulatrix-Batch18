// See https://aka.ms/new-console-template for more information
using StructDemo;


BasicPoint p1 = new(3, 4);
Console.WriteLine(p1.ToString());
Console.WriteLine(p1.DistanceFromOrigin());
Console.WriteLine(BasicPoint.Distance(p1, new BasicPoint(0, 0)));