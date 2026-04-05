using Interfaces;

Countdown countdown = new Countdown();

Console.WriteLine("Current: " + countdown.Current);
countdown.MoveNext();
Console.WriteLine("Current: " + countdown.Current);
countdown.MoveNext();
Console.WriteLine("Current: " + countdown.Current);
