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
    public partial class frmCliCancelarSolicitud : Form
    {
        public frmCliCancelarSolicitud()
        {
            InitializeComponent();
        }

        private void frmCliCancelarSolicitud_Load(object sender, EventArgs e)
        {
            
            groupBox1.Text = groupBox1.Text.Traducir();
            button1.Text = button1.Text.Traducir();
            button2.Text = button2.Text.Traducir();
        }
    }
}
