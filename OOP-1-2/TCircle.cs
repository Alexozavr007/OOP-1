using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14 {
    internal class TCircle {
        protected double radius;

        public double Radius {
            get { return radius; }
            set { radius = value >= 0 ? value : 0; }
        }

        public TCircle() {
            Radius = 0;
        }

        public TCircle(double r) {
            Radius = r;
        }

        public TCircle(TCircle other) {
            Radius = other.Radius;
        }

        public virtual void Input() {
            Console.Write("Введіть радіус: ");
            if (double.TryParse(Console.ReadLine(), out double r)) {
                Radius = r;
            }
        }

        public virtual void Output() {
            Console.WriteLine(this.ToString());
        }

        public override string ToString() {
            return $"Коло (Радіус: {Radius})";
        }

        public virtual double GetArea() {
            return Math.PI * Radius * Radius;
        }

        public double GetSectorArea(double angleDegrees) {
            return Math.PI * Radius * Radius * angleDegrees / 360.0;
        }

        public double GetCircumference() {
            return 2 * Math.PI * Radius;
        }

        public int CompareTo(TCircle other) {
            if (other == null) return 1;
            return this.Radius.CompareTo(other.Radius);
        }

        public static TCircle operator +(TCircle c1, TCircle c2) {
            return new TCircle(c1.Radius + c2.Radius);
        }

        public static TCircle operator -(TCircle c1, TCircle c2) {
            return new TCircle(Math.Abs(c1.Radius - c2.Radius));
        }

        public static TCircle operator *(double multiplier, TCircle c) {
            return new TCircle(c.Radius * multiplier);
        }

        public static TCircle operator *(TCircle c, double multiplier) {
            return new TCircle(c.Radius * multiplier);
        }
    }
}
