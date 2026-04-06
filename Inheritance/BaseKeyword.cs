public class Employee {
    public string Name = String.Empty;
    public decimal BaseSalary;


    public Employee(string name, decimal baseSalary) {
        Name = name;
        BaseSalary = baseSalary;
        Console.WriteLine("constructor called");
    }

    public virtual decimal CalculateBonus() {
        Console.WriteLine("Calculating base bonus (5% of base salary)...");
        return BaseSalary * 0.05m;
    }

}

public class Manager : Employee {

    public Manager(string name, decimal baseSalary) : base(name, baseSalary) {
        Console.WriteLine("Manager parameterless constructor called");
    }

    public decimal CalculateAnnualSalary() {
        decimal baseSalary = base.CalculateBonus();
        decimal managementIncrease = baseSalary * 0.20m;
        Console.WriteLine($"Management increase: {managementIncrease:F2}");

        return baseSalary + managementIncrease;
    }
}