using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        int playerCoins = 6000;
        
        int shirtPrice = 2500;
        int helmetPrice = 3000;
        int foodPrice = 500;
        int presentPrice = 1000;
        int sipsPrice = 700;

        Console.WriteLine("------------------------------");
        Console.WriteLine("Welcome to the general store!");
        Console.WriteLine("------------------------------");

        Console.WriteLine("");

        Console.WriteLine("What would you like to purchase?");

        Console.WriteLine("A: A nice shirt.");
        Console.WriteLine("B: A protective helmet.");
        Console.WriteLine("C: Some food.");
        Console.WriteLine("D: A present.");
        Console.WriteLine("E: A Sip.");

        Console.WriteLine("");

        Console.WriteLine("Enter the letter for your purchase: ");
        string purchaseLetter = Console.ReadLine();

        Console.WriteLine("");

        switch (purchaseLetter) {
            case "A":
                playerCoins = playerCoins - shirtPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                break;
            case "B":
                playerCoins = playerCoins - helmetPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                break;
            case "C":
                playerCoins = playerCoins - foodPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                break;
            case "D":
                playerCoins = playerCoins - presentPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                break;
            case "E":
                playerCoins = playerCoins - sipsPrice;
                Console.WriteLine($"Thanks for your purchase! You have {playerCoins} coins remaining.");
                break;
        }

        while (playerCoins > 0)
        {
            Console.WriteLine("Buy More Items");
            
            string userInput = Console.ReadLine();

            if (userInput == "PurchaseLetter")
            {
                playerCoins -= 100;
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again");
            }
        }
        Console.WriteLine("Perfect");
            
    }
}

