using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            //задаваме си база данни 
            //setting databases
            List<string> myStringList = new List<string>();
            Queue<string> myStringQueue = new Queue<string>();
            Queue<string> mySecondStringQueue = new Queue<string>();
            Stack<string> myStringStack = new Stack<string>();
            Stack<string> mySecondStringStack2 = new Stack<string>();
            //Изписваме какво ще се съдържа в кода ни
            //Showing what we will have in our code
            Console.WriteLine("Stack");
            Console.WriteLine(" ");
            // започваме с команда .push да вкарваме елементи stack-a
            //може и да се направи с команди от конзолата, но се вдига time-а и space-а на кода
            //Starting to .push-ing elemenst into "stack". We can also make it with command to push from console, but we will increase "time" and "space"
            myStringStack.Push("IT");
            myStringStack.Push("-");
            myStringStack.Push("kariera");
            //въртим цикъл който да изкара всички елементи от stack-а с командата .Pop
            //doing a while cycle whoose .pop-ing(getting out) all elements from stack
            while (myStringStack.Count != 0)
            {
                
                Console.WriteLine(myStringStack.Pop());

            }
            Console.WriteLine("---------");
            //същото като горе с IT - kariera ,но с други думи за по-лесно ориентиране
            //same like upper with IT - kariera, but with diffrent words for easy orienting
            mySecondStringStack2.Push("First Input");
            mySecondStringStack2.Push("Second Input");
            mySecondStringStack2.Push("Third Input");
            //въртим цикъл който да изкара всички елементи от stack-а с командата .Pop
            //doing a while cycle whoose .pop-ing(getting out) all elements from stack
            while (mySecondStringStack2.Count != 0)
            {
                Console.WriteLine(mySecondStringStack2.Pop());
            }
            Console.WriteLine("---------");

            Console.WriteLine("Queue");
            Console.WriteLine(" ");
            // започваме с команда .enqueue да вкарваме елементи в Queue-то
            //може и да се направи с команди от конзолата, но се вдига time-а и space-а на кода
            //Starting to .enqueue-ing elemenst into "queue". We can also make it with command to queue from console, but we will increase "time" and "space"
            myStringQueue.Enqueue("IT");
            myStringQueue.Enqueue("-");
            myStringQueue.Enqueue("kariera");
            //въртим цикъл който да изкара всички елементи от Queue-то с командата .Dequeue
            //doing a while cycle whoose .dequeue-ing(getting out) all elements from queue
            while (myStringQueue.Count != 0)
            {
                Console.WriteLine(myStringQueue.Dequeue());
            }
            Console.WriteLine("---------");
            //същото като горе с IT - kariera но с други думи за по-лесно ориентиране
            //same like upper with IT - kariera, but with diffrent words for easy orienting
            mySecondStringQueue.Enqueue("First Input");
            mySecondStringQueue.Enqueue("Second Input");
            mySecondStringQueue.Enqueue("Third Input");
            //въртим цикъл който да изкара всички елементи от Queue-то с командата .Dequeue
            while (mySecondStringQueue.Count != 0)
            {
                Console.WriteLine(mySecondStringQueue.Dequeue());
            }
           
           



            /*List<string> myStringList = new List<string>();
            Queue<string> myStringQueue = new Queue<string>();
            Stack<int> myStringStack = new Stack<int>();

            int n = int.Parse(Console.ReadLine());
            int nsec = int.Parse(Console.ReadLine());
            int ntjir = int.Parse(Console.ReadLine());

            myStringStack.Push(n);
            myStringStack.Push(nsec);
            myStringStack.Push(ntjir);

            Console.WriteLine(myStringStack.Peek());
            Console.WriteLine(myStringStack.Count());*/




        }
    }
}

