namespace LogicExercise.LoopGenerator;

interface ILoopGenerator {
    int MaxIteration { get; }
    Dictionary<int, string> Rules { get; set; }

    void AddRule(int input, string output);
    void RemoveRule(int input);
    void GenerateResult();
    void ShowRules();

    void ResetRules();

}

class LoopGenerator : ILoopGenerator {
    public int MaxIteration { get; }

    public Dictionary<int, string> Rules { get; set; }

    public LoopGenerator(int maxIteration) {
        MaxIteration = maxIteration;
        Rules = [];
    }

    public void ShowRules() {
        Console.WriteLine("=== Rules ===");

        if (Rules.Count == 0) {
            Console.WriteLine("Rules is empty");
        }

        foreach (var rule in Rules) {
            Console.WriteLine($"{rule.Key} - {rule.Value}");
        }

    }

    public void GenerateResult() {
        for (int index = 1; index <= MaxIteration; index++) {
            bool mark = false;
            foreach (var rule in Rules) {
                if (index % rule.Key == 0) {
                    Console.Write(rule.Value);
                    mark = true;
                }
            }

            Console.Write(mark ? "" : index);

            Console.Write(index == MaxIteration ? "" : ", ");
        }

    }

    public void AddRule(int input, string output) {
        if (!Rules.TryAdd(input, output)) {
            Console.WriteLine($"Rules {input} is already exist");
        }
    }

    public void RemoveRule(int input) {
        bool isRemoved = Rules.Remove(input);

        if (isRemoved) {
            Console.WriteLine($"Rules {input} removed");
        } else {
            Console.WriteLine($"Rules {input} not found");
        }
    }

    public void ResetRules() {
        if (Rules.Count == 0) {
            Console.WriteLine("Rules is already empty");
        } else {
            Rules.Clear();
            Console.WriteLine("Success to reset rules");
        }
    }
};