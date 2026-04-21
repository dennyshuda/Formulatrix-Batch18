
// Membuat thread baru
// Thread thread = new(new ThreadStart(MetodeSaya));
// thread.Start(); // Mulai eksekusi

// void MetodeSaya() {
//     Console.WriteLine("Berjalan di thread terpisah");
// }

// // Menjalankan tugas di ThreadPool
// ThreadPool.QueueUserWorkItem(state => {
//     Console.WriteLine("Tugas dari ThreadPool");
// });

// Thread - low level

Thread thread = new Thread(() => {
    int result = Compute();
    // Bagaimana return value?
});

int Compute() {
    throw new NotImplementedException();
}

thread.Start();

// Task - high level dengan return value
Task<int> task = Task.Run(() => Compute());
int result = await task;  // Bisa await!