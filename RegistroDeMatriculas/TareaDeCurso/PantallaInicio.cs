using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaDeCurso
{
    public partial class PantallaInicio : Form
    {
        Entrada logeo;



        public PantallaInicio() => InitializeComponent();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        


            private void btnInicio_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text != "") && (txtContraseña.Text != ""))
                
            {
                if ((txtUsuario.Text == "Josthim Hernandez") && (txtContraseña.Text == "1234"))
                {
                    logeo = new Entrada();
                    logeo.Show();
                    this.Hide();
                }

                else if ((txtUsuario.Text == "Owen Espinoza") && (txtContraseña.Text == "4321"))
                {
                    logeo = new Entrada();
                    logeo.Show();
                    this.Hide();
                }

                else if ((txtUsuario.Text == "Eugenio") && (txtContraseña.Text == "9876"))
                {
                    logeo = new Entrada();
                    logeo.Show();
                    this.Hide();
                }
                
            }
        }
    }
}
