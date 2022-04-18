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
    public partial class FormCheckout : Form
    {
        public FormCheckout()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string connectionString = "server=localhost;uid=root;pwd=;database=eatez;";
        string sqlQuery;
        DataTable dtNota = new DataTable();
        DataTable dtBeli = new DataTable();
        DataTable dtItungan = new DataTable();
        
        public static string idtb2;
        int poinpake;
        int poin = 0;
        int bayar;
        int jumlahmenu;
        int total;
        PictureBox[] imageControl = new PictureBox[100];
        Label[] namamenu = new Label[100];
        Label[] hargamenu = new Label[100];
        Label[] harga = new Label[100];
        Label[] subtotal = new Label[100];
        Label[] subtotalharga = new Label[100];
        Label[] jumlahh = new Label[100];
        Label[] jumlahbarang = new Label[100];
        int qty;
        int harga2;
        int subtotal2;
        private void kasipbox()
        {
            dtBeli = new DataTable();
            sqlQuery = "select  k.id_pembeli as `Pembeli`, id_menu as `ID Menu`, nama_menu as `Menu`, foto_menu as `Foto`, harga_menu as `Harga`, qty as `Qty` from keranjang k where k.id_pembeli = '"+ FormHome.idpembeli +"' and tanggal_kirim = '"+ FormHome.tgl +"'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtBeli);
            jumlahmenu = dtBeli.Rows.Count;

            imageControl = new PictureBox[jumlahmenu];
            namamenu = new Label[jumlahmenu];
            hargamenu = new Label[jumlahmenu];
            harga = new Label[jumlahmenu];
            subtotal = new Label[jumlahmenu];
            subtotalharga = new Label[jumlahmenu];
            jumlahh = new Label[jumlahmenu];
            jumlahbarang = new Label[jumlahmenu];
            int x = 12;
            int y = 12;
            int namax = 120;
            int namay = 40;
            int nilaiy = 45;
            int hargax = 275;
            int juduly = 25;
            int jumlahbrgx = 375;
            int subtotalx = 450;
            for (int i = 0; i < jumlahmenu; i++)
            {
                namamenu[i] = new System.Windows.Forms.Label();
                namamenu[i].Location = new Point(namax, namay);
                namamenu[i].Text = dtBeli.Rows[i]["Menu"].ToString();
                namamenu[i].Font = new Font("Calibri", 12, FontStyle.Bold);
                namamenu[i].AutoSize = true;

                hargamenu[i] = new System.Windows.Forms.Label();
                hargamenu[i].Location = new Point(hargax, nilaiy);
                hargamenu[i].Text = "Rp. " + dtBeli.Rows[i]["Harga"].ToString();
                hargamenu[i].Font = new Font("Calibri", 8, FontStyle.Bold);
                hargamenu[i].AutoSize = true;
                harga2 = Convert.ToInt32(dtBeli.Rows[i]["Harga"]);

                harga[i] = new System.Windows.Forms.Label();
                harga[i].Location = new Point(hargax, juduly);
                harga[i].Text = "Harga Satuan";
                harga[i].Font = new Font("Calibri", 8);
                harga[i].AutoSize = true;

                jumlahh[i] = new System.Windows.Forms.Label();
                jumlahh[i].Location = new Point(jumlahbrgx, juduly);
                jumlahh[i].Text = "Jumlah";
                jumlahh[i].Font = new Font("Calibri", 8);
                jumlahh[i].AutoSize = true;

                jumlahbarang[i] = new System.Windows.Forms.Label();
                jumlahbarang[i].Location = new Point(jumlahbrgx, nilaiy);
                jumlahbarang[i].Text = dtBeli.Rows[i]["Qty"].ToString();
                jumlahbarang[i].Font = new Font("Calibri", 8, FontStyle.Bold);
                jumlahbarang[i].AutoSize = true;
                qty = Convert.ToInt32(dtBeli.Rows[i]["Qty"]);

                subtotal[i] = new System.Windows.Forms.Label();
                subtotal[i].Location = new Point(subtotalx, juduly);
                subtotal[i].Text = "Subtotal";
                subtotal[i].Font = new Font("Calibri", 8);
                subtotal[i].AutoSize = true;

                subtotal2 = qty * harga2;
                subtotalharga[i] = new System.Windows.Forms.Label();
                subtotalharga[i].Location = new Point(subtotalx, nilaiy);
                subtotalharga[i].Text = "Rp. " + subtotal2.ToString();
                subtotalharga[i].Font = new Font("Calibri", 8, FontStyle.Bold);
                subtotalharga[i].AutoSize = true;

                imageControl[i] = new System.Windows.Forms.PictureBox();
                imageControl[i].Width = 85;
                imageControl[i].Height = 85;
                imageControl[i].SizeMode = PictureBoxSizeMode.StretchImage;
                byte[] fotomenu = (byte[])dtBeli.Rows[i]["Foto"];
                MemoryStream ms = new MemoryStream(fotomenu);
                imageControl[i].Image = Image.FromStream(ms);
                imageControl[i].Location = new Point(x, y);
                panelPesanan.Controls.Add(imageControl[i]);
                var pbox = imageControl[i];

                panelPesanan.Controls.Add(namamenu[i]);
                panelPesanan.Controls.Add(hargamenu[i]);
                panelPesanan.Controls.Add(harga[i]);
                panelPesanan.Controls.Add(jumlahh[i]);
                panelPesanan.Controls.Add(subtotal[i]);
                panelPesanan.Controls.Add(jumlahbarang[i]);
                panelPesanan.Controls.Add(subtotalharga[i]);

                y += 95;
                namay += 95;
                nilaiy += 95;
                juduly += 95;
            }
        }


        private void FormCheckout_Load(object sender, EventArgs e)
        {
            try
            {
                
                sqlConnection = new MySqlConnection(connectionString);
                dtNota = new DataTable();
                sqlQuery = "select id_pembeli as `Pembeli`, alamat as `Alamat`, poin as `Poin` from pembeli where id_pembeli = '"+ FormHome.idpembeli +"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtNota);

                tBoxAlamat.Text = dtNota.Rows[0]["Alamat"].ToString();
                labelPoin.Text = dtNota.Rows[0]["Poin"].ToString();
                labelOngkir.Text = "Rp. 10000";

                dtItungan = new DataTable();
                sqlQuery = "select sum(harga_menu*qty) as `Total` from keranjang where id_pembeli = '"+ FormHome.idpembeli +"' and tanggal_kirim = '"+FormHome.tgl +"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtItungan);
                label11.Text = "Rp. " +dtItungan.Rows[0]["Total"].ToString();
                labelTotalPesan.Text ="Rp. "+ dtItungan.Rows[0]["Total"].ToString();
                bayar = Convert.ToInt32(dtItungan.Rows[0]["Total"]);
                total = bayar - poinpake + 10000;
                labelTotalBayar.Text = "Rp. " + (total).ToString();
                labelPoinPake.Text = " - Rp. " + poinpake.ToString();
                
                kasipbox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCart formCart = new FormCart();
            formCart.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new MySqlConnection(connectionString);

                var result = MessageBox.Show("Sudah yakin dengan pesanan Anda?", "Warning!", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    DateTime today = DateTime.Today;
                    idtb2 =  today.ToString("yyyyMMdd");

                    DataTable dtTransaksi = new DataTable();
                    sqlConnection = new MySqlConnection(connectionString);
                    sqlQuery = "select id_tb as `ID` from transaksi_beli where id_tb like '%" + today.ToString("yyyyMMdd") + "%' ";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                    sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dtTransaksi);

                    int counter = dtTransaksi.Rows.Count + 1;

                    if (counter >= 10)
                    {
                        idtb2 += "0";
                        idtb2 += counter.ToString();
                    }
                    else if (counter >= 100)
                    {
                        idtb2 += counter.ToString();
                    }
                    else
                    {
                        idtb2 += "00";
                        idtb2 += counter.ToString();
                    }

                    if(radioButtonTransfer.Checked == true)
                    {
                        sqlQuery = "insert into transaksi_beli values('" + idtb2 + "', '" + FormHome.idpembeli + "', '" + today.ToString("yyyy-MM-dd") + "', '" + bayar + "', '" + poinpake + "', '" + FormHome.tgl + "', '" + textBox1.Text + "', '" + tBoxAlamat.Text + "', 10000, '" + total + "', 'Transfer Bank', '" + total / 10 + "', 'Pending', 0)";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();

                        for (int i=0; i<jumlahmenu; i++)
                        {
                            sqlQuery = "insert into detail_beli values('"+ idtb2 +"', '"+ FormHome.idpembeli +"','"+ dtBeli.Rows[i]["ID Menu"].ToString() + "', '"+qty+"', '"+ harga2*qty +"', null, null, 0)";
                            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                            sqlConnection.Open();
                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        sqlQuery = "delete from keranjang where tanggal_kirim = '"+FormHome.tgl+"' and id_pembeli = '"+FormHome.idpembeli+"'";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();

                        this.Hide();
                        FormNota formnota = new FormNota();
                        formnota.ShowDialog();
                        this.Close();

                    }
                    else if(radioButtonCOD.Checked == true)
                    {
                        sqlQuery = "insert into transaksi_beli values('" + idtb2 + "', '" + FormHome.idpembeli + "', '" + today.ToString("yyyy-MM-dd") + "', '" + bayar + "', '" + poinpake + "', '" + FormHome.tgl + "', '" + textBox1.Text + "', '" + tBoxAlamat.Text + "', 10000, '" + total + "', 'COD', '" + total / 10 + "', 'Pending', 0)";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();

                        for (int i = 0; i < jumlahmenu; i++)
                        {
                            sqlQuery = "insert into detail_beli values('" + idtb2 + "', '"+ FormHome.idpembeli +"','" + dtBeli.Rows[i]["ID Menu"].ToString() + "', '" + qty + "', '" + harga2 * qty + "', null, null, 0)";
                            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                            sqlConnection.Open();
                            sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        sqlQuery = "delete from keranjang where tanggal_kirim = '" + FormHome.tgl + "' and id_pembeli = '" + FormHome.idpembeli + "'";
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                        sqlConnection.Open();
                        sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();
                        this.Hide();
                        FormNota formnota = new FormNota();
                        formnota.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Silahkan pilih metode pembayaran terlebih dahulu!");
                        FormCheckout_Load(sender, e);
                    }

                }
                else
                {

                }
                
            }
            catch(Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonKurang_Click(object sender, EventArgs e)
        {
            try
            {
                if(poin < 100 || poin == 0)
                {
                    buttonKurang.Enabled = false;
                    buttonTambah.Enabled = true;
                }
                else
                {
                    poin -= 100;
                    buttonKurang.Enabled = true;
                    tBoxJumlah.Text = (poin).ToString();
                    poinpake = Convert.ToInt32( tBoxJumlah.Text);

                    bayar = Convert.ToInt32(dtItungan.Rows[0]["Total"]);
                    total = bayar - poinpake + 10000;
                    labelTotalBayar.Text = "Rp. " + (total).ToString();
                    labelPoinPake.Text = " - Rp. " + poinpake.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (poin >= Convert.ToInt32(labelPoin.Text))
                {
                    buttonTambah.Enabled = false;
                    buttonKurang.Enabled = true;
                }
                else
                {
                    poin += 100;
                    buttonTambah.Enabled = true;
                    buttonKurang.Enabled = true;
                    tBoxJumlah.Text = (poin).ToString();
                    poinpake = Convert.ToInt32(tBoxJumlah.Text);

                    bayar = Convert.ToInt32(dtItungan.Rows[0]["Total"]);
                    total = bayar - poinpake + 10000;
                    labelTotalBayar.Text = "Rp. " + (total).ToString();
                    labelPoinPake.Text = "- Rp. " + poinpake.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tBoxJumlah_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(poin == 0)
                {
                    buttonKurang.Enabled = false;
                    buttonTambah.Enabled = true;
                }
                else if(poin > 0 || poin < Convert.ToInt32(labelPoin.Text))
                {
                    buttonKurang.Enabled = true;
                    buttonTambah.Enabled = true;
                }
                else if(poin == Convert.ToInt32(labelPoin.Text))
                {
                    buttonTambah.Enabled = false;
                    buttonKurang.Enabled = true;
                }
                labelTotalBayar.Text = "Rp. " + (bayar - poinpake + 10000).ToString();
                labelPoinPake.Text = "- Rp. " + poinpake.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelPesanan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
