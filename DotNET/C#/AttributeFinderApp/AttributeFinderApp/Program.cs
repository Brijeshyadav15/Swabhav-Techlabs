using System;
using System.Reflection;

namespace AttributeFinderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type employee = typeof(Employee);
            MethodInfo[] methodinfo = employee.GetMethods();
            PropertyInfo[] propertyinfo = employee.GetProperties();

            Console.WriteLine("Property having Custom Attribute ");
            foreach (PropertyInfo propinfo in propertyinfo)
            {
                object[] attrs = propinfo.GetCustomAttributes(true);
                foreach (object attr in attrs)
                {
                    Console.WriteLine(propinfo.Name);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Method having Custom Attribute ");
            foreach (MethodInfo info in methodinfo)
            {
                object[] attrs = info.GetCustomAttributes(true);
                foreach (object attr in attrs)
                {
                    Console.WriteLine(info.Name);
                }
            }

        }
    }
}
