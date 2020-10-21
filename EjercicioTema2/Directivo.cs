using System;
namespace ExerTema2
{

    public class Directivo : Persona, IPastaGansa
    {
        private double beneficiosEmpresa;
        public string Depart { set; get; }
        public double Beneficios { set; get; }
        private int numPersonasACargo;

        public int NumPersonasACargo
        {
            set
            {
                numPersonasACargo = value;
                if (value <= 10)
                {
                    Beneficios = 2;
                }
                else if (value <= 50)
                {
                    Beneficios = 3.5;
                }
                else
                {
                    Beneficios = 4;
                }
            }
            get
            {
                return numPersonasACargo;
            }
        }
        public Directivo(string nombre, string apellido, int edad, string dni, string depart, int numPersACargo)
            : base(nombre, apellido, edad, dni)
        {
            Depart = depart;
            NumPersonasACargo = numPersACargo;
        }

        public Directivo() : this("", "", 0, "", "", 0)
        {
        }

        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.WriteLine("Departamento: {0}\nBeneficios: {1}%\nNúmero personas a cargo: {2}\n"
                , Depart, Beneficios, NumPersonasACargo);
        }

        public override void introducirDatos()
        {
            base.introducirDatos();
            Console.Write("Departamento: ");
            Depart = Console.ReadLine();
            Console.Write("Número de personas a cargo: ");
            NumPersonasACargo = Convert.ToInt32(Console.ReadLine());
        }

        public static Directivo operator --(Directivo d)
        {
            if (d.Beneficios >= 0)
            {
                d.Beneficios = d.Beneficios - 1;
                return d;
            }
            else
            {
                return d;
            }
        }

        public override double Hacienda()
        {
            return 0.3 * ganarPasta(beneficiosEmpresa);
        }

        public double ganarPasta(double ingresos)
        {
            beneficiosEmpresa = ingresos;

            if (ingresos >= 0)
            {
                return Beneficios / 100 * ingresos;
            }
            else
            {
                Directivo d = this;     // new Directivo(Nombre, Apellido, Edad, Dni, Depart, NumPersonasACargo); NOOO  ---- > CREAR REFERENCIA!!! Modificase o que modifiquemos en d
                d--;    
                return 0;

            }
        }
    }
}
