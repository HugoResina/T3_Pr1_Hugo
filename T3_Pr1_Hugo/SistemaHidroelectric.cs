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

        private double ComponentGenerador;
        public double GetComponentGenerador()
        {
            return ConfiguracioParametres();
        }
        public SistemaHidroelectric( ) 
        {
            ComponentGenerador = GetComponentGenerador();
           
        }

        public override double CalculEnergia(double ComponentGenerador)
        {
            return ComponentGenerador * 9.8 * 0.8;
        }

        public override double ConfiguracioParametres()
        {
            Console.WriteLine("insereix valor:");
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
                if(!valid) Console.WriteLine("numero massa petit");
            } while (!valid);
            return cabdal;

        }
        public override string ToString()
        {
            string output = string.Format("+--------{0}---------+",Math.Round(CalculEnergia(ComponentGenerador),2));
            return output;
        }
    }
}
