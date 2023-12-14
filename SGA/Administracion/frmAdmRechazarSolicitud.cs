using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SL.Services.Extensions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SGA.Administracion
{
    public partial class frmAdmRechazarSolicitud : Form
    {
        public frmAdmRechazarSolicitud()
        {
            InitializeComponent();
        }

        private void frmAdmRechazarSolicitud_Load(object sender, EventArgs e)
        {
            button1.Text = button1.Text.Traducir();
            button2.Text = button2.Text.Traducir();

            groupBox1.Text = groupBox1.Text.Traducir();
            
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
        }
    }
}
