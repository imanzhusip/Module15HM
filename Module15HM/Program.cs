using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Module15HM
{
    public class Program
    {
        static void Main()
        {
            // Задача 1: Получить список методов класса Console и вывести на экран
            Type consoleType = typeof(Console);
            MethodInfo[] consoleMethods = consoleType.GetMethods();
            Console.WriteLine("Методы класса Console:");
            foreach (MethodInfo method in consoleMethods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();
            // Задача 2: Создать экземпляр класса MyClass и вывести значения его свойств
            MyClass myObject = new MyClass
            {
                Number = 42,
                Text = "Hello"
            };
            Type myType = typeof(MyClass);
            PropertyInfo[] properties = myType.GetProperties();
            Console.WriteLine("Значения свойств класса MyClass:");
            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(myObject);
                Console.WriteLine($"{property.Name}: {value}");
            }
            Console.WriteLine();
            // Задача 3: Вызвать метод Substring класса String с помощью рефлексии
            string testString = "Hello, Reflection!";
            Type stringType = typeof(string);
            MethodInfo substringMethod = stringType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });
            object[] parameters = { 7, 10 }; // начальный индекс и длина подстроки
            string result = (string)substringMethod.Invoke(testString, parameters);
            Console.WriteLine($"Результат вызова метода Substring: {result}");
            Console.WriteLine();
            // Задача 4: Получить список конструкторов класса List<T>
            Type listType = typeof(List<>);
            ConstructorInfo[] listConstructors = listType.GetConstructors();
            Console.WriteLine("Конструкторы класса List<T>:");
            foreach (ConstructorInfo constructor in listConstructors)
            {
                Console.WriteLine(constructor);
            }
            Console.ReadKey();
        }
    }
}
