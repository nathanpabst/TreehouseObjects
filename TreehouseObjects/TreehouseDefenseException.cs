using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    public class TreehouseDefenseException : Exception
    {
        public TreehouseDefenseException()
        {

        }

        public TreehouseDefenseException(string message) : base(message)
        {

        }
    }

    public class OutOfBoundsException : TreehouseDefenseException
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
