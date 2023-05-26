namespace SikidomokTerulete
{
    public class Triange
    {
        private int triangeBase;
        private int triangeHight;

        public Triange(int triangeBase, int triangeHight)
        {
            this.triangeBase = triangeBase;
            this.triangeHight = triangeHight;
        }

        internal int Area()
        {
            return (triangeBase * triangeHight) / 2; 
        }
    }
}