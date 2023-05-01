using CorrectivoOPreventivo.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectivoOPreventivo.Helpers.SimulacionMontecarlo
{
    internal class Conclusion
    {

        public void CalcularMetricas(double dias, double acumCorrectivo, double acumPreventivo, Control ctrlConclusion)
        {
            int numeroDias = (int)Convert.ToInt64(dias) ;
            EstablecerValorLabel(ctrlConclusion, (acumCorrectivo/numeroDias).ToString(), (acumPreventivo/numeroDias).ToString());

        }

        public void EstablecerValorLabel(Control miControl, string valor, string valor2)
        {
            Label miLabel = miControl.Controls["lblCostoAcumCorrectivo"] as Label;
            miLabel.Text = "$ "+valor;

            Label miLabel2 = miControl.Controls["lblCostoAcumPreventivo"] as Label;
            miLabel2.Text = "$ "+valor2;
        }
    }
}
