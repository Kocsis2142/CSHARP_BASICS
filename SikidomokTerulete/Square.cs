using System.Security.Principal;

namespace SikidomokTerulete
{
    public class Square
    {
        private int side;
        public Square(int side)
        {
            this.side = side;
        }

        public double Area()
        {
            return (double)(side * side);
        }
    }
}