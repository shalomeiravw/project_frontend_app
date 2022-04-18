using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAA_AD_Revisi
{
    public partial class FormAlasanCancel : Form
    {
        public FormAlasanCancel()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string connectionString = "server=locahost;uid=root;pwd=;database=eatez";
        string sqlQuery;

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPesanan formPesan = new FormPesanan();
            formPesan.ShowDialog();
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormPesanan formPesan = new FormPesanan();
                formPesan.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }
    }
}
