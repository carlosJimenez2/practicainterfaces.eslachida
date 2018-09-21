using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaccion t1 = new Transaccion("0001", "20/09/18", 5000);
            Transaccion t2 = new Transaccion("0002", "21/09/18", 2500);

            t1.muestraTransacciones();
            t2.muestraTransacciones();
            Console.ReadLine();

        }
    }
}
