namespace SikidomokTerulete
{
    public class Circle
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return (radius * 2) * Math.PI; 
        }
    }
}