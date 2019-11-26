using System;
using System.Collections.Generic;

namespace NOVEMBERPROJECT_ERIK_SVEEN_TE17B
{
    class Program
    {
        static void Main(string[] args)
        {





            List<Båt> dock = new List<Båt>(); //spara alla båtar man får



            Båt båtett()     //kallar på constructors i metoder för att skapa nya båtar som är redo för sjösättning
            {
                return new Båt(5, 5, "Ett");
            }
            Båt båttvå()
            {
                return new Båt(5, 10, "två");
            }
            Båt båttre()
            {
                return new Båt(1, 1, "tre"); // ska vara namn istället för nummer
            }
            Båt båtfyra()
            {
                return new Båt(1, 1, "fyra");
            }
            Båt båtfem()
            {
                return new Båt(1, 1, "fem");
            }
            Båt båtsex()
            {
                return new Båt(1, 1, "sex");
            }
            Båt båtsju()
            {
                return new Båt(1, 1, "sju");
            }
            Båt båtåtta()
            {
                return new Båt(1, 1, "åtta");
            }
            Båt båtnio()
            {
                return new Båt(1, 1, "nio");
            }
            Båt båttio()
            {
                return new Båt(1, 1, "tio");
            }










            Båt lightpool()     //metoden som faktiskt tilllåter mig att få olika båtar när jag bygger från lightpoolen, avgränsar även lightpoolen till vissa båtar only.
            {
                Båt nyBåt = null;  // så att jag kan returna båten för det funkade inte om inte nybåt var = null


                int Båtbestämmare = Båt.Båtrullare.Next(1, 11);



                if (Båtbestämmare == 1)       //rullar efter de olika båtarna med hjälp av min static rng-generator, en if-sats/båt som går att få, samma chans att få varje båt
                {
                    nyBåt = båtett();
                }
                if (Båtbestämmare == 2)
                {
                    nyBåt = båttvå();
                }
                if (Båtbestämmare == 3)
                {
                    nyBåt = båttre();
                }
                if (Båtbestämmare == 4)
                {
                    nyBåt = båtfyra();
                }
                if (Båtbestämmare == 5)
                {
                    nyBåt = båtfem();
                }
                if (Båtbestämmare == 6)
                {
                    nyBåt = båtsex();
                }
                if (Båtbestämmare == 7)
                {
                    nyBåt = båtsju();
                }
                if (Båtbestämmare == 8)
                {
                    nyBåt = båtåtta();
                }
                if (Båtbestämmare == 9)
                {
                    nyBåt = båtnio();
                }
                if (Båtbestämmare == 10)
                {
                    nyBåt = båttio();
                }

                return nyBåt;




            }


            while (true) //loop så att spelet alltid ska gå igång och inte stängas ned när man har valt ett val och blivit klar med det.
            {




                string[] items = { " Build Light", " Build Heavy", " Build Special", " Look at dock" }; //en array för att ha alla alternativ som du kan välja mellan i
                int selected = 0; //ett nummer för att kunna göra saker med valet som spelaren väljer
                while (true) //en meny
                {

                    Console.WriteLine("Shikian, what do you want to do?");
                    Console.WriteLine();
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (i == selected) Console.Write(">");
                        else Console.Write(" ");
                        Console.WriteLine(items[i]);
                    }


                    ConsoleKeyInfo key = Console.ReadKey(); //få menyn att ha en pil som flyttas
                    if (key.Key == ConsoleKey.UpArrow) selected--;
                    if (key.Key == ConsoleKey.DownArrow) selected++;
                    if (key.Key == ConsoleKey.Enter) break; //klickar du enter så slutar menyn menya så du kan gå vidare

                    Console.Clear();    //hela denna bit ser till så att du inte kan gå under eller ovan de alternativen som finns i menyn
                    if (selected > items.Length - 1)
                    {
                        selected = items.Length - 1;
                    }

                    if (selected < 0)
                    {
                        selected = 0;
                    }
                }

                Console.Clear();
                if (selected == 0)   //om du valde lightpool så visar detta den random båten och säger att den blev addad till din dock
                {
                    dock.Add(lightpool());
                    Console.WriteLine("You got " + dock[dock.Count - 1].name + " added to your dock");
                }

                if (selected == 1)
                {
                    Console.WriteLine("Pool currently under construction, please be patient!");   //inte klar med så går inte att få någonting
                }

                if (selected == 2)
                {
                    Console.WriteLine("Pool currently under construction, please be patient!");
                }

                if (selected == 3)   //en "meny" där man får alla båtar man hitills har byggt utskriva med sina stats
                {
                    for (int i = 0; i < dock.Count; i++)
                    {
                        dock[i].printstats();
                    }
                }


                Console.ReadKey();
                Console.Clear();

            }



        }




    }





}
