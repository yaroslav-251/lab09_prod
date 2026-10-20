// шаг 2
// int[] scores = [5, 4, 3, 5, 4];
// Console.WriteLine(scores[0]);
// Console.WriteLine(scores[scores.Length - 1]);
// scores[2] = 5;
// Console.WriteLine(string.Join(", ", scores));
// шаг 3
// int[] scores = [5, 4, 3, 5, 4];
// // можем узнать точный индекс
// for (int i = 0; i < scores.Length; i++)
// {
//     Console.WriteLine($"Индекс {i}: {scores[i]}");
// }

// foreach (int score in scores)
// {
//     Console.WriteLine(score);
// }
// тут получается недопустимый индекс 3 в массиве нет такого элемента с таким индексом, условие изменяем на < чем длинна
// int[] numbers = [10, 20, 30];

// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }

// шаг 5

// void ChangeFirst(int[] array)
// {
//     array[0] = 100;
// }

// int[] data = [1, 2, 3];

// Console.WriteLine("До вызова: " + string.Join(", ", data));

// ChangeFirst(data);

// Console.WriteLine("После вызова: " + string.Join(", ", data));

//шаг 6

// int[] s = [1, 2, 3, 4, 5];

// void DoubleElements(int[] s)
// {
//     for (int i = 0; i < s.Length; i++)
//     {
//         s[i] = s[i] * 2;
//     }
// }


// Console.WriteLine("До изменения: " + string.Join(", ", s));

// DoubleElements(s);

// Console.WriteLine("После изменения: " + string.Join(", ", s));

// шаг 7
// int n = 0;
// int p = 0;
// int m = 0;
// int v = 12345678;
// int[] data = [7, -3, 12, 0, 5, 9, -8];
// int[] negative = [-5, -2, -9];
// foreach (int b in negative)
// {
//     n += b;
//     p += 1;
//     if (b > m)
//     {
//         m = b;
//     }
//     if (b < v)
//     {
//         v = b;
//     }
// }
// Console.WriteLine($"сумма {n}");
// Console.WriteLine($"среднее знач {((double)n / p):F2}");
// Console.WriteLine($"максимальный элемент {m}");
// Console.WriteLine($"Минимальный элемент {v}");
// шаг 9


// int size = 0;

// while (size <= 0)
// {
//     Console.Write("Размер массива: ");
//     int.TryParse(Console.ReadLine(), out size);

//     if (size <= 0)
//     {
//         Console.WriteLine("Введите число больше нуля!");
//     }
// }

// int[] data = new int[size];

// for (int i = 0; i < data.Length; i++)
// {
//     Console.Write($"Элемент {i + 1}: ");

//     while (!int.TryParse(Console.ReadLine(), out data[i]))
//     {
//         Console.WriteLine("Введите целое число!");
//         Console.Write($"Элемент {i + 1}: ");
//     }
// }

// Console.WriteLine("Массив: " + string.Join(", ", data));

// итоговая задача


int count = 0;

while (count <= 0)
{
    Console.Write("Сколько результатов? ");

    if (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
    {
        Console.WriteLine("Введите целое число больше нуля!");
        count = 0;
    }
}

int[] results = new int[count];

for (int i = 0; i < results.Length; i++)
{
    while (true)
    {
        Console.Write($"Результат {i + 1}: ");

        if (int.TryParse(Console.ReadLine(), out results[i]))
        {
            break;
        }

        Console.WriteLine("Введите целое число!");
    }
}

int threshold = 0;
bool correct = false;

while (!correct)
{
    Console.Write("Порог: ");

    correct = int.TryParse(Console.ReadLine(), out threshold);

    if (!correct)
    {
        Console.WriteLine("Введите целое число!");
    }
}

PrintResults(results);

int sum = 0;
int best = results[0];
int worst = results[0];
int aboveThreshold = 0;

foreach (int result in results)
{
    sum += result;

    if (result > best)
    {
        best = result;
    }

    if (result < worst)
    {
        worst = result;
    }

    if (result >= threshold)
    {
        aboveThreshold++;
    }
}

double average = (double)sum / results.Length;

Console.WriteLine($"Среднее: {average:F2}");
Console.WriteLine($"Лучший результат: {best}");
Console.WriteLine($"Худший результат: {worst}");
Console.WriteLine($"Результатов не ниже {threshold}: {aboveThreshold}");

void PrintResults(int[] array)
{
    Console.WriteLine();
    Console.WriteLine("Результаты:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1}: {array[i]}");
    }

    Console.WriteLine();
}
