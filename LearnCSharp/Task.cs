class Task {
    public string Title;
    public bool IsDone;
    public Task(string title) {
        Title = title;
        IsDone = false;
    }

    public void MarkAsDone() {
        IsDone = true;
        Console.WriteLine($"Tugas '{Title}' berhasil diselesaikan!");
    }

    public void ViewTask() {
        string status = IsDone ? "[Selesai]" : "[Belum Selesai]";
        Console.WriteLine($"{status} {Title}");
    }
}