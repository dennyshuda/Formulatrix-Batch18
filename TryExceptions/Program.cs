using System.Net;

MultipleCatchBlocksDemo();
ExceptionFiltersDemo();

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

static void ExceptionFiltersDemo() {
    Console.WriteLine("3. EXCEPTION FILTERS DEMONSTRATION");
    Console.WriteLine("==================================");

    // Simulate different web exception scenarios
    Console.WriteLine("Testing exception filters with 'when' keyword:");

    SimulateWebException(WebExceptionStatus.Timeout);
    SimulateWebException(WebExceptionStatus.SendFailure);
    SimulateWebException(WebExceptionStatus.ConnectFailure);

    Console.WriteLine();
}

static void SimulateWebException(WebExceptionStatus status) {
    try {
        // Create and throw a WebException with specific status
        var ex = new WebException("Hidup jokowi", status);
        throw ex;
    } catch (WebException ex) when (ex.Status == WebExceptionStatus.Timeout) {
        Console.WriteLine($"  Handled: Request timeout - retrying with longer timeout {ex.Message} - {ex.Status}");
    } catch (WebException ex) when (ex.Status == WebExceptionStatus.SendFailure) {
        Console.WriteLine($"  Handled: Send failure - checking network connection {ex.Message} - {ex.Status}");
    } catch (WebException ex) when (ex.Status == WebExceptionStatus.ConnectFailure) {
        Console.WriteLine($"  Handled: Connection failure - server might be down {ex.Message} - {ex.Status}");
    } catch (WebException ex) {
        Console.WriteLine($"  Handled: Other web exception - {ex.Status}");
    }
}