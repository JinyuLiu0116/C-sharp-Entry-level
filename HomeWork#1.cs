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

Console.WriteLine();
int k = 1;
for(int i = 0; i < patten; i++)
{
    for(int j = 0;j<= patten-i; j++)
    {
        Console.Write(" ");
    }
    for(int n =0; n < k; n++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    k += 2;
}

Console.WriteLine();
for(int i =0; i <= patten; i += 2)
{
    for(int j = 0; j<= patten-3-i; j+=2)
    {
        Console.Write(" ");
    }
    for(int n =0; n <=i; n++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
for(int i=0; i < patten-1; i+=2)
{
    for(int j=0; j <= i; j+=2)
    {
        Console.Write(" ");
    }
    for(int n =0; n < patten-2-i; n++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
