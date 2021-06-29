using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHW3
{
    public partial class AddButtonForm : Form
    {
        Form1 form;
        public AddButtonForm(Form1 form)
        {
            InitializeComponent();
            this.form = form;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            form.GetList().Items.Add(new Passenger(textBoxName.Text, int.Parse(textBoxNumLug.Text), double.Parse(textBoxWLug.Text), DateTime.Parse(maskedTextBox1.Text), textBox1.Text, double.Parse(textBox2.Text), textBox3.Text));

            Close();        
        }
    }
}
