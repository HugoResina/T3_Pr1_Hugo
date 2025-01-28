using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_Pr1_Hugo
{
    public class SistemaSolar : ASistemaEnergia
    {
        const double MinComponent = 1d;
        const string ErrorMsg = "error, les hores de sol han de ser un numero";
        const string InputMsg = "insereix valor de les hores de sol:";
        const string TooSmallMsg = "numero massa petit";

        private double ComponentGenerador;
        public DateTime DataCreacio;
        public string tipus;

        public double GetComponentGenerador()
        {
            return ConfiguracioParametres();
        }
        public SistemaSolar() 
        {
            ComponentGenerador = GetComponentGenerador();
            DataCreacio = DateTime.Today;
            tipus = "Solar";
        }

        public override double CalculEnergia(double horesDeSol)
        {
            return horesDeSol * 1.5;
        }

        public override double ConfiguracioParametres()
        {
            Console.WriteLine(InputMsg);
            double hores = 0d;
            bool valid = false;
            do
            {
                try
                {
                    hores = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine(ErrorMsg, MinComponent);
                }
                valid = hores >= MinComponent;
                if (!valid) Console.WriteLine(TooSmallMsg);
            } while (!valid);
            return hores;
        }
        public override string ToString()
        {
            return $"{tipus,-20} {DataCreacio:dd/MM/yyyy,-20} {Math.Round(CalculEnergia(ComponentGenerador), 2),+11}";
        }
    }
}
