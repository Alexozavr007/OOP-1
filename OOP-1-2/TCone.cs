using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14 {
    internal class TCone : TCircle{
        protected double height;

        public double Height {
            get { return height; }
            set { height = value >= 0 ? value : 0; }
        }

        public TCone() : base() {
            Height = 0;
        }

        public TCone(double r, double h) : base(r) {
            Height = h;
        }

        public TCone(TCone other) : base(other) {
            Height = other.Height;
        }

        public override void Input() {
            base.Input();
            Console.Write("Введіть висоту конуса: ");
            if (double.TryParse(Console.ReadLine(), out double h)) {
                Height = h;
            }
        }

        public override string ToString() {
            return $"Конус (Радіус основи: {Radius}, Висота: {Height})";
        }

        public double GetVolume() {
            return (1.0 / 3.0) * base.GetArea() * Height;
        }
    }
}
