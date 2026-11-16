using OOP;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Polygon poly = new Polygon();

poly.Input();
Console.WriteLine("--------------------------------");

poly.Print();

try {
    Console.WriteLine("Довжини сторін:");
    double perimeter = poly.GetPerimeter();
    Console.WriteLine($"Периметр многокутника: {perimeter:F2}");

    double area = poly.GetArea();
    Console.WriteLine($"Площа многокутника: {area:F2}");
} catch (Exception ex) {
    Console.WriteLine($"Помилка: {ex.Message}");
}

Console.ReadLine();