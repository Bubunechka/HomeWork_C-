Console.ReadLine();

int a = 44;
int b = 5;
int c = 78;

int max = a;
if (b > a)
    max = b;
if (c > b)
    max = c;
if (c > a)
    max = c;

Console.WriteLine(max);
