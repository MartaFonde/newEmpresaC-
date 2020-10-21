using System;
namespace ExerTema2
{
    abstract public class Persona
    {
        private int edad;
        private string dni;
        private char[] letraDni = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
        private int numDni;
        private int posicionLetra;

        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public int Edad
        {
            set
            {
                if (value < 0)
                {
                    edad = 0;
                }
                else
                {
                    edad = value;
                }
            }
            get
            {
                return edad;
            }
        }
        public string Dni
        {
            set
            {
                dni = value;
            }
            get
            {
                numDni = Convert.ToInt32(dni);
                posicionLetra = numDni % 23;
                return numDni + "-" + letraDni[posicionLetra];
            }
        }
        public Persona(string nombre, string apellido, int edad, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Dni = dni;
        }
        public Persona() : this("", "", 0, "")
        {
        }

        public virtual void mostrarDatos()
        {
            Console.WriteLine("Nombre: {0}\nApellidos: {1}\nEdad: {2}\nDni: {3}", Nombre, Apellido, Edad, Dni);
        }

        public virtual void introducirDatos()
        {
            Console.Write("Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            Apellido = Console.ReadLine();
            Console.Write("Edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dni: ");
            Dni = Console.ReadLine();
        }

        

        public abstract double Hacienda();
    }

}



