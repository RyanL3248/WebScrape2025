using System;
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
        public bool parOrg;
        public bool listOrg;

        public Customization()
        {
            InitializeComponent();
            this.MinimumSize = new Size(369, 489);
        }

        public Customization(HomeScreen homeScreen)
        {
            InitializeComponent();
            homeScreenForm = homeScreen;

           this.Load += Customization_Load;
           this.FormClosing += Customization_FormClosing;
           this.MinimumSize = new Size(369, 489);
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
          
        }
        private void Customization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.txtCboxState = origTxtCboxState;
            Properties.Settings.Default.imageCboxState = origImgCboxState;
            Properties.Settings.Default.linksCboxState = origLinkCboxState;
            Properties.Settings.Default.quoteCboxState = origQuoteCboxState;
            Properties.Settings.Default.statsCboxState = origStatCboxState;
            Properties.Settings.Default.titleCboxState = origTitleCboxState;
            Properties.Settings.Default.dateCboxState = origDateCboxState;
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

            homeScreenForm.Location = this.Location;
            homeScreenForm.Show();

            this.Hide();
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
            putSource = true;
        }

        private void paragraphCbox_CheckedChanged(object sender, EventArgs e)
        {
            parOrg = true;
        }

        private void listCbox_CheckedChanged(object sender, EventArgs e)
        {
            listOrg = true;
        }

        private void saveBttn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();

            origTxtCboxState = this.txtCbox.Checked;
            origImgCboxState = this.imageCbox.Checked;
            origLinkCboxState = this.linksCbox.Checked;
            origQuoteCboxState = this.quotesCbox.Checked;
            origStatCboxState = this.statsCbox.Checked;
            origTitleCboxState = this.titleCbox.Checked;
            origDateCboxState = this.dateCbox.Checked;

        }
    }
}