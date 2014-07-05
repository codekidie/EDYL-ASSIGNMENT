using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASS_EDYL
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        public form2(Form1 formGunit)
        {
            InitializeComponent();
            maoniangbagonagiinitiate = formGunit;
        }

        private Form1 maoniangbagonagiinitiate;
        private void textBox1_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
        }

        private void txtNum_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtNum.Text);
                int num2 = Convert.ToInt32(lbResult.Text);
                int result = num1 + num2;

                lbResult.Text = result.ToString();

                maoniangbagonagiinitiate.ibutangsabutton(lbResult.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" ERROR " + ex.Message);
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
