// See https://aka.ms/new-console-template for more information
 class Program
{
    static void Main(string[] args)
    {
 
 int playerMoney = 100; // Spelaren börjar med 100 kronor

        while (playerMoney > 0)
        {
            Console.WriteLine($"Du har {playerMoney} kronor kvar");

            // Vad man ska köpa
            Console.WriteLine("Vad vill du köpa?");
            Console.WriteLine("1. En brons bord (10 kr)");
            Console.WriteLine("2. En silver bord (20 kr)");
            Console.WriteLine("3. En guld bord (30 kr)");
            Console.WriteLine("4. Avsluta");

            string whatToBuy = "";
            while (whatToBuy != "1" && whatToBuy != "2" && whatToBuy != "3" && whatToBuy != "4")
            {
                whatToBuy = Console.ReadLine();
            }

            if (whatToBuy == "4")
            {
                Console.WriteLine("Du avslutade köpen. Tack för att du handlade!");
                break;
            }

            // Priset per bord
            int pricePerItem = 0;

            if (whatToBuy == "1")
            {
                pricePerItem = 10;
            }
            else if (whatToBuy == "2")
            {
                pricePerItem = 20;
            }
            else if (whatToBuy == "3")
            {
                pricePerItem = 30;
            }

            // Hur många man vill köpa
            Console.WriteLine("Hur många bord vill du köpa?");
            int numToBuy = 0;
            while (numToBuy == 0)
            {
                string num = Console.ReadLine();
                bool success = int.TryParse(num, out numToBuy);
                if (!success)
                {
                    Console.WriteLine("Du måste skriva en giltig siffra!");
                }
            }

            int finalCost = pricePerItem * numToBuy;

            if (finalCost <= playerMoney)
            {
                Console.WriteLine("Köpet gick igenom.");
                playerMoney -= finalCost;
            }
            else
            {
                Console.WriteLine("Nej, det har du inte råd med!");
            }
        }

        Console.WriteLine("Nu har du slut på pengar!");
        Console.WriteLine("Tryck på ENTER för att avsluta");
        Console.ReadLine();
    }
}