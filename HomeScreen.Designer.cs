using System.Windows.Forms;

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
            this.titleLabel = new System.Windows.Forms.Label();
            this.scraperBttn = new System.Windows.Forms.Button();
            this.customizationBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Gold;
            this.titleLabel.Location = new System.Drawing.Point(121, 52);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(228, 59);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "SITESCOUT";
            // 
            // scraperBttn
            // 
            this.scraperBttn.AutoSize = true;
            this.scraperBttn.BackColor = System.Drawing.Color.Gold;
            this.scraperBttn.Font = new System.Drawing.Font("Gill Sans MT", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scraperBttn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.scraperBttn.Location = new System.Drawing.Point(29, 151);
            this.scraperBttn.Margin = new System.Windows.Forms.Padding(4);
            this.scraperBttn.Name = "scraperBttn";
            this.scraperBttn.Size = new System.Drawing.Size(413, 73);
            this.scraperBttn.TabIndex = 1;
            this.scraperBttn.Text = "SCRAPER";
            this.scraperBttn.UseVisualStyleBackColor = false;
            this.scraperBttn.Click += new System.EventHandler(this.scraperBttn_Click);
            // 
            // customizationBttn
            // 
            this.customizationBttn.AutoSize = true;
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
            this.ClientSize = new System.Drawing.Size(472, 554);
            this.Controls.Add(this.customizationBttn);
            this.Controls.Add(this.scraperBttn);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button scraperBttn;
        private System.Windows.Forms.Button customizationBttn;
    }
}

