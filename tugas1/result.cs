using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas1
{
    internal class result
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Mobil Sedan --");
            // Mobil Sedan
            MobilSedan Toyota = new MobilSedan("Toyota Vios", "Red", 2018);
            Console.WriteLine("Model: " + Toyota.model);
            Console.WriteLine("Warna: " + Toyota.color);
            Console.WriteLine("Tahun: " + Toyota.year);

            MobilSedan Honda = new MobilSedan("Honda Civic RS", "Crystal Black Pearl", 2024);
            Console.WriteLine("Model: " + Honda.model);
            Console.WriteLine("Warna: " + Honda.color);
            Console.WriteLine("Tahun: " + Honda.year);

            Console.WriteLine("-- Burung --");
            //Burung
            burung burung1 = new burung("Jalak Bali", "Hutan");
            Console.WriteLine("Nama burung: " + burung1.nama);
            Console.WriteLine("Habitat burung: " + burung1.habitat);

            burung burung2 = new burung("Merak: ", "Padang Rumput");
            Console.WriteLine("Nama burung: " + burung2.nama);
            Console.WriteLine("Habitat burung: " + burung2.habitat);

            Console.WriteLine("-- Ikan --");
            //Ikan
            ikan ikan1 = new ikan("Nemo", "Air Laut");
            Console.WriteLine("Nama ikan: " + ikan1.nama);
            Console.WriteLine("Habitat ikan: " + ikan1.habitat);

            ikan ikan2 = new ikan("Lele", "Air Tawar");
            Console.WriteLine("Nama ikan: " + ikan2.nama);
            Console.WriteLine("Habitat ikan: " + ikan2.habitat);

            Console.WriteLine("-- Komputer --");
            //Komputer
            komputer model1 = new komputer("Macbook Air M1", "Mac OS");
            Console.WriteLine("Model atau nama: " + model1.model);
            Console.WriteLine("Sistem Operasi: " + model1.sistem_operasi);

            komputer model2 = new komputer("Zyrex Kintamani", "Windows");
            Console.WriteLine("Model atau nama: " + model2.model);
            Console.WriteLine("Sistem Operasi: " + model2.sistem_operasi);


        }



    }
}
