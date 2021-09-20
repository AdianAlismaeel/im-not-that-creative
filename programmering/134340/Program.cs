using System;

namespace _134340
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int datortal = rnd.Next(1,101);

            bool vinst = false;  
                                

            int gissningar = 0;
            

            do                  
            {                   
                Console.WriteLine("Gissa på ett nummer mellan 1 och 100: ");
                string svar = Console.ReadLine();
                int tal = int.Parse(svar);

                if (tal > datortal)
                  {
                    Console.WriteLine("Talet är för högt! Försök igen...");
                  }

                else if (tal < datortal)
                    {
                        Console.WriteLine("Talet är för lågt! Försök igen...");
                    }

                else if (tal == datortal)
                    {
                        Console.WriteLine("Du gissade rätt!");
                        vinst = true;  
                    }
               
                 gissningar++; 
            }while (!vinst);
            Console.WriteLine("Det tog dig " + gissningar++ + " försök");
            
        }
        
    }
}
