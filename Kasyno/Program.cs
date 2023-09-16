// See https://aka.ms/new-console-template for more information
/*
class Clown
{
    public string Name;
    public int Height;
    public void TalkAboutYourself()
    {
        Console.WriteLine("Mam na imie" + Name + "Oraz wzrost" + Height);
    }
    static void Main(string[] args)
    {
        Clown oneClown = new Clown();
        oneClown.Name = "Boffo";
        oneClown.Height = 180;
        oneClown.TalkAboutYourself();

        Clown twoClown = new Clown();
        twoClown.Name = "Johhny";
        twoClown.Height = 170;
        twoClown.TalkAboutYourself();

        Clown threeClown = new Clown();
        threeClown.Name = "Rafaello";
        threeClown.Height = 190;
        threeClown.TalkAboutYourself();

       
        
    }

}
*/
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Guy
{


    public double cash;
    public string Name;


    public void CashZero()
    {
        if ( cash == 0)
        {
            Console.WriteLine("Masz zero na koncie nie możesz grać");
            Console.WriteLine("Nigdy nie wygrasz z kasynem , wduś Q aby wyjść");
            char keyChar = Console.ReadKey(true).KeyChar;
            if((keyChar == 'q'||keyChar=='Q')) return;
            
        }
    }
    public void WriteMyInfo()
    {
        Console.WriteLine(Name + " " + "Ma" + " " + cash + " " + " zł");
    }
    public int GiveCash(double amount)
    {

       
        if (amount <= 0)
        {
            Console.WriteLine("Kwota jest nieprawidłowa");
            return 0;
        }
        if (amount > cash)
        {
            Console.WriteLine("Masz niewstarczająca ilość środków na koncie");
            return 0;
        }
        

        cash -= amount;
        return (int)amount;

    }

    public void ReceiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Nieprawidłowa kwota");

        }
        else
        {
            cash += amount;

        }
    }
}
    /*

        Guy jacek = new Guy() { Name = "Jacek", cash = 50 };
        Guy bartek = new Guy() { Name = "Bartek", cash = 100 };

        

        while (true)
        {
            jacek.WriteMyInfo();
            bartek.WriteMyInfo();
            Console.WriteLine("Podaj kwote");
            string howMuch = Console.ReadLine();
            if (howMuch == "") return;
            if (int.TryParse(howMuch, out int amount))
            {
                Console.WriteLine("Pieniadze ma przekazac:");
                string KtoMaPrzekazac = Console.ReadLine();
                if (KtoMaPrzekazac == "Jacek")
                {
                    int pieniadzeDaje = jacek.GiveCash(amount);
                    bartek.ReceiveCash(pieniadzeDaje);

                }
                else if (KtoMaPrzekazac == "Bartek")
                {
                    int pieniadzeDaje = bartek.GiveCash(amount);
                    jacek.ReceiveCash(pieniadzeDaje);
                }
                else
                {
                    Console.WriteLine("Wpisz Jacek lub Bartek aby kontynuowac");
                }

            }
            else
            {
                Console.WriteLine("wpisz kwote lub pusty wiersz aby zakonczyc");
            }
      
    */
    
    
        


    



        

    






    










    /*
    




    public string? name;
    public int cash;
    public void WriteMyInfo()
    {
        Console.WriteLine(name + "ma" + cash + " zł ");
    }
   
    



        Guy Jacek = new Guy() { cash = 100, name = "Jacek" };


        Guy Bartek = new Guy() { cash = 50, name = "Bartek" };

        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(name + "mówi:" + amount + "nie jest poprawną kwotą");
                return 0;
            }
            if (amount > cash)
            {
                Console.WriteLine(name + "mówi: Nie mam wystarczających środków aby dać Ci" + amount + "zł");
                return 0;
            }
            cash -= amount;
            return amount;
        }
        public void ReciveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(name + " mówi: Nie przyjmę " + amount + "zł");
            }
            else
            {
                cash += amount;
            }
        }   
    */
    /*

    string? name;
    int cash;
    public void WriteMyInfo()
    {
        Console.WriteLine(name + "ma" + cash + " zł ");
    }
    public int GiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(name + "mówi:" + amount + "nie jest poprawną kwotą");
            return 0;
        }
        if (amount > cash)
        {
            Console.WriteLine(name + "mówi: Nie mam wystarczających środków aby dać Ci" + amount + "zł");
            return 0;
        }
        cash -= amount;
        return amount;
    }
        public void ReceiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine(name + " mówi: Nie przyjmę pieniędzy zł");
            }
            else
            {
                cash += amount;
            }
        }
       

        static void Main(string[] args)
        {

            Guy Jacek = new Guy() { name = "Jacek", cash = 50 };
            Guy Bartek = new Guy() { name = "Bartek", cash = 100 };


        while (true)
        {
            Jacek.WriteMyInfo();
            Bartek.WriteMyInfo();

            Console.WriteLine("Podaj Kwote");
            string howMuch = Console.ReadLine();
            if (howMuch == " ") return;
            if (int.TryParse(howMuch, out int amount))
            {
                Console.Write("Pieniądze ma przekazać: ");
                string whichGuy = Console.ReadLine();



                if (whichGuy == "Jacek")
                {
                    int cashGiven = Jacek.GiveCash(amount);
                    Bartek.ReceiveCash(cashGiven);
                }
                else if (whichGuy == "Bartek")
                {
                    int cashGiven = Bartek.GiveCash(amount);
                    Jacek.ReceiveCash(cashGiven);
                }
                else
                {
                    Console.WriteLine("Wpisz 'Jacek' lub 'Bartek'");
                }
            }
            else
            {
                Console.WriteLine("Wpisz kwotę (lub pusty wiersz,aby zakończyć)");
            }

        }
                
        } 
}

    */



   
           
        
    
    
    
    
