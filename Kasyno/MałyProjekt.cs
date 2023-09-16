// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

class Kasyno
{
    static void Main(string[] args)
    {

        Random random = new Random();
        double odds = 0.75;
        Guy player = new Guy() { Name = "Gracz", cash = 100 };
        Console.WriteLine("Witamy w Kasynie");
        
        while (true)
        {
            player.WriteMyInfo();
            
            Console.WriteLine("Podaj stawkę:");


            string PodajStawianaKwote = Console.ReadLine();
            if (double.TryParse(PodajStawianaKwote, out double amount))
            {

                int pot = player.GiveCash((double)amount) * 2;
                if (pot > 0)
                {
                    if (random.NextDouble() > odds)
                    {
                        int winnigs = pot;
                        Console.WriteLine("Wygrałeś");
                        player.ReceiveCash(winnigs);
                    }
                    else 
                    {
                        Console.WriteLine("Przegrałeś");
                    }


                    

                }
                if (player.cash == 0)
                {
                    player.CashZero();
                    break;



                }


            }
            
            
            
        }
        

    }
}
                   
             /*     
         
                }
                else
                {
                    Console.WriteLine("Wpisz poprawną kwotę");
                }
            
            }
            Console.WriteLine("Nigdy nie wygrasz z kasynem");
        }
        



    }
       
            
   
}
             */
