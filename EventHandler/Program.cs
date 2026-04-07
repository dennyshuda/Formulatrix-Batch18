class Program {
    static void Main(string[] args) {

        var oil = new Oil("Pertalite", "calm");

        oil.StatusChanged += SendAnnouncement;
        oil.StatusChanged += SendPriceAnnouncement;
        Console.WriteLine("--- Condition Changed ---");
        oil.Condition = "war";
    }

    static void SendAnnouncement(object? sender, StatusChangedEventArgs e) {
        Console.WriteLine($"[BAHLIL]: War begins");
    }

    static void SendPriceAnnouncement(object? sender, StatusChangedEventArgs e) {
        if (sender is Oil p) {
            Console.WriteLine($"[BAHLIL]: Price will be increase 1000 {p.Name} - {e.Status}");
        } else {
            Console.WriteLine("No sender");
        }
    }
}

public class StatusChangedEventArgs : EventArgs {
    public string Status { get; }


    public StatusChangedEventArgs(string status) {
        Status = status;
    }
}

public class Oil {
    public string Name { get; set; }
    private string _condition;
    private int _price = 10_000;

    public event EventHandler<StatusChangedEventArgs>? StatusChanged;

    public Oil(string name, string condition) {
        Name = name;
        _condition = condition;
    }

    public string Condition {
        get => _condition;
        set {
            if (value == "war") {
                _condition = "war";
                _price += 1000;
                OnStatusChanged(new StatusChangedEventArgs(value));
            }
        }
    }

    protected virtual void OnStatusChanged(StatusChangedEventArgs e) {
        StatusChanged?.Invoke(this, e);
    }
}