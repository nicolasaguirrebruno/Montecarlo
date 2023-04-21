using CorrectivoOPreventivo.Helpers.SimulacionMontecarlo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrectivoOPreventivo
{
    public partial class Montecarlo : Form
    {
        double cant = Program.dias;
        double desde;
        double hasta;
        public Montecarlo()
        {
            InitializeComponent();


            if (Program.mostrar)
            {

                desde = Program.desde;
                hasta = Program.hasta;
            }

            SimulacionCorrectiva();

            SimulacionPreventiva();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCorrectivo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SimulacionCorrectiva()
        {

            var simulacion = new MantenimientoCorrectivo();

            simulacion.CalcularCorrectivo(cant, desde, hasta, dgvCorrectivo);


        }

        private void SimulacionPreventiva()
        {

            var simulacion = new MantenimientoPreventivo();

            simulacion.CalcularPreventivo(cant, desde, hasta, dgvPreventivo);


        }

        private void dgvPreventivo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
