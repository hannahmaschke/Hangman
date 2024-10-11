using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_2
{
    public partial class Form1 : Form
    {
        GameForm currentGameForm = new GameForm();

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeThemeButton_Click(object sender, EventArgs e)
        {

            changeThemeForm themeForm = new changeThemeForm(this, currentGameForm);
            this.Hide();
            themeForm.ShowDialog();
            this.Show();

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            currentGameForm.Show();

        }

        private void Form1_BackgroundImageChanged(object sender, EventArgs e)
        {
           
        }
    }
}
