bool gameRunning = true;

while (gameRunning)
{
    int spins = 0;
    int wins = 0;
    int money = 1500;
    int bet = 0;
    bool Slotmachine = true;

    while (Slotmachine)
    {
        Console.Clear();

        Console.WriteLine("[WARNING] This Slot Machine is not using real money!");
        Console.WriteLine("");
        Console.WriteLine($"Balance: {money}$");
        Console.WriteLine($"Spins: {spins}");
        Console.WriteLine($"Wins: {wins}");
        Console.WriteLine("");

        Console.WriteLine("Choose the amount to bet: 10, 50, 100, 1000 or All In");

        string choose = Console.ReadLine();
        choose = choose.ToLower();

        if (choose == "10")
        {
            bet = 10;
        }
        else if (choose == "50")
        {
            bet = 50;
        }
        else if (choose == "100")
        {
            bet = 100;
        }
        else if (choose == "1000")
        {
            bet = 1000;
        }
        else if (choose == "all in")
        {
            bet = money;
        }
        else
        {
            Console.WriteLine("Invalid choice!");
            Console.ReadLine();
            continue;
        }

        if (bet > money)
        {
            Console.WriteLine("You don't have enough money!");
            Console.ReadLine();
            continue;
        }

        money -= bet;
        spins++;

        int slot1 = Random.Shared.Next(8);
        int slot2 = Random.Shared.Next(8);
        int slot3 = Random.Shared.Next(8);

        // Testing:
        // int slot1 = Random.Shared.Next(1);
        // int slot2 = Random.Shared.Next(1);
        // int slot3 = Random.Shared.Next(1);

        Console.WriteLine();
        Console.WriteLine($"Betting: {bet}$");
        Console.WriteLine("Spinning!");
        Console.WriteLine();
        Console.WriteLine("-------------------------");

        Thread.Sleep(500);
        Console.Write($"[{slot1}");

        Thread.Sleep(500);
        Console.Write($" {slot2}");

        Thread.Sleep(500);
        Console.Write($" {slot3}]");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("-------------------------");

        if (slot1 == 7 && slot2 == 7 && slot3 == 7)
        {
            money += bet * 100;
            wins++;

            Console.WriteLine("!!! JACKPOT !!!");
            Console.WriteLine("");
            Console.WriteLine("You Hit The Jackpot!");
            Console.WriteLine("");
            Console.WriteLine($"You Won: {bet * 100}$");
            Console.WriteLine($"Balance: {money}$");
        }
        else if (slot1 == 6 && slot2 == 6 && slot3 == 6)
        {
            money += bet * 6;
            wins++;

            Console.WriteLine("You Hit The Devil!");
            Console.WriteLine("");
            Console.WriteLine($"You Won: {bet * 6}$");
        }
        else if (slot1 == 5 && slot2 == 5 && slot3 == 5)
        {
            money += bet * 5;
            wins++;

            Console.WriteLine("You Hit 555!");
            Console.WriteLine("");
            Console.WriteLine($"You Won: {bet * 5}$");
        }
        else if (slot1 == slot2 && slot2 == slot3)
        {
            money += bet * 2;
            wins++;

            Console.WriteLine("Three matching numbers!");
            Console.WriteLine("");
            Console.WriteLine($"You Won: {bet * 2}$");
        }
        else
        {
            Console.WriteLine("No jackpot or win!");
            Console.WriteLine("");
        }

        Console.WriteLine($"Money you lost: {bet}$");

        if (money <= 0)
        {
            Slotmachine = false;

            Console.WriteLine("");
            Console.WriteLine("You lost all your money! :O");
            Console.WriteLine("");
            Console.WriteLine("GameOver!");
        }

        Console.ReadLine();
    }

    Console.Clear();

    Console.WriteLine("Do you want to restart? (y/n)");

    string restart = Console.ReadLine().ToLower();

    if (restart == "yes" || restart == "y")
    {
        Console.Clear();
    }
    else
    {
        gameRunning = false;
    }
}

Console.Clear();
Console.WriteLine("Thank you for playing!");
Console.ReadLine();