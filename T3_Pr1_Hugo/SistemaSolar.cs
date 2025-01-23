using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_Pr1_Hugo
{
    public class SistemaSolar : ASistemaEnergia
    {

        public SistemaSolar(double ComponentGenerador) 
        {
        }

        public override double CalculEnergia(double horesDeSol)
        {
            return horesDeSol * 1.5;
        }

        public override double ConfiguracioParametres()
        {
            throw new NotImplementedException();
        }
    }
}
