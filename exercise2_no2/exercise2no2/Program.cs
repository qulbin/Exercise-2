using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2no2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulan;
            int tahun;
            int tanggal;
            bool validasiBulan = true;

            labelBulan:
            try
            {
                Console.WriteLine("masukkan bulan (1-12)!");
                bulan = int.Parse(Console.ReadLine());
                while ( bulan < 1 || bulan > 12)
                {
                    bulan = int.Parse(Console.ReadLine());
                }
                validasiBulan = false;
            }
            catch
            {
                Console.WriteLine("Harus input antara 1 sampai 12! ");
                goto labelBulan;

            }

            Console.WriteLine("----------------------------------------------");
            label_tahun:
            try
            {
                Console.WriteLine("masukkan TAHUN!");
                tahun = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input masih salah, tolong coba lagi ");
                goto label_tahun;
            }

            tanggal = DateTime.DaysInMonth(tahun, bulan);

            DateTime newTanggal = new DateTime(tahun, bulan, tanggal);
            string dateName = newTanggal.ToString("dd MMMM yyyy");


            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("Pilih nomor 1 - 3 : \n1. Penambahan Hari \n2. Penambahan Bulan " +
            "\n3. Penambahan Tahun ");
            Console.WriteLine("Silahkan pilih opsi: ");
            string caseInput = Console.ReadLine();

            switch(caseInput)
            {
                case "1":
                    Console.WriteLine("1. Penambahan Hari");
                    H:
                    try
                    {
                        Console.Write("Berapa hari kemudian dari tanggal hari ini \t: ");
                        int tambahHari = int.Parse(Console.ReadLine());

                        DateTime totalTambahHari = newTanggal.AddDays(tambahHari);
                        string finalhari = totalTambahHari.ToString("dd MMMM yyyy");

                        Console.WriteLine("Tanggal input sebelum perubahan \t\t: " + dateName);
                        Console.WriteLine(tambahHari + " hari kemudian adalah \t\t\t\t: " + finalhari);
                    }
                    catch
                    {
                        Console.WriteLine("Inputan yang anda masukkan salah. Silahkan coba lagi");
                        goto H;
                    }
                    break;
                case "2":
                    Console.WriteLine("2. Penambahan Bulan");
                    B:
                    try
                    {
                        Console.Write("Berapa bulan kemudian dari tanggal hari ini \t: ");
                        int tambahBulan = int.Parse(Console.ReadLine());

                        DateTime totalTambahBulan = newTanggal.AddMonths(tambahBulan);
                        string finalBulan = totalTambahBulan.ToString("dd MMMM yyyy");

                        Console.WriteLine("Tanggal input sebelum perubahan \t\t: " + dateName);
                        Console.WriteLine(tambahBulan + " bulan kemudian adalah \t\t\t: " + finalBulan);
                    }
                    catch
                    {
                        Console.WriteLine("Inputan yang anda masukkan salah. Silahkan coba lagi");
                        goto B;
                    }


                    break;
                case "3":
                    Console.WriteLine("3. Penambahan Tahun");
                    T:
                    try
                    {
                        Console.Write("Berapa tahun kemudian dari tanggal hari ini \t: ");
                        int tambahTahun = int.Parse(Console.ReadLine());

                        DateTime totalTambahTahun = newTanggal.AddYears(tambahTahun);
                        string finaltahun = totalTambahTahun.ToString("dd MMMM yyyy");

                        Console.WriteLine("Tanggal input sebelum perubahan\t\t\t: " + dateName);
                        Console.WriteLine(tambahTahun + " tahun kemudian adalah \t\t\t: " + finaltahun);
                    }
                    catch
                    {
                        Console.WriteLine("Inputan yang anda masukkan salah. Silahkan coba lagi");
                        goto T;
                    }


                    break;
                default:
                    Console.WriteLine("Maaf, anda harus input antara 1 atau 2 atau 3");
                    break;
            }
        }
    }
}
