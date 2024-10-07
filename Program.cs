using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    public class Program
    {
        static void Main(string[] args)
        {
            Palack narancsle = new Palack("Narancslé", 500, 300);
            Palack sprite = new Palack("Sprite", 500, 0);
            VisszavalthatoPalack fanta = new VisszavalthatoPalack("Fanta", 500, 250, 30);
            VisszavalthatoPalack kokaKola = new VisszavalthatoPalack("Kóla", 500, 250);

            Console.WriteLine(narancsle.ToString());
            Console.WriteLine(sprite.ToString());
            Console.WriteLine(fanta.ToString());
            Console.WriteLine(kokaKola.ToString());

            narancsle.HozzaOnt(sprite);
            Console.WriteLine("\nNarancslé és Sprite összeöntve:");
            Console.WriteLine(narancsle.ToString());

            fanta.HozzaOnt(kokaKola);
            Console.WriteLine("\nFanta és Kóla összeöntve:");
            Console.WriteLine(fanta.ToString());

            Rekesz rekesz = new Rekesz(2000);
            rekesz.UjPalack(narancsle);
            rekesz.UjPalack(fanta);
            rekesz.UjPalack(sprite);
            rekesz.UjPalack(kokaKola);

            Console.WriteLine($"\nRekesz súlya: {Math.Round(rekesz.Suly())} g");

            Console.WriteLine($"Visszaváltási pénz: {rekesz.OsszesPenz()} Ft");

            Console.ReadKey();
        }
    }
}
