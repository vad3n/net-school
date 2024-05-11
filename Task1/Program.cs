Console.Write("Enter a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter b: ");
int b = int.Parse(Console.ReadLine());

if (a < 0 || a > b)
{
    Console.WriteLine("Incorrect value for a!");
    return;
}

for (int i = a; i <= b; i++)
{
    string duodecimal = "";
    int number = i;
    int count = 0;

    while (number > 0)
    {
        var reminder = number % 12;

        if (reminder == 10)
        {
            count++;
        }

        number /= 12;
    }

    if (count == 2)
    {
        Console.WriteLine(i);
    }
}