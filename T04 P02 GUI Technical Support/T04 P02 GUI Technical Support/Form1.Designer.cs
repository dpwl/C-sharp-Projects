namespace T04_P02_GUI_Technical_Support
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
            this.computerBeepCheckbox = new System.Windows.Forms.CheckBox();
            this.discSpinCheckbox = new System.Windows.Forms.CheckBox();
            this.processButton = new System.Windows.Forms.Button();
            this.solutionTextbox = new System.Windows.Forms.TextBox();
            this.quitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // computerBeepCheckbox
            // 
            this.computerBeepCheckbox.AutoSize = true;
            this.computerBeepCheckbox.Location = new System.Drawing.Point(79, 32);
            this.computerBeepCheckbox.Name = "computerBeepCheckbox";
            this.computerBeepCheckbox.Size = new System.Drawing.Size(104, 17);
            this.computerBeepCheckbox.TabIndex = 0;
            this.computerBeepCheckbox.Text = "Computer Beeps";
            this.computerBeepCheckbox.UseVisualStyleBackColor = true;
            // 
            // discSpinCheckbox
            // 
            this.discSpinCheckbox.AutoSize = true;
            this.discSpinCheckbox.Location = new System.Drawing.Point(79, 55);
            this.discSpinCheckbox.Name = "discSpinCheckbox";
            this.discSpinCheckbox.Size = new System.Drawing.Size(99, 17);
            this.discSpinCheckbox.TabIndex = 0;
            this.discSpinCheckbox.Text = "Discdrive Spins";
            this.discSpinCheckbox.UseVisualStyleBackColor = true;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(49, 87);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(148, 23);
            this.processButton.TabIndex = 1;
            this.processButton.Text = "What should I do?";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // solutionTextbox
            // 
            this.solutionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionTextbox.ForeColor = System.Drawing.Color.Red;
            this.solutionTextbox.Location = new System.Drawing.Point(49, 116);
            this.solutionTextbox.Multiline = true;
            this.solutionTextbox.Name = "solutionTextbox";
            this.solutionTextbox.ReadOnly = true;
            this.solutionTextbox.Size = new System.Drawing.Size(148, 56);
            this.solutionTextbox.TabIndex = 2;
            this.solutionTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quitbutton
            // 
            this.quitbutton.Location = new System.Drawing.Point(71, 190);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(107, 23);
            this.quitbutton.TabIndex = 1;
            this.quitbutton.Text = "Quit";
            this.quitbutton.UseVisualStyleBackColor = true;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 314);
            this.Controls.Add(this.solutionTextbox);
            this.Controls.Add(this.quitbutton);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.discSpinCheckbox);
            this.Controls.Add(this.computerBeepCheckbox);
            this.Name = "Form1";
            this.Text = "Technical Support";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox computerBeepCheckbox;
        private System.Windows.Forms.CheckBox discSpinCheckbox;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.TextBox solutionTextbox;
        private System.Windows.Forms.Button quitbutton;
    }
}

