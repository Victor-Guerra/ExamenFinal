using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reactivo3.Clases;


namespace Reactivo3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            try
            {

                    Console.WriteLine("De su nombre:");
                    nombre = Console.ReadLine().Trim(new char[] { '\n', '\r' });

                    Console.WriteLine("De su apellido:");
                    apellido = Console.ReadLine().Trim(new char[] { '\n', '\r' });

                    if (apellido.Length <= 2 || nombre.Length <= 2)
                    {
                        throw new NombreInvalidoException();
                    }
            }
            catch (NombreInvalidoException)
            {
                Console.WriteLine(NombreInvalidoException.Mensaje);
            }
        }
    }
}
