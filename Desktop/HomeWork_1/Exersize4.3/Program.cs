Console.ReadLine();

int a = 22;
int b = 33;
int c = 9;

int max = a;
if (b > a)
    max = b;
if (c > b)
    max = c;
if (c > a)
    max = c;

Console.WriteLine(max);