﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Book
    {
        public Book()
        {
            _no++;
            No = _no;
        }
        static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

    }
}
