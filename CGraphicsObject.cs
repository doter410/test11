namespace LR4 {
    public abstract class CGraphicsObject {
        protected double x, y;
        protected string info;
        public abstract double C { get; set; }
        public abstract double S { get; set; }
        public abstract double getX();
        public abstract double getY();
        public abstract void setX(double x);
        public abstract void setY(double y);
        public static double operator +(CGraphicsObject a, CGraphicsObject b) {
            return a.C + b.C;
        }
        public static double operator +(double a, CGraphicsObject b) {
            return a + b.C;
        }
        public virtual void Show() {
            info = "Object -> CGraphicsObject";
        }
    }
}
