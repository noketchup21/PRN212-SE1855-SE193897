(int, double) SumAndAverage(params int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    double average = (double)sum / arr.Length;
    return (sum, average);
}

int [] arr = { 1, 2, 43, 1234, 32423, 12 };
(int s, double v) = SumAndAverage(arr);
Console.WriteLine($"SUM = {s}");
Console.WriteLine($"AVERAGE = {v}");