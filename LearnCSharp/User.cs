public interface IUser {
    void CallMe();
}

class User(string name, string role, string _password) : IUser {

    private string name = name;

    public string Name {
        get {
            return name;
        }
        set {
            if (!string.IsNullOrEmpty(value)) {
                name = value;
            } else {
                Console.WriteLine("Name cannot be empty!");
            }
        }
    }

    private string role = role;

    public string Role { get { return role; } }

    private readonly string Password = _password;

    public bool IsValid(string inputUser, string inputPass) {
        return Name == inputUser && Password == inputPass;
    }

    public void CallMe() {
        Console.WriteLine($"Hallo {Name}");
    }
}

