using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanhosMae
{
    public partial class HelpBox : Form
    {
        public HelpBox()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            HelpBox FormAjuda = new HelpBox();
            this.Close();
        }

        private void HelpBox_Load(object sender, EventArgs e)
        {
            string Helptxt = System.IO.File.ReadAllText(@"Ajuda.txt");
            //HelpText1.Text = {0}, Helptxt;
            HelpText1.Text = Helptxt;
            //webBAd.Url = new Uri(@"Anuncio.html");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://faucetpay.io/?r=526619");
        }
    }
}
