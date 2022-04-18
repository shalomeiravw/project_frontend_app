using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SAA_AD_Revisi
{
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string connectionString = "server=localhost;uid=root;pwd=;database=eatez;";
        string sqlQuery;
        DataTable dtKeranjang = new DataTable();
        int jumlahPanel;
        int qty;
        int harga2;
        List<Panel> listpanel = new List<Panel>();
        public Panel panel = new Panel();
        public Button[] butTambah = new Button[100];
        public Button[] butKurang = new Button[100];
        public TextBox[] tbQty = new TextBox[100];
        public Label[] labSubTotal = new Label[100];
        public Label[] labHarga = new Label[100];
        public Button[] butDelete = new Button[100];
        public CheckBox[] cbox = new CheckBox[100];
        int[] subtotal2 = new int[100];
        int totalsemua = 0;
        Label labTotalSemua = new Label();
        Button bCheckout = new Button();
        Label jumlah = new Label();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHome formHome = new FormHome();
            formHome.ShowDialog();
            this.Close();
        }

        private void FormCart_Load(object sender, EventArgs e)
        {

            labelTanggalKirim.Text = FormHome.tgl2.ToString("dd-MMMM-yyyy");
            listpanel.Clear();
            dtKeranjang = new DataTable();
            sqlQuery = "select id_pembeli as `ID Pembeli`, id_menu as `ID Menu`, NAMA_MENU as `Nama Menu`, HARGA_MENU `Harga`, FOTO_MENU as `Foto`, qty as `Qty`,tanggal_kirim as `Tanggal` FROM keranjang WHERE (id_pembeli = '" + FormLogin.iduser + "' or id_pembeli = '" + FormSignUp.idUser + "') and tanggal_kirim = '"+ FormHome.tgl +"'";
            sqlConnection = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtKeranjang);

            jumlahPanel = dtKeranjang.Rows.Count;
            if (jumlahPanel == 0)
            {
                Label kosong = new Label();
                kosong = new System.Windows.Forms.Label();
                kosong.Location = new Point(450, 325);
                kosong.Text = "There is no items";
                kosong.Font = new Font("Calibri", 20, FontStyle.Regular);
                kosong.AutoSize = true;
                bCheckout.Enabled = false;
                this.Controls.Add(kosong);
            }
            else
            {
                keranjang();
            }
            

        }

        private void keranjang()
        {
            try
            {
                int y = 125;
                for (int i = 0; i < jumlahPanel; i++)
                {
                    qty = Convert.ToInt32(dtKeranjang.Rows[i]["Qty"]);
                    harga2 = Convert.ToInt32(dtKeranjang.Rows[i]["Harga"]);

                    panel = new Panel();
                    panel.Name = "panel" + i;
                    listpanel.Add(panel);
                    panel.Location = new Point(200, y);
                    panel.Size = new Size(650, 125);
                    panel.BorderStyle = BorderStyle.FixedSingle;

                    cbox[i] = new CheckBox();
                    cbox[i].Text = "";
                    cbox[i].Location = new Point(15, 55);

                    PictureBox pbox = new PictureBox();
                    pbox.Size = new Size(100, 100);
                    pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                    byte[] fotomenu = (byte[])dtKeranjang.Rows[i]["Foto"];
                    MemoryStream ms = new MemoryStream(fotomenu);
                    pbox.Image = Image.FromStream(ms);
                    pbox.Location = new Point(40, 12);

                    Label namamenu = new Label();
                    namamenu = new System.Windows.Forms.Label();
                    namamenu.Location = new Point(150, 15);
                    namamenu.Text = dtKeranjang.Rows[i]["Nama Menu"].ToString();
                    namamenu.Font = new Font("Calibri", 12, FontStyle.Bold);
                    namamenu.AutoSize = true;

                    Label har = new Label();
                    har = new System.Windows.Forms.Label();
                    har.Location = new Point(150, 45);
                    har.Text = "Harga :";
                    har.Font = new Font("Calibri", 8, FontStyle.Regular);
                    har.AutoSize = true;

                    labHarga[i] = new Label();
                    labHarga[i] = new System.Windows.Forms.Label();
                    labHarga[i].Location = new Point(210, 45);
                    labHarga[i].Text = "Rp. " + dtKeranjang.Rows[i]["Harga"].ToString();
                    labHarga[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                    labHarga[i].AutoSize = true;
                    labHarga[i].Tag = dtKeranjang.Rows[i]["Harga"].ToString();


                    jumlah = new System.Windows.Forms.Label();
                    jumlah.Location = new Point(200, 80);
                    jumlah.Text = "Jumlah";
                    jumlah.Font = new Font("Calibri", 8, FontStyle.Regular);
                    jumlah.AutoSize = true;

                    butKurang[i] = new Button();
                    butKurang[i].Size = new Size(40, 20);
                    butKurang[i].Text = "-";
                    butKurang[i].Location = new Point(150, 95);
                    butKurang[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                    butKurang[i].Tag = i.ToString();

                    tbQty[i] = new TextBox();
                    tbQty[i].Width = 80;
                    tbQty[i].Location = new Point(200, 95);
                    tbQty[i].TextAlign = HorizontalAlignment.Center;
                    tbQty[i].Text = dtKeranjang.Rows[i]["Qty"].ToString();
                    tbQty[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                    tbQty[i].Tag = dtKeranjang.Rows[i]["Nama Menu"].ToString();

                    butTambah[i] = new Button();
                    butTambah[i].Size = new Size(40, 20);
                    butTambah[i].Text = "+";
                    butTambah[i].Location = new Point(295, 95);
                    butTambah[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                    butTambah[i].Tag = i.ToString();

                    butDelete[i] = new Button();
                    butDelete[i].Size = new Size(25, 25);
                    butDelete[i].Text = "X";
                    butDelete[i].Location = new Point(610, 12);
                    butDelete[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                    butDelete[i].Tag = i.ToString();

                    Label subtotal = new Label();
                    subtotal = new System.Windows.Forms.Label();
                    subtotal.Location = new Point(500, 95);
                    subtotal.Text = "Subtotal :";
                    subtotal.Font = new Font("Calibri", 8, FontStyle.Regular);
                    subtotal.AutoSize = true;


                    subtotal2[i] = qty * harga2;
                    labSubTotal[i] = new Label();
                    labSubTotal[i] = new System.Windows.Forms.Label();
                    labSubTotal[i].Location = new Point(570, 95);
                    labSubTotal[i].Text = "Rp. " + subtotal2[i].ToString();
                    labSubTotal[i].Font = new Font("Calibri", 8, FontStyle.Regular);
                    labSubTotal[i].AutoSize = true;

                    panel.Controls.Add(pbox);
                    panel.Controls.Add(namamenu);
                    panel.Controls.Add(har);
                    panel.Controls.Add(labHarga[i]);
                    panel.Controls.Add(butDelete[i]);
                    panel.Controls.Add(butKurang[i]);
                    panel.Controls.Add(butTambah[i]);
                    panel.Controls.Add(jumlah);
                    panel.Controls.Add(cbox[i]);
                    panel.Controls.Add(tbQty[i]);
                    panel.Controls.Add(subtotal);
                    panel.Controls.Add(labSubTotal[i]);

                    this.Controls.Add(panel);
                    butKurang[i].Click += new EventHandler(bkurang_Click);
                    butTambah[i].Click += new EventHandler(btambah_Click);
                    butDelete[i].Click += new EventHandler(bdelete_Click);
                    
                    cbox[i].CheckedChanged += new EventHandler(cbox_CheckedChanged);
                    y += 140;
                }

                for (int i = 0; i < jumlahPanel; i++)
                {
                    if (cbox[i].Checked == true)
                    {
                        totalsemua += subtotal2[i];
                    }
                }

                y += 50;


                labTotalSemua = new System.Windows.Forms.Label();
                labTotalSemua.Location = new Point(700, y);
                labTotalSemua.Text = "Total : " + totalsemua.ToString();
                labTotalSemua.Font = new Font("Calibri", 20, FontStyle.Bold);
                labTotalSemua.AutoSize = true;

                y += 50;


                bCheckout.Size = new Size(150, 40);
                bCheckout.Text = "Checkout";
                bCheckout.Location = new Point(700, y);
                bCheckout.Font = new Font("Calibri", 18, FontStyle.Bold);

                this.Controls.Add(labTotalSemua);
                this.Controls.Add(bCheckout);
                bCheckout.Click += new EventHandler(bco_Click);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bco_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCheckout formco = new FormCheckout();
            formco.ShowDialog();
            this.Close();
        }

           
        private void cbox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                totalsemua = 0;
                for (int i = 0; i < jumlahPanel; i++)
                {
                    if (cbox[i].Checked == true)
                    {
                        totalsemua += subtotal2[i];

                    }
                    else
                    {

                    }

                }
                labTotalSemua.Text = "Total : " + totalsemua.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void bkurang_Click(object sender, EventArgs e)
        {

            try
            {
                var simpanButton = sender as Button;
                int posisinya = Convert.ToInt32(simpanButton.Tag);
                int qtySekarang = Convert.ToInt32(tbQty[posisinya].Text) - 1;
                tbQty[posisinya].Text = qtySekarang.ToString();
                int subTotalLabel = qtySekarang * Convert.ToInt32(labHarga[posisinya].Tag);
                labSubTotal[posisinya].Text = "Rp. " + subTotalLabel.ToString();

                if (qty <= 0)
                {
                    sqlQuery = "delete from keranjang where nama_menu = '" + tbQty[posisinya].Tag.ToString() + "'";
                }
                else
                {
                    sqlQuery = "update keranjang set qty = '" + tbQty[posisinya].Text + "'  where nama_menu = '" + tbQty[posisinya].Tag.ToString() + "'";
                }
                sqlConnection = new MySqlConnection(connectionString);
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btambah_Click(object sender, EventArgs e)
        {
            try
            {
                var simpanButton = sender as Button;
                int posisinya = Convert.ToInt32(simpanButton.Tag);
                int qtySekarang = Convert.ToInt32(tbQty[posisinya].Text) + 1;
                tbQty[posisinya].Text = qtySekarang.ToString();
                int subTotalLabel = qtySekarang * Convert.ToInt32(labHarga[posisinya].Tag);
                labSubTotal[posisinya].Text = "Rp. " + subTotalLabel.ToString();

                sqlQuery = "update keranjang set qty = '" + tbQty[posisinya].Text + "'  where nama_menu = '" + tbQty[posisinya].Tag.ToString() + "' ";
                sqlConnection = new MySqlConnection(connectionString);
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bdelete_Click(object sender, EventArgs e)
        {
            try
            {
                Button buttonsender = (Button)sender;
                var simpanButton = sender as Button;
                int posisinya = Convert.ToInt32(simpanButton.Tag);
                int qtySekarang = Convert.ToInt32(tbQty[posisinya].Text) - 1;
                tbQty[posisinya].Text = qtySekarang.ToString();

                sqlQuery = "delete from keranjang where nama_menu = '" + tbQty[posisinya].Tag.ToString() + "'";
                sqlConnection = new MySqlConnection(connectionString);
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                if (jumlahPanel == 0)
                {
                    Label kosong = new Label();
                    kosong = new System.Windows.Forms.Label();
                    kosong.Location = new Point(402, 204);
                    kosong.Text = "Tidak Ada Barang Di Keranjang";
                    kosong.Font = new Font("Calibri", 24, FontStyle.Bold);
                    kosong.AutoSize = true;
                    bCheckout.Enabled = false;
                    this.Controls.Add(kosong);
                }
                else if (jumlahPanel >= 0)
                {
                    keranjang();
                }
                MessageBox.Show("Item telah dihapus");
                this.Hide();
                this.Close();

                FormCart formCart = new FormCart();
                formCart.ShowDialog();
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
