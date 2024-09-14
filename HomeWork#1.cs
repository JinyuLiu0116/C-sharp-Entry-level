string greeting = "Hello World! My name is Jinyu";
Console.WriteLine(greeting);
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;

Console.Clear();

Console.WriteLine("***************************************************");
Console.WriteLine("**     Programming Assignment: #2                **");
Console.WriteLine("**     Developer: Jinyu Liu                      **");
Console.WriteLine("**     Date Submitted: September 12              **");
Console.WriteLine("**     Purpose: Provide internal documentation   **");
Console.WriteLine("***************************************************");

Console.ResetColor();

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;

Console.Clear();

Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("| *******-------------------------------------------|");
Console.WriteLine("| *******-------------------------------------------|");
Console.WriteLine("| *******-------------------------------------------|");
Console.WriteLine("| *******-------------------------------------------|");
Console.WriteLine("|---------------------------------------------------|");
Console.WriteLine("|---------------------------------------------------|");
Console.WriteLine("-----------------------------------------------------");

Console.ResetColor();

int patten = 9;

for(int i = 0; i < patten; i++)
{
    for (int j = 0; j< patten; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();

}

