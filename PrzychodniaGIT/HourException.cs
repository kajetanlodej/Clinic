﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzychodniaGIT
{
    internal class HourException : Exception
    {
        public HourException() { }
        public HourException(string message) : base(message) { }
    }
}