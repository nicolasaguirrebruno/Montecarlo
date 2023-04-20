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
    public partial class IngresoDatos : Form
    {

        private Boolean mostrar = false;

        public IngresoDatos()
        {
            InitializeComponent();
        }

        private void changeEnabled(Boolean condition)
        {

            lblDesde.Enabled = condition;
            lblHasta.Enabled = condition;
            inputDesde.Enabled = condition;
            inputHasta.Enabled = condition;

            if (!condition)
            {

                inputDesde.Text = "";
                inputHasta.Text = "";

            }
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            changeEnabled(chkMostrar.Checked);


        }


        private void btnInitializeSimulation_Click(object sender, EventArgs e)
        {

            if (chkMostrar.Checked)
            {

                Program.desde = Double.Parse(inputDesde.Text);
                Program.hasta = Double.Parse(inputHasta.Text);

                mostrar = true;
            }

            Program.dias = Double.Parse(inputCantDias.Text);
            Program.mostrar = mostrar;

            var montecarlo = new Montecarlo();
            montecarlo.Show();
            this.Hide();
        }


    }
}
