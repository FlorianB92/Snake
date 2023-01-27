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
    public partial class GameOver_Screen : Form
    {
        public GameOver_Screen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Start().Show();
        }

        private void GameOver_Screen_Load(object sender, EventArgs e)
        {

        }
    }
}
