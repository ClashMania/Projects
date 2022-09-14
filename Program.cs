using System;

namespace Prosijek
{
    internal class Program
    {
        static void Main()
        {
            //Varijable
            int brojOcjena, ocjena=0;
            double zbrojOcjena = 0, prosjek;
            

            //Zaglavlje aplikacije
            Console.WriteLine("######################");
            Console.WriteLine("Izračunjavanje prosjeka");
            Console.WriteLine("######################");
            Console.WriteLine("Unesite nulu za kraj");

            //Upis broja ocjena
            Console.WriteLine("Upiši broj ocjena: ");
            brojOcjena = Convert.ToInt32(Console.ReadLine());

            //Unos ocjena
            Console.WriteLine("Unesi ocjenu: ");

            if (ocjena => 6)
            {
                Console.WriteLine("To je nemoguće!");
                
            }

            for (int i = 0; i < brojOcjena; i++)
            { 
               
                ocjena = Convert.ToInt32(Console.ReadLine());
                zbrojOcjena = zbrojOcjena + ocjena;
            
            }

            prosjek = zbrojOcjena / brojOcjena;

            if( prosjek <= 1.5 )
            {
                Console.WriteLine("Pao si razred.");
            }
            else
            {
                Console.WriteLine(prosjek);
                Console.WriteLine("Prošao si razred.");

            }
          
            }


            Console.ReadKey();

            
        }
    }
}
