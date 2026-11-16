using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP {
    public struct Point2D {
        public double X { get; set; }
        public double Y { get; set; }

        public Point2D(double x, double y) {
            X = x;
            Y = y;
        }

        public override string ToString() {
            return $"({X}; {Y})";
        }
    }
    internal class Polygon {
        private List<Point2D> vertices;

        public Polygon() {
            vertices = new List<Point2D>();
        }

        public void Input() {
            vertices.Clear();
            Console.Write("Введіть кількість вершин многокутника: ");
            var n = Convert.ToInt32(Console.ReadLine());
            if (n < 3) {
                Console.WriteLine("Помилка! Многокутник повинен мати хоча б 3 вершини.");
                return;
            }

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"--- Вершина {i + 1} ---");
                Console.Write("X: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Y: ");
                double y = Convert.ToDouble(Console.ReadLine());

                vertices.Add(new Point2D(x, y));
            }
        }

        public void Print() {
            if (vertices.Count == 0) {
                Console.WriteLine("Многокутник не задано (немає вершин).");
                return;
            }

            Console.Write("Вершини многокутника: ");
            Console.WriteLine(string.Join(", ", vertices));
        }

        public double this[int index] {
            get {
                if (vertices.Count < 3)
                    throw new Exception("Многокутник повинен мати щонайменше 3 вершини.");

                if (index < 0 || index >= vertices.Count)
                    throw new Exception("Невірний індекс сторони.");

                Point2D p1 = vertices[index];
                Point2D p2 = vertices[(index + 1) % vertices.Count];

                return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            }
        }

        public double GetPerimeter() {
            double perimeter = 0;
            for (int i = 0; i < vertices.Count; i++) {
                perimeter += this[i];
            }
            return perimeter;
        }

        public double GetArea() {
            if (vertices.Count < 3)
                return 0;

            double area = 0;
            for (int i = 0; i < vertices.Count; i++) {
                Point2D p1 = vertices[i];
                Point2D p2 = vertices[(i + 1) % vertices.Count];

                area += (p1.X * p2.Y) - (p2.X * p1.Y);
            }

            return Math.Abs(area) / 2.0;
        }
    }
}
