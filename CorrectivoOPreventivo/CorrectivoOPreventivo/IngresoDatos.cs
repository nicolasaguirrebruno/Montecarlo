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
            // Todo este metodo deberia desaparecer porque en un principio yo entendi que el mandar rangos era opcional pero despues en la presentacion del tp2 el profe nos dijo que siempre vas a tener que mandar un rango
            // Por  tanto esto no deberia estar y deberia sacarse el check. Lo que si faltan las validaciones.
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

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //                           AGREGAR VALIDACIONES !!!!!!!!                                     //
            /////////////////////////////////////////////////////////////////////////////////////////////////


            if (chkMostrar.Checked)
            {
                // Seteo como variable del programa para de esa forma no tener que andar mandando pantalla a pantalla, es mas eficiente y genera menos dependencias entre ventanas
                Program.desde = Double.Parse(inputDesde.Text);
                Program.hasta = Double.Parse(inputHasta.Text);

                mostrar = true;
            }

            // Seteo como variable del programa para de esa forma no tener que andar mandando pantalla a pantalla, es mas eficiente y genera menos dependencias entre ventanas
            Program.dias = Double.Parse(inputCantDias.Text);
            Program.mostrar = mostrar;

            // Llamo a la ventana de la simulacion
            var montecarlo = new Montecarlo();
            montecarlo.Show();
            this.Hide();
        }


    }
}
