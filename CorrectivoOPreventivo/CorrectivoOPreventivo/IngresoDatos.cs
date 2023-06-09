﻿using CorrectivoOPreventivo.Controles;
using CorrectivoOPreventivo.Helpers.Constantes;
using CorrectivoOPreventivo.Helpers.Enums;
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
        private Control correctivo;
        private Control preventivo;
        private Control conclusion;
        private int controlSeleccionado;

        public IngresoDatos()
        {
            InitializeComponent();
          
        }
        
        private void btnInitializeSimulation_Click_1(object sender, EventArgs e)
        {
            if (ValidarInputs())
            {
                ReiniciarContadores();
                CargarValores();
                btnConclusion.Enabled = true;
                btnPreventivo.Enabled = true;
                btnCorrectivo.Enabled = true;
            }
           
        }

        private void ReiniciarContadores()
        {
            
            Program.acumCorrectivo = 0;
            Program.acumPreventivo = 0;

            Program.DiasPerdidosCorrectivoMC = 0;
            Program.DiasPerdidosCorrectivoMP = 0;

            Program.DiasPerdidosMantenimiento = 0;
            
        }

        private bool ValidarInputs()
        {
            // valida que todo lo ingresado no este vacio
            bool validez = true;
            if (!ValidarCantDias())
                validez = false;
            if (!ValidarDesde())
                validez = false;
            if (!ValidarHasta())
                validez = false;
          

            if (!validez)
                this.lblErrorSimulacion.Visible = true;
            else
                this.lblErrorSimulacion.Visible = false;
            return validez;
        }

        private void CargarValores()
        {
            //carga los valores ingresados en los inputs en program
            // es mas eficiente y genera menos dependencias entre ventanas
            Program.desde = Double.Parse(inputDesde.Text);
            Program.hasta = Double.Parse(inputHasta.Text);

            mostrar = true;


            // Seteo como variable del programa para de esa forma no tener que andar mandando pantalla a pantalla, es mas eficiente y genera menos dependencias entre ventanas
            Program.dias = Double.Parse(inputCantDias.Text);
            Program.mostrar = mostrar;
            this.preventivo = new ControlMantenimientoPreventivo();
            this.preventivo.Dock = DockStyle.Fill;
            this.correctivo = new ControlMantenimientoCorrectivo();
            this.correctivo.Dock = DockStyle.Fill;
            this.conclusion = new ControlConclusion();
            this.conclusion.Dock = DockStyle.Fill;
            //generamos la simulacion
            CargarSimulacion();
        }

        private void CargarSimulacion()
        {
            this.pnSimulacion.Controls.Clear();

            if (controlSeleccionado == (int)Mantenimientos.correctivo)
            {
                
                this.pnSimulacion.Controls.Add(this.correctivo);
                
            }
            else if(controlSeleccionado == (int)Mantenimientos.preventivo)
            {
                this.pnSimulacion.Controls.Add(this.preventivo);

            }
            else if(controlSeleccionado == (int)Mantenimientos.conclusion)
            {
                this.pnSimulacion.Controls.Add(this.conclusion);
            }
          
        }

        private void btnCorrectivo_Click(object sender, EventArgs e)
        {
            this.controlSeleccionado = (int)Mantenimientos.correctivo;
            this.btnCorrectivo.BackColor = Colores.SELECCIONADO;
            this.btnCorrectivo.ForeColor = Color.Coral;
            this.btnPreventivo.BackColor = Colores.NO_SELECCIONADO;
            this.btnPreventivo.ForeColor = Color.PeachPuff;
            this.btnConclusion.BackColor = Colores.NO_SELECCIONADO;
            this.btnConclusion.ForeColor = Color.PeachPuff;
            this.CargarSimulacion();
        }

        private void btnPreventivo_Click(object sender, EventArgs e)
        {
            this.controlSeleccionado = (int)Mantenimientos.preventivo;
            this.btnCorrectivo.BackColor = Colores.NO_SELECCIONADO;
            this.btnCorrectivo.ForeColor = Color.PeachPuff;
            this.btnPreventivo.BackColor = Colores.SELECCIONADO;
            this.btnPreventivo.ForeColor = Color.Coral;
            this.btnConclusion.BackColor = Colores.NO_SELECCIONADO;
            this.btnConclusion.ForeColor = Color.PeachPuff;
            this.CargarSimulacion();
        }

        private void btnConclusion_Click(object sender, EventArgs e)
        {
            this.controlSeleccionado = (int)Mantenimientos.conclusion;
            this.btnCorrectivo.BackColor = Colores.NO_SELECCIONADO;
            this.btnCorrectivo.ForeColor = Color.PeachPuff;
            this.btnPreventivo.BackColor = Colores.NO_SELECCIONADO;
            this.btnPreventivo.ForeColor = Color.PeachPuff;
            this.btnConclusion.BackColor = Colores.SELECCIONADO;
            this.btnConclusion.ForeColor = Color.Coral;
            this.CargarSimulacion();
        }
        
        private void AceptarSoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void inputCantDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            AceptarSoloNumeros(e);
        }

        private void inputDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            AceptarSoloNumeros(e);
        }

        private void inputHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            AceptarSoloNumeros(e);
        }

        private void IngresoDatos_Load(object sender, EventArgs e)
        {
            //volvemos invisible todo los mensajes de error
            this.lblErrorCantDias.Visible = false;
            this.lblErrorDesde.Visible = false;
            this.lblErrorHasta.Visible =false;
            this.lblErrorSimulacion.Visible = false;
            //Seleccionamos por defecto que se muestre el mantenimiento correctivo
            this.controlSeleccionado = (int)Mantenimientos.correctivo;
            this.btnCorrectivo.BackColor = Colores.SELECCIONADO;
            this.btnCorrectivo.ForeColor = Color.Coral;
        }

        private void inputCantDias_TextChanged(object sender, EventArgs e)
        {
            ValidarCantDias();
        }
        private bool ValidarCantDias()
        {
            if (inputCantDias.Text == "")
            {
                this.lblErrorCantDias.Visible = true;
                //si se modifico en algun momento el inpuDesde
                //se calida que su contenido siga teniendo sentido
                if (inputDesde.Modified)
                {
                    ValidarDesde();
                }


                return false;
            }
            this.lblErrorCantDias.Visible = false;
            //si se modifico en algun momento el inpuDesde
            //se calida que su contenido siga teniendo sentido
            if (inputDesde.Modified)
            {
                ValidarDesde();
            }
            return true;
        }

        private void inputDesde_TextChanged(object sender, EventArgs e)
        {
            ValidarDesde();

        }
        private bool ValidarDesde()
        {
            if (inputDesde.Text == "")
            {
                this.lblErrorDesde.Visible = true;
                return false;
            }
            try
            {
                if (Convert.ToInt64(inputDesde.Text) >= Convert.ToInt64(inputCantDias.Text))
                {
                    this.lblErrorDesde.Visible = true;
                    this.lblErrorDesde.Text = "El valor debe ser menor a la cantidad de dias";
                    return false;
                }
            }
            catch (Exception)
            {
                this.lblErrorDesde.Visible = true;
                this.lblErrorDesde.Text = "El valor debe ser menor a la cantidad de dias";
                return false;
            }
            this.lblErrorDesde.Visible = false;
            return true;

        }

        private void inputHasta_TextChanged(object sender, EventArgs e)
        {
            ValidarHasta();
        }

        private bool ValidarHasta()
        {

            if (inputHasta.Text == "")
            {
                this.lblErrorHasta.Visible = true;
                this.lblErrorHasta.Text = "Este Valor no puede estar vacio";
                return false;
            }
            try
            {
                if (Convert.ToInt64(inputHasta.Text) <= Convert.ToInt64(inputDesde.Text))
                {
                    this.lblErrorHasta.Visible = true;
                    this.lblErrorHasta.Text = "Este Valor debe ser mayor al Desde";
                    return false;
                }
            }
            catch (Exception)
            {
                this.lblErrorHasta.Visible = true;
                this.lblErrorHasta.Text = "Este Valor debe ser mayor al Desde";
                return false;

            }
            lblErrorHasta.Visible = false;
            return true;
        }
    }
}
