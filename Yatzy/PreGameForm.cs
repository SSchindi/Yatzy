using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzy.Controls
{
    public partial class PreGameForm : Form
    {
        public PreGameForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            String Player1 = this.txtPlayer1.Text;
            String Player2 = this.txtPlayer2.Text;

            if (!String.IsNullOrEmpty(Player1) && !String.IsNullOrEmpty(Player2))
            {
                this.Close();

                GameForm gameForm = new GameForm(Player1, Player2);
                gameForm.Show();
            }
            else
            {
                MessageBox.Show("Name can't be empty!", "Please Enter a Name!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
