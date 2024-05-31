namespace PP_uke2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weatherExample = "";
            var badAnswer = "";
            int klesvalg = 0;
            int været = 0;

            Main();
            void Main()
            {
                while (true)
                {
                    Console.WriteLine($"This is the Weather Generator! \n The generator that makes weather! ;)");
                    Console.WriteLine($"Today's weather is: {MyWeather()}" + været);
                    Console.WriteLine("What clothes should you wear for it?");
                    Console.WriteLine("1) Favorittskjorte");
                    Console.WriteLine("2) Anorakk");
                    Console.WriteLine("3) Booty shorts");
                    klesvalg = int.Parse(Console.ReadLine());

                    Console.WriteLine($"{Klær()}");
                }
                string MyWeather()
                {
                    Random random = new Random();
                    var rnd = random.Next(1, 4);

                    if (rnd == 1)
                    {
                        weatherExample = "sunny";
                        været = rnd;
                    }
                    else if (rnd == 2)
                    {
                        weatherExample = "thunder and lightning";
                        været = rnd;
                    }
                    else if (rnd == 3)
                    {
                        weatherExample = "plain rain";
                        været = rnd;
                    }
                    else if (rnd == 4)
                    {
                        weatherExample = "the sky fell there's no more weather";
                        været = rnd;
                    }
                    return weatherExample;
                }

                string Klær()
                {
                    /*int weather = 
                    switch (klesvalg)
                    {
                        case 0: 
                    }*/
                    string[] klær = { "Favorittskjorte", "Anorakk", "Booty shorts", "\nTry again!\n" };
                 

                    var input = "";
                    if (klesvalg == 1 && været == 1)
                    {
                        Console.WriteLine("You went out into the sun with your favourite shirt \nand everything was awesome.\n");
                        return klær[0];

                    }
                    else if (klesvalg == 2 && været == 2)
                    {
                        Console.WriteLine("You ventured into the thunders and the lightnings with an anorak. \nYou make it to your destination.\n");
                        return klær[1];
                    }

                    else if (klesvalg == 3 && været == 3)
                    {
                        Console.WriteLine("You entered plain rain in bootyshorts and get a cold.\n");
                        return klær[2];
                    }
                    else
                    {
                        Console.WriteLine($"{yourAnswer()} is mine answer to thee");
                        return klær[3];
                        
                    }


                    string yourAnswer()
                    {
                        
                        {
                            Random answ = new Random();
                            var badChoice = answ.Next(0, 2);

                            if (badChoice == 0)
                            {
                                Console.WriteLine("Why would you do that to yourself?");
                                return badAnswer;
                                
                               

                            }
                            else if (badChoice == 1)
                            {
                                Console.WriteLine("Oh wow");
                                return badAnswer;
                               
                                
                            }
                            else
                            {
                                Console.WriteLine("Devil Wears Prada wants to speak with you.");
                                    return badAnswer;
                               
                                
                            }



                        }
                    }
                }
            }
        }
    }
}

