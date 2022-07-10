using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 20;
            char lastInitial = 'Q';
            bool married = true;
            double gpa = 3.5;
            decimal height = 5.5m;

            Console.WriteLine($"{name} {lastInitial} is a {age} year old. It is {married} that he is married. His GPA was {gpa} and his height is {height} feet.");
        }
    }
}