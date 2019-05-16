using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivo3.Clases
{

    class NombreInvalidoException : Exception
    {
        public const string Mensaje = "Nombre/Apellido no valido.";
        public NombreInvalidoException() { }
        public NombreInvalidoException(string message) : base(message)
        {
        }
        public NombreInvalidoException(string message, Exception inner) : base(message, inner) { }
    }

}
