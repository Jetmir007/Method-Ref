/*
static void Main()
{
    int a = 10, b = 20;
     BytPlats(ref a, ref b);
    Console.WriteLine(a+" "+b);
}

static void BytPlats(ref int a, ref int b)
{
    int c = a;
    a=b;
    b=c;
}
Main();
*/

static void Main()
{
    Console.WriteLine("10 upphöjt till 7: " +Power(10, 7));
    Console.WriteLine("2 upphöjt till 10: " +Power(2, 10));
}

static float Power(float a, int b)
{
    float c = a;
    for (int i = 1; i < b; i++)
    {
        c=c*a;
    }
    return c;
}
Main();