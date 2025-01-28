using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_Pr1_Hugo
{

    public class SistemaEolic : ASistemaEnergia
    {
        const double MinComponent = 5d;
        const string ErrorMsg = "error, la velocitat del vent ha de ser un numero";
        const string InputMsg = "insereix valor de la velocitat del vent:";
        const string TooSmallMsg = "numero massa petit";

        private double ComponentGenerador;
        public DateTime DataCreacio;
        public string tipus;

        public double GetComponentGenerador()
        {
            return ConfiguracioParametres();
        }

        public SistemaEolic() 
        {
            ComponentGenerador = GetComponentGenerador();
            DataCreacio = DateTime.Today;
            tipus = "Eolic";
        }

        public override double CalculEnergia(double velocitatVent)
        {
           return Math.Pow(velocitatVent, 3) * 0.2;
        }

        public override double ConfiguracioParametres()
        {
            Console.WriteLine(InputMsg);
            double velocitat = 0d;
            bool valid = false;
            do
            {
                try
                {
                    velocitat = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine(ErrorMsg, MinComponent);
                }
                valid = velocitat >= MinComponent;
                if (!valid) Console.WriteLine(TooSmallMsg);
            } while (!valid);
            return velocitat;
        }
        public override string ToString()
        {
            return $"{tipus,-20} {DataCreacio:dd/MM/yyyy,-20} {Math.Round(CalculEnergia(ComponentGenerador), 2),+11}";
        }
    }
}
