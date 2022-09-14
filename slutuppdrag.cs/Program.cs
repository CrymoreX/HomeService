using System;
namespace slutuppdrag.cs
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Creating a menu for the user
            string[] menuOptions = new string[] { "Golv", "Badrum", "Tak", "Kök", "Tjänster", "Avsluta" };
            int menuSelect = 0;

            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;

                //The first choice is shown as this for the user
                if (menuSelect == 0)
                {
                    Console.WriteLine("Välkommen till Husspecialisten");
                    Console.WriteLine("Välj ett alternativ:");
                    Console.WriteLine("--------------------");
                    Console.WriteLine(">>>  " + menuOptions[0] + "  <<<");
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                }

                else if (menuSelect == 1)
                {
                    Console.WriteLine("Välkommen till Husspecialisten");
                    Console.WriteLine("Välj ett alternativ:");
                    Console.WriteLine("-------------------");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(">>>  " + menuOptions[1] + "  <<<");
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                }
                else if (menuSelect == 2)
                {
                    Console.WriteLine("Välkommen till Husspecialisten");
                    Console.WriteLine("Välj ett alternativ:");
                    Console.WriteLine("-------------------");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(">>>  " + menuOptions[2] + "  <<<");
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                }
                else if (menuSelect == 3)
                {
                    Console.WriteLine("Välkommen till Husspecialisten");
                    Console.WriteLine("Välj ett alternativ:");
                    Console.WriteLine("-------------------");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(">>>  " + menuOptions[3] + "  <<<");
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(menuOptions[5]);
                }
                else if (menuSelect == 4)
                {
                    Console.WriteLine("Välkommen till Husspecialisten");
                    Console.WriteLine("Välj ett alternativ:");
                    Console.WriteLine("-------------------");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(">>>  " + menuOptions[4] + "  <<<");
                    Console.WriteLine(menuOptions[5]);
                }
                else if (menuSelect == 5)
                {
                    Console.WriteLine("Välkommen till Husspecialisten");
                    Console.WriteLine("Välj ett alternativ:");
                    Console.WriteLine("-------------------");
                    Console.WriteLine(menuOptions[0]);
                    Console.WriteLine(menuOptions[1]);
                    Console.WriteLine(menuOptions[2]);
                    Console.WriteLine(menuOptions[3]);
                    Console.WriteLine(menuOptions[4]);
                    Console.WriteLine(">>>  " + menuOptions[5] + "  <<<");
                }

                var keyPressed = Console.ReadKey();

                //This code is making sure the user can not choose an another option above the menu
                if (keyPressed.Key == ConsoleKey.DownArrow && menuSelect != menuOptions.Length - 1)
                {
                    menuSelect++;
                }
                else if (keyPressed.Key == ConsoleKey.UpArrow && menuSelect >= 1)
                {
                    menuSelect--;
                }
                //The key Enter us used for choosing an alternative
                else if (keyPressed.Key == ConsoleKey.Enter)
                {
                    switch (menuSelect)
                    {
                        case 0:
                            FirstChoice();
                            break;

                        case 1:
                            SecondChoice();
                            break;

                        case 2:
                            ThirdChoice();
                            break;

                        case 3:
                            FourthChoice();
                            break;

                        case 4:
                            FifthChoice();
                            break;

                        case 5:
                            SixthChoice();
                            break;
                    }

                }

            }


        }

            //User get a choice between different kind of floors
            public static void FirstChoice()
        {
            Golv.FirstChoice();

        }

            //This makes the user choice what type they want help with and shows prices in each choice
            public static void SecondChoice()
        {
            Console.Clear();
            Console.WriteLine("Badrum");
            Console.WriteLine("-------");
            Console.WriteLine("Här kan ni välja vad ni vill ha hjälp med i badrummet:\n");
            Console.WriteLine("1 - Dusch");
            Console.WriteLine("2 - Badrumsbelysning");
            Console.WriteLine("3 - Badrumsmöbler");
            Console.WriteLine("4 - Badkar\n");
            Console.WriteLine("Skriv in vilket alternativ ni vill ha hjälp med och tryck sedan på Enter");

            string tjänst = Console.ReadLine();
            if (tjänst == "1")
            {
                Console.Clear();
                Console.WriteLine("Duschalternativ:\n");
                Console.WriteLine("Duschkabin Klar\t 4000 kr");
                Console.WriteLine("Duschhörn Fox\t 2499 kr");
                Console.WriteLine("Duschdörr 1 st.\t 1200 kr");
                Console.WriteLine("Massage Lyx\t 46.000 kr");
            }
            else if (tjänst == "2")
            {
                Console.Clear();
                Console.WriteLine("Badrumsbelysning:\n");
                Console.WriteLine("Underbelysning\t 300 kr");
                Console.WriteLine("Vägglampa\t 2000 kr");
                Console.WriteLine("Spegelbelysning\t 499 kr");
                Console.WriteLine("Spottlight LED\t 1200 kr");
                Console.WriteLine("Lysrör Extra\t 560 kr");
            }
            else if (tjänst == "3")
            {
                Console.Clear();
                Console.WriteLine("Badrumstillbehör:\n");
                Console.WriteLine("Hylla Granit\t 800 kr");
                Console.WriteLine("Badrumsskåp\t 2599 kr");
                Console.WriteLine("Badrumsspegel\t 799 kr");
                Console.WriteLine("Handdukstork\t 699 kr");
            }
            else if (tjänst == "4")
            {
                Console.Clear();
                Console.WriteLine("Badkar:\n");
                Console.WriteLine("Metis Special 180 cm\t 5999 kr");
                Console.WriteLine("Bubblalife 160 cm\t 4999 kr");
                Console.WriteLine("Hygienist 170 cm\t 2499 kr");
                Console.WriteLine("BioBath 150 com \t 7999 kr");
                Console.WriteLine("Jacuzzi Deluxe  \t 46.000 kr");
            }
            else
            {
                Console.WriteLine("Error, försök igen");

            }
                Console.WriteLine("\nTryck på valfri tangent för att komma tillbaka till menyn");
                Console.ReadKey();
        }

            //This choice makes the user to make a choice of 3 diffenrent types of material for the roof
            public static void ThirdChoice()
            {
                Console.Clear();
                Console.WriteLine("Tak");
                Console.WriteLine("-----");
                Console.WriteLine("Här får ni välja vilket tak ni vill önska er att beställa:\n");
                Console.WriteLine("Tegel, Plåt eller Papp.");
                Console.WriteLine("Skriv in vilken tjänst ni vill ha hjälp med och tryck sedan på Enter");
                string tjänst = Console.ReadLine();

                if (tjänst == "Tegel")
                {
                    Console.Clear();
                    Console.WriteLine("Ni har valt alternativet: Tegel.\n");
                    Console.WriteLine("Idag kan ni få extrapris på tegel för endast 20 kr/styck.");
                }

                else if (tjänst == "Plåt")
                {
                    Console.Clear();
                    Console.WriteLine("Ni har valt alternativet: Plåt\n");
                    Console.WriteLine("Vi säljer varje plåtdel för sig och priset är 199 kr per plåtdel.");
                }

                else if (tjänst == "Papp")
                {
                    Console.Clear();
                    Console.WriteLine("Ni har valt alternativet: Papp\n");
                    Console.WriteLine("Vi säljer papp i rulle och en hel kostar 1099 kr och det täcker en yta på 30 kvm.");
                }
                else
                {
                    Console.WriteLine("Det alternativ ni har valt finns tyvärr inte, var vänliga att försöka igen.");
                }


                Console.WriteLine("\nTryck på en valfri tangent för att komma tillbaka till menyn");
                Console.ReadKey();
            }

            //This choice makes the user get a list in an Array between differnt kind of kitchen brands
            public static void FourthChoice()
            {
                Console.Clear();
                Console.WriteLine("Kök");
                Console.WriteLine("----");

                String[] Kökslista = { "Epoqkök \t30.000 kr", "Ballingslöv \t23.000 kr", "Kvikkök \t56.000 kr", "Marbodal \t43.000 kr", "Sentens \t129.000 kr" };

                foreach (String lista in Kökslista)
                {
                    Console.WriteLine(lista);
                }

                Console.WriteLine("\nTryck på valfri tangent för att komma tillbaka till menyn");
                Console.ReadKey();
            }

            //This choice makes the user choose between diffent services the company provide
            public static void FifthChoice()
            {

                Console.Clear();
                Console.WriteLine("Tjänster");
                Console.WriteLine("---------");
                Console.WriteLine("Här kan ni välja vilken tjänst ni vill ha hjälp med:\n");
                Console.WriteLine("1 - Golvslipning");
                Console.WriteLine("2 - Målning");
                Console.WriteLine("3 - Renovering\n");
                Console.WriteLine("Skriv in vad ni vill ha hjälp med, använd siffror och tryck sedan på Enter");

                

            string tjänst = Console.ReadLine();
                if (tjänst == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Ni har valt alternativet: Golvslipning\n");
                    Console.WriteLine("Golvslipningstjänsten kostar idag 500 kr/h");
                }

                else if (tjänst == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Ni har valt alternativet: Målning\n");
                    Console.WriteLine("Målning kostar idag 200 kr/h");
                }

                else if (tjänst == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Ni har valt alternativet: Renovering\n");
                    Console.WriteLine("Vi renoverar allt i huset för 329 kr/h");
                }
                else
                {
                    Console.WriteLine("Den angivna tjänsten finns tyvärr inte");
                    Console.Clear();
                }

                Console.WriteLine("\nTryck på en valfri tangent för att komma tillbaka till menyn");
                Console.ReadKey();

            }

            //Exit the program
            public static void SixthChoice()
            {
                Console.Clear();
                Console.WriteLine("Avsluta");
                Console.WriteLine("Tryck på valfri tangent för att avsluta programmet!");
                Console.ReadKey();
                //Uses to exit the program and no further alternatives are given
                Environment.Exit(1);
            }
        }
    }

    


