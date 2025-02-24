using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersExercise;

file class MyFileScopedClass
{
}

internal class MyClassThatUsesFileScopedClass
{
    public MyClassThatUsesFileScopedClass()
    {
        var myFileScopedClass = new MyFileScopedClass();
    }
}
