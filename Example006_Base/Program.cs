int a=-9;
int b=-3;

int max=a;
int min=b;

if (a>max) max=a;
if (b>max) max=b;
if (b<max) min=b;
if (a<max) min=a;

Console.Write("max= ");
Console.WriteLine (max);
Console.Write("min= ");
Console.WriteLine (min);