using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClasses.Models
{
    public class Book
    {
        public static int _count;
        public int Count { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; set; }

        static Book()
        {
            _count = 0;
        }
        public Book(string name, string authorName, int pageCount)
        {
            _count += 1;
            Count = _count;
            this.Name = name;
            this.AuthorName = authorName;
            this.PageCount = pageCount;
            this.Code = $"{name.Substring(0, 2).ToUpper()}{Count}";
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Author: {this.AuthorName}, PageCount: {this.PageCount}, Code: {this.Code}";
        }

    }
}
