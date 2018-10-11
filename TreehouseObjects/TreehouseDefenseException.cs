﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseObjects
{
    class TreehouseDefenseException : Exception
    {
        public TreehouseDefenseException()
        {

        }

        public TreehouseDefenseException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TreehouseDefenseException
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
