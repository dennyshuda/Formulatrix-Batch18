User user = new("bahlil", "Admin", "etanol");

Console.WriteLine(user.Name);
user.Name = "kkkk";

int a = unchecked(int.MaxValue + 1);

Console.WriteLine(a);
Console.WriteLine(user.Role);

if (user.IsValid("bahlil", "etanol")) {
    Console.WriteLine("Berhasil");
    RunApp();
} else {
    Console.WriteLine("Login Gagal! Username atau Password salah.");
}

Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
Console.ReadKey();

static void RunApp() {
    List<Task> tasks = [new Task("Belajar C# Class"), new Task("Implementasi Login")];

    Console.WriteLine("--- Daftar Tugas Anda ---");
    foreach (var t in tasks) {
        t.ViewTask();
    }

    tasks.Add(new Task("Mecut ai"));

    Console.WriteLine("--- Daftar Tugas Anda ---");
    foreach (var t in tasks) {
        t.ViewTask();
    }

}

