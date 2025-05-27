static int sum(int a, int b)
{
    return a + b;
}
void callsum()
{
    int s = sum(5, 8) //ok
}
double average(int a, int b)
{
    return (double)(a + b) / 2;
}
static void callAverage()
{
    double d = average(3, 6); //not ok because static method cannot call non-static method
}