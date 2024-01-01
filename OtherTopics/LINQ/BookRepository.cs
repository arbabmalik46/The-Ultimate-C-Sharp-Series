using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherTopics
{
    public class BookRepository
    {
        public IEnumerable<Books> GetBooks()
        {
            return new List<Books>()
            {
            new Books() { Title = "ADO.NET Step by Step", Price = 5},
            new Books() { Title = "ASP.NET MVC", Price = 9.99f },
            new Books() { Title = "ASP.NET Web API", Price = 12 },
            new Books() { Title = "C# Basic Topics", Price = 7 },
            new Books() { Title = "C# Advance Topics", Price = 9 },
            new Books() { Title = "C# Advance Topics", Price = 10 },
            new Books() { Title = "C# Intermediate Topics", Price = 15 }
            };
        }
    }
}
