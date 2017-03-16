using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yatzy.Controls
{
    public partial class InGameRollSystem : UserControl
    {
        public int diceCounter = 3;

        private int c1;
        private int c2;
        private int c3;
        private int c4;
        private int c5;

        private bool selectedN1 = false;
        private bool selectedN2 = false;
        private bool selectedN3 = false;
        private bool selectedN4 = false;
        private bool selectedN5 = false;

        Random rnd = new Random();

        public InGameRollSystem()
        {
            InitializeComponent();
            btnDice.Text = String.Format("Roll({0})", diceCounter);
            btnPlay.Enabled = false;
        }

        private void btnDice_Click(object sender, EventArgs e)
        {
            if(diceCounter >= 1)
            {
                CheckSelectedCubes();
                diceCounter--;
                btnDice.Text = String.Format("Roll({0})", diceCounter);
                btnPlay.Enabled = true;
            }
            else
            {
                btnDice.Enabled = false;
            }
        }

        private void CheckSelectedCubes()
        {
            List<String> cubes2Role = new List<string>();

            if (!selectedN1) cubes2Role.Add("c1");
            if (!selectedN2) cubes2Role.Add("c2");
            if (!selectedN3) cubes2Role.Add("c3");
            if (!selectedN4) cubes2Role.Add("c4");
            if (!selectedN5) cubes2Role.Add("c5");

            roleNotSelectedCubes(cubes2Role);
        }

        private void roleNotSelectedCubes(List<string> cubes2Role)
        {
            foreach(string cube in cubes2Role)
            {
                switch (cube)
                {
                    case "c1":
                        c1 = rnd.Next(1, 6);
                        break;
                    case "c2":
                        c2 = rnd.Next(1, 6);
                        break;
                    case "c3":
                        c3 = rnd.Next(1, 6);
                        break;
                    case "c4":
                        c4 = rnd.Next(1, 6);
                        break;
                    case "c5":
                        c5 = rnd.Next(1, 6);
                        break;
                }

            }

            changePicture();
        }

        private void changePicture()
        {
            cube1.Image = SetIMG(c1);
            cube2.Image = SetIMG(c2);
            cube3.Image = SetIMG(c3);
            cube4.Image = SetIMG(c4);
            cube5.Image = SetIMG(c5);
        }

        private Image SetIMG(int c1)
        {
            switch (c1)
            {
                case 1:
                    return Properties.Resources.dice_1_md;
                case 2:
                    return Properties.Resources.dice_2_md;
                case 3:
                    return Properties.Resources.dice_3_md;
                case 4:
                    return Properties.Resources.dice_4_md;
                case 5:
                    return Properties.Resources.dice_5_md;
                case 6:
                    return Properties.Resources.dice_6_md;
            }

            return Properties.Resources.dice_1_md;
        }



        #region Events
        private void cube1_Click(object sender, EventArgs e)
        {
            if (selectedN1)
            {
                //Setze selectedN1 false und ändere Background
                selectedN1 = false;
                cube1.BackColor = SystemColors.Control;
            }
            else
            {

                //Setze selectedN1 true und ändere Background
                selectedN1 = true;
                cube1.BackColor = SystemColors.ControlDark;
            }

        }
        private void cube2_Click(object sender, EventArgs e)
                {
                    if (selectedN2)
                    {
                        selectedN2 = false;
                        cube2.BackColor = SystemColors.Control;
                    }
                    else
                    {
                        selectedN2 = true;
                        cube2.BackColor = SystemColors.ControlDark;
                    }
                }
        private void cube3_Click(object sender, EventArgs e)
                {
                    if (selectedN3)
                    {
                        selectedN3 = false;
                        cube3.BackColor = SystemColors.Control;
                    }
                    else
                    {
                        selectedN3 = true;
                        cube3.BackColor = SystemColors.ControlDark;
                    }

                }
        private void cube4_Click(object sender, EventArgs e)
                {
                    if (selectedN4)
                    {
                        selectedN4 = false;
                        cube4.BackColor = SystemColors.Control;
                    }
                    else
                    {
                        selectedN4 = true;
                        cube4.BackColor = SystemColors.ControlDark;
                    }
                }
        private void cube5_Click(object sender, EventArgs e)
                {
                    if (selectedN5)
                    {
                        selectedN5 = false;
                        cube5.BackColor = SystemColors.Control;
                    }
                    else
                    {
                        selectedN5 = true;
                        cube5.BackColor = SystemColors.ControlDark;
                    }
                }
        #endregion
    }
}
