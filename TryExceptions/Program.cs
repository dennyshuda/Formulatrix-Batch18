MultipleCatchBlocksDemo();
static void MultipleCatchBlocksDemo() {
    Console.WriteLine("2. MULTIPLE CATCH BLOCKS DEMONSTRATION");
    Console.WriteLine("======================================");

    string[] testArgs = { "300" };

    Console.WriteLine($"Testing with argument: '{testArgs[0]}'");

    try {
        byte b = byte.Parse(testArgs[0]);
        Console.WriteLine($"Successfully parsed: {b}");
    } catch (IndexOutOfRangeException) {
        Console.WriteLine("Error: Please provide at least one argument");
    } catch (FormatException) {
        Console.WriteLine("Error: That's not a valid number!");
    } catch (OverflowException) {
        Console.WriteLine($"Error: The number is too large to fit in a byte (max: 255 ");
    } catch (Exception ex) // General catch-all (should be last)
      {
        Console.WriteLine($"Unexpected error: {ex.Message} - {ex.Source}");
    }

}