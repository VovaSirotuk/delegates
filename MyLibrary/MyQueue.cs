using System;


namespace MyLibrary
{
    public class MyQueue
    {
        private char[] items;
        private int count;  
        const int n = 10;   
        public Generator Generator = new Generator();
        public MyQueue()
        {
            items = new char[n];
        }
        public MyQueue(int length)
        {
            items = new char[length];
        }
        
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        
        public int Count
        {
            get { return count; }
        }
        
        public void Enqueue(char item)
        {
           
            Generator.Overflowed += Show;
            
            if (count == items.Length)
            {
                Generator.CheckQueue(items.Length, count);
            }
            else
            {
                items[count++] = item;
            }
            
            Generator.Overflowed -= Show;
        }
        // Видаляє об'єкт із початку черги та повертає його.
        public char Dequeue()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            char item = items[--count];
            items[count] = default(char); // сбрасываем ссылку
            return item;
        }
        // возвращаем элемент из верхушки стека
        // лямбда вираз
        public char Peek() => items[count - 1];

        public  void Show(object sender, OverflowedEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
        public  void ShowQueue()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(items[i]);
            }
            
        }
    }
}