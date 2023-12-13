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
    public partial class frmCliMenu : Form
    {
        public frmCliMenu()
        {
            InitializeComponent();
        }

        private void frmCliMenu_Load(object sender, EventArgs e)
        {
            
            button1.Text = button1.Text.Traducir();
            button2.Text = button2.Text.Traducir();
            button3.Text = button3.Text.Traducir();
            button4.Text = button4.Text.Traducir();

        }
    }
}
