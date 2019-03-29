using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieKillerMenu
{
    public partial class Menu : Form
    {
        TheGame FrmTheGame = new TheGame();
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (FrmTheGame.ShowDialog() == DialogResult.OK)
            {
                // Clear the textboxes (Looks and feels good) 
                this.Show();
            }
        }
    }
}
