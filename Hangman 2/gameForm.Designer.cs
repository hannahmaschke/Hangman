namespace Hangman_2
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.gameFormLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.hangmanPictureBox = new System.Windows.Forms.PictureBox();
            this.letterTextbox = new System.Windows.Forms.TextBox();
            this.enterLetterTextbox = new System.Windows.Forms.Label();
            this.guessesLabel = new System.Windows.Forms.Label();
            this.guessesTextbox = new System.Windows.Forms.TextBox();
            this.debugLabel = new System.Windows.Forms.Label();
            this.letterHolderPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameFormLabel
            // 
            this.gameFormLabel.AutoSize = true;
            this.gameFormLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameFormLabel.ForeColor = System.Drawing.Color.Black;
            this.gameFormLabel.Location = new System.Drawing.Point(229, 40);
            this.gameFormLabel.Name = "gameFormLabel";
            this.gameFormLabel.Size = new System.Drawing.Size(517, 32);
            this.gameFormLabel.TabIndex = 0;
            this.gameFormLabel.Text = "Guess the letters in the chosen word!";
            this.gameFormLabel.Click += new System.EventHandler(this.gameFormLabel_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 613);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(139, 39);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // hangmanPictureBox
            // 
            this.hangmanPictureBox.Image = global::Hangman_2.Properties.Resources.hangman1;
            this.hangmanPictureBox.InitialImage = global::Hangman_2.Properties.Resources.hangman1;
            this.hangmanPictureBox.Location = new System.Drawing.Point(331, 202);
            this.hangmanPictureBox.Name = "hangmanPictureBox";
            this.hangmanPictureBox.Size = new System.Drawing.Size(347, 310);
            this.hangmanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hangmanPictureBox.TabIndex = 2;
            this.hangmanPictureBox.TabStop = false;
            this.hangmanPictureBox.Click += new System.EventHandler(this.hangmanPictureBox_Click);
            // 
            // letterTextbox
            // 
            this.letterTextbox.Location = new System.Drawing.Point(694, 301);
            this.letterTextbox.MaxLength = 1;
            this.letterTextbox.Name = "letterTextbox";
            this.letterTextbox.Size = new System.Drawing.Size(182, 26);
            this.letterTextbox.TabIndex = 3;
            // 
            // enterLetterTextbox
            // 
            this.enterLetterTextbox.AutoSize = true;
            this.enterLetterTextbox.BackColor = System.Drawing.Color.Transparent;
            this.enterLetterTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLetterTextbox.Location = new System.Drawing.Point(725, 273);
            this.enterLetterTextbox.Name = "enterLetterTextbox";
            this.enterLetterTextbox.Size = new System.Drawing.Size(127, 25);
            this.enterLetterTextbox.TabIndex = 4;
            this.enterLetterTextbox.Text = "Enter a letter:";
            // 
            // guessesLabel
            // 
            this.guessesLabel.AutoSize = true;
            this.guessesLabel.BackColor = System.Drawing.Color.Transparent;
            this.guessesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessesLabel.Location = new System.Drawing.Point(689, 373);
            this.guessesLabel.Name = "guessesLabel";
            this.guessesLabel.Size = new System.Drawing.Size(242, 25);
            this.guessesLabel.TabIndex = 7;
            this.guessesLabel.Text = "Letters you have guessed:";
            // 
            // guessesTextbox
            // 
            this.guessesTextbox.Location = new System.Drawing.Point(694, 398);
            this.guessesTextbox.Name = "guessesTextbox";
            this.guessesTextbox.ReadOnly = true;
            this.guessesTextbox.Size = new System.Drawing.Size(201, 26);
            this.guessesTextbox.TabIndex = 9;
            this.guessesTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(108, 222);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(0, 20);
            this.debugLabel.TabIndex = 10;
            // 
            // letterHolderPanel
            // 
            this.letterHolderPanel.BackColor = System.Drawing.Color.Transparent;
            this.letterHolderPanel.Location = new System.Drawing.Point(278, 558);
            this.letterHolderPanel.Name = "letterHolderPanel";
            this.letterHolderPanel.Size = new System.Drawing.Size(454, 85);
            this.letterHolderPanel.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(882, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Enter letter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(704, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 13;
            // 
            // GameForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hangman_2.Properties.Resources.grassTheme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.letterHolderPanel);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.guessesTextbox);
            this.Controls.Add(this.guessesLabel);
            this.Controls.Add(this.enterLetterTextbox);
            this.Controls.Add(this.letterTextbox);
            this.Controls.Add(this.hangmanPictureBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.gameFormLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gameForm_FormClosing);
            this.Load += new System.EventHandler(this.gameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameFormLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox hangmanPictureBox;
        private System.Windows.Forms.TextBox letterTextbox;
        private System.Windows.Forms.Label enterLetterTextbox;
        private System.Windows.Forms.Label guessesLabel;
        private System.Windows.Forms.TextBox guessesTextbox;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Panel letterHolderPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}