using Microsoft.VisualBasic.Logging;
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
    public partial class Entrada : Form
    {
        Registro avanzar;
        public Entrada()
        {
            InitializeComponent();
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            avanzar = new Registro();
            avanzar.Show();
            this.Hide();
        }
    }
}
