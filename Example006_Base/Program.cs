Console.Write("Введите Ваше имя ");
string username = Console.ReadLine();
Console.Write("Привет, ");
Console.WriteLine(username);
Console.WriteLine("Введите число ");
string number = Console.ReadLine();

int N = int.Parse(Console.ReadLine());
int i = 1, k = 1;
while (true)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
        k++;
    }
    if (k > N)
    {
        break;
    }
    i++;
}

