using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAA_AD_Revisi
{
    public partial class FormFAQ : Form
    {
        public FormFAQ()
        {
            InitializeComponent();
        }

        private void pBoxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.ShowDialog();
            this.Close();
        }

        private void labelKritik_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKritikSaran formKritikSaran = new FormKritikSaran();
            formKritikSaran.ShowDialog();
            this.Close();
        }
    }
}
