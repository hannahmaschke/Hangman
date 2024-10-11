namespace Hangman_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.changeThemeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.ForeColor = System.Drawing.Color.White;
            this.mainMenuLabel.Location = new System.Drawing.Point(252, 39);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(332, 52);
            this.mainMenuLabel.TabIndex = 0;
            this.mainMenuLabel.Text = "H A N G M A N";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(318, 173);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(186, 43);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "PLAY GAME";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(318, 296);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(186, 43);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // changeThemeButton
            // 
            this.changeThemeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.changeThemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeThemeButton.Location = new System.Drawing.Point(318, 235);
            this.changeThemeButton.Name = "changeThemeButton";
            this.changeThemeButton.Size = new System.Drawing.Size(186, 43);
            this.changeThemeButton.TabIndex = 3;
            this.changeThemeButton.Text = "CHANGE THEME";
            this.changeThemeButton.UseVisualStyleBackColor = false;
            this.changeThemeButton.Click += new System.EventHandler(this.changeThemeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeThemeButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.mainMenuLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.BackgroundImageChanged += new System.EventHandler(this.Form1_BackgroundImageChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button changeThemeButton;
    }
}

