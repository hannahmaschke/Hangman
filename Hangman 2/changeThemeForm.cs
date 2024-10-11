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
    public partial class changeThemeForm : Form
    {
        RadioButton[] radioButtonOptions = new RadioButton[4];
        private Form1 form1;
        private GameForm gameForm;

        public changeThemeForm(Form1 mainMenuForm, GameForm gameForm)
        {
            InitializeComponent();
            this.form1 = mainMenuForm;
            this.gameForm = gameForm;
            radioButtonOptions[0] = radioButton1;
            radioButtonOptions[1] = radioButton2;
            radioButtonOptions[2] = radioButton3;
            radioButtonOptions[3] = radioButton4;
        }

    

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // When this radiobutton is selected, change the theme to purple
            this.BackgroundImage = Properties.Resources.purpleTheme;
            themeLabel.ForeColor = Color.White;
            exitButton.BackColor = Color.Fuchsia;

            // change main menu theme 
            form1.BackgroundImage = Properties.Resources.purpleTheme;
            gameForm.BackgroundImage = Properties.Resources.purpleTheme;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // When this radiobutton is selected, change the theme to purple
            this.BackgroundImage = Properties.Resources.redTheme;
            themeLabel.ForeColor = Color.White;
            exitButton.BackColor = Color.Red;

            // change main menu theme 
            form1.BackgroundImage = Properties.Resources.redTheme;
            gameForm.BackgroundImage= Properties.Resources.redTheme;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // When this radiobutton is selected, change the theme to purple
            this.BackgroundImage = Properties.Resources.grassTheme;
            themeLabel.ForeColor = Color.Black;
            exitButton.BackColor = Color.Cyan;

            // change main menu theme 
            form1.BackgroundImage = Properties.Resources.grassTheme;
            gameForm.BackgroundImage = Properties.Resources.grassTheme;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            // When this radiobutton is selected, change the theme to purple
            this.BackgroundImage = Properties.Resources.mountainTheme;
            themeLabel.ForeColor = Color.White;
            exitButton.BackColor = Color.Green;

            // change main menu theme 
            form1.BackgroundImage = Properties.Resources.mountainTheme;
            gameForm.BackgroundImage = Properties.Resources.mountainTheme;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
