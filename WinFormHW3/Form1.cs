using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHW3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = string.Empty;
            openFileDialog.Filter = "Text files(*.txt) |*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                while (!sr.EndOfStream)
                {
                    string[] splittedText = sr.ReadLine().Split('|');
                    
                    listBox1.Items.Add(new Passenger(splittedText[0],int.Parse(splittedText[1].Trim().Replace("luggages","")), double.Parse(splittedText[2].Trim().Replace("kg", "")),DateTime.Parse(splittedText[3]),splittedText[4],double.Parse(splittedText[5].Trim().Replace("hours", "")), splittedText[6]));
                }
                sr.Close();
            }
        }
        public ListBox GetList() 
        {
            return listBox1;
        }
        public string GetDate()
        {
            return maskedTextBox1.Text;
        }
        public string GetTimeOfFLight()
        {
            return textBox2.Text;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                foreach (var item in listBox1.Items)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddButtonForm form = new AddButtonForm(this);
            form.ShowDialog();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ListBoxForm form = new ListBoxForm(this);
            form.ShowDialog();
        }
    }
}
