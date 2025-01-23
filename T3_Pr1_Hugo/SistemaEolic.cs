using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_Pr1_Hugo
{
    internal class SistemaEolic : ASistemaEnergia
    {
        

        public SistemaEolic(double ComponentGenerador) 
        {
            
        }

        public override double CalculEnergia(double velocitatVent)
        {
           return Math.Pow(velocitatVent, 3) * 0.2;
        }

        public override double ConfiguracioParametres()
        {
            throw new NotImplementedException();
        }
    }
}
