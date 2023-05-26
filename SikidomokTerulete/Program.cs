using System.Security.Principal;

namespace SikidomokTerulete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(side: 4);

            Console.WriteLine($"A négyzet területe: {square.Area()}");

            var circle = new Circle(radius: 10);

            Console.WriteLine($"A kör területe: {circle.Area()}");

            var triange = new Triange(triangeBase: 6, triangeHight: 4);

            Console.WriteLine($"A háromszög területe: {triange.Area()}");

            var areasum = square.Area();

            areasum = areasum + circle.Area();

            areasum += triange.Area();

            Console.WriteLine($"A területek összege: {areasum}");

            Console.ReadLine();
        }
    }
}