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
    public partial class Form6 : Form
    {
        String connectionstring = "SERVER=localhost;DATABASE=wordguess;UID=root;PWD=Murat201907";
        private int zord, zory = 0;
        private int ortad, ortay = 0;
        private int kolayd, kolayy = 0;
        int toplamd;
        int toplamy;
        float toplamdy;
        float c;

        private void btngeri_Click(object sender, EventArgs e)
        {
            
            Form6.ActiveForm.Close();
        }

        private void btnsıfırla_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan5 = new MySqlConnection(connectionstring))
            {
                baglan5.Open();

                //Sql Sorgusu
                string query = "delete from  wordguess.kolayi where kolayid != 1";
                MySqlCommand command = new MySqlCommand(query, baglan5);
                command.ExecuteNonQuery();
                baglan5.Close();
                
            }
            using (MySqlConnection baglan6 = new MySqlConnection(connectionstring))
            {
                baglan6.Open();

                //Sql Sorgusu
                string query = "delete from  wordguess.ortai where ortaid != 1";
                MySqlCommand command = new MySqlCommand(query, baglan6);
                command.ExecuteNonQuery();
                baglan6.Close();
                
            }
            using (MySqlConnection baglan7 = new MySqlConnection(connectionstring))
            {
                baglan7.Open();

                //Sql Sorgusu
                string query = "delete from  wordguess.zori where zorid != 1";
                MySqlCommand command = new MySqlCommand(query, baglan7);
                command.ExecuteNonQuery();
                baglan7.Close();


            }
            this.Close();
            Form6 form = new Form6();
            form.Show();
        }

        float ortalama;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            using (MySqlConnection baglan1 = new MySqlConnection(connectionstring))
            {
                baglan1.Open();

                //Sql Sorgusu
                string query = "SELECT SUM(CAST(kolayd AS UNSIGNED)) AS Toplamd,SUM(CAST(kolayy AS UNSIGNED)) AS Toplamy FROM wordguess.kolayi";
                MySqlCommand command = new MySqlCommand(query, baglan1);


                //Verileri Okuma
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Toplamd = reader.GetString(0);
                        string Toplamy = reader.GetString(1);
                        lblkd2.Text = Toplamd;
                        lblky2.Text = Toplamy;
                        kolayd = Convert.ToInt32(lblkd2.Text);
                        kolayy = Convert.ToInt32(lblky2.Text);
                    }
                }
            }
            using (MySqlConnection baglan2 = new MySqlConnection(connectionstring))
            {
                baglan2.Open();

                //Sql Sorgusu
                string query = "SELECT SUM(CAST(ortad AS UNSIGNED)) AS Toplamd,SUM(CAST(ortay AS UNSIGNED)) AS Toplamy FROM wordguess.ortai";
                MySqlCommand command = new MySqlCommand(query, baglan2);


                //Verileri Okuma
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Toplamd = reader.GetString(0);
                        string Toplamy = reader.GetString(1);
                        lblod2.Text = Toplamd;
                        lbloy2.Text = Toplamy;
                        ortad = Convert.ToInt32(lblod2.Text);
                        ortay = Convert.ToInt32(lbloy2.Text);

                    }
                }
            }
            using (MySqlConnection baglan3 = new MySqlConnection(connectionstring))
            {
                baglan3.Open();

                //Sql Sorgusu
                string query = "SELECT SUM(CAST(zord AS UNSIGNED)) AS Toplamd,SUM(CAST(zory AS UNSIGNED)) AS Toplamy FROM wordguess.zori;";
                MySqlCommand command = new MySqlCommand(query, baglan3);


                //Verileri Okuma
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Toplamd = reader.GetString(0);
                        string Toplamy = reader.GetString(1);
                        lblzd2.Text = Toplamd;
                        lblzy2.Text = Toplamy;
                        zord = Convert.ToInt32(lblzd2.Text);
                        zory = Convert.ToInt32(lblzy2.Text);
                    }
                }
            }

            toplamd = kolayd + ortad + zord;
            toplamy = kolayy + ortay + zory;
            toplamdy = toplamd + toplamy;
            if (toplamdy > 0)
            {
                c = 100 / toplamdy;
                ortalama = (c * toplamd) / (c * toplamdy);
            }
            else if (toplamdy > 100)
            {
                c = 1000 / toplamdy;
                ortalama = (c * toplamd) / (c * toplamdy);
            }
            else if (toplamdy > 1000)
            {
                c = 10000 / toplamdy;
                ortalama = (c * toplamd) / (c * toplamdy);
            }
            
            int f = (int)Math.Round((ortalama - (double)(int)ortalama) * 100);
            if (f == 0) {
                progressBar1.Value = 0;
                lbly.Text = "%" + 0;

            } else { 

                progressBar1.Value = f; 
                lbly.Text = "%" + f.ToString();
            }
        }
    }
}
