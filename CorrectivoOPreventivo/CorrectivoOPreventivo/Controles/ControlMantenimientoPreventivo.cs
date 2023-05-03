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
    public partial class ControlMantenimientoPreventivo : UserControl
    {
        public ControlMantenimientoPreventivo()
        {
            InitializeComponent();
            CargarDGV();
        }
        public void CargarDGV()
        {
            var simulacion = new MantenimientoPreventivo();

            simulacion.CalcularPreventivo(Program.dias, Program.desde, Program.hasta, this.dgvPreventivo);
        }
       
    }
}
