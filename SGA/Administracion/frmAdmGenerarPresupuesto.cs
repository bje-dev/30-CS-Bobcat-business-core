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
    public partial class frmAdmGenerarPresupuesto : Form
    {
        public frmAdmGenerarPresupuesto()
        {
            InitializeComponent();
        }

        private void frmAdmGenerarPresupuesto_Load(object sender, EventArgs e)
        {
            button1.Text = button1.Text.Traducir();
            button2.Text = button2.Text.Traducir();
            

            groupBox1.Text = groupBox1.Text.Traducir();
            groupBox2.Text = groupBox2.Text.Traducir();
            groupBox3.Text = groupBox3.Text.Traducir();
            

            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            label4.Text = label4.Text.Traducir();
            label5.Text = label5.Text.Traducir();
            label6.Text = label6.Text.Traducir();
            label7.Text = label7.Text.Traducir();
            label9.Text = label9.Text.Traducir();

            checkBox1.Text = checkBox1.Text.Traducir();
            checkBox2.Text = checkBox2.Text.Traducir();
            
            
        }
    }
}
