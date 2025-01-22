namespace WebScrape2025
{
    partial class ScraperScreen
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
            this.HomeButton = new System.Windows.Forms.Button();
            this.OrganizationButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.WordButton = new System.Windows.Forms.Button();
            this.DocButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Gold;
            this.HomeButton.Location = new System.Drawing.Point(310, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(42, 56);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "button1";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // OrganizationButton
            // 
            this.OrganizationButton.BackColor = System.Drawing.Color.Gold;
            this.OrganizationButton.Location = new System.Drawing.Point(310, 177);
            this.OrganizationButton.Name = "OrganizationButton";
            this.OrganizationButton.Size = new System.Drawing.Size(42, 116);
            this.OrganizationButton.TabIndex = 3;
            this.OrganizationButton.Text = "button4";
            this.OrganizationButton.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Gold;
            this.SaveButton.Location = new System.Drawing.Point(310, 294);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(42, 74);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "button5";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // WordButton
            // 
            this.WordButton.BackColor = System.Drawing.Color.Gold;
            this.WordButton.Location = new System.Drawing.Point(310, 54);
            this.WordButton.Name = "WordButton";
            this.WordButton.Size = new System.Drawing.Size(42, 60);
            this.WordButton.TabIndex = 6;
            this.WordButton.Text = "button2";
            this.WordButton.UseVisualStyleBackColor = false;
            // 
            // DocButton
            // 
            this.DocButton.BackColor = System.Drawing.Color.Gold;
            this.DocButton.Location = new System.Drawing.Point(310, 113);
            this.DocButton.Name = "DocButton";
            this.DocButton.Size = new System.Drawing.Size(42, 65);
            this.DocButton.TabIndex = 7;
            this.DocButton.Text = "button3";
            this.DocButton.UseVisualStyleBackColor = false;
            // 
            // DownloadButton
            // 
            this.DownloadButton.BackColor = System.Drawing.Color.Gold;
            this.DownloadButton.Location = new System.Drawing.Point(310, 367);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(42, 84);
            this.DownloadButton.TabIndex = 8;
            this.DownloadButton.Text = "button6";
            this.DownloadButton.UseVisualStyleBackColor = false;
            // 
            // ScraperScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.DocButton);
            this.Controls.Add(this.WordButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OrganizationButton);
            this.Controls.Add(this.HomeButton);
            this.Name = "ScraperScreen";
            this.Text = "ScraperScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button OrganizationButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button WordButton;
        private System.Windows.Forms.Button DocButton;
        private System.Windows.Forms.Button DownloadButton;
    }
}