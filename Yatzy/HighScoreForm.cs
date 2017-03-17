using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yatzy.Model;

namespace Yatzy
{
    public partial class HighScoreForm : Form
    {
        List<User> allUser = new List<User>();
        private UserEntity _context = new UserEntity();

        public HighScoreForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            //using (UserEntity cotext = new UserEntity())
            //{
            //    allUser = cotext.User.ToList();
            //}

            //dataGridView1.DataSource = allUser;

            allUser = _context.User.ToList();

            this.dataGridView1.DataSource =
                   _context.User.Local.ToBindingList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();

            foreach (var user in _context.User.Local.ToList())
            {
                if (user == null)
                {
                    _context.User.Remove(user);
                }
            }
            this._context.SaveChanges();
            dataGridView1.Refresh();
        }
    }
}
