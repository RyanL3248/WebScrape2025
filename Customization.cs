using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebScrape2025
{
    public partial class Customization : Form
    {

        private HomeScreen homeScreenForm;
        public bool scpTxt;
        private bool origTxtCboxState;
        public bool scpImages;
        private bool origImgCboxState;
        public bool scpLinks;
        private bool origLinkCboxState;
        public bool scpQuotes;
        private bool origQuoteCboxState;
        public bool scpStats;
        private bool origStatCboxState;
        public bool putTitle;
        private bool origTitleCboxState;
        public bool putDate;
        private bool origDateCboxState;
        public bool putSource;
        private bool origSourceCboxState;
        public bool parOrg;
        private bool origParCboxState;
        public bool listOrg;
        private bool origListCboxState;
        public string[] keywords;
        public string[] origKeywords;
        private string pattern = @",\s*";
        private ScraperSettings settings;

        public Customization()
        {
            InitializeComponent();
            this.MinimumSize = new Size(369, 489);
        }

        public Customization(HomeScreen homeScreen, ScraperSettings settings)
        {
            InitializeComponent();
            homeScreenForm = homeScreen;

            this.Load += Customization_Load;
            this.MinimumSize = new Size(369, 489);
            this.settings = settings;
        }

        private void Customization_Load(object sender, EventArgs e)
        {
            this.txtCbox.Checked = Properties.Settings.Default.txtCboxState;
            origTxtCboxState = this.txtCbox.Checked;

            this.imageCbox.Checked = Properties.Settings.Default.imageCboxState;
            origImgCboxState = this.imageCbox.Checked;

            this.linksCbox.Checked = Properties.Settings.Default.linksCboxState;
            origLinkCboxState = this.linksCbox.Checked;

            this.quotesCbox.Checked = Properties.Settings.Default.quoteCboxState;
            origQuoteCboxState = this.quotesCbox.Checked;

            this.statsCbox.Checked = Properties.Settings.Default.statsCboxState;
            origStatCboxState = this.statsCbox.Checked;

            this.titleCbox.Checked = Properties.Settings.Default.titleCboxState;
            origTitleCboxState = this.titleCbox.Checked;

            this.dateCbox.Checked = Properties.Settings.Default.dateCboxState;
            origDateCboxState = this.dateCbox.Checked;

            this.sourceCbox.Checked = Properties.Settings.Default.sourceCboxState;
            origSourceCboxState = this.sourceCbox.Checked;

            this.paragraphCbox.Checked = Properties.Settings.Default.paragraphCboxState;
            origParCboxState = this.paragraphCbox.Checked;

            this.listCbox.Checked = Properties.Settings.Default.listCboxState;
            origListCboxState = this.listCbox.Checked;

            this.keywordTxtbox.Text = Properties.Settings.Default.keywordTxt;
            origKeywords = Regex.Split(this.keywordTxtbox.Text, @"[\s,]+");
            

        }

        private void homeBttn_Click(object sender, EventArgs e)
        {
            this.txtCbox.Checked = origTxtCboxState;
            Properties.Settings.Default.txtCboxState = origTxtCboxState;

            this.imageCbox.Checked = origImgCboxState;
            Properties.Settings.Default.imageCboxState = origImgCboxState;

            this.linksCbox.Checked = origLinkCboxState;
            Properties.Settings.Default.linksCboxState = origLinkCboxState;

            this.quotesCbox.Checked = origQuoteCboxState;
            Properties.Settings.Default.quoteCboxState = origQuoteCboxState;

            this.statsCbox.Checked = origStatCboxState;
            Properties.Settings.Default.statsCboxState = origStatCboxState;

            this.titleCbox.Checked = origTitleCboxState;
            Properties.Settings.Default.titleCboxState = origTitleCboxState;

            this.dateCbox.Checked = origDateCboxState;
            Properties.Settings.Default.dateCboxState = origDateCboxState;

            this.sourceCbox.Checked = origSourceCboxState;
            Properties.Settings.Default.sourceCboxState = origSourceCboxState;

            this.paragraphCbox.Checked = origParCboxState;
            Properties.Settings.Default.paragraphCboxState = origParCboxState;

            this.listCbox.Checked = origListCboxState;
            Properties.Settings.Default.listCboxState = origListCboxState;

            if (!(origKeywords == null))
            {
                this.keywordTxtbox.Text = string.Join(", ", origKeywords);
                Properties.Settings.Default.keywordTxt = string.Join(", ", origKeywords);
            }

            homeScreenForm.Location = this.Location;
            homeScreenForm.Show();

            this.Hide();
        }

        private void keywordTxtbox_TextChanged(object sender, EventArgs e)
        {
            keywords = Regex.Split(keywordTxtbox.Text, pattern);  
        }

        private void keywordTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != ',' && e.KeyChar != '-') 
            {
                e.Handled = true;
            }
        }

        private void txtCbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.txtCboxState = this.txtCbox.Checked;
            scpTxt = this.txtCbox.Checked;
        }

        private void imageCbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.imageCboxState = this.imageCbox.Checked;
            scpImages = this.imageCbox.Checked;
        }

        private void linksCbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.linksCboxState = this.linksCbox.Checked;
            scpLinks = this.linksCbox.Checked;
        }

        private void quotesCbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.quoteCboxState = this.quotesCbox.Checked;
            scpQuotes = this.quotesCbox.Checked;
        }

        private void statsCbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.statsCboxState = this.statsCbox.Checked;
            scpStats = this.statsCbox.Checked;
        }

        private void titleCbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.titleCboxState = this.titleCbox.Checked;
            putTitle = this.titleCbox.Checked;
        }

        private void dateCbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dateCboxState = this.dateCbox.Checked;
            putDate = this.dateCbox.Checked;
        }

        private void sourceCbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.sourceCboxState = this.sourceCbox.Checked;
            putSource = this.sourceCbox.Checked;
        }

        private void paragraphCbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.paragraphCboxState = this.paragraphCbox.Checked;
            parOrg = this.paragraphCbox.Checked;
        }

        private void listCbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.listCboxState = this.listCbox.Checked;
            listOrg = this.listCbox.Checked;
        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

            origTxtCboxState = this.txtCbox.Checked;
            this.settings.ScpText = this.txtCbox.Checked;
            origImgCboxState = this.imageCbox.Checked;
            this.settings.ScpImages = this.imageCbox.Checked;
            origLinkCboxState = this.linksCbox.Checked;
            this.settings.ScpLinks = this.linksCbox.Checked;
            origQuoteCboxState = this.quotesCbox.Checked;
            this.settings.ScpQuotes = this.quotesCbox.Checked;
            origStatCboxState = this.statsCbox.Checked;
            this.settings.ScpStats = this.statsCbox.Checked;
            origTitleCboxState = this.titleCbox.Checked;
            this.settings.PutTitle = this.titleCbox.Checked;
            origDateCboxState = this.dateCbox.Checked;
            this.settings.PutDate = this.dateCbox.Checked;
            origSourceCboxState = this.sourceCbox.Checked;
            this.settings.PutSource = this.sourceCbox.Checked;
            origParCboxState = this.paragraphCbox.Checked;
            this.settings.ParOrg = this.paragraphCbox.Checked;
            origListCboxState = this.listCbox.Checked;
            this.settings.ListOrg = this.listCbox.Checked;

            origKeywords = keywords;
            try
            {
                if (this.keywordTxtbox != null)
                {
                    this.settings.Keywords = keywords.ToList();
                }
            }
            catch (Exception ex)
            {
                   //Do nothing
            }
            //this.settings.Keywords = keywords.ToList();
        }
    }
}