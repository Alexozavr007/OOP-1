using ConsoleApp14;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("--- Тестування класу TCircle ---");
TCircle circle1 = new TCircle(5);
TCircle circle2 = new TCircle(3);

circle1.Output();
circle2.Output();

Console.WriteLine($"Площа кола 1: {circle1.GetArea():F2}");
Console.WriteLine($"Площа сектора (90 градусів) кола 1: {circle1.GetSectorArea(90):F2}");
Console.WriteLine($"Довжина кола 1: {circle1.GetCircumference():F2}");

Console.WriteLine("--- Тестування операторів ---");
TCircle sumCircle = circle1 + circle2;
Console.WriteLine($"Додавання (c1 + c2): {sumCircle}");

TCircle diffCircle = circle2 - circle1;
Console.WriteLine($"Віднімання за модулем (c2 - c1): {diffCircle}");

TCircle mult1 = 2.5 * circle1;
TCircle mult2 = circle2 * 2;
Console.WriteLine($"Множення (число * c1): {mult1}");
Console.WriteLine($"Множення (c2 * число): {mult2}");

Console.WriteLine("--- Тестування класу-нащадка TCone ---");
TCone cone = new TCone(4, 10);
cone.Output();
Console.WriteLine($"Об'єм конуса: {cone.GetVolume():F2}");

Console.WriteLine("Введення даних для нового конуса:");
TCone customCone = new TCone();

customCone.Input();
customCone.Output();
Console.WriteLine($"Об'єм введеного конуса: {customCone.GetVolume():F2}");

Console.ReadLine();