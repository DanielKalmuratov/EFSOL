using System;

namespace Books
{
    class Program
    {

        class Book {

            public class Notes {
                public string Note;
                public Notes(string note) {
                    Note = note;
                }
                

            }
        }
        static void Main(string[] args)
        {
            Book.Notes note = new Book.Notes("first note");
            Console.WriteLine(note.Note);
            note.Note = "second note";
            Console.WriteLine(note.Note);
            Console.ReadKey();
        }
    }
}
