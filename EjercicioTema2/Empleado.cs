using System;
namespace ExerTema2
{
    public class Empleado : Persona
    {
        private double salario;
        private string numTlf;
        private double Irpf;
        public double Salario
        {
            set
            {
                salario = value;
                if (salario < 600)
                {
                    Irpf = 7;
                }
                else if (salario <= 3000)
                {
                    Irpf = 15;
                }
                else
                {
                    Irpf = 20;
                }
            }
            get
            {
                return salario;
            }
        }
        public string NumTlf
        {
            set
            {
                numTlf = value;
            }
            get
            {
                return "+34" + numTlf;
            }
        }

        public Empleado(string nombre, string apellido, int edad, string dni, double salario, string numTlf)
            : base(nombre, apellido, edad, dni)
        {
            Salario = salario;
            NumTlf = numTlf;
        }

        public Empleado() : this("", "", 0, "", 0, "")
        {
        }


        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.WriteLine("Salario: {0}\nNúmero tlf: {1}", Salario, NumTlf);
        }

        public void mostrarDatos(int indice)
        {
            switch (indice)
            {
                case 0:
                    Console.WriteLine("Nombre: " + Nombre);
                    break;
                case 1:
                    Console.WriteLine("Apellido: " + Apellido);
                    break;
                case 2:
                    Console.WriteLine("Edad: " + Edad);
                    break;
                case 3:
                    Console.WriteLine("Dni: " + Dni);
                    break;
                case 4:
                    Console.WriteLine("Salario: " + Salario);
                    break;
                case 5:
                    Console.WriteLine("Número tlf: " + NumTlf);
                    break;
                default:
                    Console.WriteLine("Dato incorrecto");
                    break;
            }
        }

        public override double Hacienda()
        {
            return (Irpf * Salario) / 100;
        }
    }
}



