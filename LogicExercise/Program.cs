const int MAX_ITERATION = 50;

for (int i = 1; i <= MAX_ITERATION; i++) {
    if (i % 3 == 0 && i % 5 == 0) {
        Console.Write("FooBar, ");
    } else if (i % 5 == 0) {
        Console.Write("Bar, ");
    } else if (i % 3 == 0) {
        Console.Write("Foo, ");
    } else {
        Console.Write(i + ", ");
    }
}