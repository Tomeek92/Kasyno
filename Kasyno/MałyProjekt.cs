// See https://aka.ms/new-console-template for more information
class Kasyno
{
    static void Main(string[] args)
    {

        Random random = new Random();
        double odds = 0.75;
        Guy player = new Guy() { Name = "Gracz", cash = 100 };

        Console.WriteLine("Witaj w kasynie!");
        while (player.cash > 0)
        {
            player.WriteMyInfo();
            Console.WriteLine("Stawiana kwota:");
            string podajStawianaKwote = Console.ReadLine();
            if (int.TryParse(podajStawianaKwote, out int amount))
            {
                int pot = player.GiveCash(amount) * 2;
                if (pot > 0)
                {
                    if (random.NextDouble() > odds)
                    {
                        int wygrana = pot;
                        Console.WriteLine("Gracz wygrał:" + wygrana);
                        player.ReceiveCash(wygrana);
                    }
                    else
                    {
                        Console.WriteLine("Przegrałeś");
                    }
                }
                else
                {
                    Console.WriteLine("Wpisz poprawną liczbę");


                }
            }
        }
        Console.WriteLine("Nigdy nie wygrasz z Kasynem");
    }
}
