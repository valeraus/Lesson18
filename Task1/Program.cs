using Dictionary;
using System;

namespace Task1
{
    /*
    Використовуючи приклад виконаного домашнього завдання №3 з 14 уроку, 
    реалізуйте можливість підключення вашого простору імен та роботи з MyDictionary<TKey,TValue> 
    аналогічно екземпляру класу Dictionary<TKey,TValue>.
     */
    class Program
    {
        static void Main()
        {
            MyDictionary<char, string> dictionary = new MyDictionary<char, string>();
            dictionary.Add('a', "Эй");
            dictionary.Add('b', "Би");
            dictionary.Add('c', "Си");
            dictionary.Add('d', "Ди");

            Console.WriteLine(dictionary['b']);

            foreach (string pair in dictionary)
                Console.WriteLine(pair);

            Console.ReadKey();
        }
    }
}
