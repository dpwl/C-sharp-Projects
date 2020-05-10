namespace T05_P03_GUI_Array_Search
{
    partial class mainForm
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
            this.randomNumberListLabel = new System.Windows.Forms.Label();
            this.randomNumberTextbox = new System.Windows.Forms.TextBox();
            this.valueSearchLabel = new System.Windows.Forms.Label();
            this.valueSearchTextbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randomNumberListLabel
            // 
            this.randomNumberListLabel.AutoSize = true;
            this.randomNumberListLabel.Location = new System.Drawing.Point(43, 42);
            this.randomNumberListLabel.Name = "randomNumberListLabel";
            this.randomNumberListLabel.Size = new System.Drawing.Size(112, 13);
            this.randomNumberListLabel.TabIndex = 0;
            this.randomNumberListLabel.Text = "Random Number List: ";
            // 
            // randomNumberTextbox
            // 
            this.randomNumberTextbox.Location = new System.Drawing.Point(161, 39);
            this.randomNumberTextbox.Name = "randomNumberTextbox";
            this.randomNumberTextbox.ReadOnly = true;
            this.randomNumberTextbox.Size = new System.Drawing.Size(519, 20);
            this.randomNumberTextbox.TabIndex = 1;
            // 
            // valueSearchLabel
            // 
            this.valueSearchLabel.Location = new System.Drawing.Point(43, 87);
            this.valueSearchLabel.Name = "valueSearchLabel";
            this.valueSearchLabel.Size = new System.Drawing.Size(112, 13);
            this.valueSearchLabel.TabIndex = 0;
            this.valueSearchLabel.Text = "Value to Search For:";
            // 
            // valueSearchTextbox
            // 
            this.valueSearchTextbox.Location = new System.Drawing.Point(161, 84);
            this.valueSearchTextbox.Name = "valueSearchTextbox";
            this.valueSearchTextbox.Size = new System.Drawing.Size(54, 20);
            this.valueSearchTextbox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(240, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(339, 87);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(0, 13);
            this.searchResultLabel.TabIndex = 0;
            this.searchResultLabel.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 130);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.valueSearchTextbox);
            this.Controls.Add(this.randomNumberTextbox);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.valueSearchLabel);
            this.Controls.Add(this.randomNumberListLabel);
            this.Name = "mainForm";
            this.Text = "Searching an Array GUI Application";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label randomNumberListLabel;
        private System.Windows.Forms.TextBox randomNumberTextbox;
        private System.Windows.Forms.Label valueSearchLabel;
        private System.Windows.Forms.TextBox valueSearchTextbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchResultLabel;
    }
}

