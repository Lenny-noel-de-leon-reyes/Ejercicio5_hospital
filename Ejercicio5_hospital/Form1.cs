using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5_hospital
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            
            InitializeComponent();
            lblResultadoAdministracion.Visible = false;
            lblResultadoEmergencia.Visible = false;
            lblResultadoImagenes.Visible = false;
            lblResultadoLaboratorio.Visible = false;
            lblResultadoSuministros.Visible = false;
            lbl_presupuesto2.Visible = false;
            lbl_resultadoCirugia.Visible = false;
            lbl_asignacion.Visible = false;
        }

        private void btn_repartir_Click(object sender, EventArgs e)
        {
            double Presupuesto, Emergencia, Cirugia, Suministros, Administracion, Laboratorio, ImagenesDiagnosticas;

            Presupuesto = int.Parse(txt_presupuesto.Text);

            lblResultadoAdministracion.Visible = true;
            lblResultadoEmergencia.Visible = true;
            lblResultadoImagenes.Visible = true;
            lblResultadoLaboratorio.Visible = true;
            lblResultadoSuministros.Visible = true;
            lbl_presupuesto2.Visible = true;
            lbl_resultadoCirugia.Visible = true;
            lbl_asignacion.Visible = true;


            Emergencia = Presupuesto * 0.30;
            Cirugia = Presupuesto * 0.15;
            Suministros = Presupuesto * 0.25;
            Administracion = Presupuesto * 0.18;
            Laboratorio = Presupuesto * 0.05;
            ImagenesDiagnosticas = Presupuesto * 0.07;


            lbl_presupuesto2.Text = Presupuesto.ToString();
            lblResultadoEmergencia.Text = Emergencia.ToString();
            lbl_resultadoCirugia.Text = Cirugia.ToString();
            lblResultadoSuministros.Text = Suministros.ToString();
            lblResultadoAdministracion.Text = Administracion.ToString();
            lblResultadoLaboratorio.Text = Laboratorio.ToString();
            lblResultadoImagenes.Text = ImagenesDiagnosticas.ToString();
        }

        private void lbl_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_limpiar_Click(object sender, EventArgs e)
        {
            txt_presupuesto.Clear();
            txt_presupuesto.Focus();
            lblResultadoEmergencia.Text = String.Empty;
            lbl_resultadoCirugia.Text = String.Empty;
            lblResultadoImagenes.Text = String.Empty;
            lblResultadoAdministracion.Text = String.Empty;
            lbl_presupuesto2.Text = String.Empty;
            lblResultadoLaboratorio.Text = String.Empty;
            lblResultadoSuministros.Text = String.Empty;
            lbl_asignacion.Visible = false;
        }
    }
}
