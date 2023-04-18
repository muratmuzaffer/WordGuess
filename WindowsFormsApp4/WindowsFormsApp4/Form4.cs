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
namespace WindowsFormsApp4
{
    public partial class Form4 : Form
    {
        String connectionstring = "SERVER=localhost;DATABASE=wordguess;UID=root;PWD=Murat201907";

        private int remainingTime = 100;
        private Timer timer2 = new Timer();
        int dsayac = 0;
        int ysayac = 0;
        public static int üret()
        {
            int a = 0;
            for (int i = 0; i < 1; i++)
            {
                Random random = new Random();
                a = random.Next(2, 251);
            }
            return a;
        }
        public Form4()
        {
            InitializeComponent();
            timer2.Interval = 1000; // 1 saniye
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Start();
        }

        private void bitirbttn_click(object sender, EventArgs e)
        {
            DialogResult bitir;
            bitir = MessageBox.Show("Oyunu bitirmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (bitir == DialogResult.Yes)
            {
                Form4.ActiveForm.Close();
            }
        }

        private void atlabttn_click(object sender, EventArgs e)
        {
            kntrlbttn.Enabled = true;
            txtcevap.BackColor = Color.White;
            txtcevap.Text = "";
            txtdogru.Visible = false;
            int d = üret();
            txting.Text = d.ToString();

            using (MySqlConnection baglan = new MySqlConnection(connectionstring))
            {
                baglan.Open();

                //Sql Sorgusu
                string query = "SELECT word,kelime FROM ortaw WHERE idword = @id";
                MySqlCommand command = new MySqlCommand(query, baglan);
                command.Parameters.AddWithValue("@id", d);

                //Verileri Okuma
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string word = reader.GetString(0);
                        string kelime = reader.GetString(1);
                        txtdogru.Text = kelime;
                        txting.Text = word;
                    }
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            yanlıslbl.Text = Convert.ToString(ysayac);
            dogrulbl.Text = Convert.ToString(dsayac);
            txtdogru.Visible = false;
            Random random = new Random();
            int g = random.Next(2, 251);

            using (MySqlConnection baglan = new MySqlConnection(connectionstring))
            {
                baglan.Open();

                //Sql Sorgusu
                string query = "SELECT word,kelime FROM ortaw WHERE idword = @id";
                string querymod = "SELECT kelime FROM ortaw WHERE idword = @id";
                MySqlCommand command = new MySqlCommand(query, baglan);
                MySqlCommand qcommand = new MySqlCommand(querymod, baglan);
                qcommand.Parameters.AddWithValue("@id", 1);
                command.Parameters.AddWithValue("@id", g);

                //Verileri Okuma
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string word = reader.GetString(0);
                        string kelime = reader.GetString(1);
                        txtdogru.Text = kelime;
                        txting.Text = word;
                    }
                }
                using (MySqlDataReader sreader = qcommand.ExecuteReader())
                {
                    if (sreader.Read())
                    {
                        string kelime = sreader.GetString(0);
                        label11.Text = kelime;
                    }
                }
                baglan.Close();
            }
        }

        private void kontrolbttn_click(object sender, EventArgs e)
        {
            if (txtcevap.Text == txtdogru.Text)
            {
                dsayac++;
                dogrulbl.Text = Convert.ToString(dsayac);
                txtdogru.Visible = false;
                txtcevap.BackColor = Color.Green;
                kntrlbttn.Enabled = false;
            }
            else
            {
                ysayac++;
                yanlıslbl.Text = Convert.ToString(ysayac);
                txtcevap.BackColor = Color.Red;
                txtdogru.Visible = true;
                kntrlbttn.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                remainingTime--;
                surelbl.Text = remainingTime.ToString();
            }
            else
            {
                timer2.Stop();
                MessageBox.Show("Süre Doldu!");
                atlabttn.Enabled = false;
                kntrlbttn.Enabled = false;
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (MySqlConnection baglan1 = new MySqlConnection(connectionstring))
            {
                baglan1.Open();
                string sql = "INSERT INTO ortai (ortad,ortay) VALUES (@dogru,@yanlis)";
                MySqlCommand icommand = new MySqlCommand(sql, baglan1);
                icommand.Parameters.AddWithValue("@dogru", dogrulbl.Text);
                icommand.Parameters.AddWithValue("@yanlis", yanlıslbl.Text);
                icommand.ExecuteNonQuery();
                baglan1.Close();
            }
        }

        
    }
}
