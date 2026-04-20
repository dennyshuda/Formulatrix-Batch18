using LogicExercise.LoopGenerator;

public class Program {
    public static void Main() {
        Console.Clear();

        ILoopGenerator generator = new LoopGenerator(105);
        generator.AddRule(3, "Foo");
        generator.AddRule(5, "Bar");
        generator.AddRule(7, "Jazz");
        generator.AddRule(9, "Huzz");

        generator.ShowRules();

        generator.GenerateResult();
        generator.RemoveRule(7);
        generator.ShowRules();
        generator.GenerateResult();
        generator.ResetRules();
        generator.ResetRules();
        generator.ResetRules();

    }
}