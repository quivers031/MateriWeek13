using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            labelNama.Font = new Font("Arial", 10, FontStyle.Italic);
            labelNama.Text = textBoxNama.Text;
            comboBoxNama.Items.Add(textBoxNama.Text);
        }

        
        private void buttonUbah_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void buttonUbah_DockChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Data telah diinput di combobox!");
                buttonUbah_Click(sender, e);
            }
        }

        private void comboBoxNama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
