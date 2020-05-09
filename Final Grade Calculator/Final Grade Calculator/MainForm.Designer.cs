namespace Final_Grade_Calculator
{
    partial class MainForm
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
            this.quizLabel = new System.Windows.Forms.Label();
            this.quizMarkTextbox = new System.Windows.Forms.TextBox();
            this.transferTextButton = new System.Windows.Forms.Button();
            this.resetQuizMarksButton = new System.Windows.Forms.Button();
            this.multilineQuizMarkTextbox = new System.Windows.Forms.TextBox();
            this.dropCheckbox = new System.Windows.Forms.CheckBox();
            this.midtermLabel = new System.Windows.Forms.Label();
            this.midtermTextbox = new System.Windows.Forms.TextBox();
            this.calculateGradeButton = new System.Windows.Forms.Button();
            this.resetMarksButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.finaltermLabel = new System.Windows.Forms.Label();
            this.finaltermTextbox = new System.Windows.Forms.TextBox();
            this.letterGradeTextbox = new System.Windows.Forms.TextBox();
            this.percentGradeTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // quizLabel
            // 
            this.quizLabel.AutoSize = true;
            this.quizLabel.Location = new System.Drawing.Point(21, 36);
            this.quizLabel.Name = "quizLabel";
            this.quizLabel.Size = new System.Drawing.Size(58, 13);
            this.quizLabel.TabIndex = 0;
            this.quizLabel.Text = "Quiz Mark:";
            // 
            // quizMarkTextbox
            // 
            this.quizMarkTextbox.Location = new System.Drawing.Point(85, 33);
            this.quizMarkTextbox.Name = "quizMarkTextbox";
            this.quizMarkTextbox.Size = new System.Drawing.Size(58, 20);
            this.quizMarkTextbox.TabIndex = 0;
            // 
            // transferTextButton
            // 
            this.transferTextButton.Font = new System.Drawing.Font("AR DARLING", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferTextButton.Location = new System.Drawing.Point(149, 24);
            this.transferTextButton.Name = "transferTextButton";
            this.transferTextButton.Size = new System.Drawing.Size(54, 31);
            this.transferTextButton.TabIndex = 1;
            this.transferTextButton.Text = "→";
            this.transferTextButton.UseVisualStyleBackColor = true;
            this.transferTextButton.Click += new System.EventHandler(this.transferTextButton_Click);
            // 
            // resetQuizMarksButton
            // 
            this.resetQuizMarksButton.Location = new System.Drawing.Point(24, 61);
            this.resetQuizMarksButton.Name = "resetQuizMarksButton";
            this.resetQuizMarksButton.Size = new System.Drawing.Size(179, 23);
            this.resetQuizMarksButton.TabIndex = 2;
            this.resetQuizMarksButton.TabStop = false;
            this.resetQuizMarksButton.Text = "&Reset Quiz Marks";
            this.resetQuizMarksButton.UseVisualStyleBackColor = true;
            this.resetQuizMarksButton.Click += new System.EventHandler(this.resetQuizMarksButton_Click);
            // 
            // multilineQuizMarkTextbox
            // 
            this.multilineQuizMarkTextbox.Location = new System.Drawing.Point(223, 24);
            this.multilineQuizMarkTextbox.Multiline = true;
            this.multilineQuizMarkTextbox.Name = "multilineQuizMarkTextbox";
            this.multilineQuizMarkTextbox.ReadOnly = true;
            this.multilineQuizMarkTextbox.Size = new System.Drawing.Size(100, 177);
            this.multilineQuizMarkTextbox.TabIndex = 3;
            this.multilineQuizMarkTextbox.TabStop = false;
            // 
            // dropCheckbox
            // 
            this.dropCheckbox.Location = new System.Drawing.Point(193, 207);
            this.dropCheckbox.Name = "dropCheckbox";
            this.dropCheckbox.Size = new System.Drawing.Size(180, 20);
            this.dropCheckbox.TabIndex = 2;
            this.dropCheckbox.Text = "Drop lowest and highest Quizzes";
            this.dropCheckbox.UseVisualStyleBackColor = true;
            this.dropCheckbox.CheckedChanged += new System.EventHandler(this.dropCheckbox_CheckedChanged);
            // 
            // midtermLabel
            // 
            this.midtermLabel.AutoSize = true;
            this.midtermLabel.Location = new System.Drawing.Point(190, 236);
            this.midtermLabel.Name = "midtermLabel";
            this.midtermLabel.Size = new System.Drawing.Size(77, 13);
            this.midtermLabel.TabIndex = 5;
            this.midtermLabel.Text = "Mid-term Mark:";
            // 
            // midtermTextbox
            // 
            this.midtermTextbox.Location = new System.Drawing.Point(273, 233);
            this.midtermTextbox.Name = "midtermTextbox";
            this.midtermTextbox.Size = new System.Drawing.Size(50, 20);
            this.midtermTextbox.TabIndex = 3;
            this.midtermTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculateGradeButton
            // 
            this.calculateGradeButton.Location = new System.Drawing.Point(85, 301);
            this.calculateGradeButton.Name = "calculateGradeButton";
            this.calculateGradeButton.Size = new System.Drawing.Size(146, 23);
            this.calculateGradeButton.TabIndex = 5;
            this.calculateGradeButton.Text = "&Calculate Grade";
            this.calculateGradeButton.UseVisualStyleBackColor = true;
            this.calculateGradeButton.Click += new System.EventHandler(this.calculateGradeButton_Click);
            // 
            // resetMarksButton
            // 
            this.resetMarksButton.Location = new System.Drawing.Point(85, 330);
            this.resetMarksButton.Name = "resetMarksButton";
            this.resetMarksButton.Size = new System.Drawing.Size(146, 23);
            this.resetMarksButton.TabIndex = 6;
            this.resetMarksButton.Text = "Reset &All Marks";
            this.resetMarksButton.UseVisualStyleBackColor = true;
            this.resetMarksButton.Click += new System.EventHandler(this.resetMarksButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(85, 359);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(146, 23);
            this.quitButton.TabIndex = 2;
            this.quitButton.TabStop = false;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // finaltermLabel
            // 
            this.finaltermLabel.AutoSize = true;
            this.finaltermLabel.Location = new System.Drawing.Point(190, 262);
            this.finaltermLabel.Name = "finaltermLabel";
            this.finaltermLabel.Size = new System.Drawing.Size(82, 13);
            this.finaltermLabel.TabIndex = 5;
            this.finaltermLabel.Text = "Final-term Mark:";
            // 
            // finaltermTextbox
            // 
            this.finaltermTextbox.Location = new System.Drawing.Point(273, 259);
            this.finaltermTextbox.Name = "finaltermTextbox";
            this.finaltermTextbox.Size = new System.Drawing.Size(50, 20);
            this.finaltermTextbox.TabIndex = 4;
            this.finaltermTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // letterGradeTextbox
            // 
            this.letterGradeTextbox.Location = new System.Drawing.Point(238, 303);
            this.letterGradeTextbox.Name = "letterGradeTextbox";
            this.letterGradeTextbox.ReadOnly = true;
            this.letterGradeTextbox.Size = new System.Drawing.Size(38, 20);
            this.letterGradeTextbox.TabIndex = 7;
            this.letterGradeTextbox.TabStop = false;
            this.letterGradeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // percentGradeTextbox
            // 
            this.percentGradeTextbox.Location = new System.Drawing.Point(282, 303);
            this.percentGradeTextbox.Name = "percentGradeTextbox";
            this.percentGradeTextbox.ReadOnly = true;
            this.percentGradeTextbox.Size = new System.Drawing.Size(38, 20);
            this.percentGradeTextbox.TabIndex = 7;
            this.percentGradeTextbox.TabStop = false;
            this.percentGradeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 407);
            this.Controls.Add(this.percentGradeTextbox);
            this.Controls.Add(this.letterGradeTextbox);
            this.Controls.Add(this.finaltermTextbox);
            this.Controls.Add(this.midtermTextbox);
            this.Controls.Add(this.finaltermLabel);
            this.Controls.Add(this.midtermLabel);
            this.Controls.Add(this.dropCheckbox);
            this.Controls.Add(this.multilineQuizMarkTextbox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.resetMarksButton);
            this.Controls.Add(this.calculateGradeButton);
            this.Controls.Add(this.resetQuizMarksButton);
            this.Controls.Add(this.transferTextButton);
            this.Controls.Add(this.quizMarkTextbox);
            this.Controls.Add(this.quizLabel);
            this.Name = "MainForm";
            this.Text = "Final Grade Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quizLabel;
        private System.Windows.Forms.TextBox quizMarkTextbox;
        private System.Windows.Forms.Button transferTextButton;
        private System.Windows.Forms.Button resetQuizMarksButton;
        private System.Windows.Forms.TextBox multilineQuizMarkTextbox;
        private System.Windows.Forms.CheckBox dropCheckbox;
        private System.Windows.Forms.Label midtermLabel;
        private System.Windows.Forms.TextBox midtermTextbox;
        private System.Windows.Forms.Button calculateGradeButton;
        private System.Windows.Forms.Button resetMarksButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label finaltermLabel;
        private System.Windows.Forms.TextBox finaltermTextbox;
        private System.Windows.Forms.TextBox letterGradeTextbox;
        private System.Windows.Forms.TextBox percentGradeTextbox;
    }
}

