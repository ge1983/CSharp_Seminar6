// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

void FindsCoords(int k1, int b1, int k2, int b2)
{
    if (k1 == k2 && b1 == b2) 
    {
        Console.WriteLine("Прямые совпадают");
    } 
    else if (k1 == k2) 
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = (b2-b1)/(k1-k2);
        double y = k1 * x +b1; 
        Console.WriteLine($"Точка ({x}, {y}) - точка пересечения двух пррямых y = {k1} * x + {b1} и y = {k2} * x + {b2}");
    }
}

Console.WriteLine("Введите коэффициент k1 первого уравнения прямой");
int k1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите коэффициент b1 первого уравнения прямой");
int b1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите коэффициент k2 второго уравнения прямой");
int k2 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите коэффициент b2 второго уравнения прямой");
int b2 = Convert.ToInt32(Console.ReadLine());

FindsCoords(k1, b1, k2, b2);
