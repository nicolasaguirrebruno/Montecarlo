using CorrectivoOPreventivo.Helpers.SimulacionMontecarlo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrectivoOPreventivo.Controles
{
    public partial class ControlMantenimientoCorrectivo : UserControl
    {
        public ControlMantenimientoCorrectivo()
        {
            InitializeComponent();
            CargarDGV();
        }
        private void CargarDGV()
        {
            var simulacion = new MantenimientoCorrectivo();

            simulacion.CalcularCorrectivo(Program.dias, Program.desde, Program.hasta, this.dgvCorrectivo);
        }
    }
}
