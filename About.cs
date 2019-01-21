using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class About : Form
    {
        public About()
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
