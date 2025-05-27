
void swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

void sort_arr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
        }
    }
}

void sort_arrWhile(int[] arr)
{
    int i = 0;
    int j = i + 1;

}

void create_array(int[] arr)
{
    Random rd = new Random();
    for(int i=0; i < arr.Length; i++)
    {
        arr[i] = rd.Next(1, 100);
    }
}

void print_array(int[] arr)
{
    foreach(int x in arr)
    {
        Console.Write(x + " ");
    }
}

int[] arr = new int[10];
create_array(arr);
Console.WriteLine("Mang truoc khi sap xep: ");
print_array(arr);
Console.WriteLine("Mang sau khi sap xep: ");
sort_arrWhile(arr);
print_array(arr);