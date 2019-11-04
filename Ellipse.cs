using System;
namespace LR4 {
    public class Ellipse : CGraphicsObject {
        public double r1 { get; set; }
        public double r2 { get; set; }
        public override double C { get; set; }
        public override double S { get; set; }
        public Ellipse(double x, double y, double r1, double r2) {
            setX(x);
            setY(y);
            this.r1 = r1;
            this.r2 = r2;
            double loc = 3 * Math.Pow((r1 - r2) / (r1 + r2), 2);
            C = Math.PI * (r1 + r2) * (1 + (loc / (10 + Math.Sqrt(4 - loc))));
            S = Math.PI * r1 * r2;
        }
        public override sealed double getX() { return x; }
        public override sealed double getY() { return y; }
        public override sealed void setX(double x) { this.x = x; }
        public override sealed void setY(double y) { this.y = y; }
        public override void Show() {
            base.Show();
            info += " -> Ellipse\n";
            info += "Square = " + Math.Round(S, 2) + "\nPerimeter = " + Math.Round(C, 2);
            Form1.draw(Form1.Item.Ellipse, (float)getX(), (float)getY(), (float)r1, (float)r2, info);
        }
    }
}
