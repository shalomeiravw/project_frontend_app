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
using System.IO;
using System.Text.RegularExpressions;

namespace SAA_AD_Revisi
{
    public partial class FormProfil : Form
    {
        public FormProfil()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string connectionString = "server=localhost;uid=root;pwd=;database=eatez;";
        string sqlQuery;
        string newpath;
        DataTable dtProfil = new DataTable();


        private void FormProfil_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(connectionString);

                dtProfil.Clear();
                sqlQuery = "select concat(first_name, ' ',last_name) as `Nama`, first_name as `Nama Depan`, last_name as `Nama Blkng`, foto_pembeli as `Foto` ,alamat as `Alamat`, poin as `Poin`,if(jenis_kelamin = 'L', 'Laki-Laki','Perempuan') as `Jenis Kelamin`, email as `E-mail`, no_hp as `No HP` from pembeli where id_pembeli = '"+ FormLogin.iduser +"' or id_pembeli = '"+ FormSignUp.idUser +"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtProfil);

                tbFirst.Text = dtProfil.Rows[0]["Nama Depan"].ToString();
                textBoxAlamat.Text = dtProfil.Rows[0]["Alamat"].ToString();
                textBoxEditEmail.Text = dtProfil.Rows[0]["E-mail"].ToString();
                textBoxEditNoHP.Text = dtProfil.Rows[0]["No HP"].ToString();
                labelUsername.Text = dtProfil.Rows[0]["Nama"].ToString();
                labelPoin.Text = dtProfil.Rows[0]["Poin"].ToString();
                tbLast.Text = dtProfil.Rows[0]["Nama Blkng"].ToString();

                if (dtProfil.Rows[0]["Jenis Kelamin"].ToString() == "Laki-Laki")
                {
                    radioButtonPria.Checked = true;
                }
                else
                {
                    radioButtonWanita.Checked = true;
                }

                if(dtProfil.Rows[0]["Foto"].ToString() == "")
                {
                    pbDisplay.Image = SAA_AD_Revisi.Properties.Resources.user;
                    pictureBoxPilihFoto.Image = SAA_AD_Revisi.Properties.Resources.user;
                }
                else
                {
                    byte[] fotouser = (byte[])dtProfil.Rows[0]["Foto"];
                    MemoryStream ms = new MemoryStream(fotouser);
                    pbDisplay.Image = new Bitmap(ms);

                    byte[] fotouser2 = (byte[])dtProfil.Rows[0]["Foto"];
                    MemoryStream ms2 = new MemoryStream(fotouser2);
                    pictureBoxPilihFoto.Image = new Bitmap(ms2);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pBoxHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.ShowDialog();
            this.Close();
        }

        private void labelPilihFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif;)| *.jpg; *.jpeg; *.png; *.gif";
                
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxPilihFoto.Image = new Bitmap(openFileDialog.FileName);

                }
                var path = openFileDialog.FileName;
                newpath = path.Replace("\\","\\\\");
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
        string gender;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(radioButtonPria.Checked == true)
                {
                    gender = "L";
                }
                else
                {
                    gender = "P";
                }
                
                if (newpath != null)
                {
                    sqlConnection = new MySqlConnection(connectionString);
                    sqlQuery = "update pembeli set first_name = '"+ tbFirst.Text+"', last_name = '"+tbLast.Text+"', email = '"+ textBoxEditEmail.Text +"' , no_hp = '"+textBoxEditNoHP.Text +"', alamat = '"+textBoxAlamat.Text+"', jenis_kelamin = '"+ gender +"',foto_pembeli = LOAD_FILE('" + newpath.ToString() + "') where id_pembeli = '" + FormLogin.iduser + "' or id_pembeli = '"+ FormSignUp.idUser +"'";
                    sqlConnection = new MySqlConnection(connectionString);
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Foto dan Data berhasil diupdate :)");
                }
                else if (newpath == "")
                {
                    sqlConnection = new MySqlConnection(connectionString);
                    sqlQuery = "update pembeli set first_name = '" + tbFirst.Text + "', last_name = '" + tbLast.Text + "', email = '" + textBoxEditEmail.Text + "' , no_hp = '" + textBoxEditNoHP.Text + "', alamat = '" + textBoxAlamat.Text + "', jenis_kelamin = '" + gender + "' where id_pembeli = '" + FormLogin.iduser + "' or id_pembeli = '" + FormSignUp.idUser + "'";
                    sqlConnection = new MySqlConnection(connectionString);
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Data berhasil diupdate :)");
                }
                FormProfil_Load(sender, e);
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void labelPesanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPesanan formPesan = new FormPesanan();
            formPesan.ShowDialog();
            this.Close();
        }

        private void textBoxEditEmail_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxEditEmail.Text;
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

        private void buttonUbahPass_Click(object sender, EventArgs e)
        {
            FormForgotPass formForgotPass = new FormForgotPass();
            formForgotPass.ShowDialog();
        }

        private void buttonMenuFav_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuFavorit formfav = new FormMenuFavorit();
            formfav.ShowDialog();
            this.Close();
        }
    }
}
