Console.ReadLine();

int a = 2;
int b = 3;
int c = 7;

int max = a;
if (b > a)
    max = b;
if (c > b)
    max = c;
if (c > a)
    max = c;

Console.WriteLine(max);
