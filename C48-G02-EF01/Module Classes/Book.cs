using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C48_G02_EF01.Module_Classes
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string INSB { get; set; }
        public decimal Price { get; set; }
        public int NumberOfBages { get; set; }
        public int PublishedYear { get; set; }
        public bool IsInStock { get; set; }
    }
}
