using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akia_MatchingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Playbtn_Click(object sender, EventArgs e)
        {
            Form2 load_screen = new Form2();
            this.Hide();
            load_screen.Show();
        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
