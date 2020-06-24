using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//.calculate and display the bill amount


namespace Assignment2
{
    class Books
    {
        public int isbn;
        public string bookname;
        public string booktitle;
        public string bookauthor;
        public int quantityofbooks;
        public double bookprice;


        public void bill()
        {

            bookprice = bookprice * quantityofbooks;
            Console.WriteLine("bookprice" + bookprice);
        
        }
    }

    class BooksTest
        {
        public static void Main()
        {
            Books b1 = new Books();

            b1.isbn = 11;
            b1.booktitle = "c++";
            b1.bookauthor = "david";

            b1.bookname = "learning c";
            b1.quantityofbooks = 10;
            b1.bookprice = 200;
            b1.bill();
            Console.ReadKey();
        }

}
}

