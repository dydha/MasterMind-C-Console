﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.Exceptions
{
    class NullInputException : Exception
    {
        public NullInputException() : base("Veuillez entrer les index des couleurs.")
        {
        
        }
    }
}
