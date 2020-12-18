using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class FrmVille : Form
    {
        public FrmVille()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstVille.Items.Clear();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            lstVille.Items.Add(txtVille.Text);
            txtVille.Text = string.Empty;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            lstVille.Items.RemoveAt(lstVille.SelectedIndex);
        }
    }
}
