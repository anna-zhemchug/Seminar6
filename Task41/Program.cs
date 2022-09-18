// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] Num(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите значение элемента массива: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int check(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());
int[] array = Num(num);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"Введено чисел больше 0: {check(array)}");