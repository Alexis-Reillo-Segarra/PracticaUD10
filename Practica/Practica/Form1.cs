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

        private void BMultiplicar_Click(object sender, EventArgs e)
        {
            double num1 = int.Parse(TBNum1.Text);
            double num2 = int.Parse(TBNum2.Text);
            double resultado = num1 * num2;
            MessageBox.Show(resultado.ToString());
        }
    }
}
