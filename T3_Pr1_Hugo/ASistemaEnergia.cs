using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_Pr1_Hugo
{
    public abstract class ASistemaEnergia : ICalculEnergia
    {
        
        protected double ComponentGenerador;
        protected DateTime DataCreacio;

        
        public abstract double CalculEnergia(double ComponentGenerador);

        public abstract double ConfiguracioParametres();
    }
}
