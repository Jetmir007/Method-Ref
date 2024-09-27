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
    Power(ref a, ref b);
    Console.WriteLine(a+"upphöjt med"+b+"är"+ Power(a, b));
}
