using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Account);

            Console.WriteLine("Class Name : " + type.Name);

            ConstructorInfo[] constructorInfo = type.GetConstructors();
            Console.WriteLine("Total Constructor in class are: " + constructorInfo.Length);

            MethodInfo[] methodInfo = type.GetMethods();
            Console.WriteLine("Total Methods in class are: " + methodInfo.Length);


            PropertyInfo[] propertyinfo = type.GetProperties();
            Console.WriteLine("Total Properties in class are: " + propertyinfo.Length);

            FieldInfo[] fieldinfo = type.GetFields(BindingFlags.Public
            | BindingFlags.Instance);
            Console.WriteLine("Total Fields in class are: " + fieldinfo.Length);
        }
    }
}
