// DemonstrateBasicEnumeration();
// DemonstrateManualEnumeration();
namespace Enumerator;

class Program {
    static void Main() {

        List<User> users = [
            new(1, "Budi", 25, "budi@mail.com"),
            new(2, "Ani", 20, "ani@mail.com"),
            new(3, "Caca", 30, "caca@mail.com")
        ];

        var filteredAge = users.Where(u => u.Umur > 22).Take(1);
        var namaUsers = users.Select(u => u.Nama);
        var orderedAge = users.OrderBy(u => u.Umur);

        try {
            var budi = users.First(u => u.Nama == "Budi" && u.Umur > 30);
            Console.WriteLine($"data: {budi}");
        } catch (InvalidOperationException ex) {
            Console.WriteLine($"data is doesnt exist {ex.Message}");
        } catch (Exception ex) {
            Console.WriteLine($"Error: {ex.Message}");
        } finally {
            Console.WriteLine("done");
        }


        foreach (var user in namaUsers) {
            Console.WriteLine(user);
        }

        foreach (var age in orderedAge) {
            Console.WriteLine(age);
        }

        foreach (var user in filteredAge) {
            Console.WriteLine(user);
        }
        //  ini kenapa gabisa di format
        var colors = new Dictionary<string, string> {
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
    }

    static void DemonstrateBasicEnumeration() {
        string words = "Trump";

        var kursor = words.GetEnumerator();

        while (kursor.MoveNext()) {
            Console.Write($"{kursor.Current}, \n");
        }

        IEnumerable<int> Fibs(int fibCount) {
            for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++) {
                yield return prevFib; // Yields the current Fibonacci number
                int newFib = prevFib + curFib;
                prevFib = curFib;
                curFib = newFib;
            }
        }

        foreach (int fib in Fibs(8)) {
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
    public class User {
        public int Id { get; set; }
        public string Nama { get; set; }
        public int Umur { get; set; }
        public string Email { get; set; }

        // Constructor untuk inisialisasi data
        public User(int id, string nama, int umur, string email) {
            Id = id;
            Nama = nama;
            Umur = umur;
            Email = email;
        }

        // Contoh override metode ToString agar mudah dicetak
        public override string ToString() {
            return $"User: {Nama}, Umur: {Umur}, Email: {Email}";
        }
    }
}






