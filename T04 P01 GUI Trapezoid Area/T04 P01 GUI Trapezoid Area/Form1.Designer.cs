namespace T04_P01_GUI_Trapezoid_Area
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
            this.side1LengthLabel = new System.Windows.Forms.Label();
            this.side2LengthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.side1Textbox = new System.Windows.Forms.TextBox();
            this.side2Textbox = new System.Windows.Forms.TextBox();
            this.heightTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // side1LengthLabel
            // 
            this.side1LengthLabel.AutoSize = true;
            this.side1LengthLabel.Location = new System.Drawing.Point(48, 53);
            this.side1LengthLabel.Name = "side1LengthLabel";
            this.side1LengthLabel.Size = new System.Drawing.Size(125, 13);
            this.side1LengthLabel.TabIndex = 0;
            this.side1LengthLabel.Text = "Length of Parallel Side 1:";
            this.side1LengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // side2LengthLabel
            // 
            this.side2LengthLabel.AutoSize = true;
            this.side2LengthLabel.Location = new System.Drawing.Point(51, 85);
            this.side2LengthLabel.Name = "side2LengthLabel";
            this.side2LengthLabel.Size = new System.Drawing.Size(125, 13);
            this.side2LengthLabel.TabIndex = 1;
            this.side2LengthLabel.Text = "Length of Parallel Side 2:";
            this.side2LengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(84, 121);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(89, 13);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Length of Height:";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // side1Textbox
            // 
            this.side1Textbox.Location = new System.Drawing.Point(179, 50);
            this.side1Textbox.Name = "side1Textbox";
            this.side1Textbox.Size = new System.Drawing.Size(100, 20);
            this.side1Textbox.TabIndex = 0;
            // 
            // side2Textbox
            // 
            this.side2Textbox.Location = new System.Drawing.Point(179, 82);
            this.side2Textbox.Name = "side2Textbox";
            this.side2Textbox.Size = new System.Drawing.Size(100, 20);
            this.side2Textbox.TabIndex = 1;
            // 
            // heightTextbox
            // 
            this.heightTextbox.Location = new System.Drawing.Point(179, 118);
            this.heightTextbox.Name = "heightTextbox";
            this.heightTextbox.Size = new System.Drawing.Size(100, 20);
            this.heightTextbox.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(73, 159);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(73, 188);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(100, 23);
            this.quitButton.TabIndex = 4;
            this.quitButton.TabStop = false;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.ForeColor = System.Drawing.Color.Blue;
            this.resultLabel.Location = new System.Drawing.Point(179, 162);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 49);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 278);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.heightTextbox);
            this.Controls.Add(this.side2Textbox);
            this.Controls.Add(this.side1Textbox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.side2LengthLabel);
            this.Controls.Add(this.side1LengthLabel);
            this.Name = "Form1";
            this.Text = "Trapezoid Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label side1LengthLabel;
        private System.Windows.Forms.Label side2LengthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox side1Textbox;
        private System.Windows.Forms.TextBox side2Textbox;
        private System.Windows.Forms.TextBox heightTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

