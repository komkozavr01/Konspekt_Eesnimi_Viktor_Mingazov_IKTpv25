using System.ComponentModel.Design;

namespace MinuKonspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Muutujad, Matemaatilised tehted, IF, ELSE, IF ja ELSE

            //1.tuvasta sisu võrdluses tühja stringiga andmetüüp
            Console.WriteLine("Tere kasutaja, mis on sinu nimi");
            string nimi = Console.ReadLine();

            if (nimi == "")
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime");
            }
            else if (nimi != "")
            {
                Console.WriteLine("Tere " + nimi + "!");
            }
            else
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime");
            }

            //2.tuvasta arvuvahemik, võrdluses piirväärtustega, int/double/float andmetüüp
            Console.WriteLine(nimi + ", mis on sinu vanus?: ");
            int kasutajavanus = int.Parse(Console.ReadLine());

            //2.1 mitu tingimust pesastatud if-ide abil
            //if (kasutajavanus > 0)
            //{
            //    if (kasutajavanus < 18)
            //    {
            //        Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma😁");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Saad osta Monsterit, YIPPIE 🍕");
            //    }
            //}

            //2.2 mitu tingimust ühe ifi kasutades loogilist tehet "and", vältides pesastamist
            if (kasutajavanus > 0 && kasutajavanus < 18)
            {
                Console.WriteLine("Kahjuks energiajooki sulle ei müüda, oled Monsterist ilma😁");
            }
            else
            {
                Console.WriteLine("Saad osta Monsterit, YIPPIE");
            }
            //2.3 mitu vahemikku, if-elseif abil, double/float
            Console.WriteLine("Sisesta oma pikkus ka, palun, "+nimi+":");
            double pikkus = double.Parse(Console.ReadLine());
            if (pikkus < 1.00d)
            {
                Console.WriteLine("Oled juhtsu");
            }
            else if (pikkus <1.25d && pikkus > 1.00d)
            {
                Console.WriteLine("Oled peaaegu allameetrimees");
            }
            else if (pikkus <1.50d && pikkus >1.25d)
            {
                Console.WriteLine("Oioi, päkapikk enam ei olegi " + nimi + " !");
            }
            else if (pikkus < 1.75d && pikkus > 1.50d)
            {
                Console.WriteLine("Oioi, päkapikk enam ei olegi " + nimi + " !");
            }
            else if (pikkus < 2.00d && pikkus > 1.75d)
            {
                Console.WriteLine("Pikk kolge, vaata et sa pead vastu ukspiita ära ei löö");
            }
            else if (pikkus > 2.00d)
            {
                Console.WriteLine("Täielik tulnukas, kuidas pilved välja näevad?");
            }
            else
            {
                Console.WriteLine("pikkust ei tunta");
            }

            //int lahutav1 = 0;
            //int lahutav2 = 0;
            //Console.WriteLine("Tere, palun sisesta esimene lahutav: ");
            //lahutav1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta teine lahutav: ");
            //lahutav2 = int.Parse(Console.ReadLine());
            //int lahutav = lahutav1 - lahutav2;
            //Console.WriteLine($"Tehte tulemus: {lahutav}");
            //Console.WriteLine("Tehte tulemus: " + lahutav);

            //int jagatav1 = 0;
            //int jagatav2 = 0;
            //Console.WriteLine("Tere, palun sisesta esimene jagatav: ");
            //jagatav1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta teine jagatav: ");
            //jagatav2 = int.Parse(Console.ReadLine());
            //int jagatav = jagatav1 / jagatav2;
            //Console.WriteLine($"Tehte tulemus: {jagatav}");
            //Console.WriteLine("Tehte tulemus: " + jagatav);

            //int korrutav1 = 0;
            //int korrutav2 = 0;
            //Console.WriteLine("Tere, palun sisesta esimene korrutav: ");
            //korrutav1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta teine korrutav: ");
            //korrutav2 = int.Parse(Console.ReadLine());
            //int korrutav = korrutav1 * korrutav2;
            //Console.WriteLine($"Tehte tulemus: {korrutav}");
            //Console.WriteLine("Tehte tulemus: "+korrutav);

            int arv1 = 0;
            int arv2 = 0;
            Console.WriteLine("Palun sisesta esimene arv: ");
            arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Palun sisesta teine arv: ");
            arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / *");
            string tehtetüüp = Console.ReadLine();
            int tehe = 0;

            if (tehtetüüp == "+")
            {
                tehe = arv1 + arv2;
            }

            if (tehtetüüp == "-")
            {
                tehe = arv1 - arv2;
            }

            if (tehtetüüp == "/")
            {
                tehe = arv1 / arv2;
            }

            if (tehtetüüp == "*")
            {
                tehe = arv1 * arv2;
            }

            Console.WriteLine($"Tehte tulemus: {tehe}");



            // + liitmine
            // - lahutame
            // / jagamine
            // * korrutamine2

            //4 parool, if ja string andmetüüp
            Console.WriteLine("Programmi edasiseks tööks sisesta palun parool");
            string password = Console.ReadLine();

            if (password == "shiton")
            {
                Console.WriteLine("Parool on õige, aarete leagas avaneb");
            }
            else if (password == "shit" || password == "3445")
            {
                Console.WriteLine("Parool on sobimatu, palun mingi muu");
            }
            else
            {
                Console.WriteLine("Parool on vale, proovi uuesti");
            }
        }
    }
}