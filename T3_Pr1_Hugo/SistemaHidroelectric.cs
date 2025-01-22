using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_Pr1_Hugo
{
    internal class SistemaHidroelectric : ASistemaEnergia
    {
        public SistemaHidroelectric(double EnergiaGenerada, double ComponentGenerador) : base(EnergiaGenerada, ComponentGenerador)
        {
        }

        public override double CalculEnergia(double a)
        {
            throw new NotImplementedException();
        }

        public override void ConfiguracioParametres()
        {
            throw new NotImplementedException();
        }
    }
}
