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

namespace SGA.Cliente
{
    public partial class frmCliRevisionPresupuesto : Form
    {
        public frmCliRevisionPresupuesto()
        {
            InitializeComponent();
        }

        private void frmCliRevisionPresupuesto_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            label4.Text = label4.Text.Traducir();
            label5.Text = label5.Text.Traducir();
            label5.Text = label6.Text.Traducir();
            label6.Text = label6.Text.Traducir();

            groupBox1.Text = groupBox1.Text.Traducir();
            groupBox2.Text = groupBox2.Text.Traducir();
            groupBox3.Text = groupBox3.Text.Traducir();

            button1.Text = button1.Text.Traducir();
            button2.Text = button2.Text.Traducir();
            button3.Text = button3.Text.Traducir();
            button4.Text = button4.Text.Traducir();

            checkBox1.Text = checkBox1.Text.Traducir();
            checkBox2.Text = checkBox2.Text.Traducir();

        }
    
    }
}
