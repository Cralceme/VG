using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_VG
{
    class Aplicante
    {

        private string nombres;
        private string apellidos;
        private string puesto;
        private int lvlingles;
        private int diadis;
        private int horadis;



        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }

        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Puestos
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public int LVlingles
        {
            get { return lvlingles; }
            set { lvlingles = value; }
        }

        public int DiasDisponibles
        {
            get { return diadis; }
            set { diadis = value; }
        }

        public int Horasdisp
        {
            get { return horadis; }
            set { horadis = value; }

        }

        public void Registro()
        {
            Console.WriteLine("Ingrese el total de aplicantes");
            int total_aplicantes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < total_aplicantes; i++)
            {
                Console.WriteLine("Cual es el nombre del aplicantes");
                Nombres = Console.ReadLine();

                Console.WriteLine("Apellido del aplicante");
                Apellidos = Console.ReadLine();

                Console.WriteLine("Puesto deseado del aplicante");
                Puestos = Console.ReadLine();

                Console.WriteLine("Porcentaje de nivel de ingles");
                LVlingles = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("dias a la semana disponible");
                DiasDisponibles = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Horas disponibles durante el dia");
                Horasdisp = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Ingrese el siguiente");
            }

            Console.Clear();

        }

        public void Mirar()
        {
            Console.WriteLine(Nombres +" "+ Apellidos);
            Console.WriteLine(Puestos);
            Console.WriteLine("Nivel de ingles: "+ LVlingles);
            Console.WriteLine("Dias disponibles: "+DiasDisponibles);
            Console.WriteLine("Horas al dia disponibles: "+Horasdisp);

            Console.ReadKey();

        }




    }

}
