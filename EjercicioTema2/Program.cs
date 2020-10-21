using System;

namespace ExerTema2
{
    class Program
    {
        public static void beneficiosEmpresa(IPastaGansa e)   //con parametro e podemos pasar calquera obxecto que implemente a interfaz
        {
            Console.Write("Beneficios de la empresa: ");
            double beneficiosEmpresa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Beneficios añadidos: " + e.ganarPasta(beneficiosEmpresa));
        }
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Christopher", "Moltisanti", 38, "76809862", 1200, "698564898");
            EmpleadoEspecial empleadoEspecial = new EmpleadoEspecial("Silvio", "Dante", 58, "44093131", 1800, "657256985");
            Directivo directivo = new Directivo("Tony", "Soprano", 54, "89625985", "Gestión de residuos", 56);
            int opcion;
            do
            {
                Console.WriteLine("1. Visualizar datos del empleado");
                Console.WriteLine("2. Visualizar datos del empleado especial");
                Console.WriteLine("3. Visualizar datos del directivo");
                Console.WriteLine("4. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        empleado.mostrarDatos();
                        Console.WriteLine("Paga a hacienda: "+empleado.Hacienda());
                        Console.WriteLine();
                        break;
                    case 2:
                        empleadoEspecial.mostrarDatos();
                        beneficiosEmpresa(empleadoEspecial);
                        Console.WriteLine("Paga a hacienda: " + empleadoEspecial.Hacienda());
                        Console.WriteLine();
                        break;
                    case 3:
                        directivo.mostrarDatos();
                        beneficiosEmpresa(directivo);
                        Console.WriteLine("Paga a hacienda: " + directivo.Hacienda());
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

            } while (opcion != 4);




            //Empleado e = new Empleado("Marta", "Fondevila", 24, "76809862", 3000, "7676");
            //Console.WriteLine(e.Nombre);
            //e.mostrarDatos();
            //Console.WriteLine(e.Hacienda());
            //Directivo dir = new Directivo("marta", "fonde", 24, "44093131", "prog", 5, 1000);
            //dir--;
            //dir.beneficiosEmpresa = -10;
            //dir.ganarPasta(dir.beneficiosEmpresa);
            //Console.WriteLine(dir.Beneficios);
            //Console.WriteLine(dir.ganarPasta(-10));
            //Console.WriteLine(dir.Beneficios);

            //Console.WriteLine("Hacienda:" +dir.Hacienda());

        }
    }
}
