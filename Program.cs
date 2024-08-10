Console.WriteLine("Let's play a game of rock-paper-scissors! Choose your option from the list:");

while (true)
{
    Console.WriteLine(
        "\n1 - Rock" +
        "\n2 - Paper" +
        "\n3 - Scissors" +
        "\n");

    int userChoice = Convert.ToInt32(Console.ReadLine());

    if (userChoice < 1 || userChoice > 3)
    {
        Console.WriteLine("Incorrect number. Please select either number 1, 2, or 3.");
        continue;
    }

    string[] options = { "Rock", "Paper", "Scissors" };
    Random rnd = new Random();
    int computerChoice = rnd.Next(1, 4);

    Console.WriteLine($"\nYour choice: {options[userChoice - 1]}.");
    Console.WriteLine($"Computer choice: {options[computerChoice - 1]}.");

    if (userChoice == computerChoice)
    {
        Console.WriteLine("It's a tie. Let's try again.");

        continue;
    }
    else if ((userChoice == 1 && computerChoice == 3) ||
             (userChoice == 2 && computerChoice == 1) ||
             (userChoice == 3 && computerChoice == 2))
    {
        Console.WriteLine("You win! Want to play again? y/n");
    }
    else
    {
        Console.WriteLine("The computer won. Want to play again? y/n");
    }

    string userResponse = Console.ReadLine().ToLower();
    if (userResponse != "y")
    {
        break;
    }
}