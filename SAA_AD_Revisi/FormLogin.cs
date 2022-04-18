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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnection;
        MySqlDataAdapter sqlDataAdapter;
        MySqlCommand sqlCommand;
        string connectionString = "server=localhost;uid=root;pwd=;database=eatez";
        string sqlQuery;
        public static string iduser;


        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxPasswordLogin.UseSystemPasswordChar = true;
        }
        private void labelSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp signup = new FormSignUp();
            signup.ShowDialog();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(connectionString);

                DataTable dtUser = new DataTable();
                sqlQuery = "select id_pembeli as `ID`, email as `Email`, `password` as `Pass` from pembeli where email = '" + textBoxEmailLogin.Text + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtUser);
                if (textBoxEmailLogin.Text == dtUser.Rows[0]["Email"].ToString() && textBoxPasswordLogin.Text == dtUser.Rows[0]["Pass"].ToString())
                {
                    iduser = dtUser.Rows[0]["ID"].ToString();
                    this.Hide();
                    FormHome home = new FormHome();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email atau Password yang dimasukkan salah!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Email atau Password salah");

            }

        }

        private void labelForgotPass_Click(object sender, EventArgs e)
        {
            FormForgotPass form6 = new FormForgotPass();
            form6.ShowDialog();
        }

        private void cBShowPass_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cBShowPass.Checked == true)
                {
                    textBoxPasswordLogin.UseSystemPasswordChar = false;
                }
                else if (cBShowPass.Checked == false)
                {
                    textBoxPasswordLogin.UseSystemPasswordChar = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxEmailLogin_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxEmailLogin.Text;
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

        private void textBoxPasswordLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }
    }
}
