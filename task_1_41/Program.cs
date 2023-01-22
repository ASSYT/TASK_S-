// Задача 41: 
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
int[] ArrayInt(string[] strArr) // перевод строкового массива в массив чисел
{
    int[] arrayInt = new int[strArr.Length];
    for (int i = 0; i < strArr.Length; i++)
    {
        arrayInt[i] = Convert.ToInt32(strArr[i]);
    }
    return arrayInt;
}
int NumberPositive(int[] array) // счетчик по условию
{
    int numberPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) numberPositive++;
    }
    return numberPositive;
}

Console.Write("Введите количество вводимых чисел М = ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите {num} чисел через запятую ");

string str = Console.ReadLine(); 
string[] strArray = str.Split(','); 
// int[] arrInt = str.Split(',') // преобразуем строк массив в массив с М строк.эл-ми
//     .Select(x => Convert.ToInt32(x))
//     .ToArray(); 
while (strArray.Length != num) // проверка кол-ва введенных чисел
{
    Console.Write($"Количество введенных чисел не совпадает с М = {num}. Повторите ввод {num} чисел через запятую ");
    str = Console.ReadLine(); // массиву str присваиваем введенную строку 
    strArray = str.Split(','); // преобразуем строк массив в массив с М строк.эл-ми
}
int[] arrInt = ArrayInt(strArray); // перевод строкового массива в чисельный
int numberPositive = NumberPositive(arrInt);    // счётчик положительных чисел
Console.WriteLine(str + $" -> {numberPositive}"); // выводим в консоль кол-во пол.чисел
