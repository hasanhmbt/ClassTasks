using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{

    public class Books
    {

        public int Id { get; set; }
        public string Code { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, BookName: {BookName}, AuthorName: {AuthorName}, Code: {Code}, PageCount: {PageCount}, Price: {Price}";
        }

    }



  

 

      


 


}
