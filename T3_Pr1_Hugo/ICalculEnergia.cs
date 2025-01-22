using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_Pr1_Hugo
{
    internal interface ICalculEnergia
    {
        double CalculEnergia(double ComponentGenerador);
        void ConfiguracioParametres();
    }
}
