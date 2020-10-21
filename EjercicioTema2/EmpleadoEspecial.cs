using System;
namespace ExerTema2
{
    public class EmpleadoEspecial : Empleado, IPastaGansa
    {
        public double BeneficiosEmpresa { set; get; }

        public EmpleadoEspecial(string nombre, string apellido, int edad, string dni, double salario, string tlf)
            : base(nombre, apellido, edad, dni, salario, tlf)
        {
        }

        public EmpleadoEspecial()
            : this("", "", 0, "", 0, "")
        {
        }

        public double ganarPasta(double ingresos)
        {
            BeneficiosEmpresa = ingresos;
            return 0.5 * BeneficiosEmpresa;
        }

        public override double Hacienda()
        {
            return base.Hacienda() + 0.1 * (ganarPasta(BeneficiosEmpresa));
        }

        //Non son necesarias estas funcións porque non mostran máis que os datos dun empleado común. 
        //Hereda a mesma función.
        //public override void introducirDatos()
        //{
        //    base.introducirDatos();
        //}
        //public override void mostrarDatos()
        //{
        //    base.mostrarDatos();
        //}
    }
}

