using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstTask();
            //SecondTask();
            //ThirdTask();
            //FourthTask();
            FifthTask();
            Console.ReadLine();
        }
        public static void FifthTask()
        {
            using (var context = new PersonContext())
            {
                var deptors = context.Persons.Where(d => d.IsDebtor == false);

                foreach (var deptor in deptors)
                {
                    context.Entry(deptor).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }
        public static void FourthTask()
        {
            using (var context = new PersonContext())
            {
                var books = context.Books.Where(b => b.PersonId == 2);
                
                foreach(var book in books)
                {
                    Console.WriteLine(book.Name);
                }
            }
        }
        public static void ThirdTask()
        {
            using (var context = new PersonContext())
            {
                var books = context.Books.Where(b => b.PersonId == null);

                foreach(var book in books)
                {
                    Console.WriteLine(book.Person.FullName);
                }
            }
        }
        public static void SecondTask()
        {
            using (var context = new PersonContext())
            {
                var authors = context.AuthorBooks.Where(c => c.BookId == 3);

                foreach(var author in authors)
                {
                    Console.WriteLine(author.Author.Name);
                }
            }
        }
        public static void FirstTask()
        {
            using (var context = new PersonContext())
            {
                var debtors = context.Persons.Where(d => d.IsDebtor);

                foreach(var debtor in debtors)
                {
                    Console.WriteLine(debtor.FullName);
                }
            }
        }
    }
}
