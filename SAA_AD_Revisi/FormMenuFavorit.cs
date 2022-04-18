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

namespace SAA_AD_Revisi
{
    public partial class FormMenuFavorit : Form
    {
        public FormMenuFavorit()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string connectionString = "server=localhost;uid=root;pwd=;database=eatez;";
        string sqlQuery;
        DataTable dtProfil = new DataTable();
        DataTable dtFav = new DataTable();
        int jumlahPanel;
        List<Panel> listpanel = new List<Panel>();
        public Panel p = new Panel();
        PictureBox pbox = new PictureBox();
        public Button[] butAddCart = new Button[100];
        public Label[] tbQty = new Label[100];
        public Label[] labelNama = new Label[100];
        public Label[] labelDesk = new Label[100];
        public Label[] labelHarga = new Label[100];
        public Label[] labelrating = new Label[100];
        public Button[] butDelete = new Button[100];

        private void FormMenuFavorit_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(connectionString);
                dtProfil.Clear();
                sqlQuery = "select concat(first_name, ' ',last_name) as `Nama`, first_name as `Nama Depan`, last_name as `Nama Blkng`, foto_pembeli as `Foto` ,alamat as `Alamat`, poin as `Poin`,if(jenis_kelamin = 'L', 'Laki-Laki','Perempuan') as `Jenis Kelamin`, email as `E-mail`, no_hp as `No HP` from pembeli where id_pembeli = '" + FormLogin.iduser + "' or id_pembeli = '" + FormSignUp.idUser + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtProfil);

                labelUsername.Text = dtProfil.Rows[0]["Nama"].ToString();
                labelPoin.Text = dtProfil.Rows[0]["Poin"].ToString();

                if (dtProfil.Rows[0]["Foto"].ToString() == "")
                {
                    pbDisplay.Image = SAA_AD_Revisi.Properties.Resources.user;
                    pbDisplay.Image = SAA_AD_Revisi.Properties.Resources.user;
                }
                else
                {
                    byte[] fotouser = (byte[])dtProfil.Rows[0]["Foto"];
                    MemoryStream ms = new MemoryStream(fotouser);
                    pbDisplay.Image = new Bitmap(ms);

                    byte[] fotouser2 = (byte[])dtProfil.Rows[0]["Foto"];
                    MemoryStream ms2 = new MemoryStream(fotouser2);
                    pbDisplay.Image = new Bitmap(ms2);
                }

                menuFav();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtMenuFav = new DataTable();
                sqlConnection = new MySqlConnection(connectionString);
                sqlQuery = "select id_pembeli as `ID Pembeli`, id_menu as `ID Menu`, nama_menu as `Nama Menu` from menu_favorit mf, menu m where m.id_menu = mf.id_menu and (id_pembeli = '" + FormLogin.iduser+"' or id_pembeli = '"+FormSignUp.idUser+"' and nama_menu like '%"+tbSearch.Text+"%')";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtMenuFav);

                menuFav();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelPesanan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPesanan forpesan = new FormPesanan();
            forpesan.ShowDialog();
            this.Close();
        }
        

        private void menuFav()
        {
            listpanel.Clear();
            dtFav = new DataTable();
            sqlQuery = "select mf.id_pembeli as `Pembeli`, foto_menu as `Foto`, nama_menu as `Menu`, mf.id_menu as `ID Menu`, harga_menu as `Harga`, deskripsi_menu as `Deskripsi`, rating as `Rating` from menu m, menu_favorit mf where m.id_menu = mf.id_menu and mf.id_pembeli = '"+FormHome.idpembeli+"' ";
            sqlConnection = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtFav);

            jumlahPanel = dtFav.Rows.Count;
            int y = 150;
            for (int i = 0; i < jumlahPanel; i++)
            {
                Panel panel = new Panel();
                panel.Name = "panel" + i;
                listpanel.Add(panel);
                panel.Location = new Point(350, y);
                panel.Size = new Size(650, 125);
                panel.BorderStyle = BorderStyle.FixedSingle;

                pbox = new PictureBox();
                pbox.Size = new Size(100, 100);
                pbox.SizeMode = PictureBoxSizeMode.Zoom;
                byte[] fotomenu = (byte[])dtFav.Rows[i]["Foto"];
                MemoryStream ms = new MemoryStream(fotomenu);
                pbox.Image = Image.FromStream(ms);
                pbox.Location = new Point(12, 12);

                labelNama[i] = new Label();
                labelNama[i] = new System.Windows.Forms.Label();
                labelNama[i].Location = new Point(120, 15);
                labelNama[i].Text = dtFav.Rows[i]["Menu"].ToString();
                labelNama[i].Font = new Font("Calibri", 12, FontStyle.Bold);
                labelNama[i].AutoSize = true;
                labelNama[i].Tag = dtFav.Rows[i]["ID Menu"].ToString();


                labelrating[i] = new Label();
                labelrating[i] = new System.Windows.Forms.Label();
                labelrating[i].Location = new Point(120, 35);
                labelrating[i].Text = dtFav.Rows[i]["Rating"].ToString() + "/5";
                labelrating[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                labelrating[i].AutoSize = true;

                Label des = new Label();
                des = new System.Windows.Forms.Label();
                des.Location = new Point(120, 55);
                des.Text = "Deskripsi :";
                des.Font = new Font("Calibri", 8, FontStyle.Regular);
                des.AutoSize = true;

                labelDesk[i] = new Label();
                labelDesk[i] = new System.Windows.Forms.Label();
                labelDesk[i].Location = new Point(120, 68);
                labelDesk[i].Text = dtFav.Rows[i]["Deskripsi"].ToString();
                labelDesk[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                labelDesk[i].AutoSize = false;
                labelDesk[i].Size = new Size(225, 55);

                Label har = new Label();
                har = new System.Windows.Forms.Label();
                har.Location = new Point(300, 70);
                har.Text = "Harga :";
                har.Font = new Font("Calibri", 8, FontStyle.Regular);
                har.AutoSize = false;

                labelHarga[i] = new Label();
                labelHarga[i] = new System.Windows.Forms.Label();
                labelHarga[i].Location = new Point(325, 70);
                labelHarga[i].Text = "Rp. " + dtFav.Rows[i]["Harga"].ToString();
                labelHarga[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                labelHarga[i].AutoSize = false;

                butDelete[i] = new Button();
                butDelete[i].Size = new Size(35, 35);
                butDelete[i].Text = "X";
                butDelete[i].Location = new Point(605, 12);
                butDelete[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                butDelete[i].Tag = i.ToString();

                butAddCart[i] = new Button();
                butAddCart[i].Size = new Size(120, 30);
                butAddCart[i].Text = "Add to Cart";
                butAddCart[i].Location = new Point(520, 85);
                butAddCart[i].Font = new Font("Calibri", 8, FontStyle.Regular);

                panel.Controls.Add(pbox);
                panel.Controls.Add(labelNama[i]);
                panel.Controls.Add(labelrating[i]);
                panel.Controls.Add(des);
                panel.Controls.Add(labelDesk[i]);
                panel.Controls.Add(har);
                panel.Controls.Add(labelHarga[i]);
                panel.Controls.Add(butDelete[i]);
                panel.Controls.Add(butAddCart[i]);

                this.Controls.Add(panel);

                butAddCart[i].Click += new EventHandler(addtocart_click);
                butDelete[i].Click += new EventHandler(bdelete_Click);
                y += 140;
            }
        }
        private void addtocart_click(object sender, EventArgs e)
        {
            try
            {
                FormOrder fororder = new FormOrder();
                fororder.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bdelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Button buttonsender = (Button)sender;
                var simpanButton = sender as Button;
                int posisinya = Convert.ToInt32(simpanButton.Tag);

                sqlQuery = "delete from menu_favorit where id_menu = '" + labelNama[posisinya].Tag.ToString() + "' and id_pembeli = '"+FormHome.idpembeli+"'";
                sqlConnection = new MySqlConnection(connectionString);
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfil formProfil = new FormProfil();
            formProfil.ShowDialog();
            this.Close();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormHome formhome = new FormHome();
                formhome.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
