namespace learning_dotnet.Day1;

public class Person( string name) {
    private string name;

    public string Name {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    protected bool Equals(Person other) {
        return name == other.name;
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Person)obj);
    }

    public override int GetHashCode() {
        return name.GetHashCode();
    }
}