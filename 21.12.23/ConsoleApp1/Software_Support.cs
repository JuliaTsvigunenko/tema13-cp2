using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Software_Support
    {
        
        
        
        private string name;

        /// <summary>
        /// Поле производителя
        /// </summary>
        private string manufacturer;

        /// <summary>
        /// Поле бесплатное/платное
        /// </summary>
        private bool price;

        

        public string Name { get { return name; } set { name = value; } }

        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }

        public bool Price { get { return price; } set { price = value; } }

        public Software_Support()
        {

        }

        public Software_Support(string name, string manufacturer, bool price)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Price = price;
        }

      
        public void Security()
        {
            if(true)
            {
                Console.WriteLine("ПО платное");
            }
            else
            {
                Console.WriteLine("ПО бесплатное");
            }
        }

        public string ShowInfo()
        {
            return $"Название ПО: {name}\nПроизводитель ПО: {manufacturer}\nПО: {price}";
        }



    }
}
