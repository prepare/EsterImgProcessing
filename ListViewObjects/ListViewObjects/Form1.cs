using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListViewObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Exercise exc1 = new Exercise();
            exc1.distance = 100;
            exc1.type = "sprint";

            listBox1.Items.Add(exc1);

            Exercise exc2 = new Exercise();
            exc2.distance = 5;
            exc2.type = "long jump";

            listBox1.Items.Add(exc2);

            Exercise exc3 = new Exercise();
            exc3.distance = 10000;
            exc3.type = "marathon";

            listBox1.Items.Add(exc3);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (listBox1.SelectedItem is Exercise)
                {
                    Exercise exc = (Exercise)listBox1.SelectedItem;
                    MessageBox.Show(exc.ToString());
                }
            }
        }
    }
}
