using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace employer
{
    class Program
    {

        static double Atlag(List<Employe> em)
        {
            return em.Average(e => e.Salary);
            
        }
        
        //static double developer(List<Employe> dev)
        //{
        //    return dev = employer.Where(e => e.Position == "Developer").Average(e => e.Salary);
        //}

        static void Main(string[] args)
        {
            List<Employe> employer = new List<Employe>();

            using StreamReader sr = new StreamReader(path: @"..\..\..\src\employe.txt");

            foreach (var i in File.ReadAllLines(@"..\..\..\src\employe.txt"))
            {
                employer.Add(new Employe(i));
            }

            Console.WriteLine($"Az átlag életkor {employer.Average(e => e.Age)} ");
            double atlagar = employer.Average(e => e.Age);


            Employe legidosebb = employer.OrderBy(e => e.Age).Last();
            Console.WriteLine($" A legidősebb ember: {legidosebb.Age}");

            int ev = 30;
            foreach (var i in employer)
            {
                if (ev < i.Age)
                {
                    Console.WriteLine($"{i.Name} 30 év felett van");
                }
                else if (ev > i.Age)
                {
                    Console.WriteLine($"{i.Name} 30 év alatt van");
                }


            }

            var harevfelett = employer.Where(e => e.Age > 30).Select(e => e.Name).ToArray();

            foreach (var item in harevfelett)
            {
                Console.Write("Az új tömb hasznos tartalma:");
                Console.WriteLine(item);
            }



            foreach (var item in employer)
            {
                if (item.Fizetes() > 5000000)
                {
                    Console.WriteLine($"{item.Name}, {item.Fizetes()}");
                }
            }


            Console.WriteLine($"Az átlagár euróban: {Atlag(employer):0.00}");


            var dev = employer.Where(e => e.Position == "Developer").Average(e => e.Salary);
            Console.WriteLine($"A developerek átlag fizuja: {dev}");

            var noi = employer.Where(e => e.Gender == "Female").Average(e => e.Salary);
            Console.WriteLine($"Női dolgozók átlag fizuja: {noi}");

            var ferfi = employer.Where(e => e.Gender == "Male").Average(e => e.Salary);
            Console.WriteLine($"A férfi dolgozók átlag fizuja: {ferfi}");
        }
    }
}

