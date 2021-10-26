using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MoreOnCollectionApplication
{
    class Program
    {
        void UnderstandingArrayList()
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(200.0);
            numbers.Add(12.0);
            numbers.Add(100.34);
            numbers.Add(10.3);
            numbers.Add(10.7);
            numbers.Sort();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(numbers[1]);
        }
        void UnderstandingQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue("Hello");
            queue.Enqueue("Welcome");
            queue.Enqueue("Hi");
            queue.Enqueue("Bye");
            Console.WriteLine("Count before dequeue "+queue.Count);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine("Count after dequeue " + queue.Count);
        }
        void UnderstandingStack()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Welcome");
            myStack.Push("Hi");
            myStack.Push("Bye");
            Console.WriteLine("Count before dequeue " + myStack.Count);
            Console.WriteLine(myStack.Pop());
            Console.WriteLine("Count after dequeue " + myStack.Count);
        }
        void UnderstandingDictionary()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(101, "Tim");
            hashtable.Add(102, "Jim");
            hashtable.Add(103, "Kim");

            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item+" "+hashtable[item]);
            }
            Console.WriteLine("Is the employee with ID 102 present?? "+hashtable.ContainsKey(102));
            Console.WriteLine(hashtable[102]);
            Console.WriteLine("----------------");
            var myEmp = (from int emp in hashtable.Keys
                        where emp>101
                        orderby emp descending 
                        select emp).ToList();
            foreach (var item in myEmp)
            {
                Console.WriteLine(hashtable[item]);
            }
        }
        static void Main(string[] args)
        {
            //int[] nums = { 100, 76, 45, 90 };
            //var dist = from n in nums where n > 75 select n;
            //foreach (var item in dist)
            //{
            //    Console.WriteLine(item);
            //}
            new Program().UnderstandingDictionary();
            Console.ReadKey();
        }
    }
}
