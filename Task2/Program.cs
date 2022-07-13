// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

void ShowArr (double[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double[] FindIntersection (double b1, double k1, double b2, double k2 ) {
    double[] intersectionPoint = {0, 0};
    if (k1 != k2) {
        intersectionPoint[0] = (b2 - b1) / (k1 - k2);
        intersectionPoint[1] = k1 * intersectionPoint[0] + b1;
    }
    return intersectionPoint;
}

Console.Write("Введите координату b1 для первой прямой: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату k1 для первой прямой: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату b2 для второй прямой: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату k2 для второй прямой: ");
int k2 = Convert.ToInt32(Console.ReadLine());


Console.Write("The coordinates of the intersection point is: ");
ShowArr(FindIntersection(b1, k1, b2, k2));
