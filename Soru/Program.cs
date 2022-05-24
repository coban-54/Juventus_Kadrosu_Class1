using System;

namespace deneme
{
    class Saha
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu1 = new Oyuncu();
            oyuncu1.playerName = "Wojciech Szczesny";
            oyuncu1.playerAge = 31;
            oyuncu1.Position = "Kaleci";
            oyuncu1.club = "Juventus";

            Oyuncu oyuncu2 = new Oyuncu();
            oyuncu2.playerName = "Mattia De Sciglio";
            oyuncu2.playerAge = 29;
            oyuncu2.Position = "Defans";
            oyuncu2.club = "Juventus";

            Oyuncu oyuncu3 = new Oyuncu();
            oyuncu3.playerName = "Juan Cuadrado	";
            oyuncu3.playerAge = 33;
            oyuncu3.Position = "Ortasaha";
            oyuncu3.club = "Juventus";

            Oyuncu oyuncu4 = new Oyuncu();
            oyuncu4.playerName = "Dusan Vlahovic";
            oyuncu4.playerAge = 21;
            oyuncu4.Position = "Forvet";
            oyuncu4.club = "Juventus";

            Oyuncu oyuncu5 = new Oyuncu();
            oyuncu5.playerName = "Alvaro Morata";
            oyuncu5.playerAge = 29;
            oyuncu5.Position = "Forvet";
            oyuncu5.club = "Juventus";

            Oyuncu[] oyuncular = new Oyuncu[]{oyuncu1,oyuncu2,oyuncu3,oyuncu4,oyuncu5};

            foreach (var oyuncu in oyuncular)
            {
                Console.WriteLine(oyuncu.playerName + ":" + oyuncu.playerAge + ":" + oyuncu.Position + ":" +  oyuncu.club);
            }

        }

    }

    class Oyuncu
    {
        public string playerName { get; set; }

        public int playerAge { get; set; }

        public string Position { get; set; }

        public string club { get; set; }
    }
}