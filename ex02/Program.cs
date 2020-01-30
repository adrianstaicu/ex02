using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            double d = 2.95;
            int i = 4;
            Console.WriteLine(++d > i ? d : i);
            Console.Read();
            //  Putem spune ca avem de aface cu comparatia a doua tipuri de date aritmetice si o bluca if else
            // Afiseaza 4 deoarece prima conditie nu este adevarata si nu se executa
        }
    }
}
