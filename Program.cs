
static void tambah (int a, int b)
{
    int  c = 0;


     c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}




static void kurang(int a, int b)
{
    int  c = 0;


    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}

static void kali(int a, int b)
{
    int c = 0;


    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}

static void bagi (int a, int b)
{
    int  c = 0;


    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah(9,2);
kurang(2,5);
kali(1,5);
bagi(50,2);