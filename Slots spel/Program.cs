
int money = 1500;
int bet = 0;

bool Slotmachine = true;

Console.WriteLine("[WARNING] This Slot Machine is not using real money!");
Console.WriteLine("");
Console.WriteLine($"Money you got: {money}$");

while (Slotmachine)
{
Console.WriteLine();
Console.WriteLine("Choose the amount to bet: 10, 50, 100 or All In");

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
else if (choose == "all in")
{
    bet = money;
}
else
{
    Console.WriteLine("Invalid choice!");
    Console.ReadLine();
    return;
}


if (bet > money)
{
    Console.WriteLine("You don't have enough money!");
    Console.ReadLine();
    return;
}

money -= bet;

int slot1 = Random.Shared.Next(8);
int slot2 = Random.Shared.Next(8);
int slot3 = Random.Shared.Next(8);
int jackpot = Random.Shared.Next(9999999);

Console.WriteLine($"Betting: {bet}$");
Console.WriteLine("Spinning!");
Console.WriteLine();

Thread.Sleep(500);
Console.Write($"[{slot1}");

Thread.Sleep(500);
Console.Write($" {slot2}");

Thread.Sleep(500);
Console.Write($" {slot3}]");

Console.WriteLine();
Console.WriteLine();


if (slot1 == 7 && slot2 == 7 && slot3 == 7)
{
    money = jackpot;

    Console.WriteLine("!!! JACKPOT !!!");
    Console.WriteLine("");
    Console.WriteLine("You Hit The Jackpot!");
    Console.WriteLine("");
    Console.WriteLine($"You Won: {money}$");
}
else
{
    Console.WriteLine("No jackpot!");
    Console.WriteLine("");
}

Console.WriteLine($"Money you got: {money}$");

if (money <= 0)
{
    Slotmachine = false;
    Console.WriteLine("");
    Console.WriteLine("You lost all your money! :O");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("GameOver!");
}
Console.ReadLine();
}


