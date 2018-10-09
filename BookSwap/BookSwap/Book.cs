using System;
using System.Collections.Generic;

namespace TestApp
{
    public class Book
    {   
        public List<string> authors { get; set; }
        public string title {  get; set; }
        public string isbn { get; set; }
        public string isbn13 { get; set; }
        public string image { get; set; }
        public string binding { get; set; }
        public string date_published { get; set; }
        public string publisher { get; set; }
        public string edition { get; set; }

        public override string ToString(){

            return "Title:\t" + title;
        }
    } 

    public class BookWrapper{

        public Book book { get; set; }
    }
}
