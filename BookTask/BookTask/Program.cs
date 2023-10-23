using AppClasses.Models;
using System.Runtime.InteropServices;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Book Task

            //Library library = new Library();

            //library.Books.Add(new Book("Pragmatic Programmer", "Andy Hunt", 320));
            //library.Books.Add(new Book("Eloquent JavaScript", "Marijn Haverbeke", 300));
            //library.Books.Add(new Book("Ng Book", "Nathan Murray", 600));
            //library.Books.Add(new Book("Algorithms", "Robert Sedgewick", 650));


            //var booksByName = library.FindAllBooksByName("Eloquent JavaScript");
            //foreach (Book book in booksByName)
            //{
            //    Console.WriteLine(book);
            //}

            //var booksByPageCountRange = library.FindAllBooksByPageCountRange(200, 400);
            //foreach (Book book in booksByPageCountRange)
            //{
            //    Console.WriteLine(book);
            //}

            //var booksBySearchedValue = library.SearchBooks("Andy Hunt");
            //foreach (Book book in booksBySearchedValue)
            //{
            //    Console.WriteLine(book);
            //}

            //library.RemoveBookByCode("PR1");
            //foreach (Book book in library.Books)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion

            #region Generic collections examples

            #region Dictionary

            //Dictionary<string, string> citiesToCapital = new Dictionary<string, string>(){
            //        {"Azerbaijan", "Baku"},
            //        {"Turkey", "Istanbul"},
            //        {"Russia", "Moscow"}
            //};

            //citiesToCapital.Add("Italy", "Roma");

            //citiesToCapital.Remove("Turkey");
            //citiesToCapital["Russia"] = "Samara";

            //foreach (var country in citiesToCapital)
            //{
            //    Console.WriteLine($"{country.Key} <=> {country.Value}");
            //}

            #endregion


            #region Sorted List
            //SortedList<int, string> numbers = new SortedList<int, string>(){
            //        {1, "One"},
            //        {3, "Three"},
            //        {2, "Two"},
            //};
            //numbers.Add(5, "Five");
            //numbers.Add(4, "Four");

            //if (numbers.ContainsKey(4))
            //{
            //    numbers[4] = "not a four";
            //}

            //numbers.Remove(1);

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine($"{num.Key} <=> {num.Value}");
            //}
            #endregion

            #region Queue


            //Queue<char> stringWord = new Queue<char>();
            //stringWord.Enqueue('E');
            //stringWord.Enqueue('L');
            //stringWord.Enqueue('V');
            //stringWord.Enqueue('I');
            //stringWord.Enqueue('N');

            //Console.WriteLine(stringWord.Dequeue()); //removed first Element

            //Console.WriteLine(stringWord.Peek());

            //Console.WriteLine(stringWord.Dequeue()); //removed second Element

            //foreach (char word in stringWord)
            //{
            //    Console.Write(word);
            //}
            #endregion

            #region Stack
            //Stack<int> numsStack = new Stack<int>();
            //numsStack.Push(1);
            //numsStack.Push(2);
            //numsStack.Push(3);
            //numsStack.Push(4);
            //numsStack.Push(5);

            ////Console.Write("Number of elements in Stack: ", numsStack.Count);
            //numsStack.Pop();
            //numsStack.Pop();

            //foreach (var num in numsStack)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine(numsStack.Contains(1));      



            #endregion

            #endregion

        }
    }
}