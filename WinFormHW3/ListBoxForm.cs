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
    public partial class ListBoxForm : Form
    {
        
        public ListBoxForm(Form1 form)
        {
            InitializeComponent();
           
            foreach (var item in form.GetList().Items)
            {
                if ((item as Passenger).DateOfFlight==DateTime.Parse( form.GetDate()) && (item as Passenger).TimeOfFlight.Trim()==form.GetTimeOfFLight())
                {
                    
                    listBox1.Items.Add(item);
                    
                    
                }
            }
        }
    }
}
