DemonstrateBasicEnumeration();
DemonstrateManualEnumeration();

static void DemonstrateBasicEnumeration() {

    IEnumerable<int> Fibs(int fibCount) // Returns IEnumerable<int>
{
        for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++) {
            yield return prevFib; // Yields the current Fibonacci number
            int newFib = prevFib + curFib;
            prevFib = curFib;
            curFib = newFib;
        }
    }

    // ... in your main code:
    foreach (int fib in Fibs(8)) // Consumes the sequence produced by Fibs
    {
        Console.Write(fib + "  ");
    }

    Console.WriteLine("");

    Console.WriteLine("--- 1. Basic Enumeration with foreach ---");

    string word = "beer";
    Console.WriteLine($"Iterating through the string '{word}':");

    foreach (char c in word) {
        Console.WriteLine($"  Character: {c}");
    }
    Console.WriteLine();
}

static void DemonstrateManualEnumeration() {
    Console.WriteLine("--- 2. Manual Enumeration (what foreach does behind the scenes) ---");

    string word = "beer";
    Console.WriteLine($"Manually iterating through '{word}' using GetEnumerator():");

    // This is what the compiler generates for foreach statements
    using (var enumerator = word.GetEnumerator()) {
        while (enumerator.MoveNext()) {
            var element = enumerator.Current;
            Console.WriteLine($"  Character: {element}");
        }
    } // Dispose is called automatically due to 'using'
    Console.WriteLine();
}

List<string> daftarNama = ["Andi", "Budi", "Caca"];

// Mendapatkan enumerator
IEnumerator<string> enumerator = daftarNama.GetEnumerator();

// Menggunakan enumerator untuk looping manual
while (enumerator.MoveNext()) {
    Console.WriteLine(enumerator.Current);
}
static IEnumerable<int> AmbilAngkaGanjil(int batas) {
    for (int i = 1; i <= batas; i++) {
        if (i % 2 != 0) {
            yield return i;
        }
    }
}

// Cara pakainya:
foreach (var angka in AmbilAngkaGanjil(10)) {
    Console.WriteLine(angka);
}

var colors = new Dictionary<string, string>
{
    { "red", "#FF0000" },
    { "green", "#00FF00" },
    { "blue", "#0000FF" }
};

var moreColors = new Dictionary<string, string> {
    ["yellow"] = "#FFFF00",
    ["purple"] = "#800080",
    ["orange"] = "#FFA500"
};

foreach (var kvp in moreColors) {
    Console.WriteLine($"  {kvp.Key}: {kvp.Value}");
}
