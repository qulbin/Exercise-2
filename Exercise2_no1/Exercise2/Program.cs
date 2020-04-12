using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            double z;
            double hasil = 0;


            Console.WriteLine("Pilih option dari nomor 1 – 3 : \n1.Formula: (X * Y) + (Z * Y) \n2.Formula: (X + Y + Z) / X" +
                "\n3.Formula: (X - Z) * Y");
            Console.WriteLine("Silahkan pilih opsi: ");
            string caseInput = Console.ReadLine();

            switch (caseInput)
            {

                case "1":
                    Console.WriteLine("Formula: (X * Y) + (Z * Y)");
                    labelX:
                    try
                    {
                        Console.WriteLine("Input value X dalam bilangan bulat");
                        x = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("input salah");
                        goto labelX;
                    }

                    labely:
                    try
                    {
                        Console.WriteLine("Input value Y dalam bilangan bulat");
                        y = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("input salah!");
                        goto labely;
                    }

                    labelz:
                    try
                    {
                        Console.WriteLine("Input value Z dalam bilangan decimal");
                        z = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("input salah!");
                        goto labelz;
                    }

                    hasil = (x * y) + (z * y);
                    Console.WriteLine("Hasilnya dari Formula: (X * Y) + (Z * Y) adalah " + hasil);
                    break;

                case "2":
                    Console.WriteLine("2.Formula: (X + Y + Z) / X");
                    labelx2:
                    try
                    {
                        Console.WriteLine("Input value X dalam bilangan bulat");
                        x = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("input X dalam bilangan bulat!");
                        goto labelx2;
                    }

                    labely2:
                    try
                    {
                        Console.WriteLine("Input value Y dalam bilangan bulat");
                        y = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("input Y dalam bilangan bulat!");
                        goto labely2;
                    }

                    labelz2:
                    try
                    {
                        Console.WriteLine("Input value Z dalam bilangan decimal");
                        z = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("input Z dalam bilangan decimal!");
                        goto labelz2;
                    }

                    hasil = (x + y + z) / x;
                    Console.WriteLine("Hasilnya dari Formula: (X + Y + Z) / X adalah " + hasil);
                    break;

                case "3":
                    Console.WriteLine("3.Formula: (X - Z) * Y");
                    labelx3:
                    try
                    {
                        Console.WriteLine("Input value X dalam bilangan bulat");
                        x = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("input X dalam bilangan bulat!");
                        goto labelx3;
                    }

                    labely3:
                    try
                    {
                        Console.WriteLine("Input value Y dalam bilangan bulat");
                        y = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("input salah!");
                        goto labely3;
                    }

                    labelz3:
                    try
                    {
                        Console.WriteLine("Input value Z dalam bilangan decimal");
                        z = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("input salah!");
                        goto labelz3;
                    }

                    hasil = (x - z) * y;
                    Console.WriteLine("Hasilnya dari Formula: (X - Z) * Y adalah " + hasil);
                    break;
                default:
                    Console.WriteLine("Maaf, anda harus input antara 1 atau 2 atau 3");
                    break;
            }
            

        }
    }
}
