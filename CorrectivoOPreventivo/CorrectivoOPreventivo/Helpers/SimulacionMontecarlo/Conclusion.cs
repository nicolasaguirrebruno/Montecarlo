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
        private int numeroDias;
        public void CalcularMetricas(double dias, double acumCorrectivo, double acumPreventivo, ControlConclusion ctrlConclusion)
        {
            this.numeroDias = (int)Convert.ToInt64(dias) ;
            EstablecerValorLabel(ctrlConclusion, (Math.Truncate(acumCorrectivo / numeroDias * 100) /100).ToString(), (Math.Truncate(acumPreventivo / numeroDias * 100) / 100).ToString()) ; ;

        }

        public void EstablecerValorLabel(ControlConclusion miControl, string valor, string valor2)
        {
            Label miLabel = miControl.Controls["lblCostoAcumCorrectivo"] as Label;
            miLabel.Text = "$ " + valor;

            Label miLabel2 = miControl.Controls["lblCostoAcumPreventivo"] as Label;
            miLabel2.Text = "$ " + valor2;

            Label miLabel3 = miControl.Controls["lblEstrategia"] as Label;
            if(Double.Parse(valor) > Double.Parse(valor2))
            {
                miLabel3.Text = "Es conveniente optar por la estrategia de Mantenimiento Preventivo, ya que provee un menor costo promedio diario a comparación al Mantenimiento Correctivo";
            }
            else
            {
                miLabel3.Text = "Es conveniente optar por la estrategia de Mantenimiento Correctivo, ya que provee un menor costo promedio diario a comparación al Mantenimiento Preventivo";
            }

            miControl.lblHorasMC.Text = (Convert.ToInt64(Program.DiasPerdidosCorrectivoMC) * 16).ToString() + "Hs";
            miControl.lblHorasMP.Text = (Convert.ToInt64(Program.DiasPerdidosCorrectivoMP) * 16).ToString() + "Hs";
            miControl.lblDiasReparacionesMP.Text = ((Double)Math.Truncate((Convert.ToDouble(Program.DiasPerdidosCorrectivoMP) *100 / numeroDias)*10_000)/10_000).ToString() +"%";
            miControl.lblDiasReparacionesMC.Text = ((Double)Math.Truncate((Convert.ToDouble(Program.DiasPerdidosCorrectivoMC) *100/ numeroDias) * 10_000)/ 10_000).ToString() + "%";
            miControl.lblDiasPreventivo.Text = ((Double)Math.Truncate((Convert.ToDouble(Program.DiasPerdidosMantenimiento) *100/ numeroDias) * 10_000) / 10_000).ToString() +"%";
        }
    }
}
