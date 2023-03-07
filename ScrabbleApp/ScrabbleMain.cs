// See https://aka.ms/new-console-template for more information

ScrabbleScore scorer = new ScrabbleScore();

Console.WriteLine("Enter a word to score (enter '-' to exit): ");

string word = Console.ReadLine();

while (word != "-")
{
    if (word == "")
    {
        Console.WriteLine("Please enter a word, or '-' to exit: ");

        word = Console.ReadLine();
    }
    else if (word.Contains(" "))
    {
        Console.WriteLine("No spaces please. Please enter a word, or '-' to exit: ");

        word = Console.ReadLine();
    } else
    {
        Console.WriteLine("Score is: " + scorer.GetScrabbleScore(word));

        Console.WriteLine("Enter a word to score (enter '-' to exit): ");

        word = Console.ReadLine();
    }
}


