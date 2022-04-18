using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace SAA_AD_Revisi
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string connectionString = "server=localhost;uid=root;pwd=;database=eatez;";
        string sqlQuery;
        DataTable dtMenu = new DataTable();
        int jumlah;
        PictureBox[] imageControl = new PictureBox[1];
        Label[] namamenu = new Label[1];
        Label[] hargamenu = new Label[1];
        public static string detailmenu = "";
        public static string idpembeli;
        public static string tgl;
        public static DateTime tgl2;
        public DateTime tanggalPilihan;
        
        private void buttonHi_Click(object sender, EventArgs e)
        {
            if (panelProfile.Height == 34)
            {
                panelProfile.Height = 136;
            }
            else
            {
                panelProfile.Height = 34;
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(connectionString);
                DataTable dtUser = new DataTable();
                sqlQuery = "select first_name as `Nama`, poin as `Poin` from pembeli where id_pembeli = '" + FormLogin.iduser + "' or id_pembeli = '" + FormSignUp.idUser + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtUser);
                if (FormLogin.iduser != null)
                {
                    idpembeli = FormLogin.iduser;
                }
                else
                {
                    idpembeli = FormSignUp.idUser;
                }
                tgl = dtpTanggalPesan.Value.ToString("yyyy-MM-dd");
                tgl2 = Convert.ToDateTime(tgl);
                buttonHi.Text = "Hi, " + dtUser.Rows[0]["Nama"].ToString();
                buttonPoin.Text = "Poin: " + dtUser.Rows[0]["Poin"].ToString();
                panelProfile.Height = 34;
                DisplayImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfil profile = new FormProfil();
            profile.ShowDialog();
            this.Close();
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAwal welcome = new FormAwal();
            welcome.ShowDialog();
            this.Close();
        }

        private void pBFAQ_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFAQ formFAQ = new FormFAQ();
            formFAQ.ShowDialog();
            this.Close();
        }

        private void pBCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCart formKeranjang = new FormCart();
            formKeranjang.ShowDialog();
            this.Close();
        }

        private void dtpTanggalPesan_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                clear();
                tgl = dtpTanggalPesan.Value.ToString("yyyy-MM-dd");
                tgl2 = Convert.ToDateTime(tgl);
                tanggalPilihan = dtpTanggalPesan.Value;
                dtpTanggalPesan.Value = tanggalPilihan;
                DisplayImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void fotomenu_Click(object sender, EventArgs e)
        {
            try
            {
                var simpanObjek = sender as PictureBox;
                int posisinya = Convert.ToInt32(simpanObjek.Tag);
                detailmenu = imageControl[posisinya].Name.ToString();
                FormOrder formOrder = new FormOrder();
                formOrder.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayImage()
        {
            dtMenu.Clear();
            dtMenu = new DataTable();
            sqlConnection = new MySqlConnection(connectionString);
            sqlQuery = "select jc.id_menu as `ID Menu`, nama_menu as `Nama Menu`, harga_menu as `Harga Menu`, foto_menu as `Foto Menu` from menu m, jadwal_catering jc, jadwal j where m.id_menu = jc.id_menu and j.id_jadwal = jc.id_jadwal and j.bulan = '" + dtpTanggalPesan.Value.ToString("MM") + "' and j.tahun = '" + dtpTanggalPesan.Value.ToString("yyyy") + "' and (jc.tanggal like '%" + dtpTanggalPesan.Value.ToString("dd") + "%' or jc.tanggal = '32')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtMenu);
            jumlah = dtMenu.Rows.Count;
            imageControl = new PictureBox[jumlah];
            namamenu = new Label[jumlah];
            hargamenu = new Label[jumlah];
            int x = 50;
            int y = 100;
            int namax = 50;
            int namay = 265;
            int hargax = 50;
            int hargay = 290;
            for (int i = 0; i < jumlah; i++)
            {
                namamenu[i] = new System.Windows.Forms.Label();
                namamenu[i].Location = new Point(namax, namay);
                namamenu[i].Text = dtMenu.Rows[i]["Nama Menu"].ToString();
                namamenu[i].AutoSize = true;

                hargamenu[i] = new System.Windows.Forms.Label();
                hargamenu[i].Location = new Point(hargax, hargay);
                hargamenu[i].Text = "Rp. " + dtMenu.Rows[i]["Harga Menu"].ToString();

                imageControl[i] = new System.Windows.Forms.PictureBox();
                imageControl[i].Width = 150;
                imageControl[i].Height = 150;
                imageControl[i].SizeMode = PictureBoxSizeMode.Zoom;
                byte[] fotomenu = (byte[])dtMenu.Rows[i]["Foto Menu"];
                MemoryStream ms = new MemoryStream(fotomenu);
                imageControl[i].Image = Image.FromStream(ms);
                imageControl[i].Tag = i.ToString();
                imageControl[i].Name = dtMenu.Rows[i]["ID Menu"].ToString();

                sqlDataAdapter.Dispose();
                imageControl[i].Location = new Point(x, y);
                Controls.Add(imageControl[i]);
                Controls.Add(namamenu[i]);
                Controls.Add(hargamenu[i]);
                x += 200;
                namax += 200;
                hargax += 200;
                if (x > 850 && namax > 850 && hargax > 850)
                {
                    y += 300;
                    namay += 300;
                    hargay += 300;
                    x = 50;
                    namax = 50;
                    hargax = 50;
                }
                imageControl[i].Click += new EventHandler(fotomenu_Click);

            }
        }

        private void clear()
        {
            for (int i = 0; i < jumlah; i++)
            {
                namamenu[i].Visible = false;
                hargamenu[i].Visible = false;
                imageControl[i].Visible = false;
            }
        }
    }
}
