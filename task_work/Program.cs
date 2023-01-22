

Console.Write("Введите количество вводимых чисел М = ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите {num} чисел через запятую");
string str = Console.ReadLine();
string[] strArray = str.Split(',');
// double[] arr = EnterArrayDouble(raz); // заполняем массив 
int[] arrInt = ArrayInt(num, strArray); // перевод строкового массива в чисельный
int numberPositive = NumberPositive(arrInt);    // счётчик положительных чисел

// PrintArrayDouble(arr); // выводим в консоль заполненный массив
Console.WriteLine($" -> {numberPositive}"); // выводим в консоль кол-во пол. чисел из массива