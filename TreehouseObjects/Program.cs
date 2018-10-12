﻿using System;

namespace TreehouseObjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Tower tower = new Tower();
            Map map = new Map(8, 5);
            //handle exception here with try/catch since this is the first file run in the program
            try
            {
                Path path = new Path(
                    //passing the array into the constructor
                    new[] {
                        new MapLocation(0,2, map),
                        new MapLocation(1,2, map),
                        new MapLocation(2,2, map),
                        new MapLocation(3,2, map),
                        new MapLocation(4,2, map),
                        new MapLocation(5,2, map),
                        new MapLocation(6,2, map),
                        new MapLocation(7,2, map),
                        }
                );
                //if selecting a value outside of the array length (8), the compiler will return null
                //MapLocation location = path.GetLocationAt(7);
                //if (location != null)
                //{
                //Console.WriteLine($"{location.X}, {location.Y}");
                //}

                //changed the set property in Invader to private, so the following code is no longer usable

                //Invader invader = new Invader();
                //MapLocation location = new MapLocation(0, 0, map);
                ////the following line of code calls the setter property in Invader.cs
                //invader.Location = location;

                //the following line of code calls the getter property in Invader.cs
                //location = invader.Location;
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TreehouseDefenseException)
            {
                Console.WriteLine("unhandled TreehouseDefense exception.");
            }
            //by adding variable ex to the Exception message, we get more info about the type of exception that is occurring
            catch (Exception ex)
            {
                Console.WriteLine($"unhandled exception. {ex}");
            }

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
