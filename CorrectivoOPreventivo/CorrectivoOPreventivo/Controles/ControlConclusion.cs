﻿using CorrectivoOPreventivo.Helpers.SimulacionMontecarlo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace CorrectivoOPreventivo.Controles
{
    public partial class ControlConclusion : UserControl
    {
        public static double correctivo = Program.acumCorrectivo;
        public static double preventivo = Program.acumPreventivo;


        public ControlConclusion()
        {
            InitializeComponent();
            CargarConclusion();
        }

        private void CargarConclusion()
        {
            var conclusion = new Conclusion();
            
            conclusion.CalcularMetricas(Program.dias, correctivo, preventivo, this);
        }


    }
}
