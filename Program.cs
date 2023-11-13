int n = Convert.ToInt32(Console.ReadLine().Trim());

int k = Convert.ToInt32(Console.ReadLine().Trim());

List<int> arr = new List<int>();

for (int i = 0; i < n; i++)
{
    int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
    arr.Add(arrItem);
}

int result = maxMin(k, arr);

Console.WriteLine(result);

static int maxMin(int length, List<int> numberArray)
{
    numberArray.Sort();

    int minUnfairness = int.MaxValue;

    for (int index = 0; index <= numberArray.Count - length; index++)
    {
        int tempMinUnfairness = numberArray[index + length - 1] - numberArray[index];
        minUnfairness = Math.Min(minUnfairness, tempMinUnfairness);
    }

    return minUnfairness;
}