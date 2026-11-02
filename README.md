Generic Box Example
This project demonstrates how to use generic classes and generic constraints in C#.
What This Example Shows
- Generic classes with Box<T>
- Type parameters
- Generic constraints
- where T : IComparable<T>
- Type-safe reusable code
- Comparing values with CompareTo
- Using the same class with int and string
Generic Class
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

    public bool IsEqualTo(Box<T> other)
    {
        return _value.CompareTo(other._value) == 0;
    }

    public void PrintType()
    {
        Console.WriteLine(typeof(T));
    }
}
Example Usage
Box<int> first = new(10);
Box<int> second = new(25);

Console.WriteLine(first.IsGreaterThan(second)); // False
Console.WriteLine(second.IsGreaterThan(first)); // True

Box<int> third = new(10);

Console.WriteLine(first.IsEqualTo(third)); // True

Box<string> word1 = new("Apple");
Box<string> word2 = new("Banana");

Console.WriteLine(word1.IsGreaterThan(word2)); // False

first.PrintType();  // System.Int32
word1.PrintType();  // System.String
How It Works
T is a type parameter. It allows the same class to work with different types.
Box<int>
Box<string>
These are two different constructed generic types.

The constraint:
where T : IComparable<T>
means that type T must implement IComparable<T>.

This is required because the class uses:
_value.CompareTo(other._value)
The compiler knows that every valid type T has a CompareTo method.

Both int and string implement IComparable<T>, so they can be used with Box<T>.
Why Generics Are Useful
Without generics, we might use object:
object value = 10;
This can cause:
- boxing and unboxing;
- possible invalid casts;
- runtime errors;
- weaker type safety.
Generics solve these problems by checking types at compile time.
Box<int> numberBox = new(10);
Box<string> textBox = new("Hello");
The compiler prevents invalid operations.
Important Terms
- Generic type — a type that works with different data types.
- Type parameter — a placeholder such as T.
- Generic constraint — a rule that limits which types can be used.
- IComparable<T> — an interface that allows values to be compared.
- Type safety — incorrect types are rejected during compilation.
- CompareTo — returns a value less than zero, zero, or greater than zero.
- Boxing — converting a value type to object.
- Specialization — creating a concrete generic type such as Box<int>.
Theory Connection
Generics allow a class to be reused without duplicating code for every data type.

The constraint where T : IComparable<T> tells the compiler what operations are available for T.

This is an example of compile-time type safety: the program verifies the required type capabilities before execution.
Possible Improvements
- Add IsLessThan.
- Add SwapValue.
- Override ToString.
- Add null validation for other.
- Implement IEquatable<Box<T>>.
- Create a generic collection class.
- Add unit tests.
