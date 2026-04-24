namespace Assignment2
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
            this.labelUsed = new System.Windows.Forms.Label();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.buttonGuess = new System.Windows.Forms.Button();
            this.buttonInstructions = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.labelWord = new System.Windows.Forms.Label();
            this.labelLives = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUsed
            // 
            this.labelUsed.AutoSize = true;
            this.labelUsed.Location = new System.Drawing.Point(1466, 77);
            this.labelUsed.Name = "labelUsed";
            this.labelUsed.Size = new System.Drawing.Size(140, 25);
            this.labelUsed.TabIndex = 2;
            this.labelUsed.Text = "Used Letters:";
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Location = new System.Drawing.Point(940, 444);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(100, 31);
            this.textBoxGuess.TabIndex = 3;
            // 
            // buttonGuess
            // 
            this.buttonGuess.Location = new System.Drawing.Point(281, 647);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(147, 128);
            this.buttonGuess.TabIndex = 4;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonInstructions
            // 
            this.buttonInstructions.Location = new System.Drawing.Point(1471, 642);
            this.buttonInstructions.Name = "buttonInstructions";
            this.buttonInstructions.Size = new System.Drawing.Size(147, 133);
            this.buttonInstructions.TabIndex = 6;
            this.buttonInstructions.Text = "Instructions";
            this.buttonInstructions.UseVisualStyleBackColor = true;
            this.buttonInstructions.Click += new System.EventHandler(this.buttonInstructions_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(922, 645);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(147, 127);
            this.buttonNewGame.TabIndex = 7;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Location = new System.Drawing.Point(276, 77);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(78, 25);
            this.labelWord.TabIndex = 8;
            this.labelWord.Text = "_ _ _ _";
            // 
            // labelLives
            // 
            this.labelLives.AutoSize = true;
            this.labelLives.Location = new System.Drawing.Point(917, 77);
            this.labelLives.Name = "labelLives";
            this.labelLives.Size = new System.Drawing.Size(87, 25);
            this.labelLives.TabIndex = 9;
            this.labelLives.Text = "Lives: 6";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(1506, 444);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(92, 25);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1993, 1036);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelLives);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.buttonInstructions);
            this.Controls.Add(this.buttonGuess);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.labelUsed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUsed;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Button buttonInstructions;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.Label labelLives;
        private System.Windows.Forms.Label labelScore;
    }
}

