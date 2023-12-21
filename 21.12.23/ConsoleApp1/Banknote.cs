using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Banknote
    {

        private string name;

        private int nominal;

        private int kvo;


        
        public string Name { get { return name; } set { name = value; } }
        public int Nominal { get { return nominal; } set { nominal = value; } }
        public int Kvo { get { return kvo; } set { kvo = value; } }


        public Banknote()
        {

        }

        public Banknote(string name, int nominal, int kvo)
        {
            this.Name = name;
            this.Nominal = nominal;
            this.Kvo = kvo;
        }


        public void Kvo1( int y)
        {
            this.Kvo = kvo + y;
            Console.WriteLine(Kvo);
        }


        public void Nominal1(int x)
        {
            string z=(x>nominal*kvo)?"Суммы достаточно":"Суммы не достаточно";
            Console.WriteLine(z);
        }

        public string ShowInfo()
        {
            return $"Название: {name}\nНоминал: {nominal}\nКол-во: {kvo}";
        }


    }
}
