using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioBase4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSaludo_Click(object sender, EventArgs e)
        {
            labelsaludo.Text = "buenas tardes";
        }

        private void buttoncargo_Click(object sender, EventArgs e)
        {
            labelcargo.Text = "ingeniera";
        }

        private void buttonNombre_Click(object sender, EventArgs e)
        {
            labelNombre.Text = "luci";
        }

        private void buttonPaterno_Click(object sender, EventArgs e)
        {
            labelPaterno.Text = "caamal";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelMaterno.Text = "Canul";
        }
    }
}
