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

namespace WindowsFormsApplication1
{
    public partial class Transaction : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource = 127.0.0.1;port=3306;username=root;password=''");

        public Transaction()
        {
            InitializeComponent();
        }

        private void garis3_Click(object sender, EventArgs e)
        {
            Garis3 garis3 = new Garis3();
            garis3.Show();
            this.Hide();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO moger.transaction(type,name,total,date,time) VALUES ('" + comboBox1.Text + "','" + textBox6.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "')";
            MySqlCommand Quer = new MySqlCommand(query, con);
            MySqlDataReader myread;
            try
            {
                con.Open();
                myread = Quer.ExecuteReader();
                MessageBox.Show("done");
                while (myread.Read()) ;

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            con.Close();
        }
    }
}
