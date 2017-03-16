using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzy
{
    public partial class GameForm : Form
    {
        private string player1;
        private string player2;
        private int activePlayer;

        public GameForm(string player1, string player2)
        {
            InitializeComponent();

            this.player1 = player1;
            this.player2 = player2;

            SetLable();

        }

        private void SetLable()
        {
            //Name Of Player1
            lblNameP1.Text = player1;
            lblNameP1_2.Text = player1;

            //Name of Player2
            lblNameP2.Text = player2;
            lblNameP2_2.Text = player2;
        }
    }
}
