using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SL.Services.Extensions;

namespace SGA.Cliente
{
    public partial class frmCliGenerarSolicitud : Form
    {
        public frmCliGenerarSolicitud()
        {
            InitializeComponent();
        }

        private void frmCliGenerarSolicitud_Load(object sender, EventArgs e)
        {
            
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            label4.Text = label4.Text.Traducir();
            groupBox1.Text= groupBox1.Text.Traducir();
            button1.Text = button1.Text.Traducir();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
