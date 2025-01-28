using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_Pr1_Hugo
{
    internal class SistemaHidroelectric : ASistemaEnergia
    {
        const double MinComponent = 20d;
        const string ErrorMsg = "error, el cabdal ha de ser un numero";
        const string InputMsg = "insereix valor del cabdal:";
        const string TooSmallMsg = "numero massa petit";


        private double ComponentGenerador;
        public DateTime DataCreacio;
        public string tipus;
        public double GetComponentGenerador()
        {
            return ConfiguracioParametres();
        }
        public SistemaHidroelectric( ) 
        {
            ComponentGenerador = GetComponentGenerador();
            DataCreacio = DateTime.Today;
            tipus = "Hidroelectric";
           
        }

        public override double CalculEnergia(double ComponentGenerador)
        {
            return ComponentGenerador * 9.8 * 0.8;
        }

        public override double ConfiguracioParametres()
        {
            Console.WriteLine(InputMsg);
            double cabdal = 0d;
            bool valid = false;
            do
            {
                try
                {
                    cabdal = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine(ErrorMsg, MinComponent);
                }
                valid = cabdal >= MinComponent;
                if(!valid) Console.WriteLine(TooSmallMsg);
            } while (!valid);
            return cabdal;

        }
        public override string ToString()
        {
            return $"{tipus,-20} {DataCreacio:dd/MM/yyyy,-20} {Math.Round(CalculEnergia(ComponentGenerador), 2),+11}";
        }
    }
}
