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
    public partial class FormRating : Form
    {
        public FormRating()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string connectionString = "server=localhost;uid=root;pwd=;database=eatez";
        string sqlQuery;
        string rating;

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(connectionString);

                if(radioButton1.Checked == true)
                {
                    rating = "1";
                }
                else if(radioButton2.Checked == true)
                {
                    rating = "2";
                }
                else if(radioButton3.Checked == true)
                {
                    rating = "3";
                }
                else if(radioButton4.Checked == true)
                {
                    rating = "4";
                }
                else if(radioButton5.Checked == true)
                {
                    rating = "5";
                }

                sqlQuery = "update detail_beli set rating = '"+ rating +"', review = '"+ tBoxReview.Text +"' where id_tb = '"+ FormComplete.idtb +"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Terima kasih sudah membantu kami menjadi lebih baik :)");
                this.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
