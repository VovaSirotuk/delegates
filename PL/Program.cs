using System;
using MyLibrary;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Перше завдання: ");
            FirstTask firstTask = new FirstTask();

            firstTask.Anonimus();
            firstTask.Lyambda();
            Console.WriteLine("Друге завдання: ");

            MyQueue myQueue = new MyQueue();
            Console.WriteLine("Cтворена черга з символiв: ");
            myQueue.Enqueue('h');
            myQueue.Enqueue('q');
            myQueue.Enqueue('a');
            myQueue.Enqueue('b');
            myQueue.Enqueue('y');
            myQueue.ShowQueue();
            Console.WriteLine("\nВидалення двох елементiв з кiнця: ");
            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.ShowQueue();

            Console.ReadKey();
        }
    }
}