using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1


            //Edition edition = new Edition();
            //edition.Name = "Преступление и наказание";
            //edition.Sername = "Фёдор Достоевский";
            //edition.Year = 1866;
            //edition.Num();
            //Console.WriteLine(edition.ShowInfo());
            //Console.ReadKey();


            //2

            //Software_Support software_Support = new Software_Support("Прикладное программное обеспечение", "Аланом Тьюрингом", true);
            //Console.WriteLine(software_Support.ShowInfo());
            //software_Support.Security();


            //3

            Banknote banknote = new Banknote();
            banknote.Name = "Монета";
            banknote.Nominal = 5;
            banknote.Kvo = 3;
            Console.WriteLine(banknote.ShowInfo());
            int y = Convert.ToInt32(Console.ReadLine());
            int x = Convert.ToInt32(Console.ReadLine());
            banknote.Kvo1(y);
            banknote.Nominal1(x);





            Console.ReadKey();





        }
    }
}
