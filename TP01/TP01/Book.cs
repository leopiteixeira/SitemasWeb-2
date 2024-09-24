using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class Book
    {
        public static int id = 0;

        public string Name { get; set; }
        public List<Author> Authors { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }

        public Book(string nome, List<Author> autores, double price)
        {
            Name = nome;
            Authors = autores;
            Price = price;
            Qty = 0;
            id += 1;
        }

        public Book(string nome, List<Author> autores, double price, int qty)
        {
            Name = nome;
            Authors = autores;
            Price = price;
            Qty = qty;
            id += 1;
        }

        public string Detalhes()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Detalhes do Livro");
            stringBuilder.AppendLine("=====");
            stringBuilder.AppendLine($"Título: {Name}");
            foreach (Author author in Authors)
            {
                stringBuilder.AppendLine($"Autor: {author.Name}");
            }
            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            string auts = "";
            foreach (Author aut in Authors) { auts += aut.ToString() + ","; }
            string ret = $"Book[name={Name}, authors={auts} price={Price}, qty={Qty}]";
            return ret;
        }

        public string getAuthorNames()
        {
            string auts = "";
            foreach (Author aut in Authors) { auts += aut.Name + ","; }
            return auts;
        }
    }
}

