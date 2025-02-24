// See https://aka.ms/new-console-template for more information
using AccessModifiersExercise;

Console.WriteLine("Hello, World!");


public class MyRandomClass
{
    public MyRandomClass()
    {
        var myInternalClass = new MyInternalClass();
        var myPublicClass = new MyPublicClass();
        //var myFileScopedClass = new MyFileScopedClass(); // Compiler will not allow this as MyFileScopedClass is file scoped
    }
}
