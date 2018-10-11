using System;

namespace TreehouseObjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Tower tower = new Tower();
            Map map = new Map(8, 5);

            Point x = new MapLocation(4, 2);

            Point p = x;

            map.OnMap(new MapLocation(0, 0));
            Console.WriteLine(x.DistanceTo(5, 5));
            Console.WriteLine(x is MapLocation);
            Console.WriteLine(x is Point);
            Point point = new Point(0, 0);
            Console.WriteLine(point is MapLocation);

            Console.Read();
        }
            //        //------------ADDITIONAL PRACTICE WITH METHODS--------------
            //        var book1 = new Book("The Fountainhead", "Ayn Rand");
            //        Console.WriteLine(book1.GetDisplayText());

            //        book1.Loan("Natz");
            //        Console.WriteLine(book1.GetDisplayText());

            //        book1.Return();
            //        Console.WriteLine(book1.GetDisplayText());

            //        Console.Read();
            //    }

            //}
            //class Book
            //{
            //    public readonly string Title;
            //    public readonly string Author;
            //    public string Loanee = null;
            //    public bool OnLoan = false;

            //    public Book(string title, string author)
            //    {
            //        Title = title;
            //        Author = author;
            //    }

            //    public void Loan(string loanee)
            //    {
            //        Loanee = loanee;
            //        OnLoan = true;
            //    }

            //    public void Return()
            //    {
            //        Loanee = null;
            //        OnLoan = false;
            //    }

            //    public string GetDisplayText()
            //    {
            //        string text = "Book: " + Title + " by " + Author;

            //        if (OnLoan)
            //        {
            //            text += " (Currently on loan to " + Loanee + ")";
            //            return text;

            //        }
            //        else
            //        {
            //            return text;
            //        }
            //    }

        }
    
}
