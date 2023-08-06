using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind.Exceptions
{
     class IndexNotExistException :Exception
    {
        public IndexNotExistException() :base("L'index doit etre compris entre 1 et 8 (inclus).") { }
    }
}
