﻿using System;
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
    public partial class MainMenu : Form
    {
        MySqlConnection con = new MySqlConnection(@"datasource = 127.0.0.1;port=3306;username=root;password=''");

        public MainMenu()
        {
            InitializeComponent();
        }

        private void garis3_Click(object sender, EventArgs e)
        {
            Garis3 garis3 = new Garis3();
            garis3.Show();
            this.Hide();
        }
    }
}
