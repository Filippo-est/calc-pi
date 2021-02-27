using System;

namespace calcolo_del_pigreco
{
    class Program
    {
        static void Main(string[] args)
        {
            int check = 1;
            ulong lati = 12;
            double raggio = 1,AH=0.5,OH=0,HC=0,AC=0,PI=0;
            
            while(check==1)
            {
                Console.WriteLine("vuoi calcolare il pi greco se si premi -enter- se no scrivi -no-");
                if (Console.ReadLine() == "no")
                { check = 0; }
                OH = Math.Sqrt(raggio - Math.Pow(AH, 2));
                HC = raggio - OH;
                AC = Math.Sqrt(Math.Pow(AH, 2) + Math.Pow(HC, 2));
                PI = (AC * lati) / 2;

                Console.WriteLine("il numero dei lati e' {0}", lati);
                Console.WriteLine("");
                Console.WriteLine("la lunghezza di HC e' {0}", HC);
                Console.WriteLine("");
                Console.WriteLine("la lunghezza di AC e' {0}", AC);
                Console.WriteLine("");
                Console.WriteLine("Il rapporto tra circonferenza e diametro e' {0}", PI);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                //aggiorno i dati
                AH = AC / 2;
                lati = lati * 2;

            }
        }
    }
}
