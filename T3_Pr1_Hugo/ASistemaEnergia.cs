using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_Pr1_Hugo
{
    public abstract class ASistemaEnergia : ICalculEnergia
    {
        protected double EnergiaGenerada;
        protected string TipusEnergia;

        protected ASistemaEnergia(double EnergiaGenerada, string TipusEnergia) { }
        public abstract double CalculEnergia();

        public abstract void ConfiguracioParametres();
    }
}
