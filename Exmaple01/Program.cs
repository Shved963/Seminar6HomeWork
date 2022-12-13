// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();

Console.WriteLine("Введите колличество вводимых чисел");

int amountNum = IntoInt();

int [] arr = GetArrayFromConsole(amountNum);

int positiveNum = GetAmountPositiveNumbers(arr);

PrintArray(arr);
Console.WriteLine($"{positiveNum} - колличество положительных чисел");





//методы
int GetAmountPositiveNumbers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }

    return count;
}


int[] GetArrayFromConsole(int lenth)
{
    int[] array = new int[lenth];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = IntoInt();
    }

    return array;

}


int IntoInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);
    if (isParsed)
    {
        return num;
    }
    else
    {
        throw new Exception("Ввели не корректные данные");
    }

}

void PrintArray(int[] array)
{
    string msg = string.Join(", ", array);
    Console.WriteLine($"[{msg}]");
}
