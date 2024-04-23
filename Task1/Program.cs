Console.Write("Enter a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter b: ");
int b = int.Parse(Console.ReadLine());

for (int i = a; i <= b; i++)
{
    string duodecimal = "";
    int number = i;

    while (number > 0)
    {
        var reminder = number % 12;
        duodecimal += reminder <= 9 ? reminder.ToString() : (reminder == 10 ? "A" : "B");
        number /= 12;
    }

    int count = 0;
    for (int index = 0; index < duodecimal.Length; index++)
    {
        if (duodecimal[index] == 'A')
        {
            count++;
        }
    }

    if (count == 2)
    {
        Console.WriteLine(i);
    }
}