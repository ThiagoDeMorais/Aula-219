using ProjetoAula219.Entitites;
using System;
using System.Collections.Generic;

namespace ProjetoAula219
{
    class Program
    {
     

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV",900.00));
            list.Add(new Product("Notebook", 1200));
            list.Add(new Product("IPhone", 900.00));

            Comparison<Product> prop = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            list.Sort(prop);

            foreach (Product element in list)
            {
                Console.WriteLine(element);
            }
        }


    }
}
