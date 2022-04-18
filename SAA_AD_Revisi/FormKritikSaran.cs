using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SAA_AD_Revisi
{
    public partial class FormKritikSaran : Form
    {
        public FormKritikSaran()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        string connectionString = "server=localhost;uid=root;pwd=;database=eatez;";
        string sqlQuery;
        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            sqlQuery = "insert into kritik_saran values('" + FormHome.idpembeli + "', '" + textBoxKritik.Text + "', '" + textBoxSaran.Text + "')";
            sqlConnection = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            var result = MessageBox.Show("Terima kasih atas kritik dan saran anda.", "Terima Kasih", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                this.Hide();
                FormHome formHome = new FormHome();
                formHome.ShowDialog();
                this.Close();
            }
            else
            {

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.ShowDialog();
            this.Close();
        }
    }
}
