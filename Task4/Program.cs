using Task4;

Point point1 = new Point(0, 0, 0, 98);

Console.WriteLine($"Point 1: x = {point1.X}, y = {point1.Y}, z = {point1.Z}, mass = {point1.Mass}");
Console.WriteLine(point1.IsZero());

Point point2 = new Point();
point2.X = 15;
point2.Y = 2;
point2.Z = 64;
point2.Mass = 25;
Console.WriteLine($"Point 2: x = {point2.X}, y = {point2.Y}, z = {point2.Z}, mass = {point2.Mass}");
Console.WriteLine(point2.IsZero());

point2.Mass = -100;
Console.WriteLine(point2.Mass);

Console.WriteLine("Distance between: " + point1.CalculateDistance(point2));