// Enrick De Munter 5ITN NR4 2019/10/06
/*analyse
 *vragen wat de naam is?
 *vragen wat is de geboortedatum?
 */
using System;

namespace leeftijd
{
    class MainClass
    {
     

        public static void Main(string[] args)
        {//Declaratie
            DateTime geboortedatum; string naam;    //input

            //input
            //Vragen naar de naam
            Console.Write("wat is jouw naam?: ");
            naam = Console.ReadLine();

            //vragen naar zijn geboortedatum
            Console.Write("wat is jouw geboortedatum?: ");
            geboortedatum = Convert.ToDateTime(Console.ReadLine();

            //output
            //Het aantal jaar dat je oud bent
            Console.WriteLine();
            Console.WriteLine("je geboortedatum " + geboortedatum.ToLongDateString()+ ".");
            Console.WriteLine(naam + " je bent al " + DateTime.Now.Subtract(geboortedatum).Days.ToString()
            + "Jaren oud. ");
            Console.WriteLine();
            Console.ReadLine();




        }
    }
}
