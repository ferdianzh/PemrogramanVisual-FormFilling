using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekspedisi
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int control = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucHome1.Show();
            ucProfil1.Hide();
            ucPengiriman1.Hide();
            control = 1;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (control != 1)
            {
                ucHome1.Show();
                ucProfil1.Hide();
                ucPengiriman1.Hide();
                control = 1;
            }
        }

        private void profilButton_Click(object sender, EventArgs e)
        {
            if (control != 2)
            {
                ucHome1.Hide();
                ucProfil1.Show();
                ucPengiriman1.Hide();
                control = 2;
            }
        }

        private void pengirimanButton_Click(object sender, EventArgs e)
        {
            if (control != 3)
            {
                ucHome1.Hide();
                ucProfil1.Hide();
                ucPengiriman1.Show();
                control = 3;
            }
        }

        private void keluarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
