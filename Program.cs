// шаг 2
// int[] scores = [5, 4, 3, 5, 4];
// Console.WriteLine(scores[0]);
// Console.WriteLine(scores[scores.Length - 1]);
// scores[2] = 5;
// Console.WriteLine(string.Join(", ", scores));
// шаг 3
int[] scores = [5, 4, 3, 5, 4];
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"Индекс {i}: {scores[i]}");
}

foreach (int score in scores)
{
    Console.WriteLine(score);
}
