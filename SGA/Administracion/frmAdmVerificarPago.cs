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
using SL.Services.Extensions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SGA.Administracion
{
    public partial class frmAdmVerificarPago : Form
    {
        public frmAdmVerificarPago()
        {
            InitializeComponent();
        }

        private void frmAdmVerificarPago_Load(object sender, EventArgs e)
        {
            button1.Text = button1.Text.Traducir();
            button2.Text = button2.Text.Traducir();
            button3.Text = button3.Text.Traducir();
            button4.Text = button4.Text.Traducir();

            groupBox4.Text = groupBox4.Text.Traducir();
            
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            
        }
    }
}
