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

namespace SGA.Administracion
{
    public partial class frmAdmGenerarFactura : Form
    {
        public frmAdmGenerarFactura()
        {
            InitializeComponent();
        }

        private void frmAdmGenerarFactura_Load(object sender, EventArgs e)
        {
            button1.Text = button1.Text.Traducir();
            button2.Text = button2.Text.Traducir();
            button3.Text = button3.Text.Traducir();
            button4.Text = button4.Text.Traducir();
            button5.Text = button5.Text.Traducir();
            button6.Text = button6.Text.Traducir();

            groupBox1.Text = groupBox1.Text.Traducir();
            groupBox2.Text = groupBox2.Text.Traducir();
            groupBox3.Text = groupBox3.Text.Traducir();
            groupBox4.Text = groupBox4.Text.Traducir();

            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            label4.Text = label4.Text.Traducir();
            label6.Text = label6.Text.Traducir();
            label7.Text = label7.Text.Traducir();
            label9.Text = label9.Text.Traducir();

        }
    }
}
