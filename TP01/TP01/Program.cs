using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    class Program
    {
        static void Main(string[] args)
        {
            Author aut1 = new Author("Stephen King", "stk@gmail.com", 'm');
            Author aut2 = new Author("George Martin", "Gmtin@gmail.com", 'm');
            List<Author> x = new List<Author> { aut1, aut2 };
            Book b1 = new Book("O livro de teste", x, 25.99, 10);

            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1.getAuthorNames());
        }


    }
}
