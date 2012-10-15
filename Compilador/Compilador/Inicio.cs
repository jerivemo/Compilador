using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compilador
{
    public partial class ventInicio : Form
    {
        public ventInicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal ventTemp = new Principal();
            this.Hide();            
            ventTemp.Show();
            
        }
    }
}
