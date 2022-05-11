using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BDividir_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(TNum1.Text);
            double num2 = double.Parse(TNum2.Text);
            MessageBox.Show((num1 / num2).ToString());
        }
    }
}
