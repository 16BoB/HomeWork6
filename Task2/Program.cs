// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double[] CreateUserArrNums () {
    int totalPointsTwoLines = 4;
    double[] arrPoints = new double[totalPointsTwoLines];
    for (int i = 0; i < totalPointsTwoLines; i += 2) {
        Console.Write("Enter coordinate b" + (i + 1) + ": ");
        arrPoints[i] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter coordinate k" + (i + 1) + ": ");
        arrPoints[i + 1] = Convert.ToInt32(Console.ReadLine());
    }
    return arrPoints;
}

void ShowArr (double[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double[] FindIntersection (double[] arr) {
    double b1 = arr[0];
    double k1 = arr[1];
    double b2 = arr[2];
    double k2 = arr[3];
    double[] intersectionPoint = {-100, -100};
    if (k1 != k2) {
        intersectionPoint[0] = (b2 - b1) / (k1 - k2);
        intersectionPoint[1] = k1 * intersectionPoint[0] + b1;
    }
    return intersectionPoint;
}

double[] myArray = CreateUserArrNums();

Console.Write("The coordinates of the intersection point is: ");
ShowArr(FindIntersection(myArray));
