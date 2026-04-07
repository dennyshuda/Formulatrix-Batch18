string? someText = null;
object? someObject = null;

Console.WriteLine($"Reference type (string): {someText ?? "null"}");
Console.WriteLine($"Reference type (object): {someObject ?? "null"}");

int regularInt = default;
bool regularBool = default;
DateTime regularDate = default;

Console.WriteLine($"Value type (int): {regularInt}");
Console.WriteLine($"Value type (bool): {regularBool}");
Console.WriteLine($"Value type (DateTime): {regularDate}");

Nullable<int> explicitNullable = new Nullable<int>(100);
int? shorthandNullable = 100;

Console.WriteLine($"Explicit Nullable<int>: {explicitNullable}");
Console.WriteLine($"Shorthand int?: {shorthandNullable}");
Console.WriteLine($"Are they the same type? {explicitNullable.GetType() == shorthandNullable.GetType()}");