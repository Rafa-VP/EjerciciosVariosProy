using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LlamandoDesdeForms
{
    public partial class frmCallFunciones : Form
    {
        public frmCallFunciones()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            BibliotecadeFunciones.Operaciones ob1 = new BibliotecadeFunciones.Operaciones();

            double num1 = Convert.ToDouble(this.txtNum1.Text);
            double num2 = Convert.ToDouble(this.txtNum2.Text);
            this.txtResSum.Text = ob1.suma(num1, num2).ToString();

            double fact = double.Parse(this.txtFac.Text);
            this.txtResFac.Text = ob1.factorial(fact).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
