Console.Write("Please enter number of elements: ");
int size = 0;

if (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
{
    Console.WriteLine("Incorrect value for number of elements!");
    return;
}

int[] arr = new int[size];

for (int i = 0; i < size; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

Console.Write("Original array: ");
for (int i = 0; i < size; i++)
{
    Console.Write(arr[i] + " ");
}

int[] tempArr = new int[size];
tempArr[0] = arr[0];
int sizeNewArr = 1;

for (int i = 1; i < size; i++)
{
    bool isUnique = true;

    for (int j = 0; j < sizeNewArr; j++)
    {
        if (arr[i] == tempArr[j])
        {
            isUnique = false;
            break;
        }
    }

    if (isUnique)
    {
        tempArr[sizeNewArr] = arr[i];
        sizeNewArr++;
    }
}

int[] newArr = new int[sizeNewArr];

Console.Write("\nNew array: ");
for (int i = 0; i < sizeNewArr; i++)
{
    newArr[i] = tempArr[i];
    Console.Write(newArr[i] + " ");
}