// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateUserArrNums (int size) {
    int[] userNumsArr = new int[size];
    for (int i = 0; i < size; i++) {
        Console.Write("Enter the number " + (i + 1) + ": ");
        userNumsArr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return userNumsArr;
}

int CountPositiveNums (int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] > 0) {
            count++;
        }
    }
    return count;
}


Console.Write("Enter how many numbers you will enter: ");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArr = CreateUserArrNums(userSize);

Console.WriteLine("The number of entered numbers greater than zero is equal to: " + CountPositiveNums(userArr));