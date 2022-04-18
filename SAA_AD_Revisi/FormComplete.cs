using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SAA_AD_Revisi
{
    public partial class FormComplete : Form
    {
        public FormComplete()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string connectionString = "server=localhost;uid=root;pwd=;database=eatez;";
        string sqlQuery;
        DataTable dtPesanan = new DataTable();
        DataTable dtBeli = new DataTable();
        DataTable dtProfil = new DataTable();
        int jumlahPanel;
        List<Panel> listpanel = new List<Panel>();
        public Panel p = new Panel();
        int detailjumlah;
        public static string idtb;

        public Button[] butDetail = new Button[100];
        public Label[] labelNama = new Label[100];
        public Label[] labelDetail = new Label[100];
        public Label[] labelHarga = new Label[100];
        public Label[] labelTanggal = new Label[100];
        public Button[] butReorder = new Button[100];
        private void FormComplete_Load(object sender, EventArgs e)
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
                pesanan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void pesanan()
        {
            dtPesanan = new DataTable();
            sqlQuery = "select id_tb as `TB`, id_pembeli as `Pembeli`, tanggal_kirim as `Tgl`, total_bayar as `Total` from transaksi_beli where id_pembeli = '" + FormHome.idpembeli + "' and (status_pesanan = 'Selesai')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtPesanan);
            jumlahPanel = dtPesanan.Rows.Count;

           
            int y = 120;
            for (int i = 0; i < jumlahPanel; i++)
            {
                Panel panel = new Panel();
                panel.Name = "panel" + i;
                listpanel.Add(panel);
                panel.Location = new Point(375, y);
                panel.Size = new Size(650, 125);
                panel.BorderStyle = BorderStyle.FixedSingle;

                labelNama[i] = new Label();
                labelNama[i] = new System.Windows.Forms.Label();
                labelNama[i].Location = new Point(15, 15);
                labelNama[i].Text = dtPesanan.Rows[i]["TB"].ToString();
                labelNama[i].Font = new Font("Calibri", 12, FontStyle.Bold | FontStyle.Underline);
                labelNama[i].AutoSize = true;
                labelNama[i].Tag = dtPesanan.Rows[i]["TB"].ToString();

                labelTanggal[i] = new Label();
                labelTanggal[i] = new System.Windows.Forms.Label();
                labelTanggal[i].Location = new Point(15, 45);
                labelTanggal[i].Text = "Tanggal Pesanan : " + dtPesanan.Rows[i]["Tgl"].ToString();
                labelTanggal[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                labelTanggal[i].AutoSize = true;

                Label detail = new Label();
                detail = new System.Windows.Forms.Label();
                detail.Location = new Point(300, 45);
                detail.Text = "Detail :";
                detail.Font = new Font("Calibri", 8, FontStyle.Regular);
                detail.AutoSize = true;

                int detaily = 65;

                dtBeli = new DataTable();
                sqlQuery = "select id_tb as `TB`, id_pembeli as `Pembeli`, nama_menu as `Menu`, quantity_beli as `Qty` from detail_beli db, menu m where db.id_menu = m.id_menu and id_pembeli = '" + FormHome.idpembeli + "' and id_tb = '" + dtPesanan.Rows[i]["TB"].ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtBeli);
                detailjumlah = dtBeli.Rows.Count;
                for (int j = 0; j < detailjumlah; j++)
                {
                    labelDetail[j] = new Label();
                    labelDetail[j] = new System.Windows.Forms.Label();
                    labelDetail[j].Location = new Point(300, detaily);
                    labelDetail[j].Text = dtBeli.Rows[j]["Menu"].ToString() + "x" + dtBeli.Rows[j]["Qty"].ToString();
                    labelDetail[j].Font = new Font("Calibri", 8, FontStyle.Regular);
                    labelDetail[j].AutoSize = true;

                    panel.Controls.Add(labelDetail[j]);
                    detaily += 15;
                }


                butDetail[i] = new Button();
                butDetail[i].Size = new Size(60, 25);
                butDetail[i].Text = "Detail";
                butDetail[i].Location = new Point(540, 36);
                butDetail[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                butDetail[i].Tag = i.ToString();

                Label total = new Label();
                total = new System.Windows.Forms.Label();
                total.Location = new Point(500, 95);
                total.Text = "Total :";
                total.Font = new Font("Calibri", 8, FontStyle.Regular);
                total.AutoSize = true;

                labelHarga[i] = new Label();
                labelHarga[i] = new System.Windows.Forms.Label();
                labelHarga[i].Location = new Point(570, 95);
                labelHarga[i].Text = "Rp. " + dtPesanan.Rows[i]["Total"].ToString();
                labelHarga[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                labelHarga[i].AutoSize = true;

                panel.Controls.Add(labelNama[i]);
                panel.Controls.Add(labelTanggal[i]);
                panel.Controls.Add(labelDetail[i]);
                panel.Controls.Add(butDetail[i]);
                panel.Controls.Add(detail);
                panel.Controls.Add(total);
                panel.Controls.Add(labelHarga[i]);

                this.Controls.Add(panel);
                butDetail[i].Click += new EventHandler(bDetail_Click);

                y += 140;
            }
        }
        private void bDetail_Click(object sender, EventArgs e)
        {
            try
            {
                Button buttonsender = (Button)sender;
                var simpanButton = sender as Button;
                int posisinya = Convert.ToInt32(simpanButton.Tag);
                idtb = labelNama[posisinya].Text;

                this.Hide();
                FormNota nota = new FormNota();
                nota.ShowDialog();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void pBoxHome_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormHome home = new FormHome();
                home.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void labelPesanan_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormProfil profile = new FormProfil();
                profile.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOngoing_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormPesanan ongoing = new FormPesanan();
                ongoing.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
