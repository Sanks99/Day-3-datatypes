using System;

class Program
{
    static void Main()
    {
        // Implicit Conversion
        float floatValue = 3.14f;
        double doubleValue = floatValue;
        Console.WriteLine($"floatValue: {floatValue}, doubleValue: {doubleValue}");

        // Explicit Conversion
        double explicitDoubleValue = 123.456;
        int intValue = (int)explicitDoubleValue;
        Console.WriteLine($"explicitDoubleValue: {explicitDoubleValue}, intValue: {intValue}");

        // Built-in Methods
        string intAsString = intValue.ToString();
        double parsedDouble = double.Parse("7.89");
        Console.WriteLine($"intAsString: {intAsString}, parsedDouble: {parsedDouble}");

       
        string firstName = "John";
        string lastName = "Doe";
        string fullName = firstName + " " + lastName;
        Console.WriteLine($"fullName: {fullName}");

        string upperFullName = fullName.ToUpper();
        Console.WriteLine($"upperFullName: {upperFullName}");


    }
}