using System;
using System.Windows.Forms;

namespace WindowsFormsFeladat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Nev.Text) && Azonosito.Value > 0 && Nyelv.SelectedIndex > -1 && SzuletesiHely.SelectedIndex > -1)
            {
                MessageBox.Show("Sikeresen kitöltötte a kérdőívet!");
            }
            else
            {
                MessageBox.Show("Hiányos kitöltés!");
            }
        }
    }
}
