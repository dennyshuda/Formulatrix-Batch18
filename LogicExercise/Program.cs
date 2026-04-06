static string EndOfValue(int index, int max) {
    return index == max ? "" : ", ";
}


const int MAX_ITERATION = 50;
Console.WriteLine("Method 1");

for (int i = 1; i <= MAX_ITERATION; i++) {
    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0) {
        Console.Write($"FooBarJazz{EndOfValue(i, MAX_ITERATION)}");
    } else if (i % 3 == 0 && i % 5 == 0) {
        Console.Write($"FooBar{EndOfValue(i, MAX_ITERATION)}");
    } else if (i % 3 == 0 && i % 7 == 0) {
        Console.Write($"FooJaz{EndOfValue(i, MAX_ITERATION)}");
    } else if (i % 5 == 0 && i % 7 == 0) {
        Console.Write($"BarJazz{EndOfValue(i, MAX_ITERATION)}");
    } else if (i % 3 == 0) {
        Console.Write($"Foo{EndOfValue(i, MAX_ITERATION)}");
    } else if (i % 5 == 0) {
        Console.Write($"Bar{EndOfValue(i, MAX_ITERATION)}");
    } else if (i % 7 == 0) {
        Console.Write($"Jazz{EndOfValue(i, MAX_ITERATION)}");
    } else {
        Console.Write($"{i}{EndOfValue(i, MAX_ITERATION)}");
    }
}

Console.WriteLine("");
Console.WriteLine("Method 2");
for (int index = 1; index <= MAX_ITERATION; index++) {

    if (index % 3 == 0) {
        Console.Write("Foo");
    }

    if (index % 5 == 0) {
        Console.Write("Bar");
    }

    if (index % 7 == 0) {
        Console.Write("Jazz");
    }

    if (index % 3 != 0 && index % 5 != 0 && index % 7 != 0) {
        Console.Write(index);
    }

    Console.Write(index == MAX_ITERATION ? "" : ", ");
}