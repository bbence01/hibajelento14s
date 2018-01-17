using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIbabejelento14S
{
    public partial class Form1 : Form
    {

        List<Hiba1> hibak = new List<Hiba1>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        public void OK_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(textBox1.Text) || (String.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Üres Mezők",
                    "Error Message");
            }

            else {
                Hiba1 hiba = new Hiba1(textBox1.Text, textBox2.Text, dateTimePicker1.MaxDate);
                hibak.Add(hiba);
                textBox1.Text = null;
                textBox2.Text = null;
            }
        }

     
    }
}
