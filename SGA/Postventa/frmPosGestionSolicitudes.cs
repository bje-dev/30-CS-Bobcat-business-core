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

namespace SGA.Postventa
{
    public partial class frmPosGestionSolicitudes : Form
    {
        public frmPosGestionSolicitudes()
        {
            InitializeComponent();
        }

        private void frmPosGestionSolicitudes_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Traducir();
            label2.Text = label2.Text.Traducir();
            label3.Text = label3.Text.Traducir();
            label4.Text = label4.Text.Traducir();
            label5.Text = label5.Text.Traducir();
            label6.Text = label6.Text.Traducir();
            label7.Text = label7.Text.Traducir();
            label8.Text = label8.Text.Traducir();
            label9.Text = label9.Text.Traducir();
            label11.Text = label11.Text.Traducir();
            label12.Text = label12.Text.Traducir();
            label13.Text = label13.Text.Traducir();
            label14.Text = label14.Text.Traducir();
            label15.Text = label15.Text.Traducir();
            label16.Text = label16.Text.Traducir();
            label17.Text = label17.Text.Traducir();
            label18.Text = label18.Text.Traducir();


            groupBox1.Text = groupBox1.Text.Traducir();
            groupBox2.Text = groupBox2.Text.Traducir();
            groupBox3.Text = groupBox3.Text.Traducir();
            groupBox4.Text = groupBox4.Text.Traducir();
            groupBox5.Text = groupBox5.Text.Traducir();
            groupBox6.Text = groupBox6.Text.Traducir();

            button1.Text = button1.Text.Traducir();
            button2.Text = button2.Text.Traducir();
            

            
        }
    }
}
