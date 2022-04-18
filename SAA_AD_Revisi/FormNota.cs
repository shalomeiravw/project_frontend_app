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
    public partial class FormNota : Form
    {
        public FormNota()
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
        string id;

        int jumlahPanel = 0;
        int jumlahmenu;
        string idtb2;
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
        private void FormNota_Load(object sender, EventArgs e)
        {
            try
            {
                if(FormComplete.idtb != null)
                {
                    id = FormComplete.idtb;
                }
                else if(FormPesanan.idtb != null)
                {
                    id = FormPesanan.idtb;
                }
                else
                {
                    id = FormCheckout.idtb2;
                }
                sqlConnection = new MySqlConnection(connectionString);
                dtNota = new DataTable();
                sqlQuery = "select id_tb as `TB`, alamat as `Alamat`, subtotal_transaksi as `Subtotal`, notes_pesan as `Notes`, cara_pembayaran as `Metode`, dapet_poin as `Poin`, ongkir as `Ongkir`, pake_poin as `Poin Pake`, total_bayar as `Total` from transaksi_beli where ID_TB = '"+id+"'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dtNota);

                idtb2 = dtNota.Rows[0]["TB"].ToString();
                tBoxAlamat.Text = dtNota.Rows[0]["Alamat"].ToString();
                lblNotes.Text = dtNota.Rows[0]["Notes"].ToString();
                lblPoin.Text = dtNota.Rows[0]["Poin"].ToString();
                lblSubtotal.Text = "Rp. " + dtNota.Rows[0]["Subtotal"].ToString();
                label19.Text = "Rp. " + dtNota.Rows[0]["Total"].ToString();
                label14.Text = "Rp. " + dtNota.Rows[0]["Subtotal"].ToString();
                label17.Text = "Rp. " + dtNota.Rows[0]["Ongkir"].ToString();
                label21.Text = " - Rp. " + dtNota.Rows[0]["Poin Pake"].ToString();
                lblMetodeBayar.Text = dtNota.Rows[0]["Metode"].ToString();

                kasipbox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void kasipbox()
        {
            dtBeli = new DataTable();
            sqlQuery = "select id_tb as `TB`, id_pembeli as `Pembeli`, nama_menu as `Menu`, foto_menu as `Foto`, harga_menu as `Harga`, quantity_beli as `Qty` from detail_beli db, menu m where db.id_menu = m.id_menu and id_pembeli = '" + FormHome.idpembeli + "' and id_tb = '" + idtb2 + "'";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormHome home = new FormHome();
                home.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
