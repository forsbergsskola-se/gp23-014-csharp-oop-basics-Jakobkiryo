ScoreCounter one = new ScoreCounter();

ScoreCounter two = one;

ScoreCounter three = two;

ScoreCounter four = three;

one.IncreaseScore();
two.IncreaseScore();
three.IncreaseScore();
four.IncreaseScore();

Console.WriteLine($"{one.Score}");
Console.WriteLine($"{two.Score}");
Console.WriteLine($"{three.Score}");
Console.WriteLine($"{four.Score}");
