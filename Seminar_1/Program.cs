int Max(int a, int b) => a > b ? a : b;
int Max(int a, int b, int c) => Max(Max(a, b), c);
int a = -9;
int b = -3;
int c = -9;
Console.WriteLine((a > b) ? "{0} {1}" : "{1} {0}", a, b);
