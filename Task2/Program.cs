Console.Write("Enter 9 digits: ");
string input = Console.ReadLine();

int result = 0;

for (int i = 0; i < input.Length; i++)
{
    result += input[i] - '0';
}

int digit = 11 - result % 11;
Console.WriteLine(input + (digit == 10 ? "X" : digit.ToString()));