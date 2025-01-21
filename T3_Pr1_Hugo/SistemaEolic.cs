using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_Pr1_Hugo
{
    internal class SistemaEolic : ASistemaEnergia
    {
        public SistemaEolic(double EnergiaGenerada, string TipusEnergia) : base(EnergiaGenerada, TipusEnergia)
        {

        }

        public override double CalculEnergia()
        {
            throw new NotImplementedException();
        }

        public override void ConfiguracioParametres()
        {
            throw new NotImplementedException();
        }
    }
}
