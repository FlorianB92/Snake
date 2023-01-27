using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void GameStart(object sender, MouseEventArgs e)
        {
            this.Hide();
            new Game().ShowDialog();
        }

        private void ExitGame(object sender, MouseEventArgs e)
        {
            Application.ExitThread();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
