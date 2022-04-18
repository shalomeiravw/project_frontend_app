using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SAA_AD_Revisi
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string connectionString = "server=localhost;uid=root;pwd=;database=eatez;";
        string sqlQuery;
        int jumlahOrder = 1;
        int reviewMenu;
        DataTable dtMenu = new DataTable();
        DataTable dtReview = new DataTable();
        List<Panel> listpanel = new List<Panel>();
        public Panel panel = new Panel();
        public TextBox[] tbReview = new TextBox[100];
        public Label[] namaUser = new Label[100];
        public Label[] rating = new Label[100];
        private void FormOrder_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(connectionString);

                dtMenu = new DataTable();
                sqlQuery = "select id_menu as `ID`, nama_menu as `Nama`, foto_menu as `Foto`, deskripsi_menu as `Desc`, harga_menu as `Harga`, rating as `Rate` from menu where id_menu = '" + FormHome.detailmenu + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtMenu);

                dtReview = new DataTable();
                sqlQuery = "select p.id_pembeli as `ID`, concat(first_name, ' ',last_name) as `Nama`, foto_pembeli as `Foto`, rating as `Rating`, review as `Review` from pembeli p, detail_beli db where p.ID_PEMBELI = db.id_pembeli and ID_MENU = '" + FormHome.detailmenu + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtReview);
                reviewMenu = dtReview.Rows.Count;

                labelNamaMenu.Text = dtMenu.Rows[0]["Nama"].ToString();
                tBoxJumlah.Text = jumlahOrder.ToString();
                labelDeskripsi.Text = dtMenu.Rows[0]["Desc"].ToString();
                labelHarga.Text = "Rp. " + dtMenu.Rows[0]["Harga"].ToString();

                if (dtMenu.Rows[0]["Foto"].ToString() != "")
                {
                    byte[] fotomenu = (byte[])dtMenu.Rows[0]["Foto"];
                    MemoryStream ms = new MemoryStream(fotomenu);
                    pBoxFotoMenu.Image = Image.FromStream(ms);
                }
                else
                {
                    pBoxFotoMenu.Image = SAA_AD_Revisi.Properties.Resources.dish;
                }


                labelRating.Text = dtMenu.Rows[0]["Rate"].ToString() + "/5";
                review();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void review()
        {
            listpanel.Clear();
            int y = 4;
            for (int i = 0; i < reviewMenu; i++)
            {
                panel = new Panel();
                panel.Name = "panel" + i;
                listpanel.Add(panel);
                panel.Location = new Point(38, y);
                panel.Size = new Size(637, 159);
                panel.BorderStyle = BorderStyle.FixedSingle;

                PictureBox user = new PictureBox();
                user.Size = new Size(30, 30);
                user.SizeMode = PictureBoxSizeMode.StretchImage;

                user.Location = new Point(93, 19);

                if (dtReview.Rows[i]["Foto"].ToString() == "")
                {
                    user.Image = SAA_AD_Revisi.Properties.Resources.user;
                }
                else
                {
                    byte[] fotomenu = (byte[])dtReview.Rows[i]["Foto"];
                    MemoryStream ms = new MemoryStream(fotomenu);
                    user.Image = Image.FromStream(ms);
                }

                namaUser[i] = new Label();
                namaUser[i] = new System.Windows.Forms.Label();
                namaUser[i].Location = new Point(150, 15);
                namaUser[i].Text = dtReview.Rows[i]["Nama"].ToString();
                namaUser[i].Font = new Font("Calibri", 12, FontStyle.Bold);
                namaUser[i].AutoSize = true;

                rating[i] = new Label();
                rating[i] = new System.Windows.Forms.Label();
                rating[i].Location = new Point(150, 45);
                rating[i].Text = dtReview.Rows[i]["Rating"].ToString() + "/5";
                rating[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                rating[i].AutoSize = true;

                tbReview[i] = new TextBox();
                tbReview[i].Location = new Point(93, 63);
                tbReview[i].Text = dtReview.Rows[i]["Review"].ToString();
                tbReview[i].Font = new Font("Calibri", 10, FontStyle.Regular);
                tbReview[i].Multiline = true;
                tbReview[i].Size = new Size(475, 87);

                panel.Controls.Add(user);
                panel.Controls.Add(namaUser[i]);
                panel.Controls.Add(rating[i]);
                panel.Controls.Add(tbReview[i]);

                y += 170;
                panelRiview.Controls.Add(panel);
            }
        }

        private void buttonKurang_Click(object sender, EventArgs e)
        {
            jumlahOrder--;
            checkNol(jumlahOrder);
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            jumlahOrder++;
            checkNol(jumlahOrder);
        }

        private void checkNol(int order)
        {
            if (order <= 0)
            {
                MessageBox.Show("Harap masukkan jumlah dengan benar");
                jumlahOrder = 1;
                tBoxJumlah.Text = jumlahOrder.ToString();
            }
            else
            {
                tBoxJumlah.Text = jumlahOrder.ToString();
            }
        }

        private void buttonAddCart_Click(object sender, EventArgs e)
        {
            try
            {
                sqlQuery = "INSERT INTO keranjang (id_pembeli, id_menu, nama_menu, harga_menu, foto_menu, qty, tanggal_kirim) select '" + FormHome.idpembeli + "' as `id_pembeli`, '" + dtMenu.Rows[0]["ID"].ToString() + "' as `id_menu`, m.NAMA_MENU as `Nama Menu`, m.HARGA_MENU `Harga`, m.FOTO_MENU as `foto_menu`, '" + jumlahOrder + "' as qty, '"+FormHome.tgl+"' as tanggal_kirim FROM menu m WHERE m.ID_MENU = '" + dtMenu.Rows[0]["ID"].ToString() + "'";
                sqlConnection = new MySqlConnection(connectionString);
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Item berhasil ditambahkan ke dalam keranjang");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFav_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtFav = new DataTable();
                sqlConnection = new MySqlConnection(connectionString);
                sqlQuery = "select id_pembeli as `Pembeli`, id_menu as `Menu` from menu_favorit where id_pembeli = '" + FormHome.idpembeli + "' and id_menu = '"+dtMenu.Rows[0]["ID"].ToString()+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtFav);
               // for (int i = 0; i < dtFav.Rows.Count; i++)
                {
                    if (dtFav.Rows.Count>0)
                    {
                        MessageBox.Show("Menu sudah ditambahkan");
                    }
                    else
                    {
                        sqlQuery = "insert into menu_favorit values('" + FormHome.idpembeli + "', '" + dtMenu.Rows[0]["ID"].ToString() + "', 0) ";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();               
                        MessageBox.Show("Menu telah ditambahkan ke dalam favorit");

                    }
                }
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
