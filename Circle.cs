using System;
namespace LR4 {
    public class Circle : CGraphicsObject {
        public double r { get; set; }
        public override double C { get; set; }
        public override double S { get; set; }
        public Circle(double x, double y, double r) {
            setX(x);
            setY(y);
            this.r = r;
            C = 2 * Math.PI * r;
            S = Math.PI * Math.Pow(r, 2);
        }
        public override sealed double getX() { return x; }
        public override sealed double getY() { return y;  }
        public override sealed void setX(double x) { this.x = x; }
        public override sealed void setY(double y) { this.y = y; }
        public override void Show() {
            base.Show();
            info += " -> Circle\n";
            info += "Square = " + Math.Round(S, 2) + "\nPerimeter = " + Math.Round(C, 2);
            Form1.draw(Form1.Item.Circle, (float)getX(), (float)getY(), (float)r, (float)r, info);
        }
    }
}
