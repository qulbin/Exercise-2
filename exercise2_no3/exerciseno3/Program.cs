using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciseno3
{
    class Program
    {
        static void Main(string[] args)
        {
            int drone;
            int x=0;
            int y=0;
            int pindahX;

            Console.WriteLine("Sebuah drone berada pada koordinate X = 0, Y = 0");
            Console.WriteLine("Setiap kali coordinate X bergerak, Y bergerak 3 kalinya.");

            drone:
            try
            {
                Console.WriteLine("Berapa kali perpindahan drone?");
                drone = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input harus berupa interger!");
                goto drone;
            }
            
            perpindahan:
            try
            {
                Console.WriteLine("Berapa point perpindahan X setiap kali bergerak?");
                pindahX = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Maaf input belum benar, coba lagi");
                goto perpindahan;
            }

            for(int i = 0; i<drone; i++)
            {
               int xbaru = x + pindahX;
               int ybaru = y + (pindahX * 3);
               Console.WriteLine("X bergerak dari " + x + " ke " + xbaru + ", dan Y bergerak dari " + y + " ke " + ybaru);
                x = xbaru;
                y = ybaru;
            }


          
        }
    }
}
