namespace WebScrape2025
{
    partial class Customization
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
            this.homeBttn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.keywordTxtbox = new System.Windows.Forms.TextBox();
            this.linksCbox = new System.Windows.Forms.CheckBox();
            this.quotesCbox = new System.Windows.Forms.CheckBox();
            this.statsCbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.titleCbox = new System.Windows.Forms.CheckBox();
            this.dateCbox = new System.Windows.Forms.CheckBox();
            this.sourceCbox = new System.Windows.Forms.CheckBox();
            this.paragraphCbox = new System.Windows.Forms.CheckBox();
            this.listCbox = new System.Windows.Forms.CheckBox();
            this.saveBttn = new System.Windows.Forms.Button();
            this.imageCbox = new System.Windows.Forms.CheckBox();
            this.txtCbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(93, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "CUSTOMIZATION";
            // 
            // homeBttn
            // 
            this.homeBttn.BackColor = System.Drawing.Color.Orange;
            this.homeBttn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBttn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.homeBttn.Location = new System.Drawing.Point(175, 502);
            this.homeBttn.Margin = new System.Windows.Forms.Padding(4);
            this.homeBttn.Name = "homeBttn";
            this.homeBttn.Size = new System.Drawing.Size(151, 37);
            this.homeBttn.TabIndex = 2;
            this.homeBttn.Text = "HOME";
            this.homeBttn.UseVisualStyleBackColor = false;
            this.homeBttn.Click += new System.EventHandler(this.homeBttn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Enabled = false;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(51, 74);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(363, 421);
            this.button2.TabIndex = 3;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(65, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Scrape: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(69, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Specific Keywords (separated by commas):";
            // 
            // keywordTxtbox
            // 
            this.keywordTxtbox.Location = new System.Drawing.Point(69, 164);
            this.keywordTxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.keywordTxtbox.Name = "keywordTxtbox";
            this.keywordTxtbox.Size = new System.Drawing.Size(329, 22);
            this.keywordTxtbox.TabIndex = 7;
            // 
            // linksCbox
            // 
            this.linksCbox.AutoSize = true;
            this.linksCbox.BackColor = System.Drawing.Color.Gold;
            this.linksCbox.Checked = global::WebScrape2025.Properties.Settings.Default.linksCboxState;
            this.linksCbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WebScrape2025.Properties.Settings.Default, "linksCboxState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.linksCbox.Location = new System.Drawing.Point(235, 209);
            this.linksCbox.Margin = new System.Windows.Forms.Padding(4);
            this.linksCbox.Name = "linksCbox";
            this.linksCbox.Size = new System.Drawing.Size(60, 20);
            this.linksCbox.TabIndex = 9;
            this.linksCbox.Text = "Links";
            this.linksCbox.UseVisualStyleBackColor = false;
            this.linksCbox.CheckedChanged += new System.EventHandler(this.linksCbox_CheckedChanged);
            // 
            // quotesCbox
            // 
            this.quotesCbox.AutoSize = true;
            this.quotesCbox.BackColor = System.Drawing.Color.Gold;
            this.quotesCbox.Location = new System.Drawing.Point(69, 250);
            this.quotesCbox.Margin = new System.Windows.Forms.Padding(4);
            this.quotesCbox.Name = "quotesCbox";
            this.quotesCbox.Size = new System.Drawing.Size(72, 20);
            this.quotesCbox.TabIndex = 10;
            this.quotesCbox.Text = "Quotes";
            this.quotesCbox.UseVisualStyleBackColor = false;
            this.quotesCbox.CheckedChanged += new System.EventHandler(this.quotesCbox_CheckedChanged);
            // 
            // statsCbox
            // 
            this.statsCbox.AutoSize = true;
            this.statsCbox.BackColor = System.Drawing.Color.Gold;
            this.statsCbox.Location = new System.Drawing.Point(235, 250);
            this.statsCbox.Margin = new System.Windows.Forms.Padding(4);
            this.statsCbox.Name = "statsCbox";
            this.statsCbox.Size = new System.Drawing.Size(82, 20);
            this.statsCbox.TabIndex = 11;
            this.statsCbox.Text = "Statistics";
            this.statsCbox.UseVisualStyleBackColor = false;
            this.statsCbox.CheckedChanged += new System.EventHandler(this.statsCbox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(65, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Organize:";
            // 
            // titleCbox
            // 
            this.titleCbox.AutoSize = true;
            this.titleCbox.BackColor = System.Drawing.Color.Gold;
            this.titleCbox.Location = new System.Drawing.Point(69, 353);
            this.titleCbox.Margin = new System.Windows.Forms.Padding(4);
            this.titleCbox.Name = "titleCbox";
            this.titleCbox.Size = new System.Drawing.Size(94, 20);
            this.titleCbox.TabIndex = 13;
            this.titleCbox.Text = "Topic/Title";
            this.titleCbox.UseVisualStyleBackColor = false;
            this.titleCbox.CheckedChanged += new System.EventHandler(this.titleCbox_CheckedChanged);
            // 
            // dateCbox
            // 
            this.dateCbox.AutoSize = true;
            this.dateCbox.BackColor = System.Drawing.Color.Gold;
            this.dateCbox.Location = new System.Drawing.Point(197, 353);
            this.dateCbox.Margin = new System.Windows.Forms.Padding(4);
            this.dateCbox.Name = "dateCbox";
            this.dateCbox.Size = new System.Drawing.Size(58, 20);
            this.dateCbox.TabIndex = 14;
            this.dateCbox.Text = "Date";
            this.dateCbox.UseVisualStyleBackColor = false;
            this.dateCbox.CheckedChanged += new System.EventHandler(this.dateCbox_CheckedChanged);
            // 
            // sourceCbox
            // 
            this.sourceCbox.AutoSize = true;
            this.sourceCbox.BackColor = System.Drawing.Color.Gold;
            this.sourceCbox.Location = new System.Drawing.Point(285, 353);
            this.sourceCbox.Margin = new System.Windows.Forms.Padding(4);
            this.sourceCbox.Name = "sourceCbox";
            this.sourceCbox.Size = new System.Drawing.Size(72, 20);
            this.sourceCbox.TabIndex = 15;
            this.sourceCbox.Text = "Source";
            this.sourceCbox.UseVisualStyleBackColor = false;
            this.sourceCbox.CheckedChanged += new System.EventHandler(this.sourceCbox_CheckedChanged);
            // 
            // paragraphCbox
            // 
            this.paragraphCbox.AutoSize = true;
            this.paragraphCbox.BackColor = System.Drawing.Color.Gold;
            this.paragraphCbox.Location = new System.Drawing.Point(69, 394);
            this.paragraphCbox.Margin = new System.Windows.Forms.Padding(4);
            this.paragraphCbox.Name = "paragraphCbox";
            this.paragraphCbox.Size = new System.Drawing.Size(191, 20);
            this.paragraphCbox.TabIndex = 16;
            this.paragraphCbox.Text = "Paragraph by Content View";
            this.paragraphCbox.UseVisualStyleBackColor = false;
            this.paragraphCbox.CheckedChanged += new System.EventHandler(this.paragraphCbox_CheckedChanged);
            // 
            // listCbox
            // 
            this.listCbox.AutoSize = true;
            this.listCbox.BackColor = System.Drawing.Color.Gold;
            this.listCbox.Location = new System.Drawing.Point(69, 433);
            this.listCbox.Margin = new System.Windows.Forms.Padding(4);
            this.listCbox.Name = "listCbox";
            this.listCbox.Size = new System.Drawing.Size(81, 20);
            this.listCbox.TabIndex = 17;
            this.listCbox.Text = "List View";
            this.listCbox.UseVisualStyleBackColor = false;
            this.listCbox.CheckedChanged += new System.EventHandler(this.listCbox_CheckedChanged);
            // 
            // saveBttn
            // 
            this.saveBttn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.saveBttn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveBttn.FlatAppearance.BorderSize = 2;
            this.saveBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBttn.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBttn.ForeColor = System.Drawing.Color.Gold;
            this.saveBttn.Location = new System.Drawing.Point(249, 443);
            this.saveBttn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(151, 40);
            this.saveBttn.TabIndex = 18;
            this.saveBttn.Text = "SAVE";
            this.saveBttn.UseVisualStyleBackColor = false;
            this.saveBttn.Click += new System.EventHandler(this.saveBttn_Click);
            // 
            // imageCbox
            // 
            this.imageCbox.AutoSize = true;
            this.imageCbox.BackColor = System.Drawing.Color.Gold;
            this.imageCbox.Checked = global::WebScrape2025.Properties.Settings.Default.imageCboxState;
            this.imageCbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WebScrape2025.Properties.Settings.Default, "imageCboxState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.imageCbox.Location = new System.Drawing.Point(69, 209);
            this.imageCbox.Margin = new System.Windows.Forms.Padding(4);
            this.imageCbox.Name = "imageCbox";
            this.imageCbox.Size = new System.Drawing.Size(74, 20);
            this.imageCbox.TabIndex = 8;
            this.imageCbox.Text = "Images";
            this.imageCbox.UseVisualStyleBackColor = false;
            this.imageCbox.CheckedChanged += new System.EventHandler(this.imageCbox_CheckedChanged);
            // 
            // txtCbox
            // 
            this.txtCbox.AutoSize = true;
            this.txtCbox.BackColor = System.Drawing.Color.Gold;
            this.txtCbox.Checked = global::WebScrape2025.Properties.Settings.Default.txtCboxState;
            this.txtCbox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WebScrape2025.Properties.Settings.Default, "txtCboxState", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCbox.Location = new System.Drawing.Point(69, 107);
            this.txtCbox.Margin = new System.Windows.Forms.Padding(4);
            this.txtCbox.Name = "txtCbox";
            this.txtCbox.Size = new System.Drawing.Size(55, 20);
            this.txtCbox.TabIndex = 5;
            this.txtCbox.Text = "Text";
            this.txtCbox.UseVisualStyleBackColor = false;
            this.txtCbox.CheckedChanged += new System.EventHandler(this.txtCbox_CheckedChanged);
            // 
            // Customization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(471, 554);
            this.Controls.Add(this.saveBttn);
            this.Controls.Add(this.listCbox);
            this.Controls.Add(this.paragraphCbox);
            this.Controls.Add(this.sourceCbox);
            this.Controls.Add(this.dateCbox);
            this.Controls.Add(this.titleCbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statsCbox);
            this.Controls.Add(this.quotesCbox);
            this.Controls.Add(this.linksCbox);
            this.Controls.Add(this.imageCbox);
            this.Controls.Add(this.keywordTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.homeBttn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customization";
            this.Text = "CustomizationScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homeBttn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox txtCbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keywordTxtbox;
        private System.Windows.Forms.CheckBox imageCbox;
        private System.Windows.Forms.CheckBox linksCbox;
        private System.Windows.Forms.CheckBox quotesCbox;
        private System.Windows.Forms.CheckBox statsCbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox titleCbox;
        private System.Windows.Forms.CheckBox dateCbox;
        private System.Windows.Forms.CheckBox sourceCbox;
        private System.Windows.Forms.CheckBox paragraphCbox;
        private System.Windows.Forms.CheckBox listCbox;
        private System.Windows.Forms.Button saveBttn;
    }
}