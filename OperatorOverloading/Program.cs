namespace OperatorOverloading;

class Program {
    static void Main(string[] args) {

        Titik t1 = new(1, 2);
        Titik t2 = new(3, 4);
        Titik hasil = t1 + t2; //

        Console.WriteLine(hasil.X);


    }
}
public struct Note {
    public int value; // Semitones from a base 'A' note

    public Note(int semitonesFromA) { value = semitonesFromA; }

    // Overloading the '+' operator
    // This allows us to add an integer (semitones) to a Note
    public static Note operator +(Note x, int semitones) {
        return new Note(x.value + semitones);
    }
}

public struct Titik {
    public int X { get; set; }
    public int Y { get; set; }

    public Titik(int x, int y) {
        X = x;
        Y = y;
    }

    // Mendefinisikan operator '+'
    public static Titik operator +(Titik a, Titik b) {
        return new Titik(a.X + b.X, a.Y + b.Y);
    }
}
