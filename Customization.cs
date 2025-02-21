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
        public bool scpQuotes;
        public bool scpStats;
        public bool putTitle;
        public bool putDate;
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

            this.imageCbox.Checked = Properties.Settings.Default.txtCboxState;
            origImgCboxState = this.imageCbox.Checked;
          
        }
        private void Customization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.txtCboxState = origTxtCboxState;
            Properties.Settings.Default.imageCboxState = origImgCboxState;
        }

        private void homeBttn_Click(object sender, EventArgs e)
        {
            this.txtCbox.Checked = origTxtCboxState;
            Properties.Settings.Default.txtCboxState = origTxtCboxState;

            this.imageCbox.Checked = origImgCboxState;
            Properties.Settings.Default.imageCboxState = origImgCboxState;

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
            scpLinks = true;
        }

        private void quotesCbox_CheckedChanged(object sender, EventArgs e)
        {
            scpQuotes = true;
        }

        private void statsCbox_CheckedChanged(object sender, EventArgs e)
        {
            scpStats = true;
        }

        private void titleCbox_CheckedChanged(object sender, EventArgs e)
        {
            putTitle = true;
        }

        private void dateCbox_CheckedChanged(object sender, EventArgs e)
        {
            putDate = true;
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

            //txtChecked = true;
            //Properties.Settings.Default.Save();

            //Properties.Settings.Default.imageCboxState = this.imageCbox.Checked;
            //Properties.Settings.Default.Save();

            //Properties.Settings.Default.linksCboxState = this.linksCbox.Checked;
            //Properties.Settings.Default.Save();


        }
    }
}