namespace casio_fx991
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                Start:
                Console.WriteLine("Welcome in team CASIO ");
                Console.WriteLine("The Game Changer.");
                Console.WriteLine();
                Console.WriteLine("Pro funkci sčítání zvol:1");
                Console.WriteLine("Pro funkci odčítání zvol:2");
                Console.WriteLine("Pro funkci násobení zvol:3");
                Console.WriteLine("Pro funkci dělení zvol:4");
                Console.WriteLine("Pro funkci největší spolešný dělitel zvol:5");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Konec zvonec:0");
            
                int funkce= Convert.ToInt32(Console.ReadLine());

                if (funkce == 0)
                {
                    break;
                }

                switch (funkce)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Vybral jsi funkci konec,DOBROU NOC");
                        Console.WriteLine();
                        Console.WriteLine("Idu spat");

                        break;

                    case 1:
                        Console.WriteLine("Vybral jsi funkci sčítání,SKVĚLE!!!");
                        Console.WriteLine("Zadej první číslo");
                        double plus1 = Convert.ToDouble(Console.ReadLine());      /*  double(místo int) umožní napsat desetiné číslo*/
                        Console.WriteLine("Zadej druhé číslo");
                        double plus2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Výsledek:" +(plus1+plus2));
                        Console.WriteLine();
                        Console.WriteLine("______________________________");

                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Vybral jsi funkci odčítání,SKVĚLE!!!");
                        Console.WriteLine("Zadej první číslo");
                        double minus1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Zadej druhé číslo");
                        double minus2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Výsledek: " + (minus1 - minus2));
                        Console.WriteLine();
                        Console.WriteLine("______________________________");

                        Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Vybral jsi funkci násobení,SKVĚLE!!!");
                        Console.WriteLine("Zadej první číslo");
                        double krat1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Zadej druhé číslo");
                        double krat2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Výsledek"+krat1 * krat2);
                        Console.WriteLine();
                        Console.WriteLine("______________________________");

                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Vybral jsi funkci dělení,SKVĚLE!!!");
                        Console.WriteLine("Zadej první číslo");
                        double del1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Zadej druhé číslo");
                        double del2 = Convert.ToDouble(Console.ReadLine());

                        if (del1 == 0 || del2 == 0)
                        {
                            Console.WriteLine("Nelze dělit nulou");
                            
                        }
                        else
                        {
                            Console.WriteLine("Výsledek: " + (del1 / del2));
                        }
                        Console.WriteLine();
                        Console.WriteLine("______________________________");
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("Vybral jsi funkci největší společný násobek,SKVĚLE!!!");
                        Console.WriteLine("Zadej první číslo");
                        int nsd1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Zadej druhé číslo");
                        int nsd2 = Convert.ToInt32(Console.ReadLine());
                        while (nsd2 != 0)
                        {
                            int temp = nsd2;
                            nsd2 = nsd1 % nsd2;
                            nsd1 = temp;
                        }
                        Console.WriteLine("NSD:" + nsd1);
                        Console.WriteLine();
                        Console.WriteLine("______________________________");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("chyba chyba");
                        goto Start;

                }
            }
        }
    }
}


