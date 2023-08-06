using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.Exceptions
{
    class NotNumberException: Exception
    {
        public NotNumberException() :base("Veuillez entrer des index valides (entiers uniquement).") { }
    }
}
