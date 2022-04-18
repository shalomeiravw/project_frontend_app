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
using System.Text.RegularExpressions;

namespace SAA_AD_Revisi
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnection;
        MySqlDataAdapter sqlDataAdapter;
        MySqlCommand sqlCommand;
        string connectionString = "server=localhost;uid=root;pwd=;database=eatez";
        string sqlQuery;
        public static string idUser;

        private void labelLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
            this.Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEmailSignUp.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxPasswordSignUp.Text == "" || textBoxReenterPasswordSignUp.Text == "")
                {
                    MessageBox.Show("Data Belum Lengkap");
                }
                else
                {
                    string email = textBoxEmailSignUp.Text;
                    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    Match match = regex.Match(email);
                    if (match.Success && textBoxPasswordSignUp.ForeColor != Color.Red && textBoxPasswordSignUp.Text == textBoxReenterPasswordSignUp.Text)
                    {
                        DateTime today = DateTime.Today;
                        idUser = "P" + today.ToString("yyyyMMdd");

                        DataTable dtItungUser = new DataTable();
                        sqlConnection = new MySqlConnection(connectionString);
                        sqlQuery = "select ID_PEMBELI as `ID` from pembeli where id_pembeli like '%"+ today.ToString("yyyyMMdd")+ "%' ";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                        sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                        sqlDataAdapter.Fill(dtItungUser);
                        int counter = dtItungUser.Rows.Count + 1;

                        if(counter >= 10)
                        {
                            idUser += "0";
                            idUser += counter.ToString();
                        }
                        else if(counter >= 100)
                        {
                            idUser += counter.ToString();
                        }
                        else
                        {
                            idUser += "00";
                            idUser += counter.ToString();
                        }
                       // MessageBox.Show(idUser);

                        sqlConnection = new MySqlConnection(connectionString);
                        sqlQuery = "insert into pembeli values('"+ idUser +"','','"+ textBoxFirstName.Text +"','"+ textBoxLastName.Text +"','','','0','"+ textBoxEmailSignUp.Text +"','','"+textBoxReenterPasswordSignUp.Text +"',0)";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();

                        this.Hide();
                        FormHome home = new FormHome();
                        home.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        sqlConnection.Close();
                        lblEmailWarn.ForeColor = Color.Red;
                        lblEmailWarn.Text = "Please enter a valid email address!";
                    }

                }
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void textBoxReenterPasswordSignUp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPasswordSignUp.Text != textBoxReenterPasswordSignUp.Text || textBoxPasswordSignUp.ForeColor == Color.Red)
                {
                    textBoxReenterPasswordSignUp.ForeColor = Color.Red;
                }
                else
                {
                    textBoxReenterPasswordSignUp.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBoxPasswordSignUp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPasswordSignUp.TextLength < 8 || textBoxPasswordSignUp.TextLength > 20)
                {
                    textBoxPasswordSignUp.ForeColor = Color.Red;
                }
                else
                {
                    textBoxPasswordSignUp.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            textBoxPasswordSignUp.UseSystemPasswordChar = true;
            textBoxReenterPasswordSignUp.UseSystemPasswordChar = true;
        }

        private void textBoxEmailSignUp_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxEmailSignUp.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                lblEmailWarn.Text = "";
            }
            else
            {
                lblEmailWarn.ForeColor = Color.Red;
                lblEmailWarn.Text = "Please enter a valid email address!";
            }
        }

        private void cBShowPass_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(cBShowPass.Checked == true)
                {
                    textBoxPasswordSignUp.UseSystemPasswordChar = false;
                    textBoxReenterPasswordSignUp.UseSystemPasswordChar = false;
                }
                else
                {
                    textBoxPasswordSignUp.UseSystemPasswordChar = true;
                    textBoxReenterPasswordSignUp.UseSystemPasswordChar = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void textBoxReenterPasswordSignUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSignUp_Click(sender, e);
            }
        }
    }
}
