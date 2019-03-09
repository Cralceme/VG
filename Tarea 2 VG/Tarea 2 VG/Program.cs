using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_VG
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplicante objeto = new Aplicante();

            objeto.Registro();

            objeto.Mirar();

            Console.ReadKey();
        }
    }
}
