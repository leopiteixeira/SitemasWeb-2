using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class Author
    {
        public static int id = 0;
        public string Name { get; set; }
        public string Email { get; set; }
        public char Gender { get; set; }

        public Author(string nome, string email, char gender)
        {
            Name = nome;
            Email = email;
            Gender = gender;
            id += 1;
        }

        public override string ToString()
        {
            return $"Author[name={Name}, email={Email}, gender={Gender}]";
        }

        //Leonardo Pinto Teixeira e Gabriel Coutinho dos Santos

    }
}
