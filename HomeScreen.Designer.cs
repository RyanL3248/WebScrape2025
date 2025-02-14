namespace WebScrape2025
{
    partial class HomeScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.scraperButton = new System.Windows.Forms.Button();
            this.customizationBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(121, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "SITESCOUT";
            // 
            // scraperButton
            // 
            this.scraperButton.BackColor = System.Drawing.Color.Gold;
            this.scraperButton.Font = new System.Drawing.Font("Gill Sans MT", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scraperButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.scraperButton.Location = new System.Drawing.Point(29, 151);
            this.scraperButton.Margin = new System.Windows.Forms.Padding(4);
            this.scraperButton.Name = "scraperButton";
            this.scraperButton.Size = new System.Drawing.Size(413, 71);
            this.scraperButton.TabIndex = 1;
            this.scraperButton.Text = "SCRAPER";
            this.scraperButton.UseVisualStyleBackColor = false;
            this.scraperButton.Click += new System.EventHandler(this.scraperButton_Click);
            // 
            // customizationBttn
            // 
            this.customizationBttn.BackColor = System.Drawing.Color.Gold;
            this.customizationBttn.Font = new System.Drawing.Font("Gill Sans MT", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customizationBttn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.customizationBttn.Location = new System.Drawing.Point(29, 299);
            this.customizationBttn.Margin = new System.Windows.Forms.Padding(4);
            this.customizationBttn.Name = "customizationBttn";
            this.customizationBttn.Size = new System.Drawing.Size(413, 84);
            this.customizationBttn.TabIndex = 2;
            this.customizationBttn.Text = "CUSTOMIZATION";
            this.customizationBttn.UseVisualStyleBackColor = false;
            this.customizationBttn.Click += new System.EventHandler(this.customizationBttn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(471, 554);
            this.Controls.Add(this.customizationBttn);
            this.Controls.Add(this.scraperButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scraperButton;
        private System.Windows.Forms.Button customizationBttn;
    }
}

