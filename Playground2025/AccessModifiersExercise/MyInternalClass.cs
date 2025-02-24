using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersExercise;

internal class MyInternalClass
{
}

internal class  MyOtherClassThatUsesFileScopedClass
{
    public MyOtherClassThatUsesFileScopedClass()
    {
        // This would fail as we can not acces class from other file that has file access modifier on it
        //var myFileScopedClass = new MyFileScopedClass();
    }
    
}