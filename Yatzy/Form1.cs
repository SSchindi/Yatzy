using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yatzy.Controls;

namespace Yatzy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            PreGameForm preGameForm = new PreGameForm();
            preGameForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHighscore_Click(object sender, EventArgs e)
        {
            HighScoreForm highScoreForm = new HighScoreForm();
            highScoreForm.Show();
        }
    }
}
