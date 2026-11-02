using System;

class Box<T> where T : IComparable<T>
{
    private T _value;

    public Box(T value)
    {
        _value = value;
    }

    public T GetValue() => _value;

    public void SetValue(T value)
    {
        _value = value;
    }

    public bool IsGreaterThan(Box<T> other)
    {
        return _value.CompareTo(other._value) > 0;
    }

    public void PrintType()
    {
        Console.WriteLine(typeof(T));
    }

    public bool isEqualTo(Box<T> other)
    {
        return _value.CompareTo(other._value) == 0;
    }
}

class Program
{
    static void Main()
    {
        Box<int> first = new(10);
        Box<int> second = new(25);

        Console.WriteLine(first.IsGreaterThan(second)); // False
        Console.WriteLine(second.IsGreaterThan(first)); // True

        Box<string> word1 = new("Apple");
        Box<string> word2 = new("Banana");

        Console.WriteLine(word1.IsGreaterThan(word2)); // False

        Box<int> a = new(10);
        Box<int> b = new(10);

        Console.WriteLine(a.isEqualTo(b)); // True
    }
}